using MaterialSkin.Controls;
using System;

namespace QuanLyPhongTro.Forms
{
    public partial class FormTinhTien : MaterialForm
    {
        public FormTinhTien()
        {
            InitializeComponent();
        }

        private void tbXuatHoaDon_Click(object sender, EventArgs e)
        {
            new FormHoaDon().Show();
        }

        private void tbHuyTinhTien_Click(object sender, EventArgs e)
        {

        }
    }
}
