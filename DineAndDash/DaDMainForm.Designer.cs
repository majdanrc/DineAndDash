namespace DineAndDash
{
    partial class DaDMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.categorySelect = new System.Windows.Forms.ListBox();
            this.dishSelect = new System.Windows.Forms.ListBox();
            this.extras = new System.Windows.Forms.ListBox();
            this.orderTree = new System.Windows.Forms.TreeView();
            this.btnAddDish = new System.Windows.Forms.Button();
            this.btnAddExtra = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotalTitle = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // categorySelect
            // 
            this.categorySelect.FormattingEnabled = true;
            this.categorySelect.Location = new System.Drawing.Point(12, 12);
            this.categorySelect.Name = "categorySelect";
            this.categorySelect.Size = new System.Drawing.Size(270, 95);
            this.categorySelect.TabIndex = 0;
            this.categorySelect.SelectedIndexChanged += new System.EventHandler(this.categorySelect_SelectedIndexChanged);
            // 
            // dishSelect
            // 
            this.dishSelect.FormattingEnabled = true;
            this.dishSelect.Location = new System.Drawing.Point(12, 113);
            this.dishSelect.Name = "dishSelect";
            this.dishSelect.Size = new System.Drawing.Size(270, 95);
            this.dishSelect.TabIndex = 1;
            // 
            // extras
            // 
            this.extras.FormattingEnabled = true;
            this.extras.Location = new System.Drawing.Point(12, 214);
            this.extras.Name = "extras";
            this.extras.Size = new System.Drawing.Size(270, 95);
            this.extras.TabIndex = 2;
            // 
            // orderTree
            // 
            this.orderTree.Location = new System.Drawing.Point(355, 12);
            this.orderTree.Name = "orderTree";
            this.orderTree.Size = new System.Drawing.Size(422, 297);
            this.orderTree.TabIndex = 3;
            this.orderTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.orderTree_AfterSelect);
            // 
            // btnAddDish
            // 
            this.btnAddDish.Location = new System.Drawing.Point(288, 113);
            this.btnAddDish.Name = "btnAddDish";
            this.btnAddDish.Size = new System.Drawing.Size(61, 95);
            this.btnAddDish.TabIndex = 4;
            this.btnAddDish.Text = "> >";
            this.btnAddDish.UseVisualStyleBackColor = true;
            this.btnAddDish.Click += new System.EventHandler(this.btnAddDish_Click);
            // 
            // btnAddExtra
            // 
            this.btnAddExtra.Location = new System.Drawing.Point(288, 214);
            this.btnAddExtra.Name = "btnAddExtra";
            this.btnAddExtra.Size = new System.Drawing.Size(61, 95);
            this.btnAddExtra.TabIndex = 5;
            this.btnAddExtra.Text = "> >";
            this.btnAddExtra.UseVisualStyleBackColor = true;
            this.btnAddExtra.Click += new System.EventHandler(this.btnAddExtra_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTotalPrice.Location = new System.Drawing.Point(98, 335);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(19, 20);
            this.lblTotalPrice.TabIndex = 6;
            this.lblTotalPrice.Text = "0";
            // 
            // lblTotalTitle
            // 
            this.lblTotalTitle.AutoSize = true;
            this.lblTotalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTotalTitle.Location = new System.Drawing.Point(12, 335);
            this.lblTotalTitle.Name = "lblTotalTitle";
            this.lblTotalTitle.Size = new System.Drawing.Size(80, 20);
            this.lblTotalTitle.TabIndex = 7;
            this.lblTotalTitle.Text = "Wartość:";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(355, 315);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(422, 63);
            this.btnPlaceOrder.TabIndex = 8;
            this.btnPlaceOrder.Text = "wyślij zamówienie";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // DaDMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 390);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.lblTotalTitle);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnAddExtra);
            this.Controls.Add(this.btnAddDish);
            this.Controls.Add(this.orderTree);
            this.Controls.Add(this.extras);
            this.Controls.Add(this.dishSelect);
            this.Controls.Add(this.categorySelect);
            this.Name = "DaDMainForm";
            this.Text = "DaDMainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox categorySelect;
        private System.Windows.Forms.ListBox dishSelect;
        private System.Windows.Forms.ListBox extras;
        private System.Windows.Forms.TreeView orderTree;
        private System.Windows.Forms.Button btnAddDish;
        private System.Windows.Forms.Button btnAddExtra;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Button btnPlaceOrder;
    }
}

