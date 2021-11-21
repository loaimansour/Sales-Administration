namespace Product_Managment.PL
{
    partial class FRM_USER_LIST
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
            this.GBX_Product = new System.Windows.Forms.GroupBox();
            this.DGV_userList = new System.Windows.Forms.DataGridView();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.GBX_Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_userList)).BeginInit();
            this.SuspendLayout();
            // 
            // GBX_Product
            // 
            this.GBX_Product.BackColor = System.Drawing.Color.White;
            this.GBX_Product.Controls.Add(this.DGV_userList);
            this.GBX_Product.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBX_Product.Location = new System.Drawing.Point(23, 119);
            this.GBX_Product.Name = "GBX_Product";
            this.GBX_Product.Size = new System.Drawing.Size(848, 285);
            this.GBX_Product.TabIndex = 5;
            this.GBX_Product.TabStop = false;
            this.GBX_Product.Text = "Users List";
            // 
            // DGV_userList
            // 
            this.DGV_userList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_userList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_userList.Location = new System.Drawing.Point(3, 19);
            this.DGV_userList.Name = "DGV_userList";
            this.DGV_userList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_userList.Size = new System.Drawing.Size(845, 260);
            this.DGV_userList.TabIndex = 0;
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Location = new System.Drawing.Point(433, 69);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(285, 20);
            this.txtSearchUser.TabIndex = 3;
            this.txtSearchUser.TextChanged += new System.EventHandler(this.txtSearchUser_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(705, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "  :User search ";
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(574, 440);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(161, 23);
            this.btn3.TabIndex = 6;
            this.btn3.Text = "Add User";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(369, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Update User";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(54, 440);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(211, 440);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Delete User";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FRM_USER_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 496);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.GBX_Product);
            this.Controls.Add(this.txtSearchUser);
            this.Controls.Add(this.label1);
            this.Name = "FRM_USER_LIST";
            this.Text = "Managment Users";
            this.GBX_Product.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_userList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBX_Product;
        public System.Windows.Forms.DataGridView DGV_userList;
        private System.Windows.Forms.TextBox txtSearchUser;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}