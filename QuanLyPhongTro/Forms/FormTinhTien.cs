using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Controls;
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
            
            tbGiaDien.Text = CaiDat._GiaDien.ToString("N2");
            tbGiaNuoc.Text = CaiDat._GiaNuoc.ToString("N");
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
            TongTienDien();
            TongTienNuoc();
            DanhSachPhuPhi();
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
                    tbTongTienDien.Text = tong.ToString("N2");
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
                    tbTongTienNuoc.Text = tong.ToString("N2");
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
                tbTongTienPhuPhi.Text = tongPhuPhi.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TinhTongTien()
        {
            try
            {
                if (double.TryParse(tbTongTienDien.Text, out double tDien) && double.TryParse(tbTongTienNuoc.Text, out double tNuoc) 
                    && double.TryParse(tbTongTienPhuPhi.Text,out double tPhuPhi) && double.TryParse(tbGiaPhong.Text,out double gPhong)){
                    double tongTien = tDien + tNuoc + tPhuPhi + gPhong;
                    tbTongTien.Text = tongTien.ToString("N2");
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
        private void DanhSachPhuPhi()
        {
            try
            {
                using (SQLiteCommand truyVan = new SQLiteCommand("SELECT * FROM PhuPhi WHERE Xoa = 0", CaiDat.CSDL))
                {
                    using (SQLiteDataReader reader = truyVan.ExecuteReader())
                    {
                        cmPhuPhi.Items.Clear();
                        while (reader.Read())
                        {
                            string tenPhuPhi = reader["TenPhuPhi"] as string;
                            if (!string.IsNullOrWhiteSpace(tenPhuPhi))
                            {
                                cmPhuPhi.Items.Add(tenPhuPhi);
                            }
                        }
                        if(cmPhuPhi.Items.Count > 0)
                        {
                            cmPhuPhi.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (cmPhuPhi.SelectedItem == null) 
                {
                    MessageBox.Show("Chưa Chọn Phụ Phí", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string TenPhuPhi = cmPhuPhi.SelectedItem.ToString();
                using (SQLiteCommand TruyVan = new SQLiteCommand("SELECT * FROM PhuPhi WHERE TenPhuPhi = @TenPhuPhi", CaiDat.CSDL))
                {
                    TruyVan.Parameters.AddWithValue("@TenPhuPhi", TenPhuPhi);
                    using (SQLiteDataReader reader = TruyVan.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string maPhuPhi = ((Int64)reader["MaPhuPhi"]).ToString();
                            string tenPhuPhi = (string)reader["TenPhuPhi"].ToString();
                            string giaPhuPhi = ((Int64)reader["GiaPhuPhi"]).ToString();
                            System.Windows.Forms.ListViewItem item = new System.Windows.Forms.ListViewItem(maPhuPhi);
                            item.SubItems.Add(tenPhuPhi);
                            item.SubItems.Add(giaPhuPhi);


                            bool itemExists = false;
                            foreach (System.Windows.Forms.ListViewItem existingItem in lvPhuPhi.Items)
                            {
                                if (existingItem.SubItems[0].Text == maPhuPhi) // Kiểm tra mã phụ phí
                                {
                                    itemExists = true;
                                    break;
                                }
                            }
                            if (!itemExists)
                            {
                                lvPhuPhi.Items.Add(item);
                            }
                            TongTienPhuPhi();
                            TinhTongTien();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
