using MaterialSkin.Controls;
using QuanLyPhongTro.Forms.UserControlFormChinh;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace QuanLyPhongTro.Forms
{
    public partial class FormThemPhong : MaterialForm
    {
        private readonly UserControlQuanLyPhong _userControlQuanLyPhong;
        public FormThemPhong(UserControlQuanLyPhong userControl)
        {
            InitializeComponent();
            _userControlQuanLyPhong = userControl;
        }

        private void FormThemPhong_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }

            this.Text = string.Format("{0} - {1}", CaiDat.TenPhanMem, "Thêm Phòng");

            LayDanhSachPhuPhi();
        }


        //Thêm phòng
        private void btnThemPhong_Click(object sender, System.EventArgs e)
        {
            //Kiểm tra xem 
            if (string.IsNullOrEmpty(txtTenPhong.Text) || string.IsNullOrEmpty(txtGiaPhong.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            SQLiteTransaction transaction = null;
            try
            {
                transaction = CaiDat.CSDL.BeginTransaction();
                //Biến để lưu mã phòng vừa thêm
                long idPhong = -1;
                string truyVan = @"INSERT INTO Phong (TenPhong, GiaPhong, PhuPhi, TrangThai, NguoiThue, NgayThue, SoDienCu, SoNuocCu, GhiChu, Xoa)
                                    VALUES (@ten, @gia, @phuPhi, @trangThai, 0, @ngayThue, @dien, @nuoc, @ghichu, 0);
                                    SELECT last_insert_rowid();";
                using (SQLiteCommand lenh = new SQLiteCommand(truyVan, CaiDat.CSDL))
                {
                    lenh.Parameters.AddWithValue("@ten", txtTenPhong.Text);
                    lenh.Parameters.AddWithValue("@gia", Int32.Parse(txtGiaPhong.Text));
                    lenh.Parameters.AddWithValue("@phuPhi", lstPhuPhi.Items.Count);
                    lenh.Parameters.AddWithValue("@trangThai", 0);
                    lenh.Parameters.AddWithValue("@ngayThue", DateTime.Now.ToString("dd-MM-yyyy"));
                    lenh.Parameters.AddWithValue("@dien", Int32.Parse(txtSoDienCu.Text));
                    lenh.Parameters.AddWithValue("@nuoc", Int32.Parse(txtSoNuocCu.Text));
                    lenh.Parameters.AddWithValue("@ghichu", txtGhiChu.Text);


                    //Lấy id của phòng vừa mới tạo
                    idPhong = (long)lenh.ExecuteScalar();

                    foreach (ListViewItem item in lstPhuPhi.Items)
                    {
                        string maPhuPhi = item.SubItems[0].Text;

                        string truyVanPhongVaPhuPhi = @"INSERT INTO PhongVaPhuPhi (MaPhong, MaPhuPhi)
                                                        VALUES (@maPhong, @maPhuPhi)";
                        using (SQLiteCommand lenhThemQuanHe = new SQLiteCommand(truyVanPhongVaPhuPhi, CaiDat.CSDL))
                        {
                            lenhThemQuanHe.Parameters.AddWithValue("@maPhong", idPhong);
                            lenhThemQuanHe.Parameters.AddWithValue("@maPhuPhi", maPhuPhi);
                            lenhThemQuanHe.ExecuteNonQuery();
                        }
                    }
                }

                transaction.Commit();

                //Load lại danh sách phòng
                _userControlQuanLyPhong.CapNhatDanhSachPhong();

                //Focus vào phòng vừa thêm cho dễ quan sát
                foreach (ListViewItem item in _userControlQuanLyPhong.lvQuanLyPhong.Items)
                {
                    if (long.Parse(item.Text) == idPhong)
                    {
                        item.Selected = true;
                        item.EnsureVisible();
                        break;
                    }
                }

                ClearForm();

            }
            catch (Exception err)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                MaterialMessageBox.Show(err.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtTenPhong.Clear();
            txtGiaPhong.Clear();
            txtSoDienCu.Clear();
            txtSoNuocCu.Clear();
            txtGhiChu.Clear();
            cbPhuPhi.SelectedItem = null;
            lstPhuPhi.Items.Clear();
        }

        //Hủy thêm phòng
        private void btnHuy_Click(object sender, System.EventArgs e)
        {
            Close(); //Đóng form
        }


        //Thêm phụ phí
        private void btnThemPhuPhi_Click(object sender, System.EventArgs e)
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
                            ListViewItem item = new ListViewItem(((Int64)doc["MaPhuPhi"]).ToString());
                            item.SubItems.Add((string)doc["TenPhuPhi"]);
                            item.SubItems.Add(((Int64)doc["GiaPhuPhi"]).ToString());
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


        //Xóa phụ phí đã chọn trong litsview
        private void btnXoa_Click(object sender, System.EventArgs e)
        {
            try
            {
                //Kiểm tra xem có đang chọn phụ phí nào trong Listview không?
                if (lstPhuPhi.SelectedItems.Count == 0)
                {
                    MaterialMessageBox.Show("Vui lòng chọn phụ phí cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (ListViewItem item in lstPhuPhi.SelectedItems)
                {
                    lstPhuPhi.Items.Remove(item);
                }


            }
            catch (Exception err)
            {
                MaterialMessageBox.Show(err.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
