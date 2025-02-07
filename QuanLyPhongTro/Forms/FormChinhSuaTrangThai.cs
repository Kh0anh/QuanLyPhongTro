using MaterialSkin.Controls;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace QuanLyPhongTro.Forms
{
    public partial class FormChinhSuaTrangThai : MaterialForm
    {
        private string maPhong;
        private int trangThai;
        public FormChinhSuaTrangThai(string _maPhong)
        {
            InitializeComponent();

            maPhong = _maPhong;

            LoadTrangThai();
        }
        private void LoadTrangThai()
        {
            try
            {
                // Truy vấn lấy trạng thái hiện tại của phòng
                string query = "SELECT TrangThai, NguoiThue FROM Phong WHERE MaPhong = @maPhong";
                using (SQLiteCommand cmd = new SQLiteCommand(query, CaiDat.CSDL))
                {
                    cmd.Parameters.AddWithValue("@maPhong", maPhong);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Thiết lập trạng thái và trường Người thuê
                            int trangThai = Convert.ToInt32(reader["TrangThai"]);
                            cbTrangThai.SelectedItem = trangThai == 0 ? "Phòng trống" : "Đang được thuê";
                            if (trangThai == 0)
                            {
                                tbNguoiThue.Text = "Phòng trống";
                            }
                            else
                            {
                                tbNguoiThue.Text = reader["NguoiThue"].ToString();
                            }
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
                tbNguoiThue.Text = "Phòng trống";
                trangThai = 0;
            }
            else if (cbTrangThai.SelectedItem.ToString() == "Đang được thuê")
            {
                tbNguoiThue.Clear();
                tbNguoiThue.Enabled = true;  // Kích hoạt trường Người thuê
                trangThai = 1;
            }
        }

        private void btnHuyChinhSua_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btnLuuChinhSua_Click(object sender, System.EventArgs e)
        {
            if (tbNguoiThue.Text == string.Empty && trangThai == 1)
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
                    if (trangThai == 0)
                    {
                        cmd.Parameters.AddWithValue("@nguoithue", "");
                        cmd.Parameters.AddWithValue("@trangthai", 0);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@nguoithue", tbNguoiThue.Text);
                        cmd.Parameters.AddWithValue("@trangthai", 1);
                    }

                    cmd.Parameters.AddWithValue("@maPhong", maPhong); // Đảm bảo rằng bạn có maPhong trong context

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

            this.Text = string.Format("{0} - {1}", CaiDat.TenPhanMem, "Chỉnh Trạng Thái");
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

