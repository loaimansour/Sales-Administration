namespace Product_Managment.PL
{
    partial class FRM_CUSTOMER_LIST
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
            this.DGV_CST = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CST)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_CST
            // 
            this.DGV_CST.AllowUserToAddRows = false;
            this.DGV_CST.AllowUserToDeleteRows = false;
            this.DGV_CST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_CST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CST.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_CST.Location = new System.Drawing.Point(0, 0);
            this.DGV_CST.Name = "DGV_CST";
            this.DGV_CST.ReadOnly = true;
            this.DGV_CST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_CST.Size = new System.Drawing.Size(714, 448);
            this.DGV_CST.TabIndex = 0;
            this.DGV_CST.DoubleClick += new System.EventHandler(this.DGV_CST_DoubleClick);
            // 
            // FRM_CUSTOMER_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Product_Managment.Properties.Resources._10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(714, 448);
            this.Controls.Add(this.DGV_CST);
            this.Name = "FRM_CUSTOMER_LIST";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LIST OF CUSTOMERS";
            this.DoubleClick += new System.EventHandler(this.FRM_CUSTOMER_LIST_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CST)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_CST;
    }
}