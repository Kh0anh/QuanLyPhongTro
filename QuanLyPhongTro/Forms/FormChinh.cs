using MaterialSkin;
using MaterialSkin.Controls;

namespace QuanLyPhongTro.Forms
{
    public partial class FormChinh : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public FormChinh()
        {
            InitializeComponent();

            //Thêm theme vào form
            //Theme Xanh Sáng Trắng
            materialSkinManager = MaterialSkinManager.Instance;

            materialSkinManager.AddFormToManage(this);

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue800,
                Primary.Blue900,
                Primary.Blue500,
                Accent.Blue400,
                TextShade.WHITE
                );

        }

        private void FormChinh_Load(object sender, System.EventArgs e)
        {
            this.Text = CaiDat.TenPhanMem;
        }
    }
}
