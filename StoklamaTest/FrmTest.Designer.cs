namespace StoklamaTest
{
    partial class FrmTest
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSetCoil = new System.Windows.Forms.Button();
            this.btnResetCoil = new System.Windows.Forms.Button();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCoilRegister = new DevExpress.XtraEditors.TextEdit();
            this.txtWordRegister = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnSetWord = new System.Windows.Forms.Button();
            this.txtWordValue = new DevExpress.XtraEditors.TextEdit();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtCoilRegister.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWordRegister.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWordValue.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(14, 15);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(104, 44);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Bağlan";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(14, 66);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(104, 44);
            this.btnDisconnect.TabIndex = 1;
            this.btnDisconnect.Text = "Bağlantıyı Kes";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(162, 20);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 19);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "PORT:";
            // 
            // btnSetCoil
            // 
            this.btnSetCoil.Location = new System.Drawing.Point(99, 164);
            this.btnSetCoil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSetCoil.Name = "btnSetCoil";
            this.btnSetCoil.Size = new System.Drawing.Size(104, 44);
            this.btnSetCoil.TabIndex = 4;
            this.btnSetCoil.Text = "Set";
            this.btnSetCoil.UseVisualStyleBackColor = true;
            this.btnSetCoil.Click += new System.EventHandler(this.BtnSetCoil_Click);
            // 
            // btnResetCoil
            // 
            this.btnResetCoil.Location = new System.Drawing.Point(210, 164);
            this.btnResetCoil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnResetCoil.Name = "btnResetCoil";
            this.btnResetCoil.Size = new System.Drawing.Size(104, 44);
            this.btnResetCoil.TabIndex = 5;
            this.btnResetCoil.Text = "Reset";
            this.btnResetCoil.UseVisualStyleBackColor = true;
            this.btnResetCoil.Click += new System.EventHandler(this.BtnResetCoil_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(14, 176);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(25, 19);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "MB";
            // 
            // txtCoilRegister
            // 
            this.txtCoilRegister.Location = new System.Drawing.Point(43, 175);
            this.txtCoilRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCoilRegister.Name = "txtCoilRegister";
            this.txtCoilRegister.Size = new System.Drawing.Size(49, 22);
            this.txtCoilRegister.TabIndex = 7;
            // 
            // txtWordRegister
            // 
            this.txtWordRegister.Location = new System.Drawing.Point(43, 226);
            this.txtWordRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWordRegister.Name = "txtWordRegister";
            this.txtWordRegister.Size = new System.Drawing.Size(49, 22);
            this.txtWordRegister.TabIndex = 11;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(14, 228);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 19);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "MW";
            // 
            // btnSetWord
            // 
            this.btnSetWord.Location = new System.Drawing.Point(210, 215);
            this.btnSetWord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSetWord.Name = "btnSetWord";
            this.btnSetWord.Size = new System.Drawing.Size(104, 44);
            this.btnSetWord.TabIndex = 8;
            this.btnSetWord.Text = "Set";
            this.btnSetWord.UseVisualStyleBackColor = true;
            this.btnSetWord.Click += new System.EventHandler(this.BtnSetWord_Click);
            // 
            // txtWordValue
            // 
            this.txtWordValue.Location = new System.Drawing.Point(99, 226);
            this.txtWordValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWordValue.Name = "txtWordValue";
            this.txtWordValue.Size = new System.Drawing.Size(104, 22);
            this.txtWordValue.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(215, 20);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 24);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 315);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtWordValue);
            this.Controls.Add(this.txtWordRegister);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnSetWord);
            this.Controls.Add(this.txtCoilRegister);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnResetCoil);
            this.Controls.Add(this.btnSetCoil);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmTest";
            this.Text = "FrmTest";
            ((System.ComponentModel.ISupportInitialize)(this.txtCoilRegister.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWordRegister.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWordValue.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button btnSetCoil;
        private System.Windows.Forms.Button btnResetCoil;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCoilRegister;
        private DevExpress.XtraEditors.TextEdit txtWordRegister;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Button btnSetWord;
        private DevExpress.XtraEditors.TextEdit txtWordValue;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}