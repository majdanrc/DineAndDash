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
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDish = new System.Windows.Forms.Label();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.lblExtras = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // categorySelect
            // 
            this.categorySelect.FormattingEnabled = true;
            this.categorySelect.Location = new System.Drawing.Point(12, 67);
            this.categorySelect.Name = "categorySelect";
            this.categorySelect.Size = new System.Drawing.Size(270, 56);
            this.categorySelect.TabIndex = 0;
            this.categorySelect.SelectedIndexChanged += new System.EventHandler(this.categorySelect_SelectedIndexChanged);
            // 
            // dishSelect
            // 
            this.dishSelect.FormattingEnabled = true;
            this.dishSelect.Location = new System.Drawing.Point(12, 155);
            this.dishSelect.Name = "dishSelect";
            this.dishSelect.Size = new System.Drawing.Size(270, 56);
            this.dishSelect.TabIndex = 1;
            // 
            // extras
            // 
            this.extras.FormattingEnabled = true;
            this.extras.Location = new System.Drawing.Point(12, 243);
            this.extras.Name = "extras";
            this.extras.Size = new System.Drawing.Size(270, 56);
            this.extras.TabIndex = 2;
            // 
            // orderTree
            // 
            this.orderTree.Location = new System.Drawing.Point(355, 12);
            this.orderTree.Name = "orderTree";
            this.orderTree.Size = new System.Drawing.Size(422, 287);
            this.orderTree.TabIndex = 3;
            this.orderTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.orderTree_AfterSelect);
            // 
            // btnAddDish
            // 
            this.btnAddDish.Location = new System.Drawing.Point(288, 155);
            this.btnAddDish.Name = "btnAddDish";
            this.btnAddDish.Size = new System.Drawing.Size(61, 56);
            this.btnAddDish.TabIndex = 4;
            this.btnAddDish.Text = "> >";
            this.btnAddDish.UseVisualStyleBackColor = true;
            this.btnAddDish.Click += new System.EventHandler(this.btnAddDish_Click);
            // 
            // btnAddExtra
            // 
            this.btnAddExtra.Location = new System.Drawing.Point(288, 243);
            this.btnAddExtra.Name = "btnAddExtra";
            this.btnAddExtra.Size = new System.Drawing.Size(61, 56);
            this.btnAddExtra.TabIndex = 5;
            this.btnAddExtra.Text = "> >";
            this.btnAddExtra.UseVisualStyleBackColor = true;
            this.btnAddExtra.Click += new System.EventHandler(this.btnAddExtra_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTotalPrice.Location = new System.Drawing.Point(437, 335);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(19, 20);
            this.lblTotalPrice.TabIndex = 6;
            this.lblTotalPrice.Text = "0";
            // 
            // lblTotalTitle
            // 
            this.lblTotalTitle.AutoSize = true;
            this.lblTotalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTotalTitle.Location = new System.Drawing.Point(351, 335);
            this.lblTotalTitle.Name = "lblTotalTitle";
            this.lblTotalTitle.Size = new System.Drawing.Size(80, 20);
            this.lblTotalTitle.TabIndex = 7;
            this.lblTotalTitle.Text = "Wartość:";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(567, 331);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(210, 65);
            this.btnPlaceOrder.TabIndex = 8;
            this.btnPlaceOrder.Text = "wyślij zamówienie";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // rtbNotes
            // 
            this.rtbNotes.Location = new System.Drawing.Point(13, 331);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(270, 65);
            this.rtbNotes.TabIndex = 9;
            this.rtbNotes.Text = "";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCategory.Location = new System.Drawing.Point(12, 51);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(41, 13);
            this.lblCategory.TabIndex = 10;
            this.lblCategory.Text = "rodzaj";
            // 
            // lblDish
            // 
            this.lblDish.AutoSize = true;
            this.lblDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDish.Location = new System.Drawing.Point(12, 139);
            this.lblDish.Name = "lblDish";
            this.lblDish.Size = new System.Drawing.Size(50, 13);
            this.lblDish.TabIndex = 11;
            this.lblDish.Text = "pozycja";
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(12, 12);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(270, 23);
            this.btnNewOrder.TabIndex = 12;
            this.btnNewOrder.Text = "nowe zamówienie";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // lblExtras
            // 
            this.lblExtras.AutoSize = true;
            this.lblExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblExtras.Location = new System.Drawing.Point(12, 227);
            this.lblExtras.Name = "lblExtras";
            this.lblExtras.Size = new System.Drawing.Size(49, 13);
            this.lblExtras.TabIndex = 13;
            this.lblExtras.Text = "dodatki";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNotes.Location = new System.Drawing.Point(13, 315);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(40, 13);
            this.lblNotes.TabIndex = 14;
            this.lblNotes.Text = "uwagi";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(486, 373);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 15;
            this.btnTest.Text = "test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // DaDMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 412);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblExtras);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.lblDish);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.rtbNotes);
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
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDish;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Label lblExtras;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Button btnTest;
    }
}

