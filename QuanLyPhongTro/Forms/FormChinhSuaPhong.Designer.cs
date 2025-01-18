namespace QuanLyPhongTro.Forms
{
    partial class FormChinhSuaPhong
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTrangThai = new MaterialSkin.Controls.MaterialTextBox();
            this.btnXoaChinhSua = new MaterialSkin.Controls.MaterialButton();
            this.btnLuuChinhSua = new MaterialSkin.Controls.MaterialButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsvPhuPhi = new MaterialSkin.Controls.MaterialListView();
            this.colMaPhuPhi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenPhuPhi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGiaPhuPhi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btXoaPhuPhi = new MaterialSkin.Controls.MaterialButton();
            this.cbPhuPhi = new MaterialSkin.Controls.MaterialComboBox();
            this.btThemPhuPhi = new MaterialSkin.Controls.MaterialButton();
            this.tbGhiChu = new MaterialSkin.Controls.MaterialTextBox();
            this.tbSoNuocCu = new MaterialSkin.Controls.MaterialTextBox();
            this.tbSoDienCu = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpNgayThue = new System.Windows.Forms.DateTimePicker();
            this.tbNguoiThue = new MaterialSkin.Controls.MaterialTextBox();
            this.tbGiaPhong = new MaterialSkin.Controls.MaterialTextBox();
            this.tbTenPhong = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTrangThai);
            this.groupBox1.Controls.Add(this.btnXoaChinhSua);
            this.groupBox1.Controls.Add(this.btnLuuChinhSua);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tbGhiChu);
            this.groupBox1.Controls.Add(this.tbSoNuocCu);
            this.groupBox1.Controls.Add(this.tbSoDienCu);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.dtpNgayThue);
            this.groupBox1.Controls.Add(this.tbNguoiThue);
            this.groupBox1.Controls.Add(this.tbGiaPhong);
            this.groupBox1.Controls.Add(this.tbTenPhong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(971, 513);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chỉnh Sửa Phòng";
            // 
            // tbTrangThai
            // 
            this.tbTrangThai.AnimateReadOnly = false;
            this.tbTrangThai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTrangThai.Depth = 0;
            this.tbTrangThai.Enabled = false;
            this.tbTrangThai.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbTrangThai.Hint = "Trạng Thái";
            this.tbTrangThai.LeadingIcon = null;
            this.tbTrangThai.Location = new System.Drawing.Point(8, 134);
            this.tbTrangThai.Margin = new System.Windows.Forms.Padding(4);
            this.tbTrangThai.MaxLength = 50;
            this.tbTrangThai.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTrangThai.Multiline = false;
            this.tbTrangThai.Name = "tbTrangThai";
            this.tbTrangThai.Size = new System.Drawing.Size(413, 36);
            this.tbTrangThai.TabIndex = 14;
            this.tbTrangThai.Text = "";
            this.tbTrangThai.TrailingIcon = null;
            this.tbTrangThai.UseTallSize = false;
            // 
            // btnXoaChinhSua
            // 
            this.btnXoaChinhSua.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoaChinhSua.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXoaChinhSua.Depth = 0;
            this.btnXoaChinhSua.HighEmphasis = true;
            this.btnXoaChinhSua.Icon = null;
            this.btnXoaChinhSua.Location = new System.Drawing.Point(601, 459);
            this.btnXoaChinhSua.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnXoaChinhSua.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoaChinhSua.Name = "btnXoaChinhSua";
            this.btnXoaChinhSua.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoaChinhSua.Size = new System.Drawing.Size(132, 36);
            this.btnXoaChinhSua.TabIndex = 13;
            this.btnXoaChinhSua.Text = "Xoá Chỉnh Sửa";
            this.btnXoaChinhSua.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXoaChinhSua.UseAccentColor = true;
            this.btnXoaChinhSua.UseVisualStyleBackColor = true;
            this.btnXoaChinhSua.Click += new System.EventHandler(this.btnXoaChinhSua_Click);
            // 
            // btnLuuChinhSua
            // 
            this.btnLuuChinhSua.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLuuChinhSua.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLuuChinhSua.Depth = 0;
            this.btnLuuChinhSua.HighEmphasis = true;
            this.btnLuuChinhSua.Icon = null;
            this.btnLuuChinhSua.Location = new System.Drawing.Point(788, 459);
            this.btnLuuChinhSua.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnLuuChinhSua.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLuuChinhSua.Name = "btnLuuChinhSua";
            this.btnLuuChinhSua.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLuuChinhSua.Size = new System.Drawing.Size(131, 36);
            this.btnLuuChinhSua.TabIndex = 13;
            this.btnLuuChinhSua.Text = "Lưu Chỉnh Sửa";
            this.btnLuuChinhSua.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLuuChinhSua.UseAccentColor = false;
            this.btnLuuChinhSua.UseVisualStyleBackColor = true;
            this.btnLuuChinhSua.Click += new System.EventHandler(this.btnLuuChinhSua_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsvPhuPhi);
            this.groupBox2.Controls.Add(this.btXoaPhuPhi);
            this.groupBox2.Controls.Add(this.cbPhuPhi);
            this.groupBox2.Controls.Add(this.btThemPhuPhi);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(429, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(533, 382);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phụ Phí";
            // 
            // lsvPhuPhi
            // 
            this.lsvPhuPhi.AutoSizeTable = false;
            this.lsvPhuPhi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lsvPhuPhi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsvPhuPhi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaPhuPhi,
            this.colTenPhuPhi,
            this.colGiaPhuPhi});
            this.lsvPhuPhi.Depth = 0;
            this.lsvPhuPhi.FullRowSelect = true;
            this.lsvPhuPhi.HideSelection = false;
            this.lsvPhuPhi.Location = new System.Drawing.Point(8, 81);
            this.lsvPhuPhi.Margin = new System.Windows.Forms.Padding(4);
            this.lsvPhuPhi.MinimumSize = new System.Drawing.Size(267, 123);
            this.lsvPhuPhi.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lsvPhuPhi.MouseState = MaterialSkin.MouseState.OUT;
            this.lsvPhuPhi.Name = "lsvPhuPhi";
            this.lsvPhuPhi.OwnerDraw = true;
            this.lsvPhuPhi.Size = new System.Drawing.Size(517, 293);
            this.lsvPhuPhi.TabIndex = 9;
            this.lsvPhuPhi.UseCompatibleStateImageBehavior = false;
            this.lsvPhuPhi.View = System.Windows.Forms.View.Details;
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
            // btXoaPhuPhi
            // 
            this.btXoaPhuPhi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btXoaPhuPhi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btXoaPhuPhi.Depth = 0;
            this.btXoaPhuPhi.HighEmphasis = true;
            this.btXoaPhuPhi.Icon = null;
            this.btXoaPhuPhi.Location = new System.Drawing.Point(440, 30);
            this.btXoaPhuPhi.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
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
            // cbPhuPhi
            // 
            this.cbPhuPhi.AutoResize = false;
            this.cbPhuPhi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbPhuPhi.Depth = 0;
            this.cbPhuPhi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbPhuPhi.DropDownHeight = 118;
            this.cbPhuPhi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhuPhi.DropDownWidth = 121;
            this.cbPhuPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbPhuPhi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbPhuPhi.FormattingEnabled = true;
            this.cbPhuPhi.Hint = "Phụ Phí";
            this.cbPhuPhi.IntegralHeight = false;
            this.cbPhuPhi.ItemHeight = 29;
            this.cbPhuPhi.Location = new System.Drawing.Point(8, 31);
            this.cbPhuPhi.Margin = new System.Windows.Forms.Padding(4);
            this.cbPhuPhi.MaxDropDownItems = 4;
            this.cbPhuPhi.MouseState = MaterialSkin.MouseState.OUT;
            this.cbPhuPhi.Name = "cbPhuPhi";
            this.cbPhuPhi.Size = new System.Drawing.Size(324, 35);
            this.cbPhuPhi.StartIndex = 0;
            this.cbPhuPhi.TabIndex = 10;
            this.cbPhuPhi.UseTallSize = false;
            // 
            // btThemPhuPhi
            // 
            this.btThemPhuPhi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btThemPhuPhi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btThemPhuPhi.Depth = 0;
            this.btThemPhuPhi.HighEmphasis = true;
            this.btThemPhuPhi.Icon = null;
            this.btThemPhuPhi.Location = new System.Drawing.Point(344, 30);
            this.btThemPhuPhi.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
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
            // tbGhiChu
            // 
            this.tbGhiChu.AnimateReadOnly = false;
            this.tbGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGhiChu.Depth = 0;
            this.tbGhiChu.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbGhiChu.Hint = "Ghi Chú";
            this.tbGhiChu.LeadingIcon = null;
            this.tbGhiChu.Location = new System.Drawing.Point(8, 404);
            this.tbGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.tbGhiChu.MaxLength = 50;
            this.tbGhiChu.MouseState = MaterialSkin.MouseState.OUT;
            this.tbGhiChu.Multiline = false;
            this.tbGhiChu.Name = "tbGhiChu";
            this.tbGhiChu.Size = new System.Drawing.Size(955, 36);
            this.tbGhiChu.TabIndex = 8;
            this.tbGhiChu.Text = "";
            this.tbGhiChu.TrailingIcon = null;
            this.tbGhiChu.UseTallSize = false;
            // 
            // tbSoNuocCu
            // 
            this.tbSoNuocCu.AnimateReadOnly = false;
            this.tbSoNuocCu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSoNuocCu.Depth = 0;
            this.tbSoNuocCu.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbSoNuocCu.Hint = "Số Nước Cũ";
            this.tbSoNuocCu.LeadingIcon = null;
            this.tbSoNuocCu.Location = new System.Drawing.Point(8, 352);
            this.tbSoNuocCu.Margin = new System.Windows.Forms.Padding(4);
            this.tbSoNuocCu.MaxLength = 50;
            this.tbSoNuocCu.MouseState = MaterialSkin.MouseState.OUT;
            this.tbSoNuocCu.Multiline = false;
            this.tbSoNuocCu.Name = "tbSoNuocCu";
            this.tbSoNuocCu.Size = new System.Drawing.Size(413, 36);
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
            this.tbSoDienCu.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbSoDienCu.Hint = "Số Điện Cũ";
            this.tbSoDienCu.LeadingIcon = null;
            this.tbSoDienCu.Location = new System.Drawing.Point(8, 300);
            this.tbSoDienCu.Margin = new System.Windows.Forms.Padding(4);
            this.tbSoDienCu.MaxLength = 50;
            this.tbSoDienCu.MouseState = MaterialSkin.MouseState.OUT;
            this.tbSoDienCu.Multiline = false;
            this.tbSoDienCu.Name = "tbSoDienCu";
            this.tbSoDienCu.Size = new System.Drawing.Size(413, 36);
            this.tbSoDienCu.TabIndex = 6;
            this.tbSoDienCu.Text = "";
            this.tbSoDienCu.TrailingIcon = null;
            this.tbSoDienCu.UseTallSize = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(8, 234);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(78, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Ngày Thuê";
            // 
            // dtpNgayThue
            // 
            this.dtpNgayThue.Location = new System.Drawing.Point(8, 261);
            this.dtpNgayThue.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayThue.Name = "dtpNgayThue";
            this.dtpNgayThue.Size = new System.Drawing.Size(412, 30);
            this.dtpNgayThue.TabIndex = 4;
            // 
            // tbNguoiThue
            // 
            this.tbNguoiThue.AnimateReadOnly = false;
            this.tbNguoiThue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNguoiThue.Depth = 0;
            this.tbNguoiThue.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbNguoiThue.Hint = "Người Thuê";
            this.tbNguoiThue.LeadingIcon = null;
            this.tbNguoiThue.Location = new System.Drawing.Point(8, 186);
            this.tbNguoiThue.Margin = new System.Windows.Forms.Padding(4);
            this.tbNguoiThue.MaxLength = 50;
            this.tbNguoiThue.MouseState = MaterialSkin.MouseState.OUT;
            this.tbNguoiThue.Multiline = false;
            this.tbNguoiThue.Name = "tbNguoiThue";
            this.tbNguoiThue.Size = new System.Drawing.Size(413, 36);
            this.tbNguoiThue.TabIndex = 3;
            this.tbNguoiThue.Text = "";
            this.tbNguoiThue.TrailingIcon = null;
            this.tbNguoiThue.UseTallSize = false;
            // 
            // tbGiaPhong
            // 
            this.tbGiaPhong.AnimateReadOnly = false;
            this.tbGiaPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGiaPhong.Depth = 0;
            this.tbGiaPhong.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbGiaPhong.Hint = "Giá Phòng";
            this.tbGiaPhong.LeadingIcon = null;
            this.tbGiaPhong.Location = new System.Drawing.Point(8, 82);
            this.tbGiaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.tbGiaPhong.MaxLength = 50;
            this.tbGiaPhong.MouseState = MaterialSkin.MouseState.OUT;
            this.tbGiaPhong.Multiline = false;
            this.tbGiaPhong.Name = "tbGiaPhong";
            this.tbGiaPhong.Size = new System.Drawing.Size(413, 36);
            this.tbGiaPhong.TabIndex = 1;
            this.tbGiaPhong.Text = "";
            this.tbGiaPhong.TrailingIcon = null;
            this.tbGiaPhong.UseTallSize = false;
            // 
            // tbTenPhong
            // 
            this.tbTenPhong.AnimateReadOnly = false;
            this.tbTenPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTenPhong.Depth = 0;
            this.tbTenPhong.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbTenPhong.Hint = "Tên Phòng";
            this.tbTenPhong.LeadingIcon = null;
            this.tbTenPhong.Location = new System.Drawing.Point(8, 31);
            this.tbTenPhong.Margin = new System.Windows.Forms.Padding(4);
            this.tbTenPhong.MaxLength = 50;
            this.tbTenPhong.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTenPhong.Multiline = false;
            this.tbTenPhong.Name = "tbTenPhong";
            this.tbTenPhong.Size = new System.Drawing.Size(413, 36);
            this.tbTenPhong.TabIndex = 0;
            this.tbTenPhong.Text = "";
            this.tbTenPhong.TrailingIcon = null;
            this.tbTenPhong.UseTallSize = false;
            // 
            // FormChinhSuaPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 554);
            this.Controls.Add(this.groupBox1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormChinhSuaPhong";
            this.Padding = new System.Windows.Forms.Padding(4, 30, 4, 4);
            this.Text = "FormChinhSuaPhong";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox tbNguoiThue;
        private MaterialSkin.Controls.MaterialTextBox tbGiaPhong;
        private MaterialSkin.Controls.MaterialTextBox tbTenPhong;
        private System.Windows.Forms.DateTimePicker dtpNgayThue;
        private MaterialSkin.Controls.MaterialTextBox tbGhiChu;
        private MaterialSkin.Controls.MaterialTextBox tbSoNuocCu;
        private MaterialSkin.Controls.MaterialTextBox tbSoDienCu;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btThemPhuPhi;
        private MaterialSkin.Controls.MaterialComboBox cbPhuPhi;
        private MaterialSkin.Controls.MaterialListView lsvPhuPhi;
        private System.Windows.Forms.ColumnHeader colMaPhuPhi;
        private System.Windows.Forms.ColumnHeader colTenPhuPhi;
        private System.Windows.Forms.ColumnHeader colGiaPhuPhi;
        private MaterialSkin.Controls.MaterialButton btXoaPhuPhi;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialButton btnXoaChinhSua;
        private MaterialSkin.Controls.MaterialButton btnLuuChinhSua;
        private MaterialSkin.Controls.MaterialTextBox tbTrangThai;
    }
}