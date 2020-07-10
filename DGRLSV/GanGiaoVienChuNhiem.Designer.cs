namespace DGRLSV
{
	partial class GanGiaoVienChuNhiem
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GanGiaoVienChuNhiem));
			this.giangVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
			this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
			this.txbLopCN = new DevExpress.XtraEditors.TextEdit();
			this.txbKhoaGV = new DevExpress.XtraEditors.TextEdit();
			this.txbTenGV = new DevExpress.XtraEditors.TextEdit();
			this.txbMaGV = new DevExpress.XtraEditors.TextEdit();
			this.grcGiaoVien = new DevExpress.XtraGrid.GridControl();
			this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colmaGV = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coltenGV = new DevExpress.XtraGrid.Columns.GridColumn();
			this.collop = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
			this.dataLayoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txbLopCN.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txbKhoaGV.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txbTenGV.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txbMaGV.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grcGiaoVien)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// giangVienBindingSource
			// 
			this.giangVienBindingSource.DataSource = typeof(DGRLSV.giangVien);
			// 
			// dataLayoutControl1
			// 
			this.dataLayoutControl1.Controls.Add(this.btnLuu);
			this.dataLayoutControl1.Controls.Add(this.txbLopCN);
			this.dataLayoutControl1.Controls.Add(this.txbKhoaGV);
			this.dataLayoutControl1.Controls.Add(this.txbTenGV);
			this.dataLayoutControl1.Controls.Add(this.txbMaGV);
			this.dataLayoutControl1.Controls.Add(this.grcGiaoVien);
			this.dataLayoutControl1.DataSource = this.giangVienBindingSource;
			this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
			this.dataLayoutControl1.Name = "dataLayoutControl1";
			this.dataLayoutControl1.Root = this.Root;
			this.dataLayoutControl1.Size = new System.Drawing.Size(949, 409);
			this.dataLayoutControl1.TabIndex = 0;
			this.dataLayoutControl1.Text = "dataLayoutControl1";
			// 
			// btnLuu
			// 
			this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
			this.btnLuu.Location = new System.Drawing.Point(558, 12);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(379, 36);
			this.btnLuu.StyleController = this.dataLayoutControl1;
			this.btnLuu.TabIndex = 9;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// txbLopCN
			// 
			this.txbLopCN.Location = new System.Drawing.Point(629, 124);
			this.txbLopCN.Name = "txbLopCN";
			this.txbLopCN.Size = new System.Drawing.Size(308, 20);
			this.txbLopCN.StyleController = this.dataLayoutControl1;
			this.txbLopCN.TabIndex = 8;
			// 
			// txbKhoaGV
			// 
			this.txbKhoaGV.Location = new System.Drawing.Point(629, 100);
			this.txbKhoaGV.Name = "txbKhoaGV";
			this.txbKhoaGV.Size = new System.Drawing.Size(308, 20);
			this.txbKhoaGV.StyleController = this.dataLayoutControl1;
			this.txbKhoaGV.TabIndex = 7;
			// 
			// txbTenGV
			// 
			this.txbTenGV.Location = new System.Drawing.Point(629, 76);
			this.txbTenGV.Name = "txbTenGV";
			this.txbTenGV.Size = new System.Drawing.Size(308, 20);
			this.txbTenGV.StyleController = this.dataLayoutControl1;
			this.txbTenGV.TabIndex = 6;
			// 
			// txbMaGV
			// 
			this.txbMaGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.giangVienBindingSource, "maGV", true));
			this.txbMaGV.Location = new System.Drawing.Point(629, 52);
			this.txbMaGV.Name = "txbMaGV";
			this.txbMaGV.Size = new System.Drawing.Size(308, 20);
			this.txbMaGV.StyleController = this.dataLayoutControl1;
			this.txbMaGV.TabIndex = 5;
			// 
			// grcGiaoVien
			// 
			this.grcGiaoVien.DataSource = this.khoaBindingSource;
			this.grcGiaoVien.Location = new System.Drawing.Point(12, 12);
			this.grcGiaoVien.MainView = this.gridView1;
			this.grcGiaoVien.Name = "grcGiaoVien";
			this.grcGiaoVien.Size = new System.Drawing.Size(542, 385);
			this.grcGiaoVien.TabIndex = 4;
			this.grcGiaoVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// khoaBindingSource
			// 
			this.khoaBindingSource.DataSource = typeof(DGRLSV.khoa);
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmaGV,
            this.coltenGV,
            this.collop,
            this.colKhoa});
			this.gridView1.GridControl = this.grcGiaoVien;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.ShowGroupPanel = false;
			// 
			// colmaGV
			// 
			this.colmaGV.Caption = "Mã giáo viên";
			this.colmaGV.FieldName = "maGV";
			this.colmaGV.Name = "colmaGV";
			this.colmaGV.Visible = true;
			this.colmaGV.VisibleIndex = 0;
			// 
			// coltenGV
			// 
			this.coltenGV.Caption = "Tên giáo viên";
			this.coltenGV.FieldName = "tenGV";
			this.coltenGV.Name = "coltenGV";
			this.coltenGV.Visible = true;
			this.coltenGV.VisibleIndex = 1;
			// 
			// collop
			// 
			this.collop.Caption = "Lớp chủ nhiệm";
			this.collop.FieldName = "tenLop";
			this.collop.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
			this.collop.Name = "collop";
			this.collop.Visible = true;
			this.collop.VisibleIndex = 2;
			// 
			// colKhoa
			// 
			this.colKhoa.Caption = "Khoa";
			this.colKhoa.FieldName = "tenKhoa";
			this.colKhoa.Name = "colKhoa";
			this.colKhoa.Visible = true;
			this.colKhoa.VisibleIndex = 3;
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem2,
            this.layoutControlItem6});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(949, 409);
			this.Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.grcGiaoVien;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(546, 389);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.txbTenGV;
			this.layoutControlItem3.Location = new System.Drawing.Point(546, 64);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(383, 24);
			this.layoutControlItem3.Text = "Tên giáo viên";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(68, 13);
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.txbKhoaGV;
			this.layoutControlItem4.Location = new System.Drawing.Point(546, 88);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(383, 24);
			this.layoutControlItem4.Text = "Khoa";
			this.layoutControlItem4.TextSize = new System.Drawing.Size(68, 13);
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.txbLopCN;
			this.layoutControlItem5.Location = new System.Drawing.Point(546, 112);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(383, 277);
			this.layoutControlItem5.Text = "Lớp chủ nhiệm";
			this.layoutControlItem5.TextSize = new System.Drawing.Size(68, 13);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.txbMaGV;
			this.layoutControlItem2.Location = new System.Drawing.Point(546, 40);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(383, 24);
			this.layoutControlItem2.Text = "Mã giáo viên";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(68, 13);
			// 
			// layoutControlItem6
			// 
			this.layoutControlItem6.Control = this.btnLuu;
			this.layoutControlItem6.Location = new System.Drawing.Point(546, 0);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Size = new System.Drawing.Size(383, 40);
			this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem6.TextVisible = false;
			// 
			// lopBindingSource
			// 
			this.lopBindingSource.DataSource = typeof(DGRLSV.lop);
			// 
			// GanGiaoVienChuNhiem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(949, 409);
			this.Controls.Add(this.dataLayoutControl1);
			this.Name = "GanGiaoVienChuNhiem";
			this.Text = "Gán giáo viên chủ nhiệm";
			((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
			this.dataLayoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txbLopCN.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txbKhoaGV.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txbTenGV.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txbMaGV.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grcGiaoVien)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.BindingSource giangVienBindingSource;
		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraEditors.TextEdit txbMaGV;
		private DevExpress.XtraGrid.GridControl grcGiaoVien;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn colmaGV;
		private DevExpress.XtraGrid.Columns.GridColumn coltenGV;
		private DevExpress.XtraGrid.Columns.GridColumn collop;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraEditors.SimpleButton btnLuu;
		private DevExpress.XtraEditors.TextEdit txbLopCN;
		private DevExpress.XtraEditors.TextEdit txbKhoaGV;
		private DevExpress.XtraEditors.TextEdit txbTenGV;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
		private System.Windows.Forms.BindingSource lopBindingSource;
		private System.Windows.Forms.BindingSource khoaBindingSource;
		private DevExpress.XtraGrid.Columns.GridColumn colKhoa;
	}
}