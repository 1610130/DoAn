using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using System.IO;
using DevExpress.Export.Xl;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.Entity;
using DevExpress.Data.ODataLinq.Helpers;
using DevExpress.XtraGrid.Columns;
using DevExpress.Data;

namespace DGRLSV
{
	public partial class dsKetQua : DevExpress.XtraEditors.XtraForm
	{
		DGRLEF db = new DGRLEF();
		public dsKetQua()
		{
			InitializeComponent();
			db.ketQua.Load();
			ketQuaBindingSource1.DataSource = db.ketQua.Local;
			gridView1.CustomUnboundColumnData += gridView1_CustomUnboundColumnData;
		}
	private void SelectComboBox(int top)
		{
			if (cbXepLoai.SelectedIndex != -1)
			{
				gct1.DataSource = db.ketQua.Where(p => p.xepLoai == cbXepLoai.SelectedItem.ToString()
											&& p.namHoc == cbNamHoc.SelectedItem.ToString()
											&& p.sinhVien.lop.khoa.tenKhoa == cbKhoa.SelectedItem.ToString()
											&& p.maHK == cbHocKy.SelectedItem.ToString()
				).OrderByDescending(p => p.tongDiemCVHT).ToList().Take(top);
			}
			else
			{
				gct1.DataSource = db.ketQua.Where(p => p.xepLoai == p.xepLoai
											&& p.namHoc == cbNamHoc.SelectedItem.ToString()
											&& p.sinhVien.lop.khoa.tenKhoa == cbKhoa.SelectedItem.ToString()
											&& p.maHK == cbHocKy.SelectedItem.ToString()
				).OrderByDescending(p => p.tongDiemCVHT).ToList().Take(top);
			}
		}
		private void SelectComboBox()
		{
			int top;
			bool isSuccsess = int.TryParse(textEdit1.Text, out top);
			if (cbXepLoai.SelectedIndex != -1)
			{
				gct1.DataSource = db.ketQua.Where(p => p.xepLoai == cbXepLoai.SelectedItem.ToString()
											&& p.namHoc == cbNamHoc.SelectedItem.ToString()
											&& p.sinhVien.lop.khoa.tenKhoa == cbKhoa.SelectedItem.ToString()
											&& p.maHK == cbHocKy.SelectedItem.ToString()
				).OrderByDescending(p => p.tongDiemCVHT).ToList().Take(top);
			}
			else
			{
				gct1.DataSource = db.ketQua.Where(p => p.xepLoai == p.xepLoai
											&& p.namHoc == cbNamHoc.SelectedItem.ToString()
											&& p.sinhVien.lop.khoa.tenKhoa == cbKhoa.SelectedItem.ToString()
											&& p.maHK == cbHocKy.SelectedItem.ToString()
				).OrderByDescending(p => p.tongDiemCVHT).ToList().Take(top);
			}
		}
		private void cbHocKy_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (textEdit1.Text == "")
				SelectComboBox(db.sinhVien.Count());
			else
				SelectComboBox();
		}

		private void cbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbHocKy.Enabled = true;
			if (textEdit1.Text == "")
				SelectComboBox(db.sinhVien.Count());
			else
				SelectComboBox();
		}

		private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (textEdit1.Text == "")
				SelectComboBox(db.sinhVien.Count());
			else
				SelectComboBox();
		}

		private void cbXepLoai_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (textEdit1.Text == "")
				SelectComboBox(db.sinhVien.Count());
			else
				SelectComboBox();
		}

		private void textEdit1_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
		{
			if (textEdit1.Text == "")
				SelectComboBox(db.sinhVien.Count());
			else
				SelectComboBox();
		}

		private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
		{
			if (e.IsGetData)
				e.Value = 1+gridView1.GetRowHandle(e.ListSourceRowIndex);
		}
	}
}