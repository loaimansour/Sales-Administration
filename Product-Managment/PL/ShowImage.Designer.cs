namespace Product_Managment.PL
{
    partial class ShowImage
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
            this.picSelect = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // picSelect
            // 
            this.picSelect.Location = new System.Drawing.Point(12, -7);
            this.picSelect.Name = "picSelect";
            this.picSelect.Size = new System.Drawing.Size(523, 338);
            this.picSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSelect.TabIndex = 0;
            this.picSelect.TabStop = false;
            // 
            // ShowImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 376);
            this.Controls.Add(this.picSelect);
            this.Name = "ShowImage";
            this.Text = "ShowImage";
            ((System.ComponentModel.ISupportInitialize)(this.picSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox picSelect;
    }
}