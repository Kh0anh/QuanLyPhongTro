namespace QuanLyPhongTro.Forms
{
    partial class FormTinhTien
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
            this.tbNguoiThue = new MaterialSkin.Controls.MaterialTextBox();
            this.tbTenPhong = new MaterialSkin.Controls.MaterialTextBox();
            this.lvPhuPhi = new MaterialSkin.Controls.MaterialListView();
            this.colMaPhuPhi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenPhuPhi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGiaPhuPhi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbSoNuocCu = new MaterialSkin.Controls.MaterialTextBox();
            this.tbSoDienCu = new MaterialSkin.Controls.MaterialTextBox();
            this.btXoaPhuPhi = new MaterialSkin.Controls.MaterialButton();
            this.cmPhuPhi = new MaterialSkin.Controls.MaterialComboBox();
            this.tbGiaPhong = new MaterialSkin.Controls.MaterialTextBox();
            this.tbHuyTinhTien = new MaterialSkin.Controls.MaterialButton();
            this.tbXuatHoaDon = new MaterialSkin.Controls.MaterialButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btThemPhuPhi = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSoDienMoi = new MaterialSkin.Controls.MaterialTextBox();
            this.tbSoNuocMoi = new MaterialSkin.Controls.MaterialTextBox();
            this.tbTongTienDien = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbTongTienNuoc = new MaterialSkin.Controls.MaterialTextBox();
            this.tbTongTienPhuPhi = new MaterialSkin.Controls.MaterialTextBox();
            this.tbTongTien = new MaterialSkin.Controls.MaterialTextBox();
            this.tbGiaDien = new MaterialSkin.Controls.MaterialTextBox();
            this.tbGiaNuoc = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNguoiThue
            // 
            this.tbNguoiThue.AnimateReadOnly = false;
            this.tbNguoiThue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNguoiThue.Depth = 0;
            this.tbNguoiThue.Enabled = false;
            this.tbNguoiThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbNguoiThue.Hint = "Người Thuê";
            this.tbNguoiThue.LeadingIcon = null;
            this.tbNguoiThue.Location = new System.Drawing.Point(6, 109);
            this.tbNguoiThue.MaxLength = 50;
            this.tbNguoiThue.MouseState = MaterialSkin.MouseState.OUT;
            this.tbNguoiThue.Multiline = false;
            this.tbNguoiThue.Name = "tbNguoiThue";
            this.tbNguoiThue.Size = new System.Drawing.Size(310, 36);
            this.tbNguoiThue.TabIndex = 3;
            this.tbNguoiThue.Text = "";
            this.tbNguoiThue.TrailingIcon = null;
            this.tbNguoiThue.UseTallSize = false;
            // 
            // tbTenPhong
            // 
            this.tbTenPhong.AnimateReadOnly = false;
            this.tbTenPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTenPhong.Depth = 0;
            this.tbTenPhong.Enabled = false;
            this.tbTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbTenPhong.Hint = "Tên Phòng";
            this.tbTenPhong.LeadingIcon = null;
            this.tbTenPhong.Location = new System.Drawing.Point(6, 25);
            this.tbTenPhong.MaxLength = 50;
            this.tbTenPhong.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTenPhong.Multiline = false;
            this.tbTenPhong.Name = "tbTenPhong";
            this.tbTenPhong.Size = new System.Drawing.Size(310, 36);
            this.tbTenPhong.TabIndex = 0;
            this.tbTenPhong.Text = "";
            this.tbTenPhong.TrailingIcon = null;
            this.tbTenPhong.UseTallSize = false;
            // 
            // lvPhuPhi
            // 
            this.lvPhuPhi.AutoSizeTable = false;
            this.lvPhuPhi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lvPhuPhi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvPhuPhi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaPhuPhi,
            this.colTenPhuPhi,
            this.colGiaPhuPhi});
            this.lvPhuPhi.Depth = 0;
            this.lvPhuPhi.FullRowSelect = true;
            this.lvPhuPhi.HideSelection = false;
            this.lvPhuPhi.Location = new System.Drawing.Point(6, 66);
            this.lvPhuPhi.MinimumSize = new System.Drawing.Size(200, 100);
            this.lvPhuPhi.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvPhuPhi.MouseState = MaterialSkin.MouseState.OUT;
            this.lvPhuPhi.Name = "lvPhuPhi";
            this.lvPhuPhi.OwnerDraw = true;
            this.lvPhuPhi.Size = new System.Drawing.Size(388, 238);
            this.lvPhuPhi.TabIndex = 9;
            this.lvPhuPhi.UseCompatibleStateImageBehavior = false;
            this.lvPhuPhi.View = System.Windows.Forms.View.Details;
            // 
            // colMaPhuPhi
            // 
            this.colMaPhuPhi.Text = "Mã";
            // 
            // colTenPhuPhi
            // 
            this.colTenPhuPhi.Text = "Phụ Phí";
            this.colTenPhuPhi.Width = 140;
            // 
            // colGiaPhuPhi
            // 
            this.colGiaPhuPhi.Text = "Giá";
            this.colGiaPhuPhi.Width = 140;
            // 
            // tbSoNuocCu
            // 
            this.tbSoNuocCu.AnimateReadOnly = false;
            this.tbSoNuocCu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSoNuocCu.Depth = 0;
            this.tbSoNuocCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbSoNuocCu.Hint = "Số Nước Cũ";
            this.tbSoNuocCu.LeadingIcon = null;
            this.tbSoNuocCu.Location = new System.Drawing.Point(6, 193);
            this.tbSoNuocCu.MaxLength = 50;
            this.tbSoNuocCu.MouseState = MaterialSkin.MouseState.OUT;
            this.tbSoNuocCu.Multiline = false;
            this.tbSoNuocCu.Name = "tbSoNuocCu";
            this.tbSoNuocCu.Size = new System.Drawing.Size(310, 36);
            this.tbSoNuocCu.TabIndex = 7;
            this.tbSoNuocCu.Text = "";
            this.tbSoNuocCu.TrailingIcon = null;
            this.tbSoNuocCu.UseTallSize = false;
            // 
            // tbSoDienCu
            // 
            this.tbSoDienCu.AnimateReadOnly = false;
            this.tbSoDienCu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSoDienCu.Depth = 0;
            this.tbSoDienCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbSoDienCu.Hint = "Số Điện Cũ";
            this.tbSoDienCu.LeadingIcon = null;
            this.tbSoDienCu.Location = new System.Drawing.Point(6, 151);
            this.tbSoDienCu.MaxLength = 50;
            this.tbSoDienCu.MouseState = MaterialSkin.MouseState.OUT;
            this.tbSoDienCu.Multiline = false;
            this.tbSoDienCu.Name = "tbSoDienCu";
            this.tbSoDienCu.Size = new System.Drawing.Size(310, 36);
            this.tbSoDienCu.TabIndex = 6;
            this.tbSoDienCu.Text = "";
            this.tbSoDienCu.TrailingIcon = null;
            this.tbSoDienCu.UseTallSize = false;
            // 
            // btXoaPhuPhi
            // 
            this.btXoaPhuPhi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btXoaPhuPhi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btXoaPhuPhi.Depth = 0;
            this.btXoaPhuPhi.HighEmphasis = true;
            this.btXoaPhuPhi.Icon = null;
            this.btXoaPhuPhi.Location = new System.Drawing.Point(330, 24);
            this.btXoaPhuPhi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btXoaPhuPhi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btXoaPhuPhi.Name = "btXoaPhuPhi";
            this.btXoaPhuPhi.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btXoaPhuPhi.Size = new System.Drawing.Size(64, 36);
            this.btXoaPhuPhi.TabIndex = 12;
            this.btXoaPhuPhi.Text = "Xoá";
            this.btXoaPhuPhi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btXoaPhuPhi.UseAccentColor = true;
            this.btXoaPhuPhi.UseVisualStyleBackColor = true;
            // 
            // cmPhuPhi
            // 
            this.cmPhuPhi.AutoResize = false;
            this.cmPhuPhi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmPhuPhi.Depth = 0;
            this.cmPhuPhi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmPhuPhi.DropDownHeight = 118;
            this.cmPhuPhi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmPhuPhi.DropDownWidth = 121;
            this.cmPhuPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmPhuPhi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmPhuPhi.FormattingEnabled = true;
            this.cmPhuPhi.Hint = "Phụ Phí";
            this.cmPhuPhi.IntegralHeight = false;
            this.cmPhuPhi.ItemHeight = 29;
            this.cmPhuPhi.Location = new System.Drawing.Point(6, 25);
            this.cmPhuPhi.MaxDropDownItems = 4;
            this.cmPhuPhi.MouseState = MaterialSkin.MouseState.OUT;
            this.cmPhuPhi.Name = "cmPhuPhi";
            this.cmPhuPhi.Size = new System.Drawing.Size(244, 35);
            this.cmPhuPhi.StartIndex = 0;
            this.cmPhuPhi.TabIndex = 10;
            this.cmPhuPhi.UseTallSize = false;
            // 
            // tbGiaPhong
            // 
            this.tbGiaPhong.AnimateReadOnly = false;
            this.tbGiaPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGiaPhong.Depth = 0;
            this.tbGiaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbGiaPhong.Hint = "Giá Phòng";
            this.tbGiaPhong.LeadingIcon = null;
            this.tbGiaPhong.Location = new System.Drawing.Point(6, 67);
            this.tbGiaPhong.MaxLength = 50;
            this.tbGiaPhong.MouseState = MaterialSkin.MouseState.OUT;
            this.tbGiaPhong.Multiline = false;
            this.tbGiaPhong.Name = "tbGiaPhong";
            this.tbGiaPhong.Size = new System.Drawing.Size(310, 36);
            this.tbGiaPhong.TabIndex = 1;
            this.tbGiaPhong.Text = "";
            this.tbGiaPhong.TrailingIcon = null;
            this.tbGiaPhong.UseTallSize = false;
            // 
            // tbHuyTinhTien
            // 
            this.tbHuyTinhTien.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tbHuyTinhTien.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.tbHuyTinhTien.Depth = 0;
            this.tbHuyTinhTien.HighEmphasis = true;
            this.tbHuyTinhTien.Icon = null;
            this.tbHuyTinhTien.Location = new System.Drawing.Point(472, 514);
            this.tbHuyTinhTien.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbHuyTinhTien.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbHuyTinhTien.Name = "tbHuyTinhTien";
            this.tbHuyTinhTien.NoAccentTextColor = System.Drawing.Color.Empty;
            this.tbHuyTinhTien.Size = new System.Drawing.Size(124, 36);
            this.tbHuyTinhTien.TabIndex = 13;
            this.tbHuyTinhTien.Text = "Hủy Tính Tiền";
            this.tbHuyTinhTien.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.tbHuyTinhTien.UseAccentColor = true;
            this.tbHuyTinhTien.UseVisualStyleBackColor = true;
            this.tbHuyTinhTien.Click += new System.EventHandler(this.tbHuyTinhTien_Click);
            // 
            // tbXuatHoaDon
            // 
            this.tbXuatHoaDon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tbXuatHoaDon.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.tbXuatHoaDon.Depth = 0;
            this.tbXuatHoaDon.HighEmphasis = true;
            this.tbXuatHoaDon.Icon = null;
            this.tbXuatHoaDon.Location = new System.Drawing.Point(604, 514);
            this.tbXuatHoaDon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbXuatHoaDon.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbXuatHoaDon.Name = "tbXuatHoaDon";
            this.tbXuatHoaDon.NoAccentTextColor = System.Drawing.Color.Empty;
            this.tbXuatHoaDon.Size = new System.Drawing.Size(127, 36);
            this.tbXuatHoaDon.TabIndex = 13;
            this.tbXuatHoaDon.Text = "Xuất Hoá Đơn";
            this.tbXuatHoaDon.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.tbXuatHoaDon.UseAccentColor = false;
            this.tbXuatHoaDon.UseVisualStyleBackColor = true;
            this.tbXuatHoaDon.Click += new System.EventHandler(this.tbXuatHoaDon_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvPhuPhi);
            this.groupBox2.Controls.Add(this.btXoaPhuPhi);
            this.groupBox2.Controls.Add(this.cmPhuPhi);
            this.groupBox2.Controls.Add(this.btThemPhuPhi);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(322, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 310);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phụ Phí";
            // 
            // btThemPhuPhi
            // 
            this.btThemPhuPhi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btThemPhuPhi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btThemPhuPhi.Depth = 0;
            this.btThemPhuPhi.HighEmphasis = true;
            this.btThemPhuPhi.Icon = null;
            this.btThemPhuPhi.Location = new System.Drawing.Point(258, 24);
            this.btThemPhuPhi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btThemPhuPhi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btThemPhuPhi.Name = "btThemPhuPhi";
            this.btThemPhuPhi.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btThemPhuPhi.Size = new System.Drawing.Size(64, 36);
            this.btThemPhuPhi.TabIndex = 11;
            this.btThemPhuPhi.Text = "Thêm";
            this.btThemPhuPhi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btThemPhuPhi.UseAccentColor = false;
            this.btThemPhuPhi.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbGiaNuoc);
            this.groupBox1.Controls.Add(this.tbGiaDien);
            this.groupBox1.Controls.Add(this.tbSoNuocMoi);
            this.groupBox1.Controls.Add(this.tbSoDienMoi);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tbSoNuocCu);
            this.groupBox1.Controls.Add(this.tbSoDienCu);
            this.groupBox1.Controls.Add(this.tbNguoiThue);
            this.groupBox1.Controls.Add(this.tbGiaPhong);
            this.groupBox1.Controls.Add(this.tbTenPhong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 329);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Phòng";
            // 
            // tbSoDienMoi
            // 
            this.tbSoDienMoi.AnimateReadOnly = false;
            this.tbSoDienMoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSoDienMoi.Depth = 0;
            this.tbSoDienMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbSoDienMoi.Hint = "Số Điện Mới";
            this.tbSoDienMoi.LeadingIcon = null;
            this.tbSoDienMoi.Location = new System.Drawing.Point(6, 235);
            this.tbSoDienMoi.MaxLength = 50;
            this.tbSoDienMoi.MouseState = MaterialSkin.MouseState.OUT;
            this.tbSoDienMoi.Multiline = false;
            this.tbSoDienMoi.Name = "tbSoDienMoi";
            this.tbSoDienMoi.Size = new System.Drawing.Size(145, 36);
            this.tbSoDienMoi.TabIndex = 14;
            this.tbSoDienMoi.Text = "";
            this.tbSoDienMoi.TrailingIcon = null;
            this.tbSoDienMoi.UseTallSize = false;
            // 
            // tbSoNuocMoi
            // 
            this.tbSoNuocMoi.AnimateReadOnly = false;
            this.tbSoNuocMoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSoNuocMoi.Depth = 0;
            this.tbSoNuocMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbSoNuocMoi.Hint = "Số Nước Mới";
            this.tbSoNuocMoi.LeadingIcon = null;
            this.tbSoNuocMoi.Location = new System.Drawing.Point(6, 280);
            this.tbSoNuocMoi.MaxLength = 50;
            this.tbSoNuocMoi.MouseState = MaterialSkin.MouseState.OUT;
            this.tbSoNuocMoi.Multiline = false;
            this.tbSoNuocMoi.Name = "tbSoNuocMoi";
            this.tbSoNuocMoi.Size = new System.Drawing.Size(145, 36);
            this.tbSoNuocMoi.TabIndex = 15;
            this.tbSoNuocMoi.Text = "";
            this.tbSoNuocMoi.TrailingIcon = null;
            this.tbSoNuocMoi.UseTallSize = false;
            // 
            // tbTongTienDien
            // 
            this.tbTongTienDien.AnimateReadOnly = false;
            this.tbTongTienDien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTongTienDien.Depth = 0;
            this.tbTongTienDien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbTongTienDien.Hint = "Tổng Tiền Điện";
            this.tbTongTienDien.LeadingIcon = null;
            this.tbTongTienDien.Location = new System.Drawing.Point(6, 19);
            this.tbTongTienDien.MaxLength = 50;
            this.tbTongTienDien.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTongTienDien.Multiline = false;
            this.tbTongTienDien.Name = "tbTongTienDien";
            this.tbTongTienDien.Size = new System.Drawing.Size(310, 36);
            this.tbTongTienDien.TabIndex = 16;
            this.tbTongTienDien.Text = "";
            this.tbTongTienDien.TrailingIcon = null;
            this.tbTongTienDien.UseTallSize = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbTongTien);
            this.groupBox3.Controls.Add(this.tbTongTienPhuPhi);
            this.groupBox3.Controls.Add(this.tbTongTienNuoc);
            this.groupBox3.Controls.Add(this.tbTongTienDien);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 362);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 188);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tổng Tiền";
            // 
            // tbTongTienNuoc
            // 
            this.tbTongTienNuoc.AnimateReadOnly = false;
            this.tbTongTienNuoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTongTienNuoc.Depth = 0;
            this.tbTongTienNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbTongTienNuoc.Hint = "Tổng Tiền Nước";
            this.tbTongTienNuoc.LeadingIcon = null;
            this.tbTongTienNuoc.Location = new System.Drawing.Point(6, 61);
            this.tbTongTienNuoc.MaxLength = 50;
            this.tbTongTienNuoc.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTongTienNuoc.Multiline = false;
            this.tbTongTienNuoc.Name = "tbTongTienNuoc";
            this.tbTongTienNuoc.Size = new System.Drawing.Size(310, 36);
            this.tbTongTienNuoc.TabIndex = 17;
            this.tbTongTienNuoc.Text = "";
            this.tbTongTienNuoc.TrailingIcon = null;
            this.tbTongTienNuoc.UseTallSize = false;
            // 
            // tbTongTienPhuPhi
            // 
            this.tbTongTienPhuPhi.AnimateReadOnly = false;
            this.tbTongTienPhuPhi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTongTienPhuPhi.Depth = 0;
            this.tbTongTienPhuPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbTongTienPhuPhi.Hint = "Tổng Tiền Phụ Phí";
            this.tbTongTienPhuPhi.LeadingIcon = null;
            this.tbTongTienPhuPhi.Location = new System.Drawing.Point(6, 103);
            this.tbTongTienPhuPhi.MaxLength = 50;
            this.tbTongTienPhuPhi.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTongTienPhuPhi.Multiline = false;
            this.tbTongTienPhuPhi.Name = "tbTongTienPhuPhi";
            this.tbTongTienPhuPhi.Size = new System.Drawing.Size(310, 36);
            this.tbTongTienPhuPhi.TabIndex = 18;
            this.tbTongTienPhuPhi.Text = "";
            this.tbTongTienPhuPhi.TrailingIcon = null;
            this.tbTongTienPhuPhi.UseTallSize = false;
            // 
            // tbTongTien
            // 
            this.tbTongTien.AnimateReadOnly = false;
            this.tbTongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTongTien.Depth = 0;
            this.tbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbTongTien.Hint = "Tổng Tiền";
            this.tbTongTien.LeadingIcon = null;
            this.tbTongTien.Location = new System.Drawing.Point(6, 145);
            this.tbTongTien.MaxLength = 50;
            this.tbTongTien.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTongTien.Multiline = false;
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.Size = new System.Drawing.Size(310, 36);
            this.tbTongTien.TabIndex = 19;
            this.tbTongTien.Text = "";
            this.tbTongTien.TrailingIcon = null;
            this.tbTongTien.UseTallSize = false;
            // 
            // tbGiaDien
            // 
            this.tbGiaDien.AnimateReadOnly = false;
            this.tbGiaDien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGiaDien.Depth = 0;
            this.tbGiaDien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbGiaDien.Hint = "Giá Điện";
            this.tbGiaDien.LeadingIcon = null;
            this.tbGiaDien.Location = new System.Drawing.Point(157, 235);
            this.tbGiaDien.MaxLength = 50;
            this.tbGiaDien.MouseState = MaterialSkin.MouseState.OUT;
            this.tbGiaDien.Multiline = false;
            this.tbGiaDien.Name = "tbGiaDien";
            this.tbGiaDien.Size = new System.Drawing.Size(159, 36);
            this.tbGiaDien.TabIndex = 16;
            this.tbGiaDien.Text = "";
            this.tbGiaDien.TrailingIcon = null;
            this.tbGiaDien.UseTallSize = false;
            // 
            // tbGiaNuoc
            // 
            this.tbGiaNuoc.AnimateReadOnly = false;
            this.tbGiaNuoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGiaNuoc.Depth = 0;
            this.tbGiaNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbGiaNuoc.Hint = "Giá Nước";
            this.tbGiaNuoc.LeadingIcon = null;
            this.tbGiaNuoc.Location = new System.Drawing.Point(157, 280);
            this.tbGiaNuoc.MaxLength = 50;
            this.tbGiaNuoc.MouseState = MaterialSkin.MouseState.OUT;
            this.tbGiaNuoc.Multiline = false;
            this.tbGiaNuoc.Name = "tbGiaNuoc";
            this.tbGiaNuoc.Size = new System.Drawing.Size(159, 36);
            this.tbGiaNuoc.TabIndex = 17;
            this.tbGiaNuoc.Text = "";
            this.tbGiaNuoc.TrailingIcon = null;
            this.tbGiaNuoc.UseTallSize = false;
            // 
            // FormTinhTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 558);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbXuatHoaDon);
            this.Controls.Add(this.tbHuyTinhTien);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "FormTinhTien";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "FormTinhTien";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox tbNguoiThue;
        private MaterialSkin.Controls.MaterialTextBox tbTenPhong;
        private MaterialSkin.Controls.MaterialListView lvPhuPhi;
        private System.Windows.Forms.ColumnHeader colMaPhuPhi;
        private System.Windows.Forms.ColumnHeader colTenPhuPhi;
        private System.Windows.Forms.ColumnHeader colGiaPhuPhi;
        private MaterialSkin.Controls.MaterialTextBox tbSoNuocCu;
        private MaterialSkin.Controls.MaterialTextBox tbSoDienCu;
        private MaterialSkin.Controls.MaterialButton btXoaPhuPhi;
        private MaterialSkin.Controls.MaterialComboBox cmPhuPhi;
        private MaterialSkin.Controls.MaterialTextBox tbGiaPhong;
        private MaterialSkin.Controls.MaterialButton tbHuyTinhTien;
        private MaterialSkin.Controls.MaterialButton tbXuatHoaDon;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialButton btThemPhuPhi;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox tbSoDienMoi;
        private MaterialSkin.Controls.MaterialTextBox tbSoNuocMoi;
        private MaterialSkin.Controls.MaterialTextBox tbTongTienDien;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialTextBox tbTongTien;
        private MaterialSkin.Controls.MaterialTextBox tbTongTienPhuPhi;
        private MaterialSkin.Controls.MaterialTextBox tbTongTienNuoc;
        private MaterialSkin.Controls.MaterialTextBox tbGiaNuoc;
        private MaterialSkin.Controls.MaterialTextBox tbGiaDien;
    }
}