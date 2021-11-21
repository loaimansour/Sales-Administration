namespace Product_Managment.PL
{
    partial class Form_Add_Product
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
            this.Product_Information = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cpxPrdCAt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID_p = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Desc_prod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQty_prod = new System.Windows.Forms.TextBox();
            this.txtPrice_prod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.btnSelectImg_prod = new System.Windows.Forms.Button();
            this.btnExit_prod = new System.Windows.Forms.Button();
            this.btnAgree_prod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // Product_Information
            // 
            this.Product_Information.AutoSize = true;
            this.Product_Information.BackColor = System.Drawing.Color.White;
            this.Product_Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Information.ForeColor = System.Drawing.Color.Navy;
            this.Product_Information.Location = new System.Drawing.Point(534, 19);
            this.Product_Information.Name = "Product_Information";
            this.Product_Information.Size = new System.Drawing.Size(177, 24);
            this.Product_Information.TabIndex = 0;
            this.Product_Information.Text = "Product_Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(599, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = ":Product Category";
            // 
            // cpxPrdCAt
            // 
            this.cpxPrdCAt.FormattingEnabled = true;
            this.cpxPrdCAt.Location = new System.Drawing.Point(383, 73);
            this.cpxPrdCAt.Name = "cpxPrdCAt";
            this.cpxPrdCAt.Size = new System.Drawing.Size(210, 21);
            this.cpxPrdCAt.TabIndex = 2;
            this.cpxPrdCAt.SelectedIndexChanged += new System.EventHandler(this.cpxPrdCAt_SelectedIndexChanged);
            this.cpxPrdCAt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cpxPrdCAt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(599, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = ":ID";
            // 
            // txtID_p
            // 
            this.txtID_p.Location = new System.Drawing.Point(383, 120);
            this.txtID_p.Name = "txtID_p";
            this.txtID_p.Size = new System.Drawing.Size(210, 20);
            this.txtID_p.TabIndex = 0;
            this.txtID_p.TextChanged += new System.EventHandler(this.txtID_p_TextChanged);
            this.txtID_p.Validated += new System.EventHandler(this.txtID_p_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(602, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = ":Description";
            // 
            // txt_Desc_prod
            // 
            this.txt_Desc_prod.Location = new System.Drawing.Point(386, 160);
            this.txt_Desc_prod.Multiline = true;
            this.txt_Desc_prod.Name = "txt_Desc_prod";
            this.txt_Desc_prod.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Desc_prod.Size = new System.Drawing.Size(210, 82);
            this.txt_Desc_prod.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(602, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = ":Qty";
            // 
            // txtQty_prod
            // 
            this.txtQty_prod.Location = new System.Drawing.Point(386, 265);
            this.txtQty_prod.Name = "txtQty_prod";
            this.txtQty_prod.Size = new System.Drawing.Size(210, 20);
            this.txtQty_prod.TabIndex = 2;
            this.txtQty_prod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_prod_KeyPress);
            // 
            // txtPrice_prod
            // 
            this.txtPrice_prod.Location = new System.Drawing.Point(386, 302);
            this.txtPrice_prod.Name = "txtPrice_prod";
            this.txtPrice_prod.Size = new System.Drawing.Size(210, 20);
            this.txtPrice_prod.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(602, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = ":Pricce";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(602, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = ":Image Product";
            // 
            // picProduct
            // 
            this.picProduct.Image = global::Product_Managment.Properties.Resources.download1;
            this.picProduct.Location = new System.Drawing.Point(386, 332);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(210, 163);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProduct.TabIndex = 13;
            this.picProduct.TabStop = false;
            // 
            // btnSelectImg_prod
            // 
            this.btnSelectImg_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectImg_prod.Location = new System.Drawing.Point(383, 501);
            this.btnSelectImg_prod.Name = "btnSelectImg_prod";
            this.btnSelectImg_prod.Size = new System.Drawing.Size(213, 23);
            this.btnSelectImg_prod.TabIndex = 4;
            this.btnSelectImg_prod.Text = "Select Photo";
            this.btnSelectImg_prod.UseVisualStyleBackColor = true;
            this.btnSelectImg_prod.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit_prod
            // 
            this.btnExit_prod.BackgroundImage = global::Product_Managment.Properties.Resources._4;
            this.btnExit_prod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit_prod.FlatAppearance.BorderSize = 0;
            this.btnExit_prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit_prod.Location = new System.Drawing.Point(12, 471);
            this.btnExit_prod.Name = "btnExit_prod";
            this.btnExit_prod.Size = new System.Drawing.Size(103, 57);
            this.btnExit_prod.TabIndex = 15;
            this.btnExit_prod.UseVisualStyleBackColor = true;
            this.btnExit_prod.Click += new System.EventHandler(this.btnExit_prod_Click);
            // 
            // btnAgree_prod
            // 
            this.btnAgree_prod.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgree_prod.BackgroundImage = global::Product_Managment.Properties.Resources.images;
            this.btnAgree_prod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgree_prod.FlatAppearance.BorderSize = 0;
            this.btnAgree_prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgree_prod.Location = new System.Drawing.Point(155, 464);
            this.btnAgree_prod.Name = "btnAgree_prod";
            this.btnAgree_prod.Size = new System.Drawing.Size(65, 53);
            this.btnAgree_prod.TabIndex = 16;
            this.btnAgree_prod.UseVisualStyleBackColor = false;
            this.btnAgree_prod.Click += new System.EventHandler(this.btnAgree_prod_Click);
            // 
            // Form_Add_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Product_Managment.Properties.Resources._10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(792, 562);
            this.Controls.Add(this.btnAgree_prod);
            this.Controls.Add(this.btnExit_prod);
            this.Controls.Add(this.btnSelectImg_prod);
            this.Controls.Add(this.picProduct);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrice_prod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQty_prod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Desc_prod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID_p);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cpxPrdCAt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Product_Information);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form_Add_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add  Product";
            this.Load += new System.EventHandler(this.Form_Add_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExit_prod;
        private System.Windows.Forms.Button btnAgree_prod;
        public System.Windows.Forms.ComboBox cpxPrdCAt;
        public System.Windows.Forms.TextBox txtID_p;
        public System.Windows.Forms.TextBox txt_Desc_prod;
        public System.Windows.Forms.TextBox txtQty_prod;
        public System.Windows.Forms.TextBox txtPrice_prod;
        public System.Windows.Forms.PictureBox picProduct;
        public System.Windows.Forms.Button btnSelectImg_prod;
        public System.Windows.Forms.Label Product_Information;
    }
}