using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro.Forms.UserControlFormChinh
{
    public partial class UserControlQuanLyPhong : UserControl
    {
        public UserControlQuanLyPhong()
        {
            InitializeComponent();
            LoadDanhSachPhong();
        }

        private void UserControlQuanLyPhong_Load(object sender, EventArgs e)
        {
            //Kiểm tra xem Form có đang trong chế độ thiết kế không nếu có thì không load tránh lỗi
            if (this.DesignMode)
            {
                return;
            }

            CapNhatDanhSachPhong();
        }

        //Cập nhật danh sách phòng từ cơ sở dữ liệu lên listView
        public void CapNhatDanhSachPhong()
        {
            //Xoá danh sách phòng cũ trước khi cập nhật
            lvQuanLyPhong.Items.Clear();

            //Tải danh sách phòng từ cơ sở dữ liệu
            using (SQLiteCommand truyVan = new SQLiteCommand("SELECT MaPhong, TenPhong, GiaPhong, PhuPhi, TrangThai, NguoiThue, NgayThue, SoDienCu, SoNuocCu, GhiChu FROM Phong WHERE Xoa==0", CaiDat.CSDL))
            using (SQLiteDataReader doc = truyVan.ExecuteReader())
            {
                while (doc.Read())
                {
                    //Thêm dữ liệu vào lvPhongTro
                    ListViewItem item = new ListViewItem(((Int64)doc["MaPhong"]).ToString());
                    item.SubItems.Add((string)doc["TenPhong"]);
                    item.SubItems.Add(((Int64)doc["GiaPhong"]).ToString("N0"));

                    if ((Int64)doc["PhuPhi"] > 0)
                    {
                        item.SubItems.Add(layDanhSachPhuPhi((Int64)doc["MaPhong"]));
                    }
                    else
                    {
                        item.SubItems.Add("");
                    }

                    if ((Int64)doc["TrangThai"] == 0)
                    {
                        item.SubItems.Add("Phòng trống");
                        item.SubItems.Add("");
                        item.SubItems.Add("");
                    }
                    else
                    {
                        item.SubItems.Add("Được thuê");
                        item.SubItems.Add((string)doc["NguoiThue"]);
                        item.SubItems.Add((string)doc["NgayThue"]);
                    }

                    item.SubItems.Add(((Int64)doc["SoDienCu"]).ToString());
                    item.SubItems.Add(((Int64)doc["SoNuocCu"]).ToString());
                    item.SubItems.Add((string)doc["GhiChu"]);
                    this.lvQuanLyPhong.Items.Add(item);
                }
            }
        }

        private string layDanhSachPhuPhi(Int64 maPhong)
        {
            string strPhuPhi = "";
            using (SQLiteCommand truyVan = new SQLiteCommand("SELECT pp.TenPhuPhi FROM PhongVaPhuPhi pvp INNER JOIN PhuPhi pp ON pvp.MaPhuPhi=pp.MaPhuPhi WHERE pvp.MaPhong==@maPhong", CaiDat.CSDL))
            {
                truyVan.Parameters.AddWithValue("@maPhong", maPhong);
                using (SQLiteDataReader doc = truyVan.ExecuteReader())
                {
                    while (doc.Read())
                    {
                        strPhuPhi += string.Format("{0}, ", doc.GetString(0));
                    }
                }
            }

            if (strPhuPhi.Length > 0) {
                return strPhuPhi.Substring(0, strPhuPhi.Length - 2);
            }

            return strPhuPhi;
        }
        private void toolThemPhong_Click(object sender, EventArgs e)
        {
            new FormThemPhong(this).Show();
        }

        private void toolSuaPhong_Click(object sender, EventArgs e)
        {
        
            if (lvQuanLyPhong.SelectedItems.Count > 0)
            {
                string maPhong = lvQuanLyPhong.SelectedItems[0].Text;

                // Mở form chỉnh sửa và truyền mã phòng
                FormChinhSuaPhong formChinhSua = new FormChinhSuaPhong(maPhong);
                formChinhSua.ShowDialog();

                // Cập nhật lại danh sách phòng sau khi chỉnh sửa
                CapNhatDanhSachPhong();
            }
        }

        private void toolTinhTien_Click(object sender, EventArgs e)
        {
            if (lvQuanLyPhong.SelectedItems.Count > 0)
            {
                var SelectedItem = lvQuanLyPhong.SelectedItems[0];
                string maPhong = SelectedItem.SubItems[0].Text;
                string tenPhong = SelectedItem.SubItems[1].Text;
                string giaPhong = SelectedItem.SubItems[2].Text;
                string phuPhi = SelectedItem.SubItems[3].Text;
                string trangThai = SelectedItem.SubItems[4].Text;
                string nguoiThue =  SelectedItem.SubItems[5].Text;
                string ngayThue = SelectedItem.SubItems[6].Text;
                string soDienCu = SelectedItem.SubItems[7].Text;
                string soNuocCu = SelectedItem.SubItems[8].Text;
                string ghiChu = SelectedItem.SubItems[9].Text;

                FormTinhTien formTinhTien = new FormTinhTien(maPhong,tenPhong,giaPhong,phuPhi,trangThai,nguoiThue,ngayThue,soDienCu,soNuocCu,ghiChu);
                formTinhTien.ShowDialog();
            }
        }

        private void toolXoa_Click(object sender, EventArgs e)
        {
            //Lấy danh sách phòng cần xoá mà người dùng đang chọn
            ListViewItem[] danhSachPhong = layDanhSachPhong();

            //Nếu người dùng đang không chọn phòng nào thì return
            if (danhSachPhong.Length < 1)
            {
                return;
            }

            //Tạo luồng mới để tránh form chính bị đơ khi thực hiện tác vụ
            Task.Run(() =>
            {
                foreach (ListViewItem phong in danhSachPhong)
                {
                    //Xoá dữ liệu khỏi listview phòng
                    //Phải sử dụng Invoke vì đang ở luồng khác
                    Invoke((MethodInvoker)(() =>
                    {
                        lvQuanLyPhong.Items.Remove(phong);
                    }));
                }
                foreach (ListViewItem phong in danhSachPhong)
                {
                    //Xoá phòng khỏi cơ sở dữ liệu bằng cách chuyển cột Xoa sang 1
                    using (SQLiteCommand truyVan = new SQLiteCommand("UPDATE Phong SET Xoa = 1 WHERE MaPhong = @maPhong", CaiDat.CSDL))
                    {
                        truyVan.Parameters.AddWithValue("@maPhong", phong.Text);
                        truyVan.ExecuteNonQuery();
                    }
                }
            });
        }

        private void toolChinhTrangThai_Click(object sender, EventArgs e)
        {
            if (lvQuanLyPhong.SelectedItems.Count > 0)
            {
                string TrangThai = lvQuanLyPhong.SelectedItems[0].Text;

                // Mở form chỉnh sửa và truyền mã phòng
                FormChinhSuaTrangThai formChinhSua = new FormChinhSuaTrangThai(TrangThai);
                formChinhSua.ShowDialog();

                // Cập nhật lại danh sách phòng sau khi chỉnh sửa
                CapNhatDanhSachPhong();
            }
        }
        private ListViewItem[] layDanhSachPhong()
        {
            List<ListViewItem> danhSachphong = new List<ListViewItem>();
            foreach (ListViewItem phong in lvQuanLyPhong.SelectedItems)
            {
                danhSachphong.Add(phong);
            }
            return danhSachphong.ToArray();
        }

        private void LoadDanhSachPhong()
        {
            // Tải danh sách phòng vào ListView
            lvQuanLyPhong.Items.Clear();
            try
            {
                string query = "SELECT MaPhong, TenPhong FROM Phong WHERE Xoa == 0";
                using (SQLiteCommand cmd = new SQLiteCommand(query, CaiDat.CSDL))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["MaPhong"].ToString());
                        item.SubItems.Add(reader["TenPhong"].ToString());
                        lvQuanLyPhong.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
