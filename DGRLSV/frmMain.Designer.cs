namespace DGRLSV
{
	partial class frmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.skinPaletteDropDownButtonItem1 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
			this.skinPaletteRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
			this.skinPaletteRibbonGalleryBarItem2 = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
			this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
			this.btnGV = new DevExpress.XtraBars.BarButtonItem();
			this.iptExcel = new DevExpress.XtraBars.BarButtonItem();
			this.iptWord = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
			this.btnCardView = new DevExpress.XtraBars.BarButtonItem();
			this.btnListView = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbonControl1
			// 
			this.ribbonControl1.ExpandCollapseItem.Id = 0;
			this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.skinPaletteDropDownButtonItem1,
            this.skinPaletteRibbonGalleryBarItem1,
            this.skinPaletteRibbonGalleryBarItem2,
            this.skinRibbonGalleryBarItem1,
            this.btnGV,
            this.iptExcel,
            this.iptWord,
            this.barButtonItem1,
            this.barButtonItem2,
            this.btnCardView,
            this.btnListView,
            this.barButtonItem3});
			this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl1.MaxItemId = 13;
			this.ribbonControl1.Name = "ribbonControl1";
			this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage3,
            this.ribbonPage2});
			this.ribbonControl1.Size = new System.Drawing.Size(998, 158);
			// 
			// skinPaletteDropDownButtonItem1
			// 
			this.skinPaletteDropDownButtonItem1.Id = 1;
			this.skinPaletteDropDownButtonItem1.Name = "skinPaletteDropDownButtonItem1";
			// 
			// skinPaletteRibbonGalleryBarItem1
			// 
			this.skinPaletteRibbonGalleryBarItem1.Caption = "skinPaletteRibbonGalleryBarItem1";
			this.skinPaletteRibbonGalleryBarItem1.Id = 2;
			this.skinPaletteRibbonGalleryBarItem1.Name = "skinPaletteRibbonGalleryBarItem1";
			// 
			// skinPaletteRibbonGalleryBarItem2
			// 
			this.skinPaletteRibbonGalleryBarItem2.Caption = "skinPaletteRibbonGalleryBarItem2";
			this.skinPaletteRibbonGalleryBarItem2.Id = 3;
			this.skinPaletteRibbonGalleryBarItem2.Name = "skinPaletteRibbonGalleryBarItem2";
			// 
			// skinRibbonGalleryBarItem1
			// 
			this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
			this.skinRibbonGalleryBarItem1.Id = 4;
			this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
			// 
			// btnGV
			// 
			this.btnGV.Caption = "Gán giáo viên chủ nhiệm";
			this.btnGV.Id = 5;
			this.btnGV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGV.ImageOptions.SvgImage")));
			this.btnGV.Name = "btnGV";
			this.btnGV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGV_ItemClick);
			// 
			// iptExcel
			// 
			this.iptExcel.Caption = "Excel";
			this.iptExcel.Id = 6;
			this.iptExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("iptExcel.ImageOptions.Image")));
			this.iptExcel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("iptExcel.ImageOptions.LargeImage")));
			this.iptExcel.Name = "iptExcel";
			this.iptExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iptExcel_ItemClick);
			// 
			// iptWord
			// 
			this.iptWord.Caption = "Word";
			this.iptWord.Id = 7;
			this.iptWord.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("iptWord.ImageOptions.Image")));
			this.iptWord.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("iptWord.ImageOptions.LargeImage")));
			this.iptWord.Name = "iptWord";
			this.iptWord.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iptWord_ItemClick);
			// 
			// barButtonItem1
			// 
			this.barButtonItem1.Caption = "KQ";
			this.barButtonItem1.Id = 8;
			this.barButtonItem1.Name = "barButtonItem1";
			// 
			// barButtonItem2
			// 
			this.barButtonItem2.Caption = "Biểu đồ";
			this.barButtonItem2.Id = 9;
			this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
			this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
			this.barButtonItem2.Name = "barButtonItem2";
			this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
			// 
			// btnCardView
			// 
			this.btnCardView.Caption = "Thẻ";
			this.btnCardView.Id = 10;
			this.btnCardView.Name = "btnCardView";
			// 
			// btnListView
			// 
			this.btnListView.Caption = "Danh Sách";
			this.btnListView.Id = 11;
			this.btnListView.Name = "btnListView";
			// 
			// barButtonItem3
			// 
			this.barButtonItem3.Caption = "barButtonItem3";
			this.barButtonItem3.Id = 12;
			this.barButtonItem3.Name = "barButtonItem3";
			// 
			// ribbonPage3
			// 
			this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
			this.ribbonPage3.Name = "ribbonPage3";
			this.ribbonPage3.Text = "Thao tác";
			// 
			// ribbonPageGroup3
			// 
			this.ribbonPageGroup3.ItemLinks.Add(this.btnGV);
			this.ribbonPageGroup3.Name = "ribbonPageGroup3";
			// 
			// ribbonPageGroup4
			// 
			this.ribbonPageGroup4.ItemLinks.Add(this.iptExcel);
			this.ribbonPageGroup4.ItemLinks.Add(this.iptWord);
			this.ribbonPageGroup4.Name = "ribbonPageGroup4";
			this.ribbonPageGroup4.Text = "Kết xuất";
			// 
			// ribbonPageGroup5
			// 
			this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem2);
			this.ribbonPageGroup5.Name = "ribbonPageGroup5";
			this.ribbonPageGroup5.Text = "Thống Kê";
			// 
			// ribbonPage2
			// 
			this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
			this.ribbonPage2.Name = "ribbonPage2";
			this.ribbonPage2.Text = "Xem";
			// 
			// ribbonPageGroup2
			// 
			this.ribbonPageGroup2.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
			this.ribbonPageGroup2.Name = "ribbonPageGroup2";
			this.ribbonPageGroup2.Text = "Giao diện";
			// 
			// xtraTabbedMdiManager1
			// 
			this.xtraTabbedMdiManager1.MdiParent = this;
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.FileName = "Doc File|*.txt";
			// 
			// ribbonPage1
			// 
			this.ribbonPage1.Name = "ribbonPage1";
			this.ribbonPage1.Text = "Trang chủ";
			// 
			// ribbonPageGroup1
			// 
			this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.Text = "ribbonPageGroup1";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(998, 599);
			this.Controls.Add(this.ribbonControl1);
			this.IsMdiContainer = true;
			this.MinimumSize = new System.Drawing.Size(1000, 600);
			this.Name = "frmMain";
			this.Ribbon = this.ribbonControl1;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thống kê rèn luyện sinh viên";
			this.Load += new System.EventHandler(this.frmMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
		private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
		private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem1;
		private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem1;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
		private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem2;
		private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
		private DevExpress.XtraBars.BarButtonItem btnGV;
		private DevExpress.XtraBars.BarButtonItem iptExcel;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
		private DevExpress.XtraBars.BarButtonItem iptWord;
		private DevExpress.XtraBars.BarButtonItem barButtonItem1;
		private DevExpress.XtraBars.BarButtonItem barButtonItem2;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private DevExpress.XtraBars.BarButtonItem btnCardView;
		private DevExpress.XtraBars.BarButtonItem btnListView;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
		private DevExpress.XtraBars.BarButtonItem barButtonItem3;
	}
}

