namespace DGRLSV
{
	partial class dsKetQua
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
			this.gct1 = new DevExpress.XtraGrid.GridControl();
			this.ketQuaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colMSSV = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coltongDiemCVHT = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colxepLoai = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ketQuaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.bar3 = new DevExpress.XtraBars.Bar();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
			this.cbHocKy = new DevExpress.XtraEditors.ComboBoxEdit();
			this.cbNamHoc = new DevExpress.XtraEditors.ComboBoxEdit();
			this.cbKhoa = new DevExpress.XtraEditors.ComboBoxEdit();
			this.cbXepLoai = new DevExpress.XtraEditors.ComboBoxEdit();
			this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.gct1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbHocKy.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbNamHoc.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbKhoa.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbXepLoai.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
			this.stackPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// gct1
			// 
			this.gct1.DataSource = this.ketQuaBindingSource1;
			this.gct1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gct1.Location = new System.Drawing.Point(0, 27);
			this.gct1.MainView = this.gridView1;
			this.gct1.Name = "gct1";
			this.gct1.Size = new System.Drawing.Size(695, 378);
			this.gct1.TabIndex = 0;
			this.gct1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// ketQuaBindingSource1
			// 
			this.ketQuaBindingSource1.DataSource = typeof(DGRLSV.ketQua);
			// 
			// gridView1
			// 
			this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
			this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.gridView1.Appearance.Row.Options.UseTextOptions = true;
			this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.gridView1.Appearance.ViewCaption.Options.UseTextOptions = true;
			this.gridView1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridView1.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.gridView1.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
			this.gridView1.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridView1.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.gridView1.AppearancePrint.Row.Options.UseTextOptions = true;
			this.gridView1.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridView1.AppearancePrint.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colMSSV,
            this.colKhoa,
            this.coltongDiemCVHT,
            this.colxepLoai});
			this.gridView1.GridControl = this.gct1;
			this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", null, "({0} Sinh viên)")});
			this.gridView1.Name = "gridView1";
			this.gridView1.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridView1_CustomUnboundColumnData);
			// 
			// colMSSV
			// 
			this.colMSSV.Caption = "MSSV";
			this.colMSSV.FieldName = "MSSV";
			this.colMSSV.Name = "colMSSV";
			this.colMSSV.OptionsColumn.FixedWidth = true;
			this.colMSSV.Visible = true;
			this.colMSSV.VisibleIndex = 1;
			// 
			// colKhoa
			// 
			this.colKhoa.Caption = "Khoa";
			this.colKhoa.FieldName = "sinhVien.lop.khoa.tenKhoa";
			this.colKhoa.Name = "colKhoa";
			this.colKhoa.OptionsColumn.FixedWidth = true;
			this.colKhoa.Visible = true;
			this.colKhoa.VisibleIndex = 2;
			this.colKhoa.Width = 87;
			// 
			// coltongDiemCVHT
			// 
			this.coltongDiemCVHT.Caption = "Điểm rèn luyện";
			this.coltongDiemCVHT.FieldName = "tongDiemCVHT";
			this.coltongDiemCVHT.Name = "coltongDiemCVHT";
			this.coltongDiemCVHT.OptionsColumn.FixedWidth = true;
			this.coltongDiemCVHT.Visible = true;
			this.coltongDiemCVHT.VisibleIndex = 3;
			// 
			// colxepLoai
			// 
			this.colxepLoai.Caption = "Xếp loại";
			this.colxepLoai.FieldName = "xepLoai";
			this.colxepLoai.Name = "colxepLoai";
			this.colxepLoai.OptionsColumn.FixedWidth = true;
			this.colxepLoai.Visible = true;
			this.colxepLoai.VisibleIndex = 4;
			// 
			// ketQuaBindingSource
			// 
			this.ketQuaBindingSource.DataSource = typeof(DGRLSV.ketQua);
			// 
			// barManager1
			// 
			this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
			this.barManager1.DockControls.Add(this.barDockControlTop);
			this.barManager1.DockControls.Add(this.barDockControlBottom);
			this.barManager1.DockControls.Add(this.barDockControlLeft);
			this.barManager1.DockControls.Add(this.barDockControlRight);
			this.barManager1.Form = this;
			this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2});
			this.barManager1.MaxItemId = 2;
			this.barManager1.StatusBar = this.bar3;
			// 
			// bar3
			// 
			this.bar3.BarName = "Status bar";
			this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
			this.bar3.DockCol = 0;
			this.bar3.DockRow = 0;
			this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
			this.bar3.OptionsBar.AllowQuickCustomization = false;
			this.bar3.OptionsBar.DrawDragBorder = false;
			this.bar3.OptionsBar.UseWholeRow = true;
			this.bar3.Text = "Status bar";
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.barManager1;
			this.barDockControlTop.Size = new System.Drawing.Size(695, 0);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 405);
			this.barDockControlBottom.Manager = this.barManager1;
			this.barDockControlBottom.Size = new System.Drawing.Size(695, 20);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
			this.barDockControlLeft.Manager = this.barManager1;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 405);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(695, 0);
			this.barDockControlRight.Manager = this.barManager1;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 405);
			// 
			// barButtonItem1
			// 
			this.barButtonItem1.Caption = "Xuất ra word";
			this.barButtonItem1.Id = 0;
			this.barButtonItem1.Name = "barButtonItem1";
			// 
			// barButtonItem2
			// 
			this.barButtonItem2.Caption = "Xuất ra excel";
			this.barButtonItem2.Id = 1;
			this.barButtonItem2.Name = "barButtonItem2";
			// 
			// cbHocKy
			// 
			this.cbHocKy.EditValue = "Học Kỳ";
			this.cbHocKy.Enabled = false;
			this.cbHocKy.Location = new System.Drawing.Point(109, 0);
			this.cbHocKy.MenuManager = this.barManager1;
			this.cbHocKy.Name = "cbHocKy";
			this.cbHocKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cbHocKy.Properties.Items.AddRange(new object[] {
            "1",
            "2"});
			this.cbHocKy.Properties.Sorted = true;
			this.cbHocKy.Size = new System.Drawing.Size(100, 20);
			this.cbHocKy.TabIndex = 5;
			this.cbHocKy.SelectedIndexChanged += new System.EventHandler(this.cbHocKy_SelectedIndexChanged);
			// 
			// cbNamHoc
			// 
			this.cbNamHoc.EditValue = "Năm học";
			this.cbNamHoc.Location = new System.Drawing.Point(3, 0);
			this.cbNamHoc.MenuManager = this.barManager1;
			this.cbNamHoc.Name = "cbNamHoc";
			this.cbNamHoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cbNamHoc.Properties.Items.AddRange(new object[] {
            "2019",
            "2020"});
			this.cbNamHoc.Properties.Sorted = true;
			this.cbNamHoc.Size = new System.Drawing.Size(100, 20);
			this.cbNamHoc.TabIndex = 6;
			this.cbNamHoc.SelectedIndexChanged += new System.EventHandler(this.cbNamHoc_SelectedIndexChanged);
			// 
			// cbKhoa
			// 
			this.cbKhoa.EditValue = "Khoa";
			this.cbKhoa.Location = new System.Drawing.Point(215, 0);
			this.cbKhoa.MenuManager = this.barManager1;
			this.cbKhoa.Name = "cbKhoa";
			this.cbKhoa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cbKhoa.Properties.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Lịch sử",
            "Sư phạm",
            "Viễn thông"});
			this.cbKhoa.Properties.Sorted = true;
			this.cbKhoa.Size = new System.Drawing.Size(100, 20);
			this.cbKhoa.TabIndex = 7;
			this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged);
			// 
			// cbXepLoai
			// 
			this.cbXepLoai.EditValue = "Xếp loại";
			this.cbXepLoai.Location = new System.Drawing.Point(321, 0);
			this.cbXepLoai.MenuManager = this.barManager1;
			this.cbXepLoai.Name = "cbXepLoai";
			this.cbXepLoai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cbXepLoai.Properties.Items.AddRange(new object[] {
            "Kém",
            "Khá",
            "Tốt",
            "Trung Bình",
            "Xuất Sắc",
            "Yếu"});
			this.cbXepLoai.Properties.Sorted = true;
			this.cbXepLoai.Size = new System.Drawing.Size(100, 20);
			this.cbXepLoai.TabIndex = 8;
			this.cbXepLoai.SelectedIndexChanged += new System.EventHandler(this.cbXepLoai_SelectedIndexChanged);
			// 
			// stackPanel1
			// 
			this.stackPanel1.Controls.Add(this.cbNamHoc);
			this.stackPanel1.Controls.Add(this.cbHocKy);
			this.stackPanel1.Controls.Add(this.cbKhoa);
			this.stackPanel1.Controls.Add(this.cbXepLoai);
			this.stackPanel1.Controls.Add(this.labelControl1);
			this.stackPanel1.Controls.Add(this.textEdit1);
			this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.stackPanel1.Location = new System.Drawing.Point(0, 0);
			this.stackPanel1.Name = "stackPanel1";
			this.stackPanel1.Size = new System.Drawing.Size(695, 21);
			this.stackPanel1.TabIndex = 13;
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(427, 4);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(144, 13);
			this.labelControl1.TabIndex = 9;
			this.labelControl1.Text = "Danh sách sinh viên đứng đầu";
			// 
			// textEdit1
			// 
			this.textEdit1.Location = new System.Drawing.Point(577, 0);
			this.textEdit1.MenuManager = this.barManager1;
			this.textEdit1.Name = "textEdit1";
			this.textEdit1.Properties.Mask.EditMask = "n0";
			this.textEdit1.Size = new System.Drawing.Size(100, 20);
			this.textEdit1.TabIndex = 10;
			this.textEdit1.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.textEdit1_EditValueChanging);
			// 
			// gridColumn1
			// 
			this.gridColumn1.Caption = "STT";
			this.gridColumn1.FieldName = "UnboundColumn1";
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.OptionsColumn.FixedWidth = true;
			this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
			this.gridColumn1.Visible = true;
			this.gridColumn1.VisibleIndex = 0;
			// 
			// dsKetQua
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(695, 425);
			this.Controls.Add(this.stackPanel1);
			this.Controls.Add(this.gct1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Name = "dsKetQua";
			this.Text = "Danh sách sinh viên";
			((System.ComponentModel.ISupportInitialize)(this.gct1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbHocKy.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbNamHoc.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbKhoa.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbXepLoai.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
			this.stackPanel1.ResumeLayout(false);
			this.stackPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.BarButtonItem barButtonItem1;
		private DevExpress.XtraBars.BarButtonItem barButtonItem2;
		private DevExpress.XtraBars.Bar bar3;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private System.Windows.Forms.BindingSource ketQuaBindingSource;
		public DevExpress.XtraGrid.GridControl gct1;
		private System.Windows.Forms.BindingSource ketQuaBindingSource1;
		private DevExpress.XtraEditors.ComboBoxEdit cbXepLoai;
		private DevExpress.XtraEditors.ComboBoxEdit cbKhoa;
		private DevExpress.XtraEditors.ComboBoxEdit cbNamHoc;
		private DevExpress.XtraEditors.ComboBoxEdit cbHocKy;
		private DevExpress.Utils.Layout.StackPanel stackPanel1;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.TextEdit textEdit1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn coltongDiemCVHT;
		private DevExpress.XtraGrid.Columns.GridColumn colxepLoai;
		private DevExpress.XtraGrid.Columns.GridColumn colKhoa;
		private DevExpress.XtraGrid.Columns.GridColumn colMSSV;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
	}
}