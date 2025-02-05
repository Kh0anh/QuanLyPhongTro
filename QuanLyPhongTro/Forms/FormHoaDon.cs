using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Drawing.Imaging;
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
                tbTienPhong.Text = tphong.ToString("N0");
            }
            else
            {
                tbTienPhong.Text = "0";
            }
            tbKhachThue.Text = nguoiThue;
            if (double.TryParse(giaDien, out double giaDienF))
            {
                tbGiaDien.Text = giaDienF.ToString("N0");
            }
            else
            {
                tbGiaDien.Text = "0.00";
            }
            if (double.TryParse(giaNuoc, out double giaNuocF))
            {
                tbGiaNuoc.Text = giaNuocF.ToString("N0");
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
                if (double.TryParse(SoDienCu, out double dc) && double.TryParse(SoDienMoi, out double dm))
                {
                    if (dm >= dc)
                    {
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
            this.Text = string.Format("{0} - {1}", CaiDat.TenPhanMem, "Hoá Đơn");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Xác Nhận Thoát", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ form
                string tenPhong = tbTenPhong.Text;
                string khachThue = tbKhachThue.Text;
                string tienPhong = tbTienPhong.Text;
                string soDien = tbSoDien.Text;
                string giaDien = tbGiaDien.Text;
                string tienDien = tbTienDien.Text;
                string soNuoc = tbSoNuoc.Text;
                string giaNuoc = tbGiaNuoc.Text;
                string tienNuoc = tbTienNuoc.Text;
                string tongPhuPhi = tbTongTienPhuPhi.Text;
                string tongTien = tbTongTien.Text;

                // Chuẩn bị nội dung hóa đơn
                string billText = $@"
====================================
           HÓA ĐƠN THUÊ TRỌ
------------------------------------
Phòng: {tenPhong}
Khách thuê: {khachThue}
------------------------------------
Tiền phòng:          {tienPhong} đ
Điện: {soDien} kWh x {giaDien} đ
Tiền điện:           {tienDien} đ
Nước: {soNuoc} m³ x {giaNuoc} đ
Tiền nước:           {tienNuoc} đ
Phụ phí:             {tongPhuPhi} đ
------------------------------------
TỔNG CỘNG:          {tongTien} đ
====================================
";

                int width = 450;
                int height = 450;
                int padding = 10;

                // Tạo ảnh bitmap
                using (Bitmap bitmap = new Bitmap(width, height))
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    // Đặt nền trắng
                    g.Clear(Color.White);

                    // Cấu hình font
                    Font font = new Font("Courier New", 14, FontStyle.Bold);
                    Brush brush = Brushes.Black;

                    // Vẽ từng dòng text vào ảnh
                    int y = padding;
                    foreach (var line in billText.Split('\n'))
                    {
                        g.DrawString(line, font, brush, padding, y);
                        y += 25; // Khoảng cách dòng
                    }

                    // Mở hộp thoại lưu file
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "PNG Image|*.png",
                        Title = "Lưu Hóa Đơn",
                        FileName = $"HoaDon_{tenPhong}_{DateTime.Now.ToString("dd-MM")}.png"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        bitmap.Save(saveFileDialog.FileName, ImageFormat.Png);
                        MessageBox.Show("Hóa đơn đã được lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_SIZE = 0xF000;

            if (m.Msg == WM_SYSCOMMAND && (m.WParam.ToInt32() & 0xFFF0) == SC_SIZE)
                return;

            base.WndProc(ref m);
        }

    }
}
