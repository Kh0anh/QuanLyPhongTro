using System;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace QuanLyPhongTro.Forms
{
    public partial class FormThemPhong : MaterialForm
    {
        public FormThemPhong()
        {
            InitializeComponent();
        }

        private void btnThemPhuPhi_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (cbPhuPhi.SelectedItem == null )
                {
                    MaterialMessageBox.Show("Vui lòng chọn phụ phí cần thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string phuPhi = cbPhuPhi.SelectedItem.ToString();

                string query = "INSERT INTO Phong VALUES(@PhuPhi)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, CaiDat.CSDL))
                {
                    cmd.Parameters.AddWithValue("@tenPhuPhi", phuPhi);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (cbPhuPhi.SelectedItem == null)
                {
                    MaterialMessageBox.Show("Vui lòng chọn phụ phí cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string phuPhi = cbPhuPhi.SelectedItem.ToString();

                string query = "DELETE FROM Phong WHERE PhuPhi == @phuPhi";
                using (SQLiteCommand cmd = new SQLiteCommand(query, CaiDat.CSDL))
                {
                    cmd.Parameters.AddWithValue(@phuPhi, phuPhi);
                    cmd.ExecuteNonQuery();
                }
            }
            catch ( Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btnThemPhong_Click(object sender, System.EventArgs e)
        {
            try 
            {
                string query = "INSERT INTO Phong (TenPhong, GiaPhong, SoDienCu, SoNuocCu, GhiChu)" + "VALUES (@ten, @gia, @dien, @nuoc, @ghichu)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, CaiDat.CSDL))
                {
                    cmd.Parameters.AddWithValue("@ten", txtTenPhong);
                    cmd.Parameters.AddWithValue("@gia", txtGiaPhong);
                    cmd.Parameters.AddWithValue("@dien", txtSoDienCu);
                    cmd.Parameters.AddWithValue("@nuoc", txtSoNuocCu);
                    cmd.Parameters.AddWithValue("@ghichu", txtGhiChu);
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception err) 
            {
                MaterialMessageBox.Show(err.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HienThiDanhSachPhuPhi()
        {
            lstPhuPhi.Items.Clear();
            try
            {
                string query = "SELECT MaPhuPhi, TenPhuPhi, GiaPhuPhi FROM PhuPhi WHERE Xoa == 0";
                using (SQLiteCommand cmd = new SQLiteCommand(query, CaiDat.CSDL))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["MaPhuPhi"].ToString());
                            item.SubItems.Add((string)reader["TenPhuPhi"]);
                            item.SubItems.Add(((Int64)reader["GiaPhuPhi"]).ToString());
                            lstPhuPhi.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MaterialMessageBox.Show(err.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LayDanhSachPhuPhi()
        {
            cbPhuPhi.Items.Clear();
            try
            {
                string query = "SELECT TenPhuPhi FROM PhuPhi"; // Truy vấn lấy danh sách tên phụ phí từ bảng PhuPhi
                using (SQLiteCommand cmd = new SQLiteCommand(query, CaiDat.CSDL)) // CSDL là đối tượng kết nối với SQLite
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader()) // Đọc dữ liệu trả về
                    {
                        // Xóa tất cả các mục hiện tại trong ComboBox (nếu có)
                        cbPhuPhi.Items.Clear();

                        // Duyệt qua các dòng dữ liệu và thêm vào ComboBox
                        while (reader.Read())
                        {
                            string tenPhuPhi = reader["TenPhuPhi"].ToString(); // Lấy tên phụ phí từ mỗi dòng
                            cbPhuPhi.Items.Add(tenPhuPhi); // Thêm vào ComboBox
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Lỗi: {err.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); // Xử lý lỗi
            }
        }


        private void FormThemPhong_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }
            HienThiDanhSachPhuPhi();
            LayDanhSachPhuPhi();
        }
    }
}
