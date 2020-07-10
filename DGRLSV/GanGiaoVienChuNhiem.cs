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

namespace DGRLSV
{
	public partial class GanGiaoVienChuNhiem : DevExpress.XtraEditors.XtraForm
	{
		DGRLEF db = new DGRLEF();
		public GanGiaoVienChuNhiem()
		{
			InitializeComponent();
			LoadData();
			AddBinding();
		}

		private void LoadData()
		{
			var kq = from c in db.giangVien
					 from p in db.lop
					 where p.maGV == c.maGV
					 select new { c.maGV, c.tenGV, c.khoa.tenKhoa, p.tenLop };
			grcGiaoVien.DataSource = /*db.giangVien.ToList()*/kq.ToList();
		}
		void AddBinding()
		{
			txbMaGV.DataBindings.Add(new Binding("Text", grcGiaoVien.DataSource, "maGV"));
			txbTenGV.DataBindings.Add(new Binding("Text", grcGiaoVien.DataSource, "tenGV"));
			txbKhoaGV.DataBindings.Add(new Binding("Text", grcGiaoVien.DataSource, "tenKhoa"));
			txbLopCN.DataBindings.Add(new Binding("Text", grcGiaoVien.DataSource, "tenLop"));
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			update();
			LoadData();
			XtraMessageBox.Show("Dữ liệu đã được lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		private void update()
		{
			string magv = txbMaGV.Text.Trim();
			lop lop = db.lop.FirstOrDefault(c => c.maGV == magv);
			lop.tenLop = txbLopCN.Text.Trim();
			db.SaveChanges();
		}
	}
}