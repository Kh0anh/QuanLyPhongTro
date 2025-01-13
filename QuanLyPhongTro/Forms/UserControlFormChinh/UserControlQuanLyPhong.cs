using System;
using System.Windows.Forms;

namespace QuanLyPhongTro.Forms.UserControlFormChinh
{
    public partial class UserControlQuanLyPhong : UserControl
    {
        public UserControlQuanLyPhong()
        {
            InitializeComponent();
        }

        private void UserControlQuanLyPhong_Load(object sender, EventArgs e)
        {

        }

        private void toolThemPhong_Click(object sender, EventArgs e)
        {
            new FormThemPhong().Show();
        }

        private void toolSuaPhong_Click(object sender, EventArgs e)
        {
            new FormChinhSuaPhong().Show();
        }

        private void toolTinhTien_Click(object sender, EventArgs e)
        {
            new FormTinhTien().Show();
        }

        private void toolXoa_Click(object sender, EventArgs e)
        {

        }

        private void toolChinhTrangThai_Click(object sender, EventArgs e)
        {
            new FormChinhSuaTrangThai().Show();
        }
    }
}
