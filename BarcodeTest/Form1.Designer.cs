namespace BarcodeTest
{
    partial class Form1
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
            this.txtBardoceString = new System.Windows.Forms.TextBox();
            this.btnBarCode = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBardoceString
            // 
            this.txtBardoceString.Location = new System.Drawing.Point(12, 326);
            this.txtBardoceString.Name = "txtBardoceString";
            this.txtBardoceString.Size = new System.Drawing.Size(429, 20);
            this.txtBardoceString.TabIndex = 1;
            // 
            // btnBarCode
            // 
            this.btnBarCode.Location = new System.Drawing.Point(447, 324);
            this.btnBarCode.Name = "btnBarCode";
            this.btnBarCode.Size = new System.Drawing.Size(144, 23);
            this.btnBarCode.TabIndex = 2;
            this.btnBarCode.Text = "Barcode Oluştur";
            this.btnBarCode.UseVisualStyleBackColor = true;
            this.btnBarCode.Click += new System.EventHandler(this.btnCreateBarcode);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 307);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 358);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBarCode);
            this.Controls.Add(this.txtBardoceString);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBardoceString;
        private System.Windows.Forms.Button btnBarCode;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

