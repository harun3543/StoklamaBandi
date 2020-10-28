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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.XtraGauges.Core.Model.IndicatorState ındicatorState1 = new DevExpress.XtraGauges.Core.Model.IndicatorState();
            DevExpress.XtraGauges.Core.Model.IndicatorState ındicatorState2 = new DevExpress.XtraGauges.Core.Model.IndicatorState();
            DevExpress.XtraGauges.Core.Model.IndicatorState ındicatorState3 = new DevExpress.XtraGauges.Core.Model.IndicatorState();
            DevExpress.XtraGauges.Core.Model.IndicatorState ındicatorState4 = new DevExpress.XtraGauges.Core.Model.IndicatorState();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnShowDesigner = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtProductName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtProductCode = new DevExpress.XtraEditors.TextEdit();
            this.dgwRecipe = new System.Windows.Forms.DataGridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lblSistemDurumu = new System.Windows.Forms.Label();
            this.gaugeControl1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.stateIndicatorGauge1 = new DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorGauge();
            this.stateConnectComponent = new DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent();
            this.btnConnect = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnStop = new DevExpress.XtraEditors.SimpleButton();
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.cbxSelectRecipe = new System.Windows.Forms.ComboBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btnIslemeAl = new DevExpress.XtraEditors.SimpleButton();
            this.txtHataliUrun = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtIstenilenAdet = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblSayilanAdet = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.lblShowAdet = new DevExpress.XtraEditors.LabelControl();
            this.lblShowProductName = new DevExpress.XtraEditors.LabelControl();
            this.lblShowProductCode = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.btnPreviewPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHataliUrun.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIstenilenAdet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.btnPrint);
            this.groupControl1.Controls.Add(this.btnPreviewPrint);
            this.groupControl1.Controls.Add(this.btnShowDesigner);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtProductName);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtProductCode);
            this.groupControl1.Controls.Add(this.dgwRecipe);
            this.groupControl1.Location = new System.Drawing.Point(12, 292);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1240, 347);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Reçete Bilgileri";
            // 
            // btnShowDesigner
            // 
            this.btnShowDesigner.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnShowDesigner.ImageOptions.Image")));
            this.btnShowDesigner.Location = new System.Drawing.Point(8, 278);
            this.btnShowDesigner.Name = "btnShowDesigner";
            this.btnShowDesigner.Size = new System.Drawing.Size(129, 47);
            this.btnShowDesigner.TabIndex = 18;
            this.btnShowDesigner.Text = "Designer Göster";
            this.btnShowDesigner.Click += new System.EventHandler(this.btnShowDesigner_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(146, 153);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 47);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(285, 153);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 47);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Sil";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(8, 153);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 47);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(8, 85);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(78, 16);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "Malzeme Adı:";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(115, 84);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(190, 20);
            this.txtProductName.TabIndex = 14;
            this.txtProductName.Click += new System.EventHandler(this.Txt_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(8, 49);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(88, 16);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Malzeme Kodu:";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(115, 48);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(190, 20);
            this.txtProductCode.TabIndex = 12;
            this.txtProductCode.Click += new System.EventHandler(this.Txt_Click);
            // 
            // dgwRecipe
            // 
            this.dgwRecipe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwRecipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRecipe.Location = new System.Drawing.Point(694, 36);
            this.dgwRecipe.Name = "dgwRecipe";
            this.dgwRecipe.Size = new System.Drawing.Size(541, 306);
            this.dgwRecipe.TabIndex = 0;
            this.dgwRecipe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwRecipe_CellClick);
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImageOptions.Image")));
            this.groupControl2.Controls.Add(this.lblSistemDurumu);
            this.groupControl2.Controls.Add(this.gaugeControl1);
            this.groupControl2.Controls.Add(this.btnConnect);
            this.groupControl2.Location = new System.Drawing.Point(12, 645);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1240, 104);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Bağlantı Durumu";
            // 
            // lblSistemDurumu
            // 
            this.lblSistemDurumu.AutoSize = true;
            this.lblSistemDurumu.Location = new System.Drawing.Point(302, 57);
            this.lblSistemDurumu.Name = "lblSistemDurumu";
            this.lblSistemDurumu.Size = new System.Drawing.Size(78, 13);
            this.lblSistemDurumu.TabIndex = 2;
            this.lblSistemDurumu.Text = "Sistem Durumu";
            // 
            // gaugeControl1
            // 
            this.gaugeControl1.AutoLayout = false;
            this.gaugeControl1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.stateIndicatorGauge1});
            this.gaugeControl1.Location = new System.Drawing.Point(143, 26);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(89, 73);
            this.gaugeControl1.TabIndex = 1;
            // 
            // stateIndicatorGauge1
            // 
            this.stateIndicatorGauge1.Bounds = new System.Drawing.Rectangle(4, 6, 82, 61);
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
            ındicatorState1.Name = "State1";
            ındicatorState1.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ElectricLight1;
            ındicatorState2.Name = "State2";
            ındicatorState2.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ElectricLight2;
            ındicatorState3.Name = "State3";
            ındicatorState3.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ElectricLight3;
            ındicatorState4.Name = "State4";
            ındicatorState4.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ElectricLight4;
            this.stateConnectComponent.States.AddRange(new DevExpress.XtraGauges.Core.Model.IIndicatorState[] {
            ındicatorState1,
            ındicatorState2,
            ındicatorState3,
            ındicatorState4});
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConnect.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnConnect.Appearance.Options.UseFont = true;
            this.btnConnect.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect.ImageOptions.Image")));
            this.btnConnect.Location = new System.Drawing.Point(8, 26);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(129, 73);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Bağlan";
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.groupControl3.Appearance.Options.UseBackColor = true;
            this.groupControl3.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl3.CaptionImageOptions.Image")));
            this.groupControl3.Controls.Add(this.btnStop);
            this.groupControl3.Controls.Add(this.btnStart);
            this.groupControl3.Location = new System.Drawing.Point(12, 13);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(207, 273);
            this.groupControl3.TabIndex = 5;
            this.groupControl3.Text = "Süreç İşlemleri";
            // 
            // btnStop
            // 
            this.btnStop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.ImageOptions.Image")));
            this.btnStop.Location = new System.Drawing.Point(5, 169);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(197, 67);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Durdur";
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.ImageOptions.Image")));
            this.btnStart.Location = new System.Drawing.Point(8, 62);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(194, 66);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Başlat";
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(100, 16);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Seçilen Reçete:";
            // 
            // groupControl4
            // 
            this.groupControl4.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.groupControl4.Appearance.Options.UseBackColor = true;
            this.groupControl4.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl4.CaptionImageOptions.Image")));
            this.groupControl4.Controls.Add(this.cbxSelectRecipe);
            this.groupControl4.Controls.Add(this.labelControl9);
            this.groupControl4.Controls.Add(this.textEdit4);
            this.groupControl4.Controls.Add(this.labelControl10);
            this.groupControl4.Controls.Add(this.labelControl8);
            this.groupControl4.Controls.Add(this.btnIslemeAl);
            this.groupControl4.Controls.Add(this.txtHataliUrun);
            this.groupControl4.Controls.Add(this.labelControl4);
            this.groupControl4.Controls.Add(this.txtIstenilenAdet);
            this.groupControl4.Controls.Add(this.labelControl3);
            this.groupControl4.Controls.Add(this.lblSayilanAdet);
            this.groupControl4.Controls.Add(this.labelControl2);
            this.groupControl4.Controls.Add(this.labelControl1);
            this.groupControl4.Location = new System.Drawing.Point(225, 13);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(551, 273);
            this.groupControl4.TabIndex = 6;
            this.groupControl4.Text = "Reçete Seçimi";
            // 
            // cbxSelectRecipe
            // 
            this.cbxSelectRecipe.FormattingEnabled = true;
            this.cbxSelectRecipe.Location = new System.Drawing.Point(128, 39);
            this.cbxSelectRecipe.Name = "cbxSelectRecipe";
            this.cbxSelectRecipe.Size = new System.Drawing.Size(187, 21);
            this.cbxSelectRecipe.TabIndex = 16;
            this.cbxSelectRecipe.SelectedIndexChanged += new System.EventHandler(this.cbxSelectRecipe_IndexChanged);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(205, 161);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(56, 16);
            this.labelControl9.TabIndex = 15;
            this.labelControl9.Text = "(2. Bölge)";
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(128, 158);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(71, 20);
            this.textEdit4.TabIndex = 14;
            this.textEdit4.Click += new System.EventHandler(this.Txt_Click);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(5, 161);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(97, 16);
            this.labelControl10.TabIndex = 13;
            this.labelControl10.Text = "İstenilen Adet:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(205, 124);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(56, 16);
            this.labelControl8.TabIndex = 12;
            this.labelControl8.Text = "(1. Bölge)";
            // 
            // btnIslemeAl
            // 
            this.btnIslemeAl.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIslemeAl.ImageOptions.Image")));
            this.btnIslemeAl.Location = new System.Drawing.Point(205, 215);
            this.btnIslemeAl.Name = "btnIslemeAl";
            this.btnIslemeAl.Size = new System.Drawing.Size(110, 21);
            this.btnIslemeAl.TabIndex = 4;
            this.btnIslemeAl.Text = "İşleme Al";
            // 
            // txtHataliUrun
            // 
            this.txtHataliUrun.Location = new System.Drawing.Point(128, 215);
            this.txtHataliUrun.Name = "txtHataliUrun";
            this.txtHataliUrun.Size = new System.Drawing.Size(71, 20);
            this.txtHataliUrun.TabIndex = 11;
            this.txtHataliUrun.Click += new System.EventHandler(this.Txt_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(5, 215);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(117, 16);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Hatalı Ürün Sayısı:";
            // 
            // txtIstenilenAdet
            // 
            this.txtIstenilenAdet.Location = new System.Drawing.Point(128, 121);
            this.txtIstenilenAdet.Name = "txtIstenilenAdet";
            this.txtIstenilenAdet.Size = new System.Drawing.Size(71, 20);
            this.txtIstenilenAdet.TabIndex = 9;
            this.txtIstenilenAdet.EditValueChanged += new System.EventHandler(this.TxtIstenilenAdet_EditValueChanged);
            this.txtIstenilenAdet.Click += new System.EventHandler(this.Txt_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(5, 124);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(97, 16);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "İstenilen Adet:";
            // 
            // lblSayilanAdet
            // 
            this.lblSayilanAdet.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblSayilanAdet.Appearance.Options.UseFont = true;
            this.lblSayilanAdet.Location = new System.Drawing.Point(128, 79);
            this.lblSayilanAdet.Name = "lblSayilanAdet";
            this.lblSayilanAdet.Size = new System.Drawing.Size(24, 16);
            this.lblSayilanAdet.TabIndex = 7;
            this.lblSayilanAdet.Text = "***";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 77);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 16);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Sayılan Adet:";
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
            this.groupControl5.Location = new System.Drawing.Point(782, 13);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(465, 273);
            this.groupControl5.TabIndex = 16;
            this.groupControl5.Text = "Seçilen Reçete Bilgileri";
            // 
            // lblShowAdet
            // 
            this.lblShowAdet.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblShowAdet.Appearance.Options.UseFont = true;
            this.lblShowAdet.Location = new System.Drawing.Point(126, 112);
            this.lblShowAdet.Name = "lblShowAdet";
            this.lblShowAdet.Size = new System.Drawing.Size(15, 16);
            this.lblShowAdet.TabIndex = 16;
            this.lblShowAdet.Text = "---";
            // 
            // lblShowProductName
            // 
            this.lblShowProductName.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblShowProductName.Appearance.Options.UseFont = true;
            this.lblShowProductName.Location = new System.Drawing.Point(126, 75);
            this.lblShowProductName.Name = "lblShowProductName";
            this.lblShowProductName.Size = new System.Drawing.Size(15, 16);
            this.lblShowProductName.TabIndex = 16;
            this.lblShowProductName.Text = "---";
            // 
            // lblShowProductCode
            // 
            this.lblShowProductCode.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblShowProductCode.Appearance.Options.UseFont = true;
            this.lblShowProductCode.Location = new System.Drawing.Point(126, 39);
            this.lblShowProductCode.Name = "lblShowProductCode";
            this.lblShowProductCode.Size = new System.Drawing.Size(15, 16);
            this.lblShowProductCode.TabIndex = 16;
            this.lblShowProductCode.Text = "---";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(14, 112);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(37, 16);
            this.labelControl12.TabIndex = 19;
            this.labelControl12.Text = "Adet:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(14, 75);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(86, 16);
            this.labelControl7.TabIndex = 17;
            this.labelControl7.Text = "Malzeme Adı:";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(14, 39);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(97, 16);
            this.labelControl11.TabIndex = 15;
            this.labelControl11.Text = "Malzeme Kodu:";
            // 
            // btnPreviewPrint
            // 
            this.btnPreviewPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image1")));
            this.btnPreviewPrint.Location = new System.Drawing.Point(143, 278);
            this.btnPreviewPrint.Name = "btnPreviewPrint";
            this.btnPreviewPrint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPreviewPrint.Size = new System.Drawing.Size(140, 47);
            this.btnPreviewPrint.TabIndex = 19;
            this.btnPreviewPrint.Text = "Yazıcı Çıktısını Göster";
            this.btnPreviewPrint.Click += new System.EventHandler(this.btnShowPreview_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnPrint.Location = new System.Drawing.Point(289, 278);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPrint.Size = new System.Drawing.Size(129, 47);
            this.btnPrint.TabIndex = 20;
            this.btnPrint.Text = "Yazdır";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.groupControl5);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stoklama Bandı";
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
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHataliUrun.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIstenilenAdet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
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
        private DevExpress.XtraEditors.SimpleButton btnIslemeAl;
        private DevExpress.XtraEditors.TextEdit txtHataliUrun;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl1;
        private DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorGauge stateIndicatorGauge1;
        private DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent stateConnectComponent;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtProductCode;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl8;
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
        private DevExpress.XtraEditors.SimpleButton btnShowDesigner;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnPreviewPrint;
    }
}

