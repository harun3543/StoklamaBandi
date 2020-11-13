namespace StoklamaBandi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            DevExpress.XtraGauges.Core.Model.IndicatorState ındicatorState17 = new DevExpress.XtraGauges.Core.Model.IndicatorState();
            DevExpress.XtraGauges.Core.Model.IndicatorState ındicatorState18 = new DevExpress.XtraGauges.Core.Model.IndicatorState();
            DevExpress.XtraGauges.Core.Model.IndicatorState ındicatorState19 = new DevExpress.XtraGauges.Core.Model.IndicatorState();
            DevExpress.XtraGauges.Core.Model.IndicatorState ındicatorState20 = new DevExpress.XtraGauges.Core.Model.IndicatorState();
            DevExpress.XtraGauges.Core.Model.IndicatorState ındicatorState21 = new DevExpress.XtraGauges.Core.Model.IndicatorState();
            DevExpress.XtraGauges.Core.Model.IndicatorState ındicatorState22 = new DevExpress.XtraGauges.Core.Model.IndicatorState();
            DevExpress.XtraGauges.Core.Model.IndicatorState ındicatorState23 = new DevExpress.XtraGauges.Core.Model.IndicatorState();
            DevExpress.XtraGauges.Core.Model.IndicatorState ındicatorState24 = new DevExpress.XtraGauges.Core.Model.IndicatorState();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btnPreviewPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtProductName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtProductCode = new DevExpress.XtraEditors.TextEdit();
            this.dgwRecipe = new System.Windows.Forms.DataGridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnDisconnect2 = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSistemDurumu = new System.Windows.Forms.Label();
            this.gaugeControl1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.stateIndicatorGauge1 = new DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorGauge();
            this.stateConnectComponent = new DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent();
            this.btnConnect = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnResetPiston = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStop = new DevExpress.XtraEditors.SimpleButton();
            this.gaugeControl2 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.stateIndicatorGauge2 = new DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorGauge();
            this.stateStartStop = new DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent();
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.txtToplamMiktar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.cbxSelectRecipe = new System.Windows.Forms.ComboBox();
            this.txtIstenilenAdet = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblKasaNumarasi = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.lblToplamMiktar = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnKasaIciMReset = new DevExpress.XtraEditors.SimpleButton();
            this.lblSayilanAdet = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.lblShowAdet = new DevExpress.XtraEditors.LabelControl();
            this.lblShowProductName = new DevExpress.XtraEditors.LabelControl();
            this.lblShowProductCode = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRecipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stateIndicatorGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateConnectComponent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stateIndicatorGauge2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateStartStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplamMiktar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIstenilenAdet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.btnPreviewPrint);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtProductName);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtProductCode);
            this.groupControl1.Controls.Add(this.dgwRecipe);
            this.groupControl1.Location = new System.Drawing.Point(12, 345);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1235, 262);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Reçete Bilgileri";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(138, 277);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(30, 23);
            this.labelControl8.TabIndex = 26;
            this.labelControl8.Text = "***";
            // 
            // btnPreviewPrint
            // 
            this.btnPreviewPrint.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPreviewPrint.Appearance.Options.UseFont = true;
            this.btnPreviewPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPreviewPrint.ImageOptions.Image")));
            this.btnPreviewPrint.Location = new System.Drawing.Point(9, 198);
            this.btnPreviewPrint.Name = "btnPreviewPrint";
            this.btnPreviewPrint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPreviewPrint.Size = new System.Drawing.Size(197, 50);
            this.btnPreviewPrint.TabIndex = 19;
            this.btnPreviewPrint.Text = "Yazıcı Çıktısını Göster";
            this.btnPreviewPrint.Click += new System.EventHandler(this.btnShowPreview_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(182, 121);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(166, 62);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(354, 121);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(156, 62);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Sil";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(9, 121);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 62);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(9, 41);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(87, 18);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "Malzeme Adı:";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(115, 38);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductName.Properties.Appearance.Options.UseFont = true;
            this.txtProductName.Size = new System.Drawing.Size(190, 30);
            this.txtProductName.TabIndex = 14;
            this.txtProductName.Click += new System.EventHandler(this.Txt_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(9, 83);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(101, 18);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Malzeme Kodu:";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(116, 82);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductCode.Properties.Appearance.Options.UseFont = true;
            this.txtProductCode.Size = new System.Drawing.Size(190, 30);
            this.txtProductCode.TabIndex = 12;
            this.txtProductCode.Click += new System.EventHandler(this.Txt_Click);
            // 
            // dgwRecipe
            // 
            this.dgwRecipe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwRecipe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgwRecipe.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwRecipe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgwRecipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwRecipe.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgwRecipe.Location = new System.Drawing.Point(735, 36);
            this.dgwRecipe.Name = "dgwRecipe";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwRecipe.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgwRecipe.RowHeadersWidth = 60;
            this.dgwRecipe.Size = new System.Drawing.Size(495, 213);
            this.dgwRecipe.TabIndex = 0;
            this.dgwRecipe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwRecipe_CellClick);
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImageOptions.Image")));
            this.groupControl2.Controls.Add(this.simpleButton1);
            this.groupControl2.Controls.Add(this.btnDisconnect2);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.lblSistemDurumu);
            this.groupControl2.Controls.Add(this.gaugeControl1);
            this.groupControl2.Controls.Add(this.btnConnect);
            this.groupControl2.Location = new System.Drawing.Point(12, 613);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1240, 106);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Bağlantı Durumu";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(1055, 26);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(180, 68);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Kapat";
            this.simpleButton1.Click += new System.EventHandler(this.btnFrmClose);
            // 
            // btnDisconnect2
            // 
            this.btnDisconnect2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDisconnect2.Appearance.Options.UseFont = true;
            this.btnDisconnect2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDisconnect2.ImageOptions.Image")));
            this.btnDisconnect2.Location = new System.Drawing.Point(191, 26);
            this.btnDisconnect2.Name = "btnDisconnect2";
            this.btnDisconnect2.Size = new System.Drawing.Size(180, 68);
            this.btnDisconnect2.TabIndex = 4;
            this.btnDisconnect2.Text = "Bağlantıyı Kes";
            this.btnDisconnect2.Click += new System.EventHandler(this.btnDisconnect);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(482, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sistem Durumu:";
            // 
            // lblSistemDurumu
            // 
            this.lblSistemDurumu.AutoSize = true;
            this.lblSistemDurumu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSistemDurumu.ForeColor = System.Drawing.Color.Red;
            this.lblSistemDurumu.Location = new System.Drawing.Point(627, 52);
            this.lblSistemDurumu.Name = "lblSistemDurumu";
            this.lblSistemDurumu.Size = new System.Drawing.Size(39, 19);
            this.lblSistemDurumu.TabIndex = 2;
            this.lblSistemDurumu.Text = "***";
            // 
            // gaugeControl1
            // 
            this.gaugeControl1.AutoLayout = false;
            this.gaugeControl1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.stateIndicatorGauge1});
            this.gaugeControl1.Location = new System.Drawing.Point(377, 26);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(89, 68);
            this.gaugeControl1.TabIndex = 1;
            // 
            // stateIndicatorGauge1
            // 
            this.stateIndicatorGauge1.Bounds = new System.Drawing.Rectangle(6, 2, 77, 62);
            this.stateIndicatorGauge1.Indicators.AddRange(new DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent[] {
            this.stateConnectComponent});
            this.stateIndicatorGauge1.Name = "stateIndicatorGauge1";
            // 
            // stateConnectComponent
            // 
            this.stateConnectComponent.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(124F, 124F);
            this.stateConnectComponent.Name = "stateIndicatorComponent1";
            this.stateConnectComponent.Size = new System.Drawing.SizeF(200F, 200F);
            this.stateConnectComponent.StateIndex = 1;
            ındicatorState17.Name = "State1";
            ındicatorState17.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ElectricLight1;
            ındicatorState18.Name = "State2";
            ındicatorState18.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ElectricLight2;
            ındicatorState19.Name = "State3";
            ındicatorState19.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ElectricLight3;
            ındicatorState20.Name = "State4";
            ındicatorState20.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ElectricLight4;
            this.stateConnectComponent.States.AddRange(new DevExpress.XtraGauges.Core.Model.IIndicatorState[] {
            ındicatorState17,
            ındicatorState18,
            ındicatorState19,
            ındicatorState20});
            // 
            // btnConnect
            // 
            this.btnConnect.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConnect.Appearance.Options.UseFont = true;
            this.btnConnect.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect.ImageOptions.Image")));
            this.btnConnect.Location = new System.Drawing.Point(5, 26);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(180, 68);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Bağlan";
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.groupControl3.Appearance.Options.UseBackColor = true;
            this.groupControl3.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl3.CaptionImageOptions.Image")));
            this.groupControl3.Controls.Add(this.btnResetPiston);
            this.groupControl3.Controls.Add(this.label3);
            this.groupControl3.Controls.Add(this.btnStop);
            this.groupControl3.Controls.Add(this.gaugeControl2);
            this.groupControl3.Controls.Add(this.btnStart);
            this.groupControl3.Location = new System.Drawing.Point(12, 13);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(399, 326);
            this.groupControl3.TabIndex = 5;
            this.groupControl3.Text = "Süreç İşlemleri";
            // 
            // btnResetPiston
            // 
            this.btnResetPiston.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResetPiston.Appearance.Options.UseFont = true;
            this.btnResetPiston.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnResetPiston.ImageOptions.Image")));
            this.btnResetPiston.Location = new System.Drawing.Point(208, 39);
            this.btnResetPiston.Name = "btnResetPiston";
            this.btnResetPiston.Size = new System.Drawing.Size(186, 66);
            this.btnResetPiston.TabIndex = 18;
            this.btnResetPiston.Text = "Piston Konumunu \r\nDeğiştir";
            this.btnResetPiston.Click += new System.EventHandler(this.BtnResetPiston_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(2, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sistem Çalışma Durumu:";
            // 
            // btnStop
            // 
            this.btnStop.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStop.Appearance.Options.UseFont = true;
            this.btnStop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.ImageOptions.Image")));
            this.btnStop.Location = new System.Drawing.Point(5, 116);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(197, 67);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Durdur";
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // gaugeControl2
            // 
            this.gaugeControl2.AutoLayout = false;
            this.gaugeControl2.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.stateIndicatorGauge2});
            this.gaugeControl2.Location = new System.Drawing.Point(208, 221);
            this.gaugeControl2.Name = "gaugeControl2";
            this.gaugeControl2.Size = new System.Drawing.Size(82, 74);
            this.gaugeControl2.TabIndex = 4;
            // 
            // stateIndicatorGauge2
            // 
            this.stateIndicatorGauge2.Bounds = new System.Drawing.Rectangle(5, 3, 72, 67);
            this.stateIndicatorGauge2.Indicators.AddRange(new DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent[] {
            this.stateStartStop});
            this.stateIndicatorGauge2.Name = "stateIndicatorGauge2";
            // 
            // stateStartStop
            // 
            this.stateStartStop.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(124F, 124F);
            this.stateStartStop.Name = "stateIndicatorComponent1";
            this.stateStartStop.Size = new System.Drawing.SizeF(200F, 200F);
            this.stateStartStop.StateIndex = 1;
            ındicatorState21.Name = "State1";
            ındicatorState21.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ElectricLight1;
            ındicatorState22.Name = "State2";
            ındicatorState22.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ElectricLight2;
            ındicatorState23.Name = "State3";
            ındicatorState23.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ElectricLight3;
            ındicatorState24.Name = "State4";
            ındicatorState24.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ElectricLight4;
            this.stateStartStop.States.AddRange(new DevExpress.XtraGauges.Core.Model.IIndicatorState[] {
            ındicatorState21,
            ındicatorState22,
            ındicatorState23,
            ındicatorState24});
            // 
            // btnStart
            // 
            this.btnStart.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.Appearance.Options.UseFont = true;
            this.btnStart.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.ImageOptions.Image")));
            this.btnStart.Location = new System.Drawing.Point(8, 39);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(194, 66);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Başlat";
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(126, 19);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Seçilen Reçete:";
            // 
            // groupControl4
            // 
            this.groupControl4.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.groupControl4.Appearance.Options.UseBackColor = true;
            this.groupControl4.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl4.CaptionImageOptions.Image")));
            this.groupControl4.Controls.Add(this.txtToplamMiktar);
            this.groupControl4.Controls.Add(this.labelControl13);
            this.groupControl4.Controls.Add(this.cbxSelectRecipe);
            this.groupControl4.Controls.Add(this.txtIstenilenAdet);
            this.groupControl4.Controls.Add(this.labelControl3);
            this.groupControl4.Controls.Add(this.labelControl1);
            this.groupControl4.Location = new System.Drawing.Point(417, 13);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(391, 164);
            this.groupControl4.TabIndex = 6;
            this.groupControl4.Text = "Reçete Seçimi ve İstenen Miktarlar";
            // 
            // txtToplamMiktar
            // 
            this.txtToplamMiktar.Location = new System.Drawing.Point(137, 79);
            this.txtToplamMiktar.Name = "txtToplamMiktar";
            this.txtToplamMiktar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamMiktar.Properties.Appearance.Options.UseFont = true;
            this.txtToplamMiktar.Size = new System.Drawing.Size(212, 30);
            this.txtToplamMiktar.TabIndex = 23;
            this.txtToplamMiktar.Click += new System.EventHandler(this.TxtNumber_Click);
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(5, 82);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(125, 19);
            this.labelControl13.TabIndex = 22;
            this.labelControl13.Text = "Toplam Miktar:";
            // 
            // cbxSelectRecipe
            // 
            this.cbxSelectRecipe.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxSelectRecipe.FormattingEnabled = true;
            this.cbxSelectRecipe.Location = new System.Drawing.Point(137, 38);
            this.cbxSelectRecipe.Name = "cbxSelectRecipe";
            this.cbxSelectRecipe.Size = new System.Drawing.Size(212, 31);
            this.cbxSelectRecipe.TabIndex = 16;
            this.cbxSelectRecipe.SelectedIndexChanged += new System.EventHandler(this.cbxSelectRecipe_IndexChanged);
            // 
            // txtIstenilenAdet
            // 
            this.txtIstenilenAdet.Location = new System.Drawing.Point(137, 122);
            this.txtIstenilenAdet.Name = "txtIstenilenAdet";
            this.txtIstenilenAdet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIstenilenAdet.Properties.Appearance.Options.UseFont = true;
            this.txtIstenilenAdet.Size = new System.Drawing.Size(212, 30);
            this.txtIstenilenAdet.TabIndex = 9;
            this.txtIstenilenAdet.EditValueChanged += new System.EventHandler(this.TxtIstenilenAdet_EditValueChanged);
            this.txtIstenilenAdet.Click += new System.EventHandler(this.TxtNumber_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(5, 125);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(128, 19);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Kasa İçi Miktar:";
            // 
            // lblKasaNumarasi
            // 
            this.lblKasaNumarasi.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKasaNumarasi.Appearance.Options.UseFont = true;
            this.lblKasaNumarasi.Location = new System.Drawing.Point(138, 212);
            this.lblKasaNumarasi.Name = "lblKasaNumarasi";
            this.lblKasaNumarasi.Size = new System.Drawing.Size(30, 23);
            this.lblKasaNumarasi.TabIndex = 21;
            this.lblKasaNumarasi.Text = "***";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(7, 212);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(127, 19);
            this.labelControl9.TabIndex = 20;
            this.labelControl9.Text = "Kasa Numarası:";
            // 
            // lblToplamMiktar
            // 
            this.lblToplamMiktar.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamMiktar.Appearance.Options.UseFont = true;
            this.lblToplamMiktar.Location = new System.Drawing.Point(138, 136);
            this.lblToplamMiktar.Name = "lblToplamMiktar";
            this.lblToplamMiktar.Size = new System.Drawing.Size(30, 23);
            this.lblToplamMiktar.TabIndex = 19;
            this.lblToplamMiktar.Text = "***";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(7, 136);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(125, 19);
            this.labelControl4.TabIndex = 18;
            this.labelControl4.Text = "Toplam Miktar:";
            // 
            // btnKasaIciMReset
            // 
            this.btnKasaIciMReset.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKasaIciMReset.Appearance.Options.UseFont = true;
            this.btnKasaIciMReset.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKasaİciMReset.ImageOptions.Image")));
            this.btnKasaIciMReset.Location = new System.Drawing.Point(247, 40);
            this.btnKasaIciMReset.Name = "btnKasaIciMReset";
            this.btnKasaIciMReset.Size = new System.Drawing.Size(180, 70);
            this.btnKasaIciMReset.TabIndex = 17;
            this.btnKasaIciMReset.Text = "Tümünü Resetle";
            this.btnKasaIciMReset.Click += new System.EventHandler(this.BtnKasaMiktarReset_Click);
            // 
            // lblSayilanAdet
            // 
            this.lblSayilanAdet.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayilanAdet.Appearance.Options.UseFont = true;
            this.lblSayilanAdet.Location = new System.Drawing.Point(138, 61);
            this.lblSayilanAdet.Name = "lblSayilanAdet";
            this.lblSayilanAdet.Size = new System.Drawing.Size(30, 23);
            this.lblSayilanAdet.TabIndex = 7;
            this.lblSayilanAdet.Text = "***";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(6, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(126, 19);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Kasa içi Miktar:";
            // 
            // groupControl5
            // 
            this.groupControl5.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.groupControl5.Appearance.Options.UseBackColor = true;
            this.groupControl5.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl5.CaptionImageOptions.Image")));
            this.groupControl5.Controls.Add(this.lblShowAdet);
            this.groupControl5.Controls.Add(this.lblShowProductName);
            this.groupControl5.Controls.Add(this.lblShowProductCode);
            this.groupControl5.Controls.Add(this.labelControl12);
            this.groupControl5.Controls.Add(this.labelControl7);
            this.groupControl5.Controls.Add(this.labelControl11);
            this.groupControl5.Location = new System.Drawing.Point(417, 183);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(391, 156);
            this.groupControl5.TabIndex = 16;
            this.groupControl5.Text = "Barkod için Gereken Bilgiler";
            // 
            // lblShowAdet
            // 
            this.lblShowAdet.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblShowAdet.Appearance.Options.UseFont = true;
            this.lblShowAdet.Location = new System.Drawing.Point(148, 125);
            this.lblShowAdet.Name = "lblShowAdet";
            this.lblShowAdet.Size = new System.Drawing.Size(15, 18);
            this.lblShowAdet.TabIndex = 16;
            this.lblShowAdet.Text = "---";
            // 
            // lblShowProductName
            // 
            this.lblShowProductName.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblShowProductName.Appearance.Options.UseFont = true;
            this.lblShowProductName.Location = new System.Drawing.Point(148, 46);
            this.lblShowProductName.Name = "lblShowProductName";
            this.lblShowProductName.Size = new System.Drawing.Size(15, 18);
            this.lblShowProductName.TabIndex = 16;
            this.lblShowProductName.Text = "---";
            // 
            // lblShowProductCode
            // 
            this.lblShowProductCode.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblShowProductCode.Appearance.Options.UseFont = true;
            this.lblShowProductCode.Location = new System.Drawing.Point(148, 86);
            this.lblShowProductCode.Name = "lblShowProductCode";
            this.lblShowProductCode.Size = new System.Drawing.Size(15, 18);
            this.lblShowProductCode.TabIndex = 16;
            this.lblShowProductCode.Text = "---";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(14, 125);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(118, 18);
            this.labelControl12.TabIndex = 19;
            this.labelControl12.Text = "Kasa İçi Miktar:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(14, 46);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(99, 18);
            this.labelControl7.TabIndex = 17;
            this.labelControl7.Text = "Malzeme Adı:";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(14, 86);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(112, 18);
            this.labelControl11.TabIndex = 15;
            this.labelControl11.Text = "Malzeme Kodu:";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // groupControl6
            // 
            this.groupControl6.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl6.CaptionImageOptions.Image")));
            this.groupControl6.Controls.Add(this.labelControl10);
            this.groupControl6.Controls.Add(this.labelControl8);
            this.groupControl6.Controls.Add(this.labelControl2);
            this.groupControl6.Controls.Add(this.lblSayilanAdet);
            this.groupControl6.Controls.Add(this.btnKasaIciMReset);
            this.groupControl6.Controls.Add(this.labelControl4);
            this.groupControl6.Controls.Add(this.lblKasaNumarasi);
            this.groupControl6.Controls.Add(this.lblToplamMiktar);
            this.groupControl6.Controls.Add(this.labelControl9);
            this.groupControl6.Location = new System.Drawing.Point(814, 12);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(433, 327);
            this.groupControl6.TabIndex = 27;
            this.groupControl6.Text = "Sayılan Miktarlar";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(7, 277);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(110, 19);
            this.labelControl10.TabIndex = 27;
            this.labelControl10.Text = "Kalan Miktar:";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1264, 731);
            this.Controls.Add(this.groupControl6);
            this.Controls.Add(this.groupControl5);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stoklama Bandı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRecipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stateIndicatorGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateConnectComponent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stateIndicatorGauge2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateStartStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplamMiktar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIstenilenAdet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            this.groupControl6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnStop;
        private DevExpress.XtraEditors.SimpleButton btnStart;
        private DevExpress.XtraEditors.SimpleButton btnConnect;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.LabelControl lblSayilanAdet;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtIstenilenAdet;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.DataGridView dgwRecipe;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl1;
        private DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorGauge stateIndicatorGauge1;
        private DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent stateConnectComponent;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtProductCode;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtProductName;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl lblShowAdet;
        private DevExpress.XtraEditors.LabelControl lblShowProductName;
        private DevExpress.XtraEditors.LabelControl lblShowProductCode;
        private System.Windows.Forms.Label lblSistemDurumu;
        private System.Windows.Forms.ComboBox cbxSelectRecipe;
        private DevExpress.XtraEditors.SimpleButton btnPreviewPrint;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl2;
        private DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorGauge stateIndicatorGauge2;
        private DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent stateStartStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnDisconnect2;
        private DevExpress.XtraEditors.SimpleButton btnKasaIciMReset;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnResetPiston;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit txtToplamMiktar;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl lblKasaNumarasi;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl lblToplamMiktar;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraEditors.LabelControl labelControl10;
    }
}

