using System.Data.SQLite;
using System.Windows.Forms;
using System;
using MaterialSkin.Controls;

namespace QuanLyPhongTro.Forms
{
    public partial class FormChinhSuaTrangThai : MaterialForm
    {
        private string TrangThai; // Lưu mã phòng được truyền vào

        public FormChinhSuaTrangThai(string TrangThai)
        {
            InitializeComponent();
            this.TrangThai = TrangThai;
            LoadTrangThai();          
        }
        private void KiemTraTrangThai(int TrangThai)
        {
            // Nếu phòng trống (0), vô hiệu hóa "Người thuê"
            if (TrangThai == 0)
            {
                tbNguoiThue.Enabled = false;
            }
            else // Nếu đã được thuê (1), kích hoạt "Người thuê"
            {
                tbNguoiThue.Enabled = true;
            }
        }
        private void LoadTrangThai()
        {
            try
            {
                // Truy vấn lấy trạng thái hiện tại của phòng
                string query = "SELECT TrangThai, NguoiThue FROM Phong WHERE MaPhong = @maPhong";
                using (SQLiteCommand cmd = new SQLiteCommand(query, CaiDat.CSDL))
                {
                    cmd.Parameters.AddWithValue("@maPhong", TrangThai);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Thiết lập trạng thái và trường Người thuê
                            int trangThai = Convert.ToInt32(reader["TrangThai"]);
                            cbTrangThai.SelectedItem = trangThai == 0 ? "Phòng trống" : "Được thuê";
                            tbNguoiThue.Text = reader["NguoiThue"].ToString();
                            tbNguoiThue.Enabled = trangThai == 1; // Bật/tắt ô Người thuê
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTrangThai.SelectedItem.ToString() == "Phòng trống")
            {
                tbNguoiThue.Enabled = false; // Vô hiệu hóa trường Người thuê
                tbNguoiThue.Clear();         // Xóa dữ liệu trong trường Người thuê
            }
            else if (cbTrangThai.SelectedItem.ToString() == "Được thuê")
            {
                tbNguoiThue.Enabled = true;  // Kích hoạt trường Người thuê
            }
        }

        private void btnHuyChinhSua_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btnLuuChinhSua_Click(object sender, System.EventArgs e)
        {
            if (tbNguoiThue.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng điền tên người thuê!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Truy vấn cập nhật chỉ người thuê và trạng thái
                string query = "UPDATE Phong SET NguoiThue = @nguoithue, TrangThai = @trangthai WHERE MaPhong = @maPhong";

                using (SQLiteCommand cmd = new SQLiteCommand(query, CaiDat.CSDL))
                {
                    // Thêm các tham số vào câu lệnh SQL
                    cmd.Parameters.AddWithValue("@nguoithue", tbNguoiThue.Text);
                    cmd.Parameters.AddWithValue("@trangthai", cbTrangThai.Text);
                    cmd.Parameters.AddWithValue("@maPhong", TrangThai); // Đảm bảo rằng bạn có maPhong trong context

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thông tin phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormChinhSuaTrangThai_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }
        }
    }

        
}

