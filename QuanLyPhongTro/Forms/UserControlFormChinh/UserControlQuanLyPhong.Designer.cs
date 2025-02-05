namespace QuanLyPhongTro.Forms.UserControlFormChinh
{
    partial class UserControlQuanLyPhong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmQuanLyPhong = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.toolThemPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSuaPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.toolChinhTrangThai = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTinhTien = new System.Windows.Forms.ToolStripMenuItem();
            this.toolXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.lvQuanLyPhong = new MaterialSkin.Controls.MaterialListView();
            this.colMaPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGiaPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhuPhi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTrangThai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNguoiThue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgayThue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoDienCu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoNuocCu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGhiChu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.cmQuanLyPhong.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmQuanLyPhong
            // 
            this.cmQuanLyPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmQuanLyPhong.Depth = 0;
            this.cmQuanLyPhong.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmQuanLyPhong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolThemPhong,
            this.toolSuaPhong,
            this.toolChinhTrangThai,
            this.toolTinhTien,
            this.toolXoa});
            this.cmQuanLyPhong.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmQuanLyPhong.Name = "contextMenuStrip1";
            this.cmQuanLyPhong.Size = new System.Drawing.Size(166, 114);
            // 
            // toolThemPhong
            // 
            this.toolThemPhong.Name = "toolThemPhong";
            this.toolThemPhong.Size = new System.Drawing.Size(165, 22);
            this.toolThemPhong.Text = "Thêm Phòng";
            this.toolThemPhong.Click += new System.EventHandler(this.toolThemPhong_Click);
            // 
            // toolSuaPhong
            // 
            this.toolSuaPhong.Name = "toolSuaPhong";
            this.toolSuaPhong.Size = new System.Drawing.Size(165, 22);
            this.toolSuaPhong.Text = "Sửa Phòng";
            this.toolSuaPhong.Click += new System.EventHandler(this.toolSuaPhong_Click);
            // 
            // toolChinhTrangThai
            // 
            this.toolChinhTrangThai.Name = "toolChinhTrangThai";
            this.toolChinhTrangThai.Size = new System.Drawing.Size(165, 22);
            this.toolChinhTrangThai.Text = "Chỉnh Trạng Thái";
            this.toolChinhTrangThai.Click += new System.EventHandler(this.toolChinhTrangThai_Click);
            // 
            // toolTinhTien
            // 
            this.toolTinhTien.Name = "toolTinhTien";
            this.toolTinhTien.Size = new System.Drawing.Size(165, 22);
            this.toolTinhTien.Text = "Tính Tiền";
            this.toolTinhTien.Click += new System.EventHandler(this.toolTinhTien_Click);
            // 
            // toolXoa
            // 
            this.toolXoa.Name = "toolXoa";
            this.toolXoa.Size = new System.Drawing.Size(165, 22);
            this.toolXoa.Text = "Xoá";
            this.toolXoa.Click += new System.EventHandler(this.toolXoa_Click);
            // 
            // lvQuanLyPhong
            // 
            this.lvQuanLyPhong.AutoSizeTable = false;
            this.lvQuanLyPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lvQuanLyPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvQuanLyPhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaPhong,
            this.colTenPhong,
            this.colGiaPhong,
            this.colPhuPhi,
            this.colTrangThai,
            this.colNguoiThue,
            this.colNgayThue,
            this.colSoDienCu,
            this.colSoNuocCu,
            this.colGhiChu});
            this.lvQuanLyPhong.ContextMenuStrip = this.cmQuanLyPhong;
            this.lvQuanLyPhong.Depth = 0;
            this.lvQuanLyPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvQuanLyPhong.FullRowSelect = true;
            this.lvQuanLyPhong.HideSelection = false;
            this.lvQuanLyPhong.Location = new System.Drawing.Point(0, 0);
            this.lvQuanLyPhong.MinimumSize = new System.Drawing.Size(200, 100);
            this.lvQuanLyPhong.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvQuanLyPhong.MouseState = MaterialSkin.MouseState.OUT;
            this.lvQuanLyPhong.Name = "lvQuanLyPhong";
            this.lvQuanLyPhong.OwnerDraw = true;
            this.lvQuanLyPhong.Size = new System.Drawing.Size(800, 400);
            this.lvQuanLyPhong.TabIndex = 1;
            this.lvQuanLyPhong.UseCompatibleStateImageBehavior = false;
            this.lvQuanLyPhong.View = System.Windows.Forms.View.Details;
            // 
            // colMaPhong
            // 
            this.colMaPhong.Text = "Mã phòng";
            this.colMaPhong.Width = 120;
            // 
            // colTenPhong
            // 
            this.colTenPhong.Text = "Tên phòng";
            this.colTenPhong.Width = 120;
            // 
            // colGiaPhong
            // 
            this.colGiaPhong.Text = "Giá phòng";
            this.colGiaPhong.Width = 140;
            // 
            // colPhuPhi
            // 
            this.colPhuPhi.Text = "Phụ phí";
            this.colPhuPhi.Width = 140;
            // 
            // colTrangThai
            // 
            this.colTrangThai.Text = "Trạng thái";
            this.colTrangThai.Width = 140;
            // 
            // colNguoiThue
            // 
            this.colNguoiThue.Text = "Người thuê";
            this.colNguoiThue.Width = 180;
            // 
            // colNgayThue
            // 
            this.colNgayThue.Text = "Ngày thuê";
            this.colNgayThue.Width = 120;
            // 
            // colSoDienCu
            // 
            this.colSoDienCu.Text = "Số điện cũ";
            this.colSoDienCu.Width = 120;
            // 
            // colSoNuocCu
            // 
            this.colSoNuocCu.Text = "Số nước cũ";
            this.colSoNuocCu.Width = 120;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Text = "Ghi chú";
            this.colGhiChu.Width = 240;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvQuanLyPhong);
            this.panel2.Controls.Add(this.materialTextBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 400);
            this.panel2.TabIndex = 3;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(1018, -43);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(132, 36);
            this.materialTextBox1.TabIndex = 0;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            this.materialTextBox1.UseTallSize = false;
            // 
            // UserControlQuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "UserControlQuanLyPhong";
            this.Size = new System.Drawing.Size(800, 400);
            this.Load += new System.EventHandler(this.UserControlQuanLyPhong_Load);
            this.cmQuanLyPhong.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialContextMenuStrip cmQuanLyPhong;
        private System.Windows.Forms.ToolStripMenuItem toolThemPhong;
        private System.Windows.Forms.ToolStripMenuItem toolSuaPhong;
        private System.Windows.Forms.ToolStripMenuItem toolTinhTien;
        private System.Windows.Forms.ToolStripMenuItem toolXoa;
        private System.Windows.Forms.ToolStripMenuItem toolChinhTrangThai;
        public MaterialSkin.Controls.MaterialListView lvQuanLyPhong;
        private System.Windows.Forms.ColumnHeader colMaPhong;
        private System.Windows.Forms.ColumnHeader colTenPhong;
        private System.Windows.Forms.ColumnHeader colGiaPhong;
        private System.Windows.Forms.ColumnHeader colPhuPhi;
        private System.Windows.Forms.ColumnHeader colTrangThai;
        private System.Windows.Forms.ColumnHeader colNguoiThue;
        private System.Windows.Forms.ColumnHeader colNgayThue;
        private System.Windows.Forms.ColumnHeader colSoDienCu;
        private System.Windows.Forms.ColumnHeader colSoNuocCu;
        private System.Windows.Forms.ColumnHeader colGhiChu;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
    }
}
