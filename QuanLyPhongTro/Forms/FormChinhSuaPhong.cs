using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.Windows.Forms;

namespace QuanLyPhongTro.Forms
{
    public partial class FormChinhSuaPhong : MaterialForm
    {
        private string maPhong;
        private int trangThai;
        public FormChinhSuaPhong(string maPhong)
        {
            InitializeComponent();
            LoadData(maPhong);
            this.maPhong = maPhong;

            LayDanhSachPhuPhi();
            HienThiDanhSachPhuPhi();
        }

        private void LoadData(string maPhong)
        {
            // Tải dữ liệu của phòng được chọn
            try
            {
                string query = "SELECT MaPhong, TenPhong, GiaPhong, PhuPhi, NguoiThue, NgayThue, TrangThai, SoDienCu, SoNuocCu, GhiChu FROM Phong WHERE MaPhong = @maPhong AND Xoa == 0";

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

                            if ((Int64)reader["TrangThai"] == 1)
                            {
                                tbTrangThai.Text = "Đang được thuê";
                                dtpNgayThue.Value = DateTime.ParseExact(reader["NgayThue"].ToString(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
                                tbNguoiThue.Text = reader["NguoiThue"].ToString();
                                trangThai = 1;
                            }
                            else
                            {
                                tbTrangThai.Text = "Phòng trống";
                                dtpNgayThue.Enabled = false;
                                tbNguoiThue.Text = "Phòng trống";
                                trangThai = 0;
                            }

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

        //Đưa dữ liệu các phụ phí vào trong combobox
        private void LayDanhSachPhuPhi()
        {
            // Xóa danh sách phụ phí cũ trước khi thêm mới vào ComboBox
            cbPhuPhi.Items.Clear();
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

                cbPhuPhi.DataSource = items;
                cbPhuPhi.DisplayMember = "Value";
                cbPhuPhi.ValueMember = "Key";
            }
            catch (Exception err)
            {
                MaterialMessageBox.Show(err.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HienThiDanhSachPhuPhi()
        {
            lsvPhuPhi.Items.Clear();
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
                            lsvPhuPhi.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (tbNguoiThue.Text == string.Empty && trangThai == 1)
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
                string query = "UPDATE Phong SET TenPhong = @ten, GiaPhong = @gia, NguoiThue = @nguoithue, NgayThue = @ngaythue, PhuPhi = @phuPhi, SoDienCu = @dien, SoNuocCu = @nuoc, GhiChu = @ghichu WHERE MaPhong = @maPhong";
                using (SQLiteCommand cmd = new SQLiteCommand(query, CaiDat.CSDL))
                {
                    cmd.Parameters.AddWithValue("@ten", tbTenPhong.Text);
                    cmd.Parameters.AddWithValue("@gia", tbGiaPhong.Text);
                    if (trangThai == 0)
                    {
                        cmd.Parameters.AddWithValue("@nguoithue", "");
                        tbNguoiThue.Enabled = false;
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@nguoithue", tbNguoiThue.Text);
                    }
                    cmd.Parameters.AddWithValue("@phuPhi", lsvPhuPhi.Items.Count);
                    cmd.Parameters.AddWithValue("@ngaythue", dtpNgayThue.Value.ToString("dd-MM-yyyy"));
                    cmd.Parameters.AddWithValue("@dien", tbSoDienCu.Text);
                    cmd.Parameters.AddWithValue("@nuoc", tbSoNuocCu.Text);
                    cmd.Parameters.AddWithValue("@ghichu", tbGhiChu.Text);
                    cmd.Parameters.AddWithValue("@maPhong", maPhong);

                    cmd.ExecuteNonQuery();

                    XoaVaThemPhuPhi();

                    MessageBox.Show("Chỉnh sửa thông tin phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close(); // Đóng form sau khi lưu
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XoaVaThemPhuPhi()
        {
            using (SQLiteCommand lenh = new SQLiteCommand("DELETE FROM PhongVaPhuPhi WHERE MaPhong = @maPhong;", CaiDat.CSDL))
            {
                lenh.Parameters.AddWithValue("@maPhong", maPhong);
                lenh.ExecuteNonQuery();
            }

            foreach (System.Windows.Forms.ListViewItem item in lsvPhuPhi.Items)
            {
                string maPhuPhi = item.SubItems[0].Text;

                string truyVanPhongVaPhuPhi = @"INSERT INTO PhongVaPhuPhi (MaPhong, MaPhuPhi)
                                                        VALUES (@maPhong, @maPhuPhi)";
                using (SQLiteCommand lenhThemQuanHe = new SQLiteCommand(truyVanPhongVaPhuPhi, CaiDat.CSDL))
                {
                    lenhThemQuanHe.Parameters.AddWithValue("@maPhong", maPhong);
                    lenhThemQuanHe.Parameters.AddWithValue("@maPhuPhi", maPhuPhi);
                    lenhThemQuanHe.ExecuteNonQuery();
                }
            }
        }

        private void FormChinhSuaPhong_Load_1(object sender, EventArgs e)
        {
            this.Text = string.Format("{0} - {1}", CaiDat.TenPhanMem, "Chỉnh Sửa Phòng");
        }

        private void btThemPhuPhi_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra xem có đang chọn phụ phí nào trong ComboBox không?
                if (cbPhuPhi.SelectedItem == null)
                {
                    MaterialMessageBox.Show("Vui lòng chọn phụ phí cần thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string truyVan = "SELECT MaPhuPhi, TenPhuPhi, GiaPhuPhi FROM PhuPhi WHERE MaPhuPhi = @maPhuphi";
                using (SQLiteCommand lenh = new SQLiteCommand(truyVan, CaiDat.CSDL))
                {
                    lenh.Parameters.AddWithValue("@maPhuphi", cbPhuPhi.SelectedValue);
                    using (SQLiteDataReader doc = lenh.ExecuteReader())
                    {
                        while (doc.Read())
                        {
                            System.Windows.Forms.ListViewItem item = new System.Windows.Forms.ListViewItem(((Int64)doc["MaPhuPhi"]).ToString());
                            item.SubItems.Add((string)doc["TenPhuPhi"]);
                            item.SubItems.Add(((Int64)doc["GiaPhuPhi"]).ToString());

                            Invoke((MethodInvoker)(() =>
                            {
                                lsvPhuPhi.Items.Add(item);
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
                //Kiểm tra xem có đang chọn phụ phí nào trong Listview không?
                if (lsvPhuPhi.SelectedItems.Count == 0)
                {
                    MaterialMessageBox.Show("Vui lòng chọn phụ phí cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (System.Windows.Forms.ListViewItem item in lsvPhuPhi.SelectedItems)
                {
                    Invoke((MethodInvoker)(() =>
                    {
                        lsvPhuPhi.Items.Remove(item);
                    }));
                }


            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
