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

        private void FormThemPhong_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }
            HienThiDanhSachPhuPhi();
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

                string truyVan = @"INSERT INTO Phong (TenPhong, GiaPhong, PhuPhi, TrangThai, NguoiThue, NgayThue, SoDienCu, SoNuocCu, GhiChu, Xoa)
                                    VALUES (@ten, @gia, @phuPhi, @trangThai, 0, @ngayThue, @dien, @nuoc, @ghichu, 0);
                                    SELECT last_insert_rowid();";
                using (SQLiteCommand lenh = new SQLiteCommand(truyVan, CaiDat.CSDL))
                {
                    lenh.Parameters.AddWithValue("@ten", txtTenPhong.Text);
                    lenh.Parameters.AddWithValue("@gia", Int32.Parse(txtGiaPhong.Text));
                    lenh.Parameters.AddWithValue("@phuPhi", 0);
                    lenh.Parameters.AddWithValue("@trangThai", 1);
                    lenh.Parameters.AddWithValue("@ngayThue", DateTime.Now.ToString("dd-MM-yyyy"));
                    lenh.Parameters.AddWithValue("@dien", Int32.Parse(txtSoDienCu.Text));
                    lenh.Parameters.AddWithValue("@nuoc", Int32.Parse(txtSoNuocCu.Text));
                    lenh.Parameters.AddWithValue("@ghichu", txtGhiChu.Text);


                    //Lấy id của phòng vừa mới tạo
                    var idPhong = (long)lenh.ExecuteScalar();

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
                if (cbPhuPhi.SelectedItem == null )
                {
                    MaterialMessageBox.Show("Vui lòng chọn phụ phí cần thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                string phuPhi = cbPhuPhi.SelectedItem.ToString();

                //Truy vấn lấy phụ phí từ CSDL để thêm vào listview
                string truyVan = "SELECT MaPhuPhi, GiaPhuPhi FROM PhuPhi WHERE TenPhuPhi = @phuPhi";
                using (SQLiteCommand lenh = new SQLiteCommand(truyVan, CaiDat.CSDL))
                {
                    lenh.Parameters.AddWithValue("@phuPhi", phuPhi);
                    using (SQLiteDataReader doc = lenh.ExecuteReader())
                    {
                        while (doc.Read())
                        {
                            string maPhuPhi = doc["MaPhuPhi"].ToString();

                            // Thêm phụ phí vào ListView
                            ListViewItem item = new ListViewItem(maPhuPhi);
                            item.SubItems.Add(phuPhi);
                            item.SubItems.Add(((int)doc["GiaPhuPhi"]).ToString());
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

                string phuPhi = lstPhuPhi.SelectedItems[0].SubItems[1].Text;

                //Truy vấn xóa phụ phí được chọn
                string truyVan = "SELECT MaPhuPhi FROM PhuPhi WHERE TenPhuPhi = @phuPhi";
                using (SQLiteCommand lenh = new SQLiteCommand(truyVan, CaiDat.CSDL))
                {
                    lenh.Parameters.AddWithValue(@phuPhi, phuPhi);
                    var maPhuPhi = lenh.ExecuteScalar();

                    if (maPhuPhi != null)
                    {
                        // Xóa liên kết trong bảng PhongVaPhuPhi
                        string truyVanXoa = "DELETE FROM PhongVaPhuPhi WHERE MaPhuPhi = @maPhuPhi";
                        using (SQLiteCommand cmdDelete = new SQLiteCommand(truyVanXoa, CaiDat.CSDL))
                        {
                            cmdDelete.Parameters.AddWithValue("@maPhuPhi", maPhuPhi);
                            cmdDelete.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MaterialMessageBox.Show(err.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Hiển thị danh sách phụ phí lên listview
        private void HienThiDanhSachPhuPhi()
        {
            //Xóa danh sách listview cũ trước khi hiển thị cái mới
            lstPhuPhi.Items.Clear();
            try
            {
                //Truy vấn lấy các thuộc tính từ bảng Phụ Phí
                string truyVan = "SELECT MaPhuPhi, TenPhuPhi, GiaPhuPhi FROM PhuPhi WHERE Xoa == 0";
                using (SQLiteCommand cmd = new SQLiteCommand(truyVan, CaiDat.CSDL))
                {
                    using (SQLiteDataReader doc = cmd.ExecuteReader())
                    {
                        while (doc.Read())
                        {   
                            //Thêm các item vào trong litsview
                            ListViewItem item = new ListViewItem(doc["MaPhuPhi"].ToString());
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


        //Đưa dữ liệu các phụ phí vào trong combobox
        private void LayDanhSachPhuPhi()
        {
            // Xóa danh sách phụ phí cũ trước khi thêm mới vào ComboBox
            cbPhuPhi.Items.Clear();
            try
            {  
                // Truy vấn lấy danh sách tên phụ phí từ bảng PhuPhi
                string truyVan = "SELECT TenPhuPhi FROM PhuPhi"; 
                using (SQLiteCommand cmd = new SQLiteCommand(truyVan, CaiDat.CSDL))
                {
                    // Đọc dữ liệu trả về
                    using (SQLiteDataReader doc = cmd.ExecuteReader()) 
                    {
                        // Duyệt qua các dòng dữ liệu và thêm vào ComboBox
                        while (doc.Read())
                        {
                            // Lấy tên phụ phí từ mỗi dòng
                            string tenPhuPhi = doc["TenPhuPhi"].ToString();
                            // Thêm vào ComboBox
                            cbPhuPhi.Items.Add(tenPhuPhi); 
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MaterialMessageBox.Show(err.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
