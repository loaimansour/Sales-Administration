namespace Product_Managment.PL
{
    partial class MainFrm
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
            this.Msp = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.signInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Create_Abackup = new System.Windows.Forms.ToolStripMenuItem();
            this.SignUot = new System.Windows.Forms.ToolStripMenuItem();
            this.Product = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.categoryManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Customer = new System.Windows.Forms.ToolStripMenuItem();
            this.customerManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addANewSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesAdministrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Users = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Msp.SuspendLayout();
            this.SuspendLayout();
            // 
            // Msp
            // 
            this.Msp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Product,
            this.Customer,
            this.Users});
            this.Msp.Location = new System.Drawing.Point(0, 0);
            this.Msp.Name = "Msp";
            this.Msp.Size = new System.Drawing.Size(865, 24);
            this.Msp.TabIndex = 1;
            this.Msp.Text = "menuStrip1";
            this.Msp.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Msp_ItemClicked);
            // 
            // File
            // 
            this.File.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signInToolStripMenuItem,
            this.Create_Abackup,
            this.SignUot});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(37, 20);
            this.File.Text = "File";
            this.File.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // signInToolStripMenuItem
            // 
            this.signInToolStripMenuItem.Name = "signInToolStripMenuItem";
            this.signInToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.signInToolStripMenuItem.Text = "Sign in";
            this.signInToolStripMenuItem.Click += new System.EventHandler(this.signInToolStripMenuItem_Click);
            // 
            // Create_Abackup
            // 
            this.Create_Abackup.Name = "Create_Abackup";
            this.Create_Abackup.Size = new System.Drawing.Size(159, 22);
            this.Create_Abackup.Text = "Create a backup";
            this.Create_Abackup.Click += new System.EventHandler(this.Create_Abackup_Click);
            // 
            // SignUot
            // 
            this.SignUot.Name = "SignUot";
            this.SignUot.Size = new System.Drawing.Size(159, 22);
            this.SignUot.Text = "Sign Out";
            this.SignUot.Click += new System.EventHandler(this.SignUot_Click);
            // 
            // Product
            // 
            this.Product.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewProductToolStripMenuItem,
            this.productManagementToolStripMenuItem,
            this.toolStripSeparator2,
            this.categoryManagementToolStripMenuItem});
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(61, 20);
            this.Product.Text = "Product";
            // 
            // addNewProductToolStripMenuItem
            // 
            this.addNewProductToolStripMenuItem.Name = "addNewProductToolStripMenuItem";
            this.addNewProductToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.addNewProductToolStripMenuItem.Text = "Add New Product";
            this.addNewProductToolStripMenuItem.Click += new System.EventHandler(this.addNewProductToolStripMenuItem_Click);
            // 
            // productManagementToolStripMenuItem
            // 
            this.productManagementToolStripMenuItem.Name = "productManagementToolStripMenuItem";
            this.productManagementToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.productManagementToolStripMenuItem.Text = "product management";
            this.productManagementToolStripMenuItem.Click += new System.EventHandler(this.productManagementToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(201, 6);
            // 
            // categoryManagementToolStripMenuItem
            // 
            this.categoryManagementToolStripMenuItem.Name = "categoryManagementToolStripMenuItem";
            this.categoryManagementToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.categoryManagementToolStripMenuItem.Text = "Categories management";
            this.categoryManagementToolStripMenuItem.Click += new System.EventHandler(this.categoryManagementToolStripMenuItem_Click);
            // 
            // Customer
            // 
            this.Customer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerManagementToolStripMenuItem,
            this.toolStripSeparator1,
            this.addANewSaleToolStripMenuItem,
            this.salesAdministrationToolStripMenuItem});
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(76, 20);
            this.Customer.Text = "Customers";
            // 
            // customerManagementToolStripMenuItem
            // 
            this.customerManagementToolStripMenuItem.Name = "customerManagementToolStripMenuItem";
            this.customerManagementToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.customerManagementToolStripMenuItem.Text = "Customer management";
            this.customerManagementToolStripMenuItem.Click += new System.EventHandler(this.customerManagementToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // addANewSaleToolStripMenuItem
            // 
            this.addANewSaleToolStripMenuItem.Name = "addANewSaleToolStripMenuItem";
            this.addANewSaleToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.addANewSaleToolStripMenuItem.Text = "Add a new sale";
            this.addANewSaleToolStripMenuItem.Click += new System.EventHandler(this.addANewSaleToolStripMenuItem_Click);
            // 
            // salesAdministrationToolStripMenuItem
            // 
            this.salesAdministrationToolStripMenuItem.Name = "salesAdministrationToolStripMenuItem";
            this.salesAdministrationToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.salesAdministrationToolStripMenuItem.Text = "Sales Administration";
            this.salesAdministrationToolStripMenuItem.Click += new System.EventHandler(this.salesAdministrationToolStripMenuItem_Click);
            // 
            // Users
            // 
            this.Users.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.userManagementToolStripMenuItem});
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(47, 20);
            this.Users.Text = "Users";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.userManagementToolStripMenuItem.Text = "User management";
            this.userManagementToolStripMenuItem.Click += new System.EventHandler(this.userManagementToolStripMenuItem_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(865, 488);
            this.Controls.Add(this.Msp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.DoubleClick += new System.EventHandler(this.MainFrm_DoubleClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFrm_KeyDown);
            this.Msp.ResumeLayout(false);
            this.Msp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem signInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem categoryManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addANewSaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesAdministrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        public System.Windows.Forms.MenuStrip Msp;
        public System.Windows.Forms.ToolStripMenuItem Product;
        public System.Windows.Forms.ToolStripMenuItem Customer;
        public System.Windows.Forms.ToolStripMenuItem Users;
        public System.Windows.Forms.ToolStripMenuItem Create_Abackup;
        public System.Windows.Forms.ToolStripMenuItem SignUot;
    }
}