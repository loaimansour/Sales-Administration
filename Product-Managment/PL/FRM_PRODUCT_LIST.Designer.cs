namespace Product_Managment.PL
{
    partial class FRM_PRODUCT_LIST
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
            this.DGV_PR_LIST = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PR_LIST)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_PR_LIST
            // 
            this.DGV_PR_LIST.AllowUserToAddRows = false;
            this.DGV_PR_LIST.AllowUserToDeleteRows = false;
            this.DGV_PR_LIST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_PR_LIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PR_LIST.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_PR_LIST.Location = new System.Drawing.Point(0, 0);
            this.DGV_PR_LIST.MultiSelect = false;
            this.DGV_PR_LIST.Name = "DGV_PR_LIST";
            this.DGV_PR_LIST.ReadOnly = true;
            this.DGV_PR_LIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_PR_LIST.Size = new System.Drawing.Size(941, 490);
            this.DGV_PR_LIST.TabIndex = 0;
            this.DGV_PR_LIST.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_PR_LIST_CellContentClick);
            this.DGV_PR_LIST.DoubleClick += new System.EventHandler(this.DGV_PR_LIST_DoubleClick);
            // 
            // FRM_PRODUCT_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 490);
            this.Controls.Add(this.DGV_PR_LIST);
            this.Name = "FRM_PRODUCT_LIST";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List All Product";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PR_LIST)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DGV_PR_LIST;
    }
}