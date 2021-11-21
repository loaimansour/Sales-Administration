namespace Product_Managment.PL
{
    partial class FRM_ORDERS
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.txtSales = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtInvoiceNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtQTY = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtID_Prud = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFinalTotal = new System.Windows.Forms.TextBox();
            this.btnDelSelect = new System.Windows.Forms.Button();
            this.DGV_Product = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteCurrentLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteALLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBrows = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picC = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtEmil = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtPh = new System.Windows.Forms.TextBox();
            this.txtIdCs = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Product)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picC)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.txtSales);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.txtInvoiceNum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(638, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(496, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "billing data";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(146, 162);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(233, 22);
            this.txtDate.TabIndex = 1;
            // 
            // txtSales
            // 
            this.txtSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSales.Location = new System.Drawing.Point(173, 194);
            this.txtSales.Name = "txtSales";
            this.txtSales.ReadOnly = true;
            this.txtSales.Size = new System.Drawing.Size(206, 22);
            this.txtSales.TabIndex = 8;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(173, 64);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(206, 85);
            this.txtDesc.TabIndex = 0;
            // 
            // txtInvoiceNum
            // 
            this.txtInvoiceNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvoiceNum.Location = new System.Drawing.Point(173, 34);
            this.txtInvoiceNum.Name = "txtInvoiceNum";
            this.txtInvoiceNum.ReadOnly = true;
            this.txtInvoiceNum.Size = new System.Drawing.Size(206, 22);
            this.txtInvoiceNum.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(386, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = " Invoice Desc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(384, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date of Sale";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(390, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seller name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(386, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Invoice Num";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtDiscount);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtAmount);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtQTY);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtID_Prud);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtFinalTotal);
            this.groupBox2.Controls.Add(this.btnDelSelect);
            this.groupBox2.Controls.Add(this.DGV_Product);
            this.groupBox2.Controls.Add(this.btnBrows);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(35, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(1099, 242);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Products";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Location = new System.Drawing.Point(882, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 24);
            this.label18.TabIndex = 18;
            this.label18.Text = "Selection";
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Location = new System.Drawing.Point(143, 47);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(111, 21);
            this.txtTotal.TabIndex = 17;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Location = new System.Drawing.Point(143, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 24);
            this.label17.TabIndex = 16;
            this.label17.Text = "Total";
            // 
            // txtDiscount
            // 
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscount.Location = new System.Drawing.Point(251, 47);
            this.txtDiscount.MaxLength = 2;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(99, 21);
            this.txtDiscount.TabIndex = 15;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            this.txtDiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDiscount_KeyDown);
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            this.txtDiscount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDiscount_KeyUp);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Location = new System.Drawing.Point(250, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 24);
            this.label16.TabIndex = 14;
            this.label16.Text = "Discount(%)";
            // 
            // txtAmount
            // 
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Location = new System.Drawing.Point(345, 47);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(100, 21);
            this.txtAmount.TabIndex = 13;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Location = new System.Drawing.Point(344, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 24);
            this.label15.TabIndex = 12;
            this.label15.Text = "Amount";
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Location = new System.Drawing.Point(538, 47);
            this.txtPrice.MaxLength = 8;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 21);
            this.txtPrice.TabIndex = 11;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrice_KeyDown);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            this.txtPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPrice_KeyUp);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Location = new System.Drawing.Point(538, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 24);
            this.label14.TabIndex = 10;
            this.label14.Text = "Unit Price";
            // 
            // txtQTY
            // 
            this.txtQTY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQTY.Location = new System.Drawing.Point(440, 47);
            this.txtQTY.MaxLength = 8;
            this.txtQTY.Name = "txtQTY";
            this.txtQTY.Size = new System.Drawing.Size(100, 21);
            this.txtQTY.TabIndex = 9;
            this.txtQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQTY.TextChanged += new System.EventHandler(this.txtQTY_TextChanged);
            this.txtQTY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQTY_KeyDown);
            this.txtQTY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQTY_KeyPress);
            this.txtQTY.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQTY_KeyUp);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(439, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 24);
            this.label13.TabIndex = 8;
            this.label13.Text = "QTY";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(638, 47);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(146, 21);
            this.txtName.TabIndex = 7;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(635, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 24);
            this.label12.TabIndex = 6;
            this.label12.Text = "Product_Name";
            // 
            // txtID_Prud
            // 
            this.txtID_Prud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID_Prud.Location = new System.Drawing.Point(783, 47);
            this.txtID_Prud.Name = "txtID_Prud";
            this.txtID_Prud.ReadOnly = true;
            this.txtID_Prud.Size = new System.Drawing.Size(100, 21);
            this.txtID_Prud.TabIndex = 5;
            this.txtID_Prud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(783, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 24);
            this.label11.TabIndex = 4;
            this.label11.Text = "ID_Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(356, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total :";
            // 
            // txtFinalTotal
            // 
            this.txtFinalTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFinalTotal.Location = new System.Drawing.Point(143, 188);
            this.txtFinalTotal.Name = "txtFinalTotal";
            this.txtFinalTotal.ReadOnly = true;
            this.txtFinalTotal.Size = new System.Drawing.Size(206, 21);
            this.txtFinalTotal.TabIndex = 2;
            this.txtFinalTotal.TextChanged += new System.EventHandler(this.txtFinalTotal_TextChanged);
            // 
            // btnDelSelect
            // 
            this.btnDelSelect.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDelSelect.Location = new System.Drawing.Point(794, 188);
            this.btnDelSelect.Name = "btnDelSelect";
            this.btnDelSelect.Size = new System.Drawing.Size(146, 27);
            this.btnDelSelect.TabIndex = 1;
            this.btnDelSelect.Text = "Delete selected";
            this.btnDelSelect.UseVisualStyleBackColor = true;
            // 
            // DGV_Product
            // 
            this.DGV_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Product.ColumnHeadersVisible = false;
            this.DGV_Product.ContextMenuStrip = this.contextMenuStrip1;
            this.DGV_Product.Location = new System.Drawing.Point(143, 74);
            this.DGV_Product.MultiSelect = false;
            this.DGV_Product.Name = "DGV_Product";
            this.DGV_Product.ReadOnly = true;
            this.DGV_Product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Product.Size = new System.Drawing.Size(809, 105);
            this.DGV_Product.TabIndex = 0;
            this.DGV_Product.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Product_CellContentClick);
            this.DGV_Product.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DGV_Product_RowsRemoved);
            this.DGV_Product.DoubleClick += new System.EventHandler(this.DGV_Product_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.editToolStripMenuItem,
            this.toolStripSeparator2,
            this.deleteCurrentLineToolStripMenuItem,
            this.toolStripSeparator3,
            this.deleteALLToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(176, 88);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(172, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(172, 6);
            // 
            // deleteCurrentLineToolStripMenuItem
            // 
            this.deleteCurrentLineToolStripMenuItem.Name = "deleteCurrentLineToolStripMenuItem";
            this.deleteCurrentLineToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.deleteCurrentLineToolStripMenuItem.Text = "Delete Current Line";
            this.deleteCurrentLineToolStripMenuItem.Click += new System.EventHandler(this.deleteCurrentLineToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(172, 6);
            // 
            // deleteALLToolStripMenuItem
            // 
            this.deleteALLToolStripMenuItem.Name = "deleteALLToolStripMenuItem";
            this.deleteALLToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.deleteALLToolStripMenuItem.Text = "Delete ALL";
            this.deleteALLToolStripMenuItem.Click += new System.EventHandler(this.deleteALLToolStripMenuItem_Click);
            // 
            // btnBrows
            // 
            this.btnBrows.Location = new System.Drawing.Point(875, 43);
            this.btnBrows.Name = "btnBrows";
            this.btnBrows.Size = new System.Drawing.Size(78, 26);
            this.btnBrows.TabIndex = 19;
            this.btnBrows.Text = ".....";
            this.btnBrows.UseVisualStyleBackColor = true;
            this.btnBrows.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.picC);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.txtFirst);
            this.groupBox3.Controls.Add(this.txtEmil);
            this.groupBox3.Controls.Add(this.txtLast);
            this.groupBox3.Controls.Add(this.txtPh);
            this.groupBox3.Controls.Add(this.txtIdCs);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(35, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(597, 258);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customer data";
            // 
            // picC
            // 
            this.picC.Location = new System.Drawing.Point(37, 25);
            this.picC.Name = "picC";
            this.picC.Size = new System.Drawing.Size(133, 159);
            this.picC.TabIndex = 19;
            this.picC.TabStop = false;
            this.picC.Click += new System.EventHandler(this.picC_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.SteelBlue;
            this.button2.Location = new System.Drawing.Point(212, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 27);
            this.button2.TabIndex = 0;
            this.button2.Text = "........";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtFirst
            // 
            this.txtFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirst.Location = new System.Drawing.Point(212, 62);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.ReadOnly = true;
            this.txtFirst.Size = new System.Drawing.Size(280, 23);
            this.txtFirst.TabIndex = 18;
            // 
            // txtEmil
            // 
            this.txtEmil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmil.Location = new System.Drawing.Point(212, 162);
            this.txtEmil.Name = "txtEmil";
            this.txtEmil.ReadOnly = true;
            this.txtEmil.Size = new System.Drawing.Size(280, 23);
            this.txtEmil.TabIndex = 17;
            // 
            // txtLast
            // 
            this.txtLast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLast.Location = new System.Drawing.Point(212, 100);
            this.txtLast.Name = "txtLast";
            this.txtLast.ReadOnly = true;
            this.txtLast.Size = new System.Drawing.Size(280, 23);
            this.txtLast.TabIndex = 16;
            // 
            // txtPh
            // 
            this.txtPh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPh.Location = new System.Drawing.Point(212, 132);
            this.txtPh.Name = "txtPh";
            this.txtPh.ReadOnly = true;
            this.txtPh.Size = new System.Drawing.Size(280, 23);
            this.txtPh.TabIndex = 15;
            // 
            // txtIdCs
            // 
            this.txtIdCs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdCs.Location = new System.Drawing.Point(355, 27);
            this.txtIdCs.Name = "txtIdCs";
            this.txtIdCs.ReadOnly = true;
            this.txtIdCs.Size = new System.Drawing.Size(137, 23);
            this.txtIdCs.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(503, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(504, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(499, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "First Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(500, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(499, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "ID Customer";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.SteelBlue;
            this.button3.Location = new System.Drawing.Point(766, 566);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 27);
            this.button3.TabIndex = 20;
            this.button3.Text = "new sale";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.SteelBlue;
            this.button4.Location = new System.Drawing.Point(358, 566);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 27);
            this.button4.TabIndex = 21;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Enabled = false;
            this.btn_Print.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_Print.Location = new System.Drawing.Point(496, 566);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(113, 27);
            this.btn_Print.TabIndex = 22;
            this.btn_Print.Text = "Print Invoice";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.Location = new System.Drawing.Point(628, 566);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 27);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Save Sale";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FRM_ORDERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Product_Managment.Properties.Resources._10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1151, 640);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FRM_ORDERS";
            this.Text = "The main screen of the sales process";
            this.Load += new System.EventHandler(this.FRM_ORDERS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Product)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtInvoiceNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFinalTotal;
        private System.Windows.Forms.Button btnDelSelect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.PictureBox picC;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox txtFirst;
        public System.Windows.Forms.TextBox txtEmil;
        public System.Windows.Forms.TextBox txtLast;
        public System.Windows.Forms.TextBox txtPh;
        public System.Windows.Forms.TextBox txtIdCs;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.DataGridView DGV_Product;
        public System.Windows.Forms.TextBox txtID_Prud;
        public System.Windows.Forms.TextBox txtQTY;
        public System.Windows.Forms.Button btnBrows;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem deleteCurrentLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem deleteALLToolStripMenuItem;
        public System.Windows.Forms.TextBox txtSales;
    }
}