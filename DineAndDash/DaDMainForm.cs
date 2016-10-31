using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DaD.DAL.Dto;
using DaD.DAL.Queries;
using DaD.DAL.Repositories;
using DineAndDash.ControlModels;

namespace DineAndDash
{
    public partial class DaDMainForm : Form
    {
        private readonly List<MenuItemDto> _menuItems;

        public DaDMainForm()
        {
            InitializeComponent();

            try
            {
                if (_menuItems == null)
                {
                    _menuItems = MenuItemRepository.GetMenuItems();
                }

                var categories = _menuItems.Select(c => c.Category).Distinct().ToList();

                var categoryItems = categories.Select(c => new MenuListItem(c)).ToList();

                categorySelect.Items.AddRange((MenuListItem[])categoryItems.ToArray());
            }
            catch (Exception)
            {
                // ignored, code that can throw exceptions should be used in constructor
            }
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

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
