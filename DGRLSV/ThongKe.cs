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
using System.Data.Entity;
using DevExpress.XtraCharts;
using DevExpress.Utils.Extensions;
using DevExpress.Utils.MVVM;
using ComboBox = System.Windows.Forms.ComboBox;

namespace DGRLSV
{
    public partial class ThongKe : DevExpress.XtraEditors.XtraForm
    {
        DGRLEF db = new DGRLEF();
        public ThongKe()
        {
            InitializeComponent();

        }
        private void cbChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbChoice.SelectedItem.ToString())
            {
                case "":
                    break;
                case "Khoa":
                    cbCustom.Show();
                    cbCustom.Properties.Items.Clear();
                    cbCustom.SelectedItem = null;
                    foreach (var item in db.khoa)
                    {
                        cbCustom.Properties.Items.Add(item.tenKhoa).ToString();
                    }
                    break;
                case "Lớp":
                    cbCustom.Show();
                    cbCustom.Properties.Items.Clear();
                    cbCustom.SelectedItem = null;
                    foreach (var item in db.lop)
                    {
                        cbCustom.Properties.Items.Add(item.tenLop).ToString();
                    }
                    break;
                case "Xếp loại":
                    cbCustom.Hide();
                    pnChart.Controls.Clear();
                    drawChart("Xếp loại sinh viên");
                    break;
                default:
                    break;
            }
        }

        private void cbCustom_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbChoice.SelectedIndex)
            {
                case 0:
                    if (cbCustom.SelectedItem != null)
                    {
                        pnChart.Controls.Clear();
                        drawChart("Xếp loại sinh viên khoa "+ cbCustom.SelectedItem.ToString());
                    }
                    break;
                case 1:
                    if (cbCustom.SelectedItem != null)
                    {
                        pnChart.Controls.Clear();
                        drawChart("Xếp loại sinh viên lớp " + cbCustom.SelectedItem.ToString());
                    }
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        private void drawChart(string title)
        {
            ChartControl pieChart = new ChartControl();

            pieChart.Titles.Add(new ChartTitle() { Text = title });
            Series series1 = new Series(title, ViewType.Pie);
            series1.DataSource = GetDataPoints();
            series1.ArgumentDataMember = "Argument";
            series1.ValueDataMembers.AddRange(new string[] { "Value" });
            pieChart.Series.Add(series1);
            series1.Label.TextPattern = "{VP:p1}";
            series1.LegendTextPattern = "{A}";
            ((PieSeriesLabel)series1.Label).Position = PieSeriesLabelPosition.TwoColumns;
            ((PieSeriesLabel)series1.Label).ResolveOverlappingMode = ResolveOverlappingMode.Default;
            PieSeriesView myView = (PieSeriesView)series1.View;
            myView.ExplodeMode = PieExplodeMode.UseFilters;
            myView.ExplodedDistancePercentage = 30;
            myView.RuntimeExploding = true;
            pieChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            pieChart.Dock = DockStyle.Fill;
            this.pnChart.AddControl(pieChart);
        }
        public List<ThongKe> TKKhoa()
        {
            double kha = Math.Round((double)db.ketQua.Where(p => p.xepLoai == "Khá"
                && p.sinhVien.lop.khoa.tenKhoa == cbCustom.SelectedItem.ToString()).Count() / (double)db.ketQua.Where(p => p.sinhVien.lop.khoa.tenKhoa == cbCustom.SelectedItem.ToString()).Count() * 100, 2);
            double kem = Math.Round((double)db.ketQua.Where(p => p.xepLoai == "Kém"
                            && p.sinhVien.lop.khoa.tenKhoa == cbCustom.SelectedItem.ToString()).Count() / (double)db.ketQua.Where(p => p.sinhVien.lop.khoa.tenKhoa == cbCustom.SelectedItem.ToString()).Count() * 100, 2);
            double yeu = Math.Round((double)db.ketQua.Where(p => p.xepLoai == "Yếu"
                            && p.sinhVien.lop.khoa.tenKhoa == cbCustom.SelectedItem.ToString()).Count() / (double)db.ketQua.Where(p => p.sinhVien.lop.khoa.tenKhoa == cbCustom.SelectedItem.ToString()).Count() * 100, 2);
            double tb = Math.Round((double)db.ketQua.Where(p => p.xepLoai == "Trung bình"
                            && p.sinhVien.lop.khoa.tenKhoa == cbCustom.SelectedItem.ToString()).Count() / (double)db.ketQua.Where(p => p.sinhVien.lop.khoa.tenKhoa == cbCustom.SelectedItem.ToString()).Count() * 100, 2);
            double tot = Math.Round((double)db.ketQua.Where(p => p.xepLoai == "Tốt"
                            && p.sinhVien.lop.khoa.tenKhoa == cbCustom.SelectedItem.ToString()).Count() / (double)db.ketQua.Where(p => p.sinhVien.lop.khoa.tenKhoa == cbCustom.SelectedItem.ToString()).Count() * 100, 2);
            double xuatsac = Math.Round((double)db.ketQua.Where(p => p.xepLoai == "Xuất sắc"
                            && p.sinhVien.lop.khoa.tenKhoa == cbCustom.SelectedItem.ToString()).Count() / (double)db.ketQua.Where(p => p.sinhVien.lop.khoa.tenKhoa == cbCustom.SelectedItem.ToString()).Count() * 100, 2);
            return new List<ThongKe> {
                                new ThongKe { Argument = "Kém"       ,   Value = kem     },
                                new ThongKe { Argument = "Yếu"       ,   Value = yeu     },
                                new ThongKe { Argument = "Trung bình",   Value = tb      },
                                new ThongKe { Argument = "Khá"       ,   Value = kha     },
                                new ThongKe { Argument = "Tốt"       ,   Value = tot     },
                                new ThongKe { Argument = "Xuất sắc"  ,   Value = xuatsac }
                        };
        }
        public List<ThongKe> TKLop()
        {
            double kha = Math.Round((double)db.ketQua.Where(p => p.xepLoai == "Khá"
                && p.sinhVien.lop.tenLop == cbCustom.SelectedItem.ToString()).Count() / (double)db.ketQua.Where(p => p.sinhVien.lop.tenLop == cbCustom.SelectedItem.ToString()).Count() * 100, 2);
            double kem = Math.Round((double)db.ketQua.Where(p => p.xepLoai == "Kém"
                            && p.sinhVien.lop.tenLop == cbCustom.SelectedItem.ToString()).Count() / (double)db.ketQua.Where(p => p.sinhVien.lop.tenLop == cbCustom.SelectedItem.ToString()).Count() * 100, 2);
            double yeu = Math.Round((double)db.ketQua.Where(p => p.xepLoai == "Yếu"
                            && p.sinhVien.lop.tenLop == cbCustom.SelectedItem.ToString()).Count() / (double)db.ketQua.Where(p => p.sinhVien.lop.tenLop == cbCustom.SelectedItem.ToString()).Count() * 100, 2);
            double tb = Math.Round((double)db.ketQua.Where(p => p.xepLoai == "Trung bình"
                            && p.sinhVien.lop.tenLop == cbCustom.SelectedItem.ToString()).Count() / (double)db.ketQua.Where(p => p.sinhVien.lop.tenLop == cbCustom.SelectedItem.ToString()).Count() * 100, 2);
            double tot = Math.Round((double)db.ketQua.Where(p => p.xepLoai == "Tốt"
                            && p.sinhVien.lop.tenLop == cbCustom.SelectedItem.ToString()).Count() / (double)db.ketQua.Where(p => p.sinhVien.lop.tenLop == cbCustom.SelectedItem.ToString()).Count() * 100, 2);
            double xuatsac = Math.Round((double)db.ketQua.Where(p => p.xepLoai == "Xuất sắc"
                            && p.sinhVien.lop.tenLop == cbCustom.SelectedItem.ToString()).Count() / (double)db.ketQua.Where(p => p.sinhVien.lop.tenLop == cbCustom.SelectedItem.ToString()).Count() * 100, 2);
            return new List<ThongKe> {
                                new ThongKe { Argument = "Kém"       ,   Value = kem     },
                                new ThongKe { Argument = "Yếu"       ,   Value = yeu     },
                                new ThongKe { Argument = "Trung bình",   Value = tb      },
                                new ThongKe { Argument = "Khá"       ,   Value = kha     },
                                new ThongKe { Argument = "Tốt"       ,   Value = tot     },
                                new ThongKe { Argument = "Xuất sắc"  ,   Value = xuatsac }
                        };
        }
        public List<ThongKe> TKXepLoai()
        {
            double kem = Math.Round((double)db.ketQua.Where(p => p.xepLoai == "Kém").Count()
                                                         /(double)db.ketQua.Count() * 100, 2);
            double yeu = Math.Round((double)db.ketQua.Where(p => p.xepLoai == "Yếu").Count()
                                                         / (double)db.ketQua.Count() * 100, 2);
            double tb = Math.Round((double)db.ketQua.Where(p => p.xepLoai == "Trung bình").Count()
                                                         / (double)db.ketQua.Count() * 100, 2);
            double kha = Math.Round((double)db.ketQua.Where(p => p.xepLoai == "Khá").Count()
                                                         / (double)db.ketQua.Count() * 100, 2);
            double tot = Math.Round((double)db.ketQua.Where(p => p.xepLoai == "Tốt").Count()
                                                         / (double)db.ketQua.Count() * 100, 2);
            double xuatsac = Math.Round((double)db.ketQua.Where(p => p.xepLoai == "Xuất sắc").Count()
                                                         / (double)db.ketQua.Count() * 100, 2);
            return new List<ThongKe> {
                                new ThongKe { Argument = "Kém"       ,   Value = kem     },
                                new ThongKe { Argument = "Yếu"       ,   Value = yeu     },
                                new ThongKe { Argument = "Trung bình",   Value = tb      },
                                new ThongKe { Argument = "Khá"       ,   Value = kha     },
                                new ThongKe { Argument = "Tốt"       ,   Value = tot     },
                                new ThongKe { Argument = "Xuất sắc"  ,   Value = xuatsac }
                        };
        }
        public string Argument { get; set; }
        public double Value { get; set; }
        public List<ThongKe> GetDataPoints()
        {
            switch (cbChoice.SelectedIndex)
            {
                case 0:
                    return TKKhoa();
                case 1:
                    return TKLop();
                case 2:
                    return TKXepLoai();
                default:
                    return null;
            }
        }
    }
}