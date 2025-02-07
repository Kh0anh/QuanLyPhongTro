using System;
using System.Windows.Forms;

namespace QuanLyPhongTro.Forms.UserControlFormChinh
{
    public partial class UserControlCaiDat : UserControl
    {
        public UserControlCaiDat()
        {
            InitializeComponent();
        }

        private void UserControlCaiDat_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }

            try
            {
                // Lấy giá trị từ cơ sở dữ liệu và hiển thị vào TextBox
                tbGiaDien.Text = CaiDat.GiaDien.ToString();
                tbGiaNuoc.Text = CaiDat.GiaNuoc.ToString();

                CapNhatDanhSachPhuPhi();
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                MessageBox.Show("Không thể tải giá điện và giá nước: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btCapNhatGiaDienNuoc_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ TextBox
                if (!int.TryParse(tbGiaDien.Text, out int giaDienMoi))
                {
                    MessageBox.Show("Giá điện phải là số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(tbGiaNuoc.Text, out int giaNuocMoi))
                {
                    MessageBox.Show("Giá nước phải là số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cập nhật giá trị vào cơ sở dữ liệu
                CaiDat.GiaDien = giaDienMoi;
                CaiDat.GiaNuoc = giaNuocMoi;

                // Thông báo thành công
                MessageBox.Show("Cập nhật giá điện và giá nước thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btThemPhuPhi_Click(object sender, EventArgs e)
        {
            string tenPhuPhi = tbTenPhuPhi.Text.Trim();
            if (!int.TryParse(tbGiaPhuPhi.Text.Trim(), out int giaPhuPhi))
            {
                MessageBox.Show("Giá phụ phí phải là số nguyên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                CaiDat.ThemPhuPhi(tenPhuPhi, giaPhuPhi);
                MessageBox.Show("Thêm phụ phí thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CapNhatDanhSachPhuPhi(); // Cập nhật lại danh sách hiển thị
                tbTenPhuPhi.Text = "";
                tbGiaPhuPhi.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btXoaPhuPhi_Click(object sender, EventArgs e)
        {
            if (lvPhuPhi.SelectedItems.Count > 0) // Kiểm tra xem có mục nào được chọn không
            {
                // Lấy mã phụ phí từ mục được chọn
                ListViewItem selectedItem = lvPhuPhi.SelectedItems[0];
                int maPhuPhi = int.Parse(selectedItem.Text); // Cột đầu tiên chứa mã phụ phí

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phụ phí này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        CaiDat.XoaPhuPhi(maPhuPhi); // Xóa phụ phí trong cơ sở dữ liệu
                        MessageBox.Show("Xóa phụ phí thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CapNhatDanhSachPhuPhi(); // Cập nhật lại danh sách sau khi xóa
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xóa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phụ phí để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CapNhatDanhSachPhuPhi()
        {
            lvPhuPhi.Items.Clear();
            foreach (var phuPhi in CaiDat.LayDanhSachPhuPhi())
            {
                ListViewItem item = new ListViewItem(phuPhi.MaPhuPhi.ToString())
                {
                    SubItems = { phuPhi.TenPhuPhi, phuPhi.GiaPhuPhi.ToString() }
                };
                lvPhuPhi.Items.Add(item);
            }
        }

    }
}
