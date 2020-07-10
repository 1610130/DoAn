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
		ThongKe tk;
		GanGiaoVienChuNhiem gv;
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
		private Form kiemtraform(Type ftype)
		{
			foreach (Form f in this.MdiChildren)
			{
				if (f.GetType() == ftype)
				{
					return f;
				}
			}
			return null;
		}
		private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Form form = kiemtraform(typeof(dsKetQua));
			if (form == null)
			{
				f = new dsKetQua();
				f.MdiParent = this;
				f.Show();
			}
			else
			{
				form.Activate();
			}
		}
		private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Form form = kiemtraform(typeof(ThongKe));
			if (form == null)
			{
				tk = new ThongKe();
				tk.MdiParent = this;
				tk.Show();
			}
			else
			{
				form.Activate();
			}
		}
		private void btnGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Form form = kiemtraform(typeof(GanGiaoVienChuNhiem));
			if (form == null)
			{
				gv = new GanGiaoVienChuNhiem();
				gv.MdiParent = this;
				gv.Show();
			}
			else
			{
				form.Activate();
			}
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
	}
}
