using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace QuanLyPhongTro.Forms
{
    public partial class FormTinhTien : MaterialForm
    {
        public FormTinhTien(string maPhong,string tenPhong,string giaPhong, string phuPhi, string trangThai,string nguoiThue,string ngayThue, string soDienCu, string soNuocCu, string ghiChu)
        {
            InitializeComponent();
            tbTenPhong.Text = tenPhong;
            tbNguoiThue.Text = nguoiThue;
            tbSoDienCu.Text = soDienCu;
            tbSoNuocCu.Text = soNuocCu;
            tbGiaPhong.Text = giaPhong;

        }

        private void tbXuatHoaDon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNguoiThue.Text))
            {
                MessageBox.Show("Phòng chưa được thuê", "Thông Báo");
                this.Close();
                return;
            }
            if (!double.TryParse(tbSoDienCu.Text, out double soDienCu) ||
                !double.TryParse(tbSoDienMoi.Text, out double soDienMoi) ||
                !double.TryParse(tbSoNuocCu.Text, out double soNuocCu) ||
                !double.TryParse(tbSoNuocMoi.Text, out double soNuocMoi))
            {
                MessageBox.Show("Số điện hoặc nước không hợp lệ.", "Thông Báo");
                return;
            }

            if (soDienMoi < soDienCu || soNuocMoi < soNuocCu)
            {
                MessageBox.Show("Số điện và nước mới phải lớn hơn hoặc bằng số điện và nước cũ.", "Thông Báo");
                return;
            }
            else new FormHoaDon().Show();
        }

        private void tbHuyTinhTien_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Xác Nhận Hủy", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FormTinhTien_Load(object sender, EventArgs e)
        {
            TongTienDien();
            TongTienNuoc();
        }
        private void TongTienDien() 
        {
            if (float.TryParse(tbSoDienCu.Text, out float dc) &&
                float.TryParse(tbSoDienMoi.Text, out float dm) &&
                float.TryParse(tbGiaDien.Text, out float gd))
            {
                if (dm >= dc)
                {
                    double tong = (dm - dc) * gd;
                    tbTongTienDien.Text = tong.ToString();
                }
                else
                {
                    tbTongTienDien.Text = "0";
                   // MessageBox.Show("Số điện mới phải lớn hơn hoặc bằng giá điện cũ", "Thông Báo");
                }

            }
            else
            {
                tbTongTienDien.Text = "0";
                //MessageBox.Show("Số điện mới phải lớn hơn hoặc bằng giá điện cũ", "Thông Báo");
            }
                
            
        }
        private void TongTienNuoc()
        {
            if (float.TryParse(tbSoNuocCu.Text, out float nc) &&
                float.TryParse(tbSoNuocMoi.Text, out float nm) &&
                float.TryParse(tbGiaNuoc.Text, out float gn))
            {
                if (nm >= nc)
                {
                    double tong = (nm - nc) * gn;
                    tbTongTienNuoc.Text = tong.ToString();
                }
                else
                {
                    tbTongTienNuoc.Text = "0";
                    // MessageBox.Show("Số điện mới phải lớn hơn hoặc bằng giá điện cũ", "Thông Báo");
                }

            }
            else
            {
                tbTongTienNuoc.Text = "0";
                //MessageBox.Show("Số điện mới phải lớn hơn hoặc bằng giá điện cũ", "Thông Báo");
            }


        }

        private void tbSoDienMoi_TextChanged(object sender, EventArgs e)
        {
            TongTienDien();
        }

        private void tbGiaDien_TextChanged(object sender, EventArgs e)
        {
            TongTienDien();
        }

        private void tbSoNuocMoi_TextChanged(object sender, EventArgs e)
        {
            TongTienNuoc();
        }

        private void tbGiaNuoc_TextChanged(object sender, EventArgs e)
        {
            TongTienNuoc();
        }
    }
}
