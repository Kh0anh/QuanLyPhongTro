using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Controls;
using System.Windows.Forms;

namespace QuanLyPhongTro.Forms
{
    public partial class FormTinhTien : MaterialForm
    {
        private string maPhong;
        public FormTinhTien(string _maPhong,string tenPhong,string giaPhong, string phuPhi, string trangThai,string nguoiThue,string ngayThue, string soDienCu, string soNuocCu, string ghiChu)
        {
            InitializeComponent();
            maPhong = _maPhong;

            tbTenPhong.Text = tenPhong;
            tbNguoiThue.Text = nguoiThue;
            tbSoDienCu.Text = soDienCu;
            tbSoNuocCu.Text = soNuocCu;
            tbGiaPhong.Text = giaPhong;
            
            tbGiaDien.Text = CaiDat._GiaDien.ToString("N0");
            tbGiaNuoc.Text = CaiDat._GiaNuoc.ToString("N0");
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
            else
            {
                string tenPhong = tbTenPhong.Text;
                string giaPhong = tbGiaPhong.Text;
                string nguoiThue = tbNguoiThue.Text;
                string SoDienCu = tbSoDienCu.Text;
                string SoNuocCu = tbSoNuocCu.Text;
                string SoDienMoi = tbSoDienMoi.Text;
                string SoNuocMoi = tbSoNuocMoi.Text;
                string giaDien = tbGiaDien.Text;
                string giaNuoc = tbGiaNuoc.Text;
                string tongTienDien = tbTongTienDien.Text;
                string tongTienNuoc = tbTongTienNuoc.Text;
                string tongTienPhuPhi = tbTongTienPhuPhi.Text;
                string tongTien = tbTongTien.Text;
                new FormHoaDon(tenPhong,giaPhong,nguoiThue,SoDienCu,SoNuocCu,SoDienMoi,SoNuocMoi,giaDien,giaNuoc,tongTienDien,tongTienNuoc,tongTienPhuPhi,tongTien).Show();

                string query = "UPDATE Phong SET SoDienCu = @dien, SoNuocCu = @nuoc WHERE MaPhong = @maPhong";
                using (SQLiteCommand cmd = new SQLiteCommand(query, CaiDat.CSDL))
                {
                    cmd.Parameters.AddWithValue("@dien", tbSoDienMoi);
                    cmd.Parameters.AddWithValue("@nuoc", tbSoNuocMoi);
                    cmd.Parameters.AddWithValue("@maPhong", maPhong);
                    cmd.ExecuteNonQuery();
                }

                this.Close();
            }
            
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
            this.Text = string.Format("{0} - {1}", CaiDat.TenPhanMem, "Tính Tiền");

            HienThiDanhSachPhuPhi();
            LayDanhSachPhuPhi();

            TongTienDien();
            TongTienNuoc();
            TongTienPhuPhi();
            TinhTongTien();
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
                    tbTongTienDien.Text = tong.ToString("N0");
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
                    tbTongTienNuoc.Text = tong.ToString("N0");
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

        private void TongTienPhuPhi()
        {
            try
            {
                double tongPhuPhi = 0;
                foreach (System.Windows.Forms.ListViewItem item in lvPhuPhi.Items)
                {
                    if (double.TryParse(item.SubItems[2].Text, out double giaPhuPhi))
                    {
                        tongPhuPhi += giaPhuPhi;
                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu giá phụ phí không hợp lệ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                tbTongTienPhuPhi.Text = tongPhuPhi.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LayDanhSachPhuPhi()
        {
            // Xóa danh sách phụ phí cũ trước khi thêm mới vào ComboBox
            cmPhuPhi.Items.Clear();
            try
            {
                List<KeyValuePair<Int64, string>> items = new List<KeyValuePair<Int64, string>> { };

                // Truy vấn lấy danh sách tên phụ phí từ bảng PhuPhi
                string truyVan = "SELECT MaPhuPhi, TenPhuPhi FROM PhuPhi";
                using (SQLiteCommand cmd = new SQLiteCommand(truyVan, CaiDat.CSDL))
                {
                    // Đọc dữ liệu trả về
                    using (SQLiteDataReader doc = cmd.ExecuteReader())
                    {
                        // Duyệt qua các dòng dữ liệu và thêm vào ComboBox
                        while (doc.Read())
                        {
                            // Lấy tên phụ phí từ mỗi dòng
                            Int64 maPhuPhi = (Int64)doc["MaPhuPhi"];
                            string tenPhuPhi = doc["TenPhuPhi"].ToString();

                            // Thêm vào ComboBox
                            items.Add(new KeyValuePair<Int64, string>(maPhuPhi, tenPhuPhi));
                        }
                    }
                }

                cmPhuPhi.DataSource = items;
                cmPhuPhi.DisplayMember = "Value";
                cmPhuPhi.ValueMember = "Key";
            }
            catch (Exception err)
            {
                MaterialMessageBox.Show(err.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TinhTongTien()
        {
            try
            {
                if (double.TryParse(tbTongTienDien.Text, out double tDien) && double.TryParse(tbTongTienNuoc.Text, out double tNuoc) 
                    && double.TryParse(tbTongTienPhuPhi.Text,out double tPhuPhi) && double.TryParse(tbGiaPhong.Text,out double gPhong)){
                    double tongTien = tDien + tNuoc + tPhuPhi + gPhong;
                    tbTongTien.Text = tongTien.ToString("N0");
                }
                else 
                { 
                    tbTongTien.Text = "0"; 
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HienThiDanhSachPhuPhi()
        {
            lvPhuPhi.Items.Clear();
            try
            {
                using (SQLiteCommand truyVan = new SQLiteCommand("SELECT pp.MaPhuPhi, pp.TenPhuPhi, pp.GiaPhuPhi FROM PhongVaPhuPhi pvp INNER JOIN PhuPhi pp ON pvp.MaPhuPhi=pp.MaPhuPhi WHERE pvp.MaPhong==@maPhong", CaiDat.CSDL))
                {
                    truyVan.Parameters.AddWithValue("@maPhong", maPhong);
                    using (SQLiteDataReader doc = truyVan.ExecuteReader())
                    {
                        while (doc.Read())
                        {
                            System.Windows.Forms.ListViewItem item = new System.Windows.Forms.ListViewItem(((Int64)doc["MaPhuPhi"]).ToString());
                            item.SubItems.Add((string)doc["TenPhuPhi"]);
                            item.SubItems.Add(((Int64)doc["GiaPhuPhi"]).ToString());
                            lvPhuPhi.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TbSoDienMoi_TextChanged(object sender, EventArgs e)
        {
            TongTienDien();
            TinhTongTien();
        }

        private void tbGiaDien_TextChanged(object sender, EventArgs e)
        {
            TongTienDien();
            TinhTongTien(); 
        }

        private void tbSoNuocMoi_TextChanged(object sender, EventArgs e)
        {
            TongTienNuoc();
            TinhTongTien();
        }

        private void tbGiaNuoc_TextChanged(object sender, EventArgs e)
        {
            TongTienNuoc();
            TinhTongTien();
        }
        private void btThemPhuPhi_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra xem có đang chọn phụ phí nào trong ComboBox không?
                if (cmPhuPhi.SelectedItem == null)
                {
                    MaterialMessageBox.Show("Vui lòng chọn phụ phí cần thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string truyVan = "SELECT MaPhuPhi, TenPhuPhi, GiaPhuPhi FROM PhuPhi WHERE MaPhuPhi = @maPhuphi";
                using (SQLiteCommand lenh = new SQLiteCommand(truyVan, CaiDat.CSDL))
                {
                    lenh.Parameters.AddWithValue("@maPhuphi", cmPhuPhi.SelectedValue);
                    using (SQLiteDataReader doc = lenh.ExecuteReader())
                    {
                        while (doc.Read())
                        {
                            System.Windows.Forms.ListViewItem item = new System.Windows.Forms.ListViewItem(((Int64)doc["MaPhuPhi"]).ToString());
                            item.SubItems.Add((string)doc["TenPhuPhi"]);
                            item.SubItems.Add(((Int64)doc["GiaPhuPhi"]).ToString());

                            Invoke((MethodInvoker)(() =>
                            {
                                lvPhuPhi.Items.Add(item);
                            }));
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btXoaPhuPhi_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvPhuPhi.SelectedItems.Count > 0)
                {
                    foreach(System.Windows.Forms.ListViewItem selectdeItem in lvPhuPhi.SelectedItems)
                    {
                        lvPhuPhi.Items.Remove(selectdeItem);
                    }
                }
                else
                {
                    MessageBox.Show("Chưa chọn mục để xóa.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                TongTienPhuPhi();
                TinhTongTien();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbSoDienMoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)(8)))
                e.Handled = true;
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
