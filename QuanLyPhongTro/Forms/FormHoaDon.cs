using MaterialSkin.Controls;
using System;
using System.IO.Packaging;
using System.Windows.Forms;

namespace QuanLyPhongTro.Forms
{
    public partial class FormHoaDon : MaterialForm
    {
        public FormHoaDon(string tenPhong, string giaPhong, string nguoiThue, string SoDienCu, string SoNuocCu, string SoDienMoi, string SoNuocMoi, string giaDien, string giaNuoc, string tongTienDien, string tongTienNuoc, string tongTienPhuPhi, string tongTien)
        {
            InitializeComponent();

            tbTenPhong.Text = tenPhong;
            if (double.TryParse(giaPhong, out double tphong))
            {
                tbTienPhong.Text = tphong.ToString("N2");
            }
            else
            {
                tbTienPhong.Text = "0";
            }
            tbKhachThue.Text = nguoiThue;
            if (double.TryParse(giaDien, out double giaDienF))
            {
                tbGiaDien.Text = giaDienF.ToString("N2");
            }
            else
            {
                tbGiaDien.Text = "0.00";
            }
            if (double.TryParse(giaNuoc, out double giaNuocF))
            {
                tbGiaNuoc.Text = giaNuocF.ToString("N2");
            }
            else
            {
                tbGiaNuoc.Text = "0.00";
            }
            tbTienDien.Text = tongTienDien;
            tbTienNuoc.Text = tongTienNuoc;
            tbTongTienPhuPhi.Text = tongTienPhuPhi;
            tbTongTien.Text = tongTien;


            TinhSoDien(SoDienCu, SoDienMoi);
            TinhSoNuoc(SoNuocCu, SoNuocMoi);
        }

        private void TinhSoDien(string SoDienCu, string SoDienMoi)
        {
            try
            {
                SoDienCu = SoDienCu.Trim();
                SoDienMoi = SoDienMoi.Trim();
                if (double.TryParse(SoDienCu, out double dc) && double.TryParse(SoDienMoi,out double dm) )
                {
                    if (dm >= dc) {
                        double soDien = dm - dc;
                        tbSoDien.Text = soDien.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Số điện mới phải lớn hơn hoặc bằng số điện cũ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbSoDien.Text = "0";
                    }
                }
                else
                {
                    MessageBox.Show("Dữ liệu số điện không hợp lệ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbSoDien.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TinhSoNuoc(string SoNuocCu, string SoNuocMoi)
        {
            try
            {
                SoNuocCu = SoNuocCu.Trim();
                SoNuocMoi = SoNuocMoi.Trim();
                if (double.TryParse(SoNuocCu, out double nc) && double.TryParse(SoNuocMoi, out double nm))
                {
                    if (nm >= nc)
                    {
                        double soNuoc = nm - nc;
                        tbSoNuoc.Text = soNuoc.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Số điện mới phải lớn hơn hoặc bằng số điện cũ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbSoNuoc.Text = "0";
                    }
                }
                else
                {
                    MessageBox.Show("Dữ liệu số điện không hợp lệ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbSoNuoc.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Xác Nhận Thoát", "Thông Báo",MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dg == DialogResult.Yes) { 
                this.Close();
            }
        }
    }
}
