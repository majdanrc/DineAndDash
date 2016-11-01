namespace DineAndDash
{
    partial class OrderHistory
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
            this.btnGet = new System.Windows.Forms.Button();
            this.ordersList = new System.Windows.Forms.ListBox();
            this.orderView = new System.Windows.Forms.TreeView();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(12, 12);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(186, 23);
            this.btnGet.TabIndex = 0;
            this.btnGet.Text = "pobierz";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // ordersList
            // 
            this.ordersList.FormattingEnabled = true;
            this.ordersList.Location = new System.Drawing.Point(12, 41);
            this.ordersList.Name = "ordersList";
            this.ordersList.Size = new System.Drawing.Size(186, 329);
            this.ordersList.TabIndex = 1;
            this.ordersList.SelectedIndexChanged += new System.EventHandler(this.orders_SelectedIndexChanged);
            // 
            // orderView
            // 
            this.orderView.Location = new System.Drawing.Point(204, 41);
            this.orderView.Name = "orderView";
            this.orderView.Size = new System.Drawing.Size(473, 238);
            this.orderView.TabIndex = 2;
            // 
            // rtbNotes
            // 
            this.rtbNotes.Location = new System.Drawing.Point(204, 304);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(473, 66);
            this.rtbNotes.TabIndex = 3;
            this.rtbNotes.Text = "";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNotes.Location = new System.Drawing.Point(204, 288);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(40, 13);
            this.lblNotes.TabIndex = 4;
            this.lblNotes.Text = "uwagi";
            // 
            // OrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 382);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.rtbNotes);
            this.Controls.Add(this.orderView);
            this.Controls.Add(this.ordersList);
            this.Controls.Add(this.btnGet);
            this.Name = "OrderHistory";
            this.Text = "OrderHistory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.ListBox ordersList;
        private System.Windows.Forms.TreeView orderView;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.Label lblNotes;
    }
}