using DevExpress.Export.Xl;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DGRLSV
{
	public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		dsKetQua f;
		public frmMain()
		{
			InitializeComponent();
		}
		private void frmMain_Load(object sender, EventArgs e)
		{
			f = new dsKetQua();
			f.MdiParent = this;
			f.Show();
		}

		private void iptExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			DevExpress.XtraGrid.Views.Grid.GridView View = f.gct1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
			if (View != null)
			{
				View.ExportToXlsx("MdiChill.xlsx");
				Process excelexport = new Process();
				excelexport.StartInfo.FileName = "EXCEL.exe";
				excelexport.StartInfo.Arguments = "MdiChill.xlsx";
				excelexport.Start();
			}
		}

		private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			ThongKe tk = new ThongKe();
			if (tk != MdiParent) {
			tk.MdiParent = this;
			tk.Show();
			}
		}

		private void btnGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			GanGiaoVienChuNhiem gv = new GanGiaoVienChuNhiem();
			gv.MdiParent = this;
			gv.Show();
		}

		private void iptWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			DevExpress.XtraGrid.Views.Grid.GridView View = f.gct1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
			if (View != null)
			{
				View.ExportToDocx("MdiChill.docx");
				Process wordexport = new Process();
				wordexport.StartInfo.FileName = "WINWORD.exe";
				wordexport.StartInfo.Arguments = "MdiChill.docx";
				wordexport.Start();
			}
		}

		//private void btnCardView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		//{
		//	dsKetQua f = new dsKetQua();
		//	BandedGridView bandedGridView = new BandedGridView();
		//	GridBand gridBand = new GridBand();
		//	gridBand.Caption = "Band";
		//	gridBand.Name = "gridBand";
		//	gridBand.VisibleIndex = 0;
		//	bandedGridView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
		//	gridBand});
		//	bandedGridView.GridControl = f.gct1;
		//	bandedGridView.Name = "bandedGridView";
		//	f.gct1.ViewCollection.Add(bandedGridView);
		//	f.gct1.MainView = bandedGridView;
		//}
	}
}
