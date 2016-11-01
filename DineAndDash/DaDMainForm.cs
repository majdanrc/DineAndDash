using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DaD.BackOffice.Services;
using DaD.DAL.Dto;
using DaD.DAL.Queries;
using DaD.DAL.Repositories;
using DineAndDash.ControlModels;
using DineAndDash.Properties;

namespace DineAndDash
{
    public partial class DaDMainForm : Form
    {
        private List<MenuItemDto> _menuItems;
        private readonly OrderingService _orderingService;
        private readonly MailingService _mailingService;

        public DaDMainForm()
        {
            InitializeComponent();

            _orderingService = new OrderingService();
            _mailingService = new MailingService();

            NewOrder();
        }

        private void categorySelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            dishSelect.Items.Clear();
            extras.Items.Clear();

            var selected = (MenuListItem)categorySelect.SelectedItem;

            var dishes = _menuItems.MainByCategory(selected.Category);
            var extrasForCategory = _menuItems.ExtrasByCategory(selected.Category);

            var dishItems = dishes.Select(d => new MenuListItem(d)).ToArray();
            dishSelect.Items.AddRange((MenuListItem[])dishItems);

            var extraItems = extrasForCategory.Select(d => new MenuListItem(d)).ToArray();
            extras.Items.AddRange((MenuListItem[])extraItems);
        }

        private void btnAddDish_Click(object sender, EventArgs e)
        {
            var selectedDish = (MenuListItem)dishSelect.SelectedItem;

            if (selectedDish == null)
                return;;

            var menuItem = _menuItems.FirstOrDefault(m => m.Id == selectedDish.MenuItemId);

            if (menuItem != null)
            {
                var dishItem = new MenuNodeItem(menuItem);
                orderTree.Nodes.Add(dishItem);
                orderTree.SelectedNode = dishItem;

                RecalculatePrice();
            }
        }

        private void btnAddExtra_Click(object sender, EventArgs e)
        {
            var currentNode = (MenuNodeItem)orderTree.SelectedNode;

            var selectedExtra = (MenuListItem)extras.SelectedItem;

            if (selectedExtra == null || currentNode == null)
                return;

            var currentDish = !currentNode.Extra ? currentNode : currentNode.Parent;

            var menuItem = _menuItems.FirstOrDefault(m => m.Id == selectedExtra.MenuItemId);

            if (menuItem != null)
            {
                var dishItem = new MenuNodeItem(menuItem);
                currentDish.Nodes.Add(dishItem);
                currentDish.Expand();

                RecalculatePrice();
            }

        }

        private void orderTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var selectedNode = (MenuNodeItem)orderTree.SelectedNode;

            if (selectedNode == null || !selectedNode.IsSelected)
                return;

            foreach (var orderTreeNode in orderTree.Nodes.Cast<TreeNode>())
            {
                orderTreeNode.BackColor = TransparencyKey;
            }

            var topLevelNode = !selectedNode.Extra ? selectedNode : selectedNode.Parent;
            topLevelNode.BackColor = Color.DarkKhaki;
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            var selectedNode = (MenuNodeItem)orderTree.SelectedNode;

            if (selectedNode == null || !selectedNode.IsSelected)
                return;

            if (!selectedNode.Extra)
            {
                orderTree.Nodes.Remove(selectedNode);
            }
            else
            {
                var parent = selectedNode.Parent;
                parent.Nodes.Remove(selectedNode);
            }

            RecalculatePrice();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            PlaceOrder();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show(Resources.NewOrderConfirmation,
                Resources.NewOrderDialog,
                MessageBoxButtons.YesNo);

            if (response == DialogResult.Yes)
            {
                ClearOrder();
                NewOrder();
            }
        }

        private void orderHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var orderHistory = new OrderHistory();
            orderHistory.Show();
        }

        private void RecalculatePrice()
        {
            var totalPrice = 0.0M;

            foreach (var orderTreeNode in orderTree.Nodes.Cast<MenuNodeItem>())
            {
                totalPrice += orderTreeNode.Price;

                totalPrice += orderTreeNode.Nodes.Cast<MenuNodeItem>().Sum(extraNode => extraNode.Price);
            }

            lblTotalPrice.Text = totalPrice.ToString(CultureInfo.InvariantCulture);
        }

        private void ClearOrder()
        {
            orderTree.Nodes.Clear();
            rtbNotes.Text = string.Empty;
            dishSelect.Items.Clear();
            extras.Items.Clear();     
        }

        private void NewOrder()
        {
            try
            {
                _menuItems = MenuItemRepository.GetMenuItems();

                var categories = _menuItems.Select(c => c.Category).Distinct().ToList();
                var categoryItems = categories.Select(c => new MenuListItem(c)).ToList();

                categorySelect.Items.Clear();
                categorySelect.Items.AddRange((MenuListItem[])categoryItems.ToArray());

                RecalculatePrice();
            }
            catch (Exception)
            {
                // ignored, but code that can throw exceptions shouldn't be used in constructor
            }
        }

        private void PlaceOrder()
        {
            if (orderTree.Nodes.Count == 0)
            {
                MessageBox.Show(Resources.EmptyOrder, Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var order = new OrderDto
            {
                CreatedOn = DateTime.UtcNow,
                Notes = rtbNotes.Text
            };

            foreach (var mainNode in orderTree.Nodes.Cast<MenuNodeItem>())
            {
                var orderEntry = new OrderEntryDto
                {
                    MenuItemId = mainNode.MenuItemId
                };

                foreach (var extra in mainNode.Nodes.Cast<MenuNodeItem>())
                {
                    var extraEntry = new OrderEntryDto
                    {
                        MenuItemId = extra.MenuItemId
                    };

                    orderEntry.Extras.Add(extraEntry);
                }

                order.OrderItems.Add(orderEntry);
            }

            var savedOrder = _orderingService.PlaceOrder(order);

            if (savedOrder == null)
            {
                MessageBox.Show(Resources.OrderSaveError,
                    Resources.Error,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            var sent = _mailingService.SendOrder(savedOrder);

            if (sent)
            {
                MessageBox.Show(Resources.OrderSent,
                    Resources.Info,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);                
            }
            else
            {
                MessageBox.Show(Resources.OrderSendEmailError,
                    Resources.Warning,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);                
            }

            ClearOrder();
            NewOrder();
        }
    }
}
