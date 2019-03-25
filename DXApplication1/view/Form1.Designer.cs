namespace DXApplication1
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
            if (--OpenFormCount == 0) System.Windows.Forms.Application.Exit();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.DoughnutSeriesLabel doughnutSeriesLabel1 = new DevExpress.XtraCharts.DoughnutSeriesLabel();
            DevExpress.XtraCharts.DoughnutSeriesView doughnutSeriesView1 = new DevExpress.XtraCharts.DoughnutSeriesView();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabFormControl1 = new DevExpress.XtraBars.TabFormControl();
            this.tabFormDefaultManager1 = new DevExpress.XtraBars.TabFormDefaultManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tabFormPage1 = new DevExpress.XtraBars.TabFormPage();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.tabFormPage2 = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer1 = new DevExpress.XtraBars.TabFormContentContainer();
            this.dataGrid_listeler = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.tabFormPage5 = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer4 = new DevExpress.XtraBars.TabFormContentContainer();
            this.groupBox_tahsilat = new System.Windows.Forms.GroupBox();
            this.dateEdit_tahsilatTarih = new System.Windows.Forms.DateTimePicker();
            this.txt_tahsilatMiktar = new System.Windows.Forms.TextBox();
            this.txt_tahsilatOgrenciId = new System.Windows.Forms.TextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.grid_tahsilat = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.button_tahsilatMakbuz = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.button_tahsilatYap = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.tabFormPage4 = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer3 = new DevExpress.XtraBars.TabFormContentContainer();
            this.groupBox_odemeler = new System.Windows.Forms.GroupBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.grid_odemeler = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.datetime_giderTarih = new System.Windows.Forms.DateTimePicker();
            this.txt_odemeMiktar = new System.Windows.Forms.TextBox();
            this.txt_odemeId = new System.Windows.Forms.TextBox();
            this.label_odemeDegiskenId = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.comboBox_odemeTur = new System.Windows.Forms.ComboBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_odemetur = new DevExpress.XtraEditors.LabelControl();
            this.btn_odemelerTamamla = new DevExpress.XtraEditors.SimpleButton();
            this.txt_giderAciklama = new DevExpress.XtraEditors.TextEdit();
            this.tabFormPage3 = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer2 = new DevExpress.XtraBars.TabFormContentContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_soforEkle = new System.Windows.Forms.Button();
            this.button_okulEkle = new System.Windows.Forms.Button();
            this.Btn_aracEkle = new System.Windows.Forms.Button();
            this.Btn_ogrenciEkle = new System.Windows.Forms.Button();
            this.pdYazici = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
            this.tabFormContentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_listeler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tabFormContentContainer4.SuspendLayout();
            this.groupBox_tahsilat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tahsilat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.tabFormContentContainer3.SuspendLayout();
            this.groupBox_odemeler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_odemeler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_giderAciklama.Properties)).BeginInit();
            this.tabFormContentContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabFormControl1
            // 
            this.tabFormControl1.Location = new System.Drawing.Point(0, 0);
            this.tabFormControl1.Manager = this.tabFormDefaultManager1;
            this.tabFormControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabFormControl1.Name = "tabFormControl1";
            this.tabFormControl1.Pages.Add(this.tabFormPage1);
            this.tabFormControl1.Pages.Add(this.tabFormPage2);
            this.tabFormControl1.Pages.Add(this.tabFormPage5);
            this.tabFormControl1.Pages.Add(this.tabFormPage4);
            this.tabFormControl1.Pages.Add(this.tabFormPage3);
            this.tabFormControl1.SelectedPage = this.tabFormPage1;
            this.tabFormControl1.Size = new System.Drawing.Size(1008, 61);
            this.tabFormControl1.TabForm = this;
            this.tabFormControl1.TabIndex = 0;
            this.tabFormControl1.TabStop = false;
            this.tabFormControl1.OuterFormCreating += new DevExpress.XtraBars.OuterFormCreatingEventHandler(this.OnOuterFormCreating);
            // 
            // tabFormDefaultManager1
            // 
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlTop);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlBottom);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlLeft);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlRight);
            this.tabFormDefaultManager1.DockingEnabled = false;
            this.tabFormDefaultManager1.Form = this;
            this.tabFormDefaultManager1.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 61);
            this.barDockControlTop.Manager = null;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1008, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 694);
            this.barDockControlBottom.Manager = null;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1008, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 61);
            this.barDockControlLeft.Manager = null;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 633);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1008, 61);
            this.barDockControlRight.Manager = null;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 633);
            // 
            // tabFormPage1
            // 
            this.tabFormPage1.ContentContainer = this.xtraScrollableControl1;
            this.tabFormPage1.Name = "tabFormPage1";
            this.tabFormPage1.Text = "Giriş";
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.richTextBox1);
            this.xtraScrollableControl1.Controls.Add(this.chartControl2);
            this.xtraScrollableControl1.Controls.Add(this.labelControl10);
            this.xtraScrollableControl1.Controls.Add(this.labelControl2);
            this.xtraScrollableControl1.Controls.Add(this.labelControl1);
            this.xtraScrollableControl1.Controls.Add(this.chartControl1);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 61);
            this.xtraScrollableControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(1008, 633);
            this.xtraScrollableControl1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BulletIndent = 5;
            this.richTextBox1.Location = new System.Drawing.Point(53, 307);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(379, 212);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // chartControl2
            // 
            this.chartControl2.AppearanceNameSerializable = "Northern Lights";
            this.chartControl2.DataBindings = null;
            this.chartControl2.Legend.MarkerMode = DevExpress.XtraCharts.LegendMarkerMode.CheckBoxAndMarker;
            this.chartControl2.Legend.Name = "Default Legend";
            this.chartControl2.Location = new System.Drawing.Point(498, 307);
            this.chartControl2.Name = "chartControl2";
            doughnutSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.TwoColumns;
            doughnutSeriesLabel1.TextPattern = "{A} / {V}";
            series1.Label = doughnutSeriesLabel1;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.Name = "okul";
            series1.View = doughnutSeriesView1;
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl2.Size = new System.Drawing.Size(449, 212);
            this.chartControl2.TabIndex = 2;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Appearance.Options.UseForeColor = true;
            this.labelControl10.Location = new System.Drawing.Point(53, 278);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(60, 24);
            this.labelControl10.TabIndex = 1;
            this.labelControl10.Text = "notlar";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(498, 277);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(227, 24);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "öğrenci - okul dağılımı";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(53, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 24);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "analiz";
            // 
            // chartControl1
            // 
            this.chartControl1.DataBindings = null;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(53, 62);
            this.chartControl1.Name = "chartControl1";
            series2.Name = "gelir";
            series2.View = lineSeriesView1;
            series3.Name = "gider";
            series3.View = lineSeriesView2;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2,
        series3};
            this.chartControl1.Size = new System.Drawing.Size(892, 148);
            this.chartControl1.TabIndex = 0;
            // 
            // tabFormPage2
            // 
            this.tabFormPage2.ContentContainer = this.tabFormContentContainer1;
            this.tabFormPage2.Name = "tabFormPage2";
            this.tabFormPage2.Text = "listeler";
            // 
            // tabFormContentContainer1
            // 
            this.tabFormContentContainer1.Controls.Add(this.dataGrid_listeler);
            this.tabFormContentContainer1.Controls.Add(this.simpleButton5);
            this.tabFormContentContainer1.Controls.Add(this.simpleButton4);
            this.tabFormContentContainer1.Controls.Add(this.simpleButton3);
            this.tabFormContentContainer1.Controls.Add(this.simpleButton2);
            this.tabFormContentContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabFormContentContainer1.Location = new System.Drawing.Point(0, 61);
            this.tabFormContentContainer1.Name = "tabFormContentContainer1";
            this.tabFormContentContainer1.Size = new System.Drawing.Size(1008, 633);
            this.tabFormContentContainer1.TabIndex = 6;
            // 
            // dataGrid_listeler
            // 
            this.dataGrid_listeler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGrid_listeler.Location = new System.Drawing.Point(0, 207);
            this.dataGrid_listeler.MainView = this.gridView1;
            this.dataGrid_listeler.MenuManager = this.tabFormDefaultManager1;
            this.dataGrid_listeler.Name = "dataGrid_listeler";
            this.dataGrid_listeler.Size = new System.Drawing.Size(1008, 426);
            this.dataGrid_listeler.TabIndex = 5;
            this.dataGrid_listeler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dataGrid_listeler;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // simpleButton5
            // 
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(677, 32);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(136, 42);
            this.simpleButton5.TabIndex = 4;
            this.simpleButton5.Text = "okul listesi";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(508, 32);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(136, 42);
            this.simpleButton4.TabIndex = 3;
            this.simpleButton4.Text = "araç listesi";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(332, 32);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(136, 42);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "şoför listesi";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(165, 30);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(136, 42);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "öğrenci listesi";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // tabFormPage5
            // 
            this.tabFormPage5.ContentContainer = this.tabFormContentContainer4;
            this.tabFormPage5.Name = "tabFormPage5";
            this.tabFormPage5.Text = "tahsilat";
            // 
            // tabFormContentContainer4
            // 
            this.tabFormContentContainer4.Controls.Add(this.groupBox_tahsilat);
            this.tabFormContentContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer4.Location = new System.Drawing.Point(0, 61);
            this.tabFormContentContainer4.Name = "tabFormContentContainer4";
            this.tabFormContentContainer4.Size = new System.Drawing.Size(1008, 633);
            this.tabFormContentContainer4.TabIndex = 9;
            // 
            // groupBox_tahsilat
            // 
            this.groupBox_tahsilat.Controls.Add(this.dateEdit_tahsilatTarih);
            this.groupBox_tahsilat.Controls.Add(this.txt_tahsilatMiktar);
            this.groupBox_tahsilat.Controls.Add(this.txt_tahsilatOgrenciId);
            this.groupBox_tahsilat.Controls.Add(this.labelControl9);
            this.groupBox_tahsilat.Controls.Add(this.grid_tahsilat);
            this.groupBox_tahsilat.Controls.Add(this.button_tahsilatMakbuz);
            this.groupBox_tahsilat.Controls.Add(this.labelControl8);
            this.groupBox_tahsilat.Controls.Add(this.button_tahsilatYap);
            this.groupBox_tahsilat.Controls.Add(this.labelControl7);
            this.groupBox_tahsilat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_tahsilat.Location = new System.Drawing.Point(0, 0);
            this.groupBox_tahsilat.Name = "groupBox_tahsilat";
            this.groupBox_tahsilat.Size = new System.Drawing.Size(1008, 633);
            this.groupBox_tahsilat.TabIndex = 16;
            this.groupBox_tahsilat.TabStop = false;
            // 
            // dateEdit_tahsilatTarih
            // 
            this.dateEdit_tahsilatTarih.CalendarFont = new System.Drawing.Font("Tahoma", 8F);
            this.dateEdit_tahsilatTarih.CustomFormat = "yyyy-MM-dd";
            this.dateEdit_tahsilatTarih.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dateEdit_tahsilatTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEdit_tahsilatTarih.Location = new System.Drawing.Point(251, 483);
            this.dateEdit_tahsilatTarih.Name = "dateEdit_tahsilatTarih";
            this.dateEdit_tahsilatTarih.Size = new System.Drawing.Size(171, 26);
            this.dateEdit_tahsilatTarih.TabIndex = 18;
            this.dateEdit_tahsilatTarih.Value = new System.DateTime(2018, 4, 14, 18, 18, 33, 0);
            // 
            // txt_tahsilatMiktar
            // 
            this.txt_tahsilatMiktar.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_tahsilatMiktar.Location = new System.Drawing.Point(252, 437);
            this.txt_tahsilatMiktar.MaxLength = 10;
            this.txt_tahsilatMiktar.Name = "txt_tahsilatMiktar";
            this.txt_tahsilatMiktar.Size = new System.Drawing.Size(170, 28);
            this.txt_tahsilatMiktar.TabIndex = 17;
            this.txt_tahsilatMiktar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numeric_kontrol_KeyUp);
            // 
            // txt_tahsilatOgrenciId
            // 
            this.txt_tahsilatOgrenciId.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_tahsilatOgrenciId.Location = new System.Drawing.Point(252, 392);
            this.txt_tahsilatOgrenciId.MaxLength = 5;
            this.txt_tahsilatOgrenciId.Name = "txt_tahsilatOgrenciId";
            this.txt_tahsilatOgrenciId.Size = new System.Drawing.Size(170, 28);
            this.txt_tahsilatOgrenciId.TabIndex = 16;
            this.txt_tahsilatOgrenciId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numeric_kontrol_KeyUp);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(137, 394);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(83, 22);
            this.labelControl9.TabIndex = 15;
            this.labelControl9.Text = "ogrenci id:";
            // 
            // grid_tahsilat
            // 
            this.grid_tahsilat.Dock = System.Windows.Forms.DockStyle.Top;
            this.grid_tahsilat.Location = new System.Drawing.Point(3, 18);
            this.grid_tahsilat.MainView = this.gridView2;
            this.grid_tahsilat.MenuManager = this.tabFormDefaultManager1;
            this.grid_tahsilat.Name = "grid_tahsilat";
            this.grid_tahsilat.Size = new System.Drawing.Size(1002, 359);
            this.grid_tahsilat.TabIndex = 11;
            this.grid_tahsilat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grid_tahsilat;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView2_SelectionChanged);
            // 
            // button_tahsilatMakbuz
            // 
            this.button_tahsilatMakbuz.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.button_tahsilatMakbuz.Appearance.Options.UseFont = true;
            this.button_tahsilatMakbuz.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("button_tahsilatMakbuz.ImageOptions.Image")));
            this.button_tahsilatMakbuz.Location = new System.Drawing.Point(534, 458);
            this.button_tahsilatMakbuz.Name = "button_tahsilatMakbuz";
            this.button_tahsilatMakbuz.Size = new System.Drawing.Size(183, 46);
            this.button_tahsilatMakbuz.TabIndex = 9;
            this.button_tahsilatMakbuz.Text = "makbuz yazdır";
            this.button_tahsilatMakbuz.Click += new System.EventHandler(this.button_tahsilatMakbuz_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(167, 436);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(53, 22);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "miktar:";
            // 
            // button_tahsilatYap
            // 
            this.button_tahsilatYap.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button_tahsilatYap.Appearance.Options.UseFont = true;
            this.button_tahsilatYap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("button_tahsilatYap.ImageOptions.Image")));
            this.button_tahsilatYap.Location = new System.Drawing.Point(534, 392);
            this.button_tahsilatYap.Name = "button_tahsilatYap";
            this.button_tahsilatYap.Size = new System.Drawing.Size(183, 46);
            this.button_tahsilatYap.TabIndex = 8;
            this.button_tahsilatYap.Text = "tahsilat yap";
            this.button_tahsilatYap.Click += new System.EventHandler(this.button_tahsilatYap_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(180, 483);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(40, 22);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "tarih:";
            // 
            // tabFormPage4
            // 
            this.tabFormPage4.ContentContainer = this.tabFormContentContainer3;
            this.tabFormPage4.Name = "tabFormPage4";
            this.tabFormPage4.Text = "Ödemeler";
            // 
            // tabFormContentContainer3
            // 
            this.tabFormContentContainer3.Controls.Add(this.groupBox_odemeler);
            this.tabFormContentContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer3.Location = new System.Drawing.Point(0, 61);
            this.tabFormContentContainer3.Name = "tabFormContentContainer3";
            this.tabFormContentContainer3.Size = new System.Drawing.Size(1008, 633);
            this.tabFormContentContainer3.TabIndex = 8;
            // 
            // groupBox_odemeler
            // 
            this.groupBox_odemeler.Controls.Add(this.simpleButton1);
            this.groupBox_odemeler.Controls.Add(this.grid_odemeler);
            this.groupBox_odemeler.Controls.Add(this.datetime_giderTarih);
            this.groupBox_odemeler.Controls.Add(this.txt_odemeMiktar);
            this.groupBox_odemeler.Controls.Add(this.txt_odemeId);
            this.groupBox_odemeler.Controls.Add(this.label_odemeDegiskenId);
            this.groupBox_odemeler.Controls.Add(this.labelControl4);
            this.groupBox_odemeler.Controls.Add(this.labelControl5);
            this.groupBox_odemeler.Controls.Add(this.comboBox_odemeTur);
            this.groupBox_odemeler.Controls.Add(this.labelControl6);
            this.groupBox_odemeler.Controls.Add(this.labelControl_odemetur);
            this.groupBox_odemeler.Controls.Add(this.btn_odemelerTamamla);
            this.groupBox_odemeler.Controls.Add(this.txt_giderAciklama);
            this.groupBox_odemeler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_odemeler.Location = new System.Drawing.Point(0, 0);
            this.groupBox_odemeler.Name = "groupBox_odemeler";
            this.groupBox_odemeler.Size = new System.Drawing.Size(1008, 633);
            this.groupBox_odemeler.TabIndex = 18;
            this.groupBox_odemeler.TabStop = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(142, 71);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(165, 51);
            this.simpleButton1.TabIndex = 19;
            this.simpleButton1.Text = "yeni ödeme türü ekle";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // grid_odemeler
            // 
            this.grid_odemeler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grid_odemeler.Location = new System.Drawing.Point(3, 230);
            this.grid_odemeler.MainView = this.gridView3;
            this.grid_odemeler.MaximumSize = new System.Drawing.Size(0, 400);
            this.grid_odemeler.MenuManager = this.tabFormDefaultManager1;
            this.grid_odemeler.Name = "grid_odemeler";
            this.grid_odemeler.Size = new System.Drawing.Size(1002, 400);
            this.grid_odemeler.TabIndex = 18;
            this.grid_odemeler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.grid_odemeler;
            this.gridView3.Name = "gridView3";
            // 
            // datetime_giderTarih
            // 
            this.datetime_giderTarih.CalendarFont = new System.Drawing.Font("Tahoma", 8F);
            this.datetime_giderTarih.CustomFormat = "yyyy-MM-dd";
            this.datetime_giderTarih.Font = new System.Drawing.Font("Tahoma", 9F);
            this.datetime_giderTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetime_giderTarih.Location = new System.Drawing.Point(538, 115);
            this.datetime_giderTarih.Name = "datetime_giderTarih";
            this.datetime_giderTarih.Size = new System.Drawing.Size(171, 26);
            this.datetime_giderTarih.TabIndex = 14;
            this.datetime_giderTarih.Value = new System.DateTime(2018, 4, 14, 18, 18, 33, 0);
            // 
            // txt_odemeMiktar
            // 
            this.txt_odemeMiktar.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_odemeMiktar.Location = new System.Drawing.Point(538, 68);
            this.txt_odemeMiktar.MaxLength = 10;
            this.txt_odemeMiktar.Name = "txt_odemeMiktar";
            this.txt_odemeMiktar.Size = new System.Drawing.Size(170, 28);
            this.txt_odemeMiktar.TabIndex = 13;
            this.txt_odemeMiktar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numeric_kontrol_KeyUp);
            // 
            // txt_odemeId
            // 
            this.txt_odemeId.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_odemeId.Location = new System.Drawing.Point(538, 23);
            this.txt_odemeId.MaxLength = 3;
            this.txt_odemeId.Name = "txt_odemeId";
            this.txt_odemeId.Size = new System.Drawing.Size(170, 28);
            this.txt_odemeId.TabIndex = 12;
            this.txt_odemeId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numeric_kontrol_KeyUp);
            // 
            // label_odemeDegiskenId
            // 
            this.label_odemeDegiskenId.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_odemeDegiskenId.Appearance.Options.UseFont = true;
            this.label_odemeDegiskenId.Location = new System.Drawing.Point(439, 23);
            this.label_odemeDegiskenId.Name = "label_odemeDegiskenId";
            this.label_odemeDegiskenId.Size = new System.Drawing.Size(67, 22);
            this.label_odemeDegiskenId.TabIndex = 1;
            this.label_odemeDegiskenId.Text = "Şoför id:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(453, 68);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(53, 22);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "miktar:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(466, 115);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 22);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "tarih:";
            // 
            // comboBox_odemeTur
            // 
            this.comboBox_odemeTur.FormattingEnabled = true;
            this.comboBox_odemeTur.Location = new System.Drawing.Point(142, 33);
            this.comboBox_odemeTur.Name = "comboBox_odemeTur";
            this.comboBox_odemeTur.Size = new System.Drawing.Size(165, 24);
            this.comboBox_odemeTur.TabIndex = 10;
            this.comboBox_odemeTur.SelectedIndexChanged += new System.EventHandler(this.comboBox_odemeTur_SelectedIndexChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(431, 162);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(75, 22);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "açıklama:";
            // 
            // labelControl_odemetur
            // 
            this.labelControl_odemetur.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl_odemetur.Appearance.Options.UseFont = true;
            this.labelControl_odemetur.Location = new System.Drawing.Point(9, 32);
            this.labelControl_odemetur.Name = "labelControl_odemetur";
            this.labelControl_odemetur.Size = new System.Drawing.Size(127, 24);
            this.labelControl_odemetur.TabIndex = 1;
            this.labelControl_odemetur.Text = "Ödeme türü:";
            // 
            // btn_odemelerTamamla
            // 
            this.btn_odemelerTamamla.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_odemelerTamamla.Appearance.Options.UseFont = true;
            this.btn_odemelerTamamla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_odemelerTamamla.ImageOptions.Image")));
            this.btn_odemelerTamamla.Location = new System.Drawing.Point(739, 23);
            this.btn_odemelerTamamla.Name = "btn_odemelerTamamla";
            this.btn_odemelerTamamla.Size = new System.Drawing.Size(221, 73);
            this.btn_odemelerTamamla.TabIndex = 16;
            this.btn_odemelerTamamla.Text = "Ödemeyi Tamamla";
            this.btn_odemelerTamamla.Click += new System.EventHandler(this.btn_odemelerTamamla_Click);
            // 
            // txt_giderAciklama
            // 
            this.txt_giderAciklama.Location = new System.Drawing.Point(538, 156);
            this.txt_giderAciklama.Name = "txt_giderAciklama";
            this.txt_giderAciklama.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_giderAciklama.Properties.Appearance.Options.UseFont = true;
            this.txt_giderAciklama.Size = new System.Drawing.Size(171, 28);
            this.txt_giderAciklama.TabIndex = 15;
            // 
            // tabFormPage3
            // 
            this.tabFormPage3.ContentContainer = this.tabFormContentContainer2;
            this.tabFormPage3.Name = "tabFormPage3";
            this.tabFormPage3.Text = "tanımlar";
            // 
            // tabFormContentContainer2
            // 
            this.tabFormContentContainer2.Controls.Add(this.label4);
            this.tabFormContentContainer2.Controls.Add(this.label3);
            this.tabFormContentContainer2.Controls.Add(this.label2);
            this.tabFormContentContainer2.Controls.Add(this.label1);
            this.tabFormContentContainer2.Controls.Add(this.button_soforEkle);
            this.tabFormContentContainer2.Controls.Add(this.button_okulEkle);
            this.tabFormContentContainer2.Controls.Add(this.Btn_aracEkle);
            this.tabFormContentContainer2.Controls.Add(this.Btn_ogrenciEkle);
            this.tabFormContentContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer2.Location = new System.Drawing.Point(0, 61);
            this.tabFormContentContainer2.Name = "tabFormContentContainer2";
            this.tabFormContentContainer2.Size = new System.Drawing.Size(1008, 633);
            this.tabFormContentContainer2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(647, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "OKUL EKLE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(154, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "ARAÇ EKLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(635, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "ŞOFÖR EKLE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(145, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "ÖĞRENCİ EKLE";
            // 
            // button_soforEkle
            // 
            this.button_soforEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_soforEkle.Image = global::DXApplication1.Properties.Resources.sofor;
            this.button_soforEkle.Location = new System.Drawing.Point(513, 40);
            this.button_soforEkle.Name = "button_soforEkle";
            this.button_soforEkle.Size = new System.Drawing.Size(357, 187);
            this.button_soforEkle.TabIndex = 19;
            this.button_soforEkle.UseVisualStyleBackColor = true;
            this.button_soforEkle.Click += new System.EventHandler(this.button_soforEkle_Click);
            // 
            // button_okulEkle
            // 
            this.button_okulEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_okulEkle.Image = global::DXApplication1.Properties.Resources.okul;
            this.button_okulEkle.Location = new System.Drawing.Point(513, 269);
            this.button_okulEkle.Name = "button_okulEkle";
            this.button_okulEkle.Size = new System.Drawing.Size(357, 187);
            this.button_okulEkle.TabIndex = 21;
            this.button_okulEkle.UseVisualStyleBackColor = true;
            this.button_okulEkle.Click += new System.EventHandler(this.button_okulEkle_Click);
            // 
            // Btn_aracEkle
            // 
            this.Btn_aracEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_aracEkle.Image = global::DXApplication1.Properties.Resources.arac;
            this.Btn_aracEkle.Location = new System.Drawing.Point(41, 269);
            this.Btn_aracEkle.Name = "Btn_aracEkle";
            this.Btn_aracEkle.Size = new System.Drawing.Size(357, 187);
            this.Btn_aracEkle.TabIndex = 20;
            this.Btn_aracEkle.UseVisualStyleBackColor = true;
            this.Btn_aracEkle.Click += new System.EventHandler(this.Btn_aracEkle_Click);
            // 
            // Btn_ogrenciEkle
            // 
            this.Btn_ogrenciEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_ogrenciEkle.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.Btn_ogrenciEkle.ForeColor = System.Drawing.Color.White;
            this.Btn_ogrenciEkle.Image = global::DXApplication1.Properties.Resources.ogrenci;
            this.Btn_ogrenciEkle.Location = new System.Drawing.Point(41, 40);
            this.Btn_ogrenciEkle.Name = "Btn_ogrenciEkle";
            this.Btn_ogrenciEkle.Size = new System.Drawing.Size(357, 187);
            this.Btn_ogrenciEkle.TabIndex = 18;
            this.Btn_ogrenciEkle.UseVisualStyleBackColor = true;
            this.Btn_ogrenciEkle.Click += new System.EventHandler(this.Btn_ogrenciEkle_Click);
            // 
            // pdYazici
            // 
            this.pdYazici.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdYazici_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.pdYazici;
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.pdYazici;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 694);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Controls.Add(this.tabFormControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(960, 700);
            this.Name = "Form1";
            this.TabFormControl = this.tabFormControl1;
            this.Text = "Servis Takip";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            this.xtraScrollableControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.tabFormContentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_listeler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tabFormContentContainer4.ResumeLayout(false);
            this.groupBox_tahsilat.ResumeLayout(false);
            this.groupBox_tahsilat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tahsilat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.tabFormContentContainer3.ResumeLayout(false);
            this.groupBox_odemeler.ResumeLayout(false);
            this.groupBox_odemeler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_odemeler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_giderAciklama.Properties)).EndInit();
            this.tabFormContentContainer2.ResumeLayout(false);
            this.tabFormContentContainer2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.TabFormControl tabFormControl1;
        private DevExpress.XtraBars.TabFormDefaultManager tabFormDefaultManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraBars.TabFormPage tabFormPage1;
        private DevExpress.XtraBars.TabFormPage tabFormPage2;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer1;
        private DevExpress.XtraBars.TabFormPage tabFormPage4;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer3;
        private DevExpress.XtraBars.TabFormPage tabFormPage5;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer4;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.TextEdit txt_giderAciklama;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl label_odemeDegiskenId;
        private DevExpress.XtraEditors.LabelControl labelControl_odemetur;
        private DevExpress.XtraEditors.SimpleButton btn_odemelerTamamla;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer2;
        private DevExpress.XtraEditors.SimpleButton button_tahsilatMakbuz;
        private DevExpress.XtraEditors.SimpleButton button_tahsilatYap;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraGrid.GridControl grid_tahsilat;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraBars.TabFormPage tabFormPage3;
        private System.Windows.Forms.Button button_soforEkle;
        private System.Windows.Forms.Button Btn_ogrenciEkle;
        private System.Windows.Forms.Button Btn_aracEkle;
        private System.Windows.Forms.Button button_okulEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.ComboBox comboBox_odemeTur;
        private DevExpress.XtraGrid.GridControl dataGrid_listeler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox_odemeler;
        private System.Windows.Forms.TextBox txt_odemeId;
        private System.Windows.Forms.TextBox txt_odemeMiktar;
        private System.Windows.Forms.GroupBox groupBox_tahsilat;
        private System.Windows.Forms.TextBox txt_tahsilatMiktar;
        private System.Windows.Forms.TextBox txt_tahsilatOgrenciId;
        private System.Windows.Forms.DateTimePicker datetime_giderTarih;
        private System.Windows.Forms.DateTimePicker dateEdit_tahsilatTarih;
        private DevExpress.XtraGrid.GridControl grid_odemeler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Drawing.Printing.PrintDocument pdYazici;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

