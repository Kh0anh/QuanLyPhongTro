namespace QuanLyPhongTro.Forms
{
    partial class FormChinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChinh));
            this.tabControlChinh = new MaterialSkin.Controls.MaterialTabControl();
            this.tabQuanLyPhong = new System.Windows.Forms.TabPage();
            this.userControlQuanLyPhong = new QuanLyPhongTro.Forms.UserControlFormChinh.UserControlQuanLyPhong();
            this.tabCaiDat = new System.Windows.Forms.TabPage();
            this.userControlCaiDat1 = new QuanLyPhongTro.Forms.UserControlFormChinh.UserControlCaiDat();
            this.imgDanhSachBieuTuong = new System.Windows.Forms.ImageList(this.components);
            this.tabControlChinh.SuspendLayout();
            this.tabQuanLyPhong.SuspendLayout();
            this.tabCaiDat.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlChinh
            // 
            this.tabControlChinh.Controls.Add(this.tabQuanLyPhong);
            this.tabControlChinh.Controls.Add(this.tabCaiDat);
            this.tabControlChinh.Depth = 0;
            this.tabControlChinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlChinh.ImageList = this.imgDanhSachBieuTuong;
            this.tabControlChinh.Location = new System.Drawing.Point(3, 64);
            this.tabControlChinh.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControlChinh.Multiline = true;
            this.tabControlChinh.Name = "tabControlChinh";
            this.tabControlChinh.SelectedIndex = 0;
            this.tabControlChinh.Size = new System.Drawing.Size(894, 383);
            this.tabControlChinh.TabIndex = 1;
            // 
            // tabQuanLyPhong
            // 
            this.tabQuanLyPhong.Controls.Add(this.userControlQuanLyPhong);
            this.tabQuanLyPhong.ImageKey = "CanhCua.png";
            this.tabQuanLyPhong.Location = new System.Drawing.Point(4, 23);
            this.tabQuanLyPhong.Name = "tabQuanLyPhong";
            this.tabQuanLyPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuanLyPhong.Size = new System.Drawing.Size(886, 356);
            this.tabQuanLyPhong.TabIndex = 0;
            this.tabQuanLyPhong.Text = "Quản Lý Phòng";
            this.tabQuanLyPhong.UseVisualStyleBackColor = true;
            // 
            // userControlQuanLyPhong
            // 
            this.userControlQuanLyPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlQuanLyPhong.Location = new System.Drawing.Point(3, 3);
            this.userControlQuanLyPhong.Name = "userControlQuanLyPhong";
            this.userControlQuanLyPhong.Size = new System.Drawing.Size(880, 350);
            this.userControlQuanLyPhong.TabIndex = 0;
            // 
            // tabCaiDat
            // 
            this.tabCaiDat.Controls.Add(this.userControlCaiDat1);
            this.tabCaiDat.ImageKey = "CaiDat.png";
            this.tabCaiDat.Location = new System.Drawing.Point(4, 23);
            this.tabCaiDat.Name = "tabCaiDat";
            this.tabCaiDat.Padding = new System.Windows.Forms.Padding(3);
            this.tabCaiDat.Size = new System.Drawing.Size(886, 356);
            this.tabCaiDat.TabIndex = 1;
            this.tabCaiDat.Text = "Cài Đặt";
            this.tabCaiDat.UseVisualStyleBackColor = true;
            // 
            // userControlCaiDat1
            // 
            this.userControlCaiDat1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlCaiDat1.Location = new System.Drawing.Point(3, 3);
            this.userControlCaiDat1.Name = "userControlCaiDat1";
            this.userControlCaiDat1.Size = new System.Drawing.Size(880, 350);
            this.userControlCaiDat1.TabIndex = 0;
            // 
            // imgDanhSachBieuTuong
            // 
            this.imgDanhSachBieuTuong.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgDanhSachBieuTuong.ImageStream")));
            this.imgDanhSachBieuTuong.TransparentColor = System.Drawing.Color.Transparent;
            this.imgDanhSachBieuTuong.Images.SetKeyName(0, "CaiDat.png");
            this.imgDanhSachBieuTuong.Images.SetKeyName(1, "CanhCua.png");
            // 
            // FormChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.tabControlChinh);
            this.DrawerAutoHide = false;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tabControlChinh;
            this.Name = "FormChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChinh";
            this.Load += new System.EventHandler(this.FormChinh_Load);
            this.tabControlChinh.ResumeLayout(false);
            this.tabQuanLyPhong.ResumeLayout(false);
            this.tabCaiDat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl tabControlChinh;
        private System.Windows.Forms.TabPage tabQuanLyPhong;
        private System.Windows.Forms.TabPage tabCaiDat;
        private UserControlFormChinh.UserControlCaiDat userControlCaiDat1;
        private System.Windows.Forms.ImageList imgDanhSachBieuTuong;
        public UserControlFormChinh.UserControlQuanLyPhong userControlQuanLyPhong;
    }
}