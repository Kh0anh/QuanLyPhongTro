using System.Data.SQLite;
using System.Windows.Forms;
using System;
using MaterialSkin.Controls;
using QuanLyPhongTro.Forms.UserControlFormChinh;

namespace QuanLyPhongTro.Forms
{
    public partial class FormChinhSuaPhong : MaterialForm
    {
        private string maPhong;
        public FormChinhSuaPhong()
        {
            InitializeComponent();
        }

        public FormChinhSuaPhong(string maPhong)
        {
            InitializeComponent();
            LoadData(maPhong);
            this.maPhong = maPhong;
        }

        private void LoadData(string maPhong)
        {
            // Tải dữ liệu của phòng được chọn
            try
            {
                string query = "SELECT MaPhong, TenPhong, GiaPhong, PhuPhi, NguoiThue, NgayThue, SoDienCu, SoNuocCu, GhiChu FROM Phong WHERE MaPhong = @maPhong AND Xoa == 0";

                // Kiểm tra xem CSDL đã được mở chưa, nếu chưa thì mở
                if (CaiDat.CSDL.State != System.Data.ConnectionState.Open)
                {
                    CaiDat.CSDL.Open();
                }

                using (SQLiteCommand cmd = new SQLiteCommand(query, CaiDat.CSDL))
                {
                    cmd.Parameters.AddWithValue("@maPhong", maPhong);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Gắn dữ liệu vào các điều khiển
                            tbTenPhong.Text = reader["TenPhong"].ToString();
                            tbGiaPhong.Text = reader["GiaPhong"].ToString();
                            tbNguoiThue.Text = reader["NguoiThue"].ToString();
                            dtpNgayThue.Value = DateTime.Parse(reader["NgayThue"].ToString());
                            tbSoDienCu.Text = reader["SoDienCu"].ToString();
                            tbSoNuocCu.Text = reader["SoNuocCu"].ToString();
                            tbGhiChu.Text = reader["GhiChu"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }






        private void HienThiDanhSachPhuPhi()
        {
           lsvPhuPhi.Items.Clear();
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
                            lsvPhuPhi.Items.Add(item);
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
                    MessageBox.Show(err.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); // Xử lý lỗi
                }
            }



            private void btnXoaChinhSua_Click(object sender, EventArgs e)
            {
                Close();
            }

            

            private void FormChinhSuaPhong_Load(object sender, EventArgs e)
            {

                if (this.DesignMode)
                {
                    return;
                }
                

            }

        private void btnLuuChinhSua_Click(object sender, EventArgs e)
        {
            if (tbTenPhong.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng điền tên phòng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbGiaPhong.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng điền giá phòng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbNguoiThue.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng điền tên người thuê!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbSoDienCu.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng điền số điện cũ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbSoNuocCu.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng điền số nước cũ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = "UPDATE Phong SET TenPhong = @ten, GiaPhong = @gia, NguoiThue = @nguoithue, NgayThue = @ngaythue, SoDienCu = @dien, SoNuocCu = @nuoc, GhiChu = @ghichu WHERE MaPhong = @maPhong";
                using (SQLiteCommand cmd = new SQLiteCommand(query, CaiDat.CSDL))
                {
                    cmd.Parameters.AddWithValue("@ten", tbTenPhong.Text);
                    cmd.Parameters.AddWithValue("@gia", tbGiaPhong.Text);
                    cmd.Parameters.AddWithValue("@nguoithue", tbNguoiThue.Text);
                    cmd.Parameters.AddWithValue("@ngaythue", dtpNgayThue.Value);
                    cmd.Parameters.AddWithValue("@dien", tbSoDienCu.Text);
                    cmd.Parameters.AddWithValue("@nuoc", tbSoNuocCu.Text);
                    cmd.Parameters.AddWithValue("@ghichu", tbGhiChu.Text);
                    cmd.Parameters.AddWithValue("@maPhong", maPhong); 

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Chỉnh sửa thông tin phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form sau khi lưu
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
