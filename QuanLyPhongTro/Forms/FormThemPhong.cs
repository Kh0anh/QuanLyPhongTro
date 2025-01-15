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
                //Kiểm tra xem có đang chọn phụ phí nào trong ComboBox không?
                if (cbPhuPhi.SelectedItem == null )
                {
                    MaterialMessageBox.Show("Vui lòng chọn phụ phí cần thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                string phuPhi = cbPhuPhi.SelectedItem.ToString();

                //Truy vấn để thêm phụ phí
                string query = "INSERT INTO Phong VALUES(@PhuPhi)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, CaiDat.CSDL))
                {
                    cmd.Parameters.AddWithValue("@tenPhuPhi", phuPhi);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception err)
            {
                MaterialMessageBox.Show(err.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, System.EventArgs e)
        {
            try
            {
                //Kiểm tra xem có đang chọn phụ phí nào trong Listview không?
                if (lstPhuPhi.SelectedItems == null)
                {
                    MaterialMessageBox.Show("Vui lòng chọn phụ phí cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Lấy phụ phí được chọn chuyển sang chuỗi để thêm vào csdl
                string phuPhi = lstPhuPhi.SelectedItems.ToString();

                //Truy vấn xóa phụ phí được chọn
                string query = "DELETE FROM Phong WHERE PhuPhi == @phuPhi";
                using (SQLiteCommand cmd = new SQLiteCommand(query, CaiDat.CSDL))
                {
                    cmd.Parameters.AddWithValue(@phuPhi, phuPhi);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception err)
            {
                MaterialMessageBox.Show(err.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, System.EventArgs e)
        {
            Close(); //Đóng form
        }

        private void btnThemPhong_Click(object sender, System.EventArgs e)
        {
            //Kiểm tra xem 
            if (string.IsNullOrEmpty(txtTenPhong.Text) || string.IsNullOrEmpty(txtGiaPhong.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            try 
            {
                string truyVan = "INSERT INTO Phong (TenPhong, GiaPhong, SoDienCu, SoNuocCu, GhiChu)" + "VALUES (@ten, @gia, @dien, @nuoc, @ghichu)";
                using (SQLiteCommand cmd = new SQLiteCommand(truyVan, CaiDat.CSDL))
                {
                    cmd.Parameters.AddWithValue("@ten", txtTenPhong.Text);
                    cmd.Parameters.AddWithValue("@gia", Int32.Parse(txtGiaPhong.Text));
                    cmd.Parameters.AddWithValue("@dien", Int32.Parse(txtSoDienCu.Text));
                    cmd.Parameters.AddWithValue("@nuoc", Int32.Parse(txtSoNuocCu.Text));
                    cmd.Parameters.AddWithValue("@ghichu", txtGhiChu.Text);
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

        private void LayDanhSachPhuPhi()
        {
            try
            {  
                // Truy vấn lấy danh sách tên phụ phí từ bảng PhuPhi
                string truyVan = "SELECT TenPhuPhi FROM PhuPhi"; 
                using (SQLiteCommand cmd = new SQLiteCommand(truyVan, CaiDat.CSDL))
                {
                    // Đọc dữ liệu trả về
                    using (SQLiteDataReader doc = cmd.ExecuteReader()) 
                    {
                        // Xóa danh sách phụ phí cũ trước khi thêm mới vào ComboBox
                        cbPhuPhi.Items.Clear();

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
