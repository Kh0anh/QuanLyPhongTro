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
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.colMaPhuPhi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenPhuPhi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGiaPhuPhi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btXoaPhuPhi = new MaterialSkin.Controls.MaterialButton();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.btThemPhuPhi = new MaterialSkin.Controls.MaterialButton();
            this.mtbGhiChu = new MaterialSkin.Controls.MaterialTextBox();
            this.mtbSoNuocCu = new MaterialSkin.Controls.MaterialTextBox();
            this.mtbSoDienCu = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpNgayThue = new System.Windows.Forms.DateTimePicker();
            this.mtbNguoiThue = new MaterialSkin.Controls.MaterialTextBox();
            this.tbGiaPhong = new MaterialSkin.Controls.MaterialTextBox();
            this.tbTenPhong = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTrangThai);
            this.groupBox1.Controls.Add(this.materialButton4);
            this.groupBox1.Controls.Add(this.materialButton3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.mtbGhiChu);
            this.groupBox1.Controls.Add(this.mtbSoNuocCu);
            this.groupBox1.Controls.Add(this.mtbSoDienCu);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.dtpNgayThue);
            this.groupBox1.Controls.Add(this.mtbNguoiThue);
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
            // materialButton4
            // 
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.Location = new System.Drawing.Point(601, 459);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton4.Size = new System.Drawing.Size(132, 36);
            this.materialButton4.TabIndex = 13;
            this.materialButton4.Text = "Xoá Chỉnh Sửa";
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = true;
            this.materialButton4.UseVisualStyleBackColor = true;
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(788, 459);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(131, 36);
            this.materialButton3.TabIndex = 13;
            this.materialButton3.Text = "Lưu Chỉnh Sửa";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.materialListView1);
            this.groupBox2.Controls.Add(this.btXoaPhuPhi);
            this.groupBox2.Controls.Add(this.materialComboBox1);
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
            // materialListView1
            // 
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaPhuPhi,
            this.colTenPhuPhi,
            this.colGiaPhuPhi});
            this.materialListView1.Depth = 0;
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(8, 81);
            this.materialListView1.Margin = new System.Windows.Forms.Padding(4);
            this.materialListView1.MinimumSize = new System.Drawing.Size(267, 123);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(517, 293);
            this.materialListView1.TabIndex = 9;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
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
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 118;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.Hint = "Phụ Phí";
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 29;
            this.materialComboBox1.Location = new System.Drawing.Point(8, 31);
            this.materialComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(324, 35);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 10;
            this.materialComboBox1.UseTallSize = false;
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
            // mtbGhiChu
            // 
            this.mtbGhiChu.AnimateReadOnly = false;
            this.mtbGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbGhiChu.Depth = 0;
            this.mtbGhiChu.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbGhiChu.Hint = "Ghi Chú";
            this.mtbGhiChu.LeadingIcon = null;
            this.mtbGhiChu.Location = new System.Drawing.Point(8, 404);
            this.mtbGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.mtbGhiChu.MaxLength = 50;
            this.mtbGhiChu.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbGhiChu.Multiline = false;
            this.mtbGhiChu.Name = "mtbGhiChu";
            this.mtbGhiChu.Size = new System.Drawing.Size(955, 36);
            this.mtbGhiChu.TabIndex = 8;
            this.mtbGhiChu.Text = "";
            this.mtbGhiChu.TrailingIcon = null;
            this.mtbGhiChu.UseTallSize = false;
            // 
            // mtbSoNuocCu
            // 
            this.mtbSoNuocCu.AnimateReadOnly = false;
            this.mtbSoNuocCu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbSoNuocCu.Depth = 0;
            this.mtbSoNuocCu.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbSoNuocCu.Hint = "Số Nước Cũ";
            this.mtbSoNuocCu.LeadingIcon = null;
            this.mtbSoNuocCu.Location = new System.Drawing.Point(8, 352);
            this.mtbSoNuocCu.Margin = new System.Windows.Forms.Padding(4);
            this.mtbSoNuocCu.MaxLength = 50;
            this.mtbSoNuocCu.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbSoNuocCu.Multiline = false;
            this.mtbSoNuocCu.Name = "mtbSoNuocCu";
            this.mtbSoNuocCu.Size = new System.Drawing.Size(413, 36);
            this.mtbSoNuocCu.TabIndex = 7;
            this.mtbSoNuocCu.Text = "";
            this.mtbSoNuocCu.TrailingIcon = null;
            this.mtbSoNuocCu.UseTallSize = false;
            // 
            // mtbSoDienCu
            // 
            this.mtbSoDienCu.AnimateReadOnly = false;
            this.mtbSoDienCu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbSoDienCu.Depth = 0;
            this.mtbSoDienCu.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbSoDienCu.Hint = "Số Điện Cũ";
            this.mtbSoDienCu.LeadingIcon = null;
            this.mtbSoDienCu.Location = new System.Drawing.Point(8, 300);
            this.mtbSoDienCu.Margin = new System.Windows.Forms.Padding(4);
            this.mtbSoDienCu.MaxLength = 50;
            this.mtbSoDienCu.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbSoDienCu.Multiline = false;
            this.mtbSoDienCu.Name = "mtbSoDienCu";
            this.mtbSoDienCu.Size = new System.Drawing.Size(413, 36);
            this.mtbSoDienCu.TabIndex = 6;
            this.mtbSoDienCu.Text = "";
            this.mtbSoDienCu.TrailingIcon = null;
            this.mtbSoDienCu.UseTallSize = false;
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
            // mtbNguoiThue
            // 
            this.mtbNguoiThue.AnimateReadOnly = false;
            this.mtbNguoiThue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbNguoiThue.Depth = 0;
            this.mtbNguoiThue.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbNguoiThue.Hint = "Người Thuê";
            this.mtbNguoiThue.LeadingIcon = null;
            this.mtbNguoiThue.Location = new System.Drawing.Point(8, 186);
            this.mtbNguoiThue.Margin = new System.Windows.Forms.Padding(4);
            this.mtbNguoiThue.MaxLength = 50;
            this.mtbNguoiThue.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbNguoiThue.Multiline = false;
            this.mtbNguoiThue.Name = "mtbNguoiThue";
            this.mtbNguoiThue.Size = new System.Drawing.Size(413, 36);
            this.mtbNguoiThue.TabIndex = 3;
            this.mtbNguoiThue.Text = "";
            this.mtbNguoiThue.TrailingIcon = null;
            this.mtbNguoiThue.UseTallSize = false;
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
        private MaterialSkin.Controls.MaterialTextBox mtbNguoiThue;
        private MaterialSkin.Controls.MaterialTextBox tbGiaPhong;
        private MaterialSkin.Controls.MaterialTextBox tbTenPhong;
        private System.Windows.Forms.DateTimePicker dtpNgayThue;
        private MaterialSkin.Controls.MaterialTextBox mtbGhiChu;
        private MaterialSkin.Controls.MaterialTextBox mtbSoNuocCu;
        private MaterialSkin.Controls.MaterialTextBox mtbSoDienCu;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btThemPhuPhi;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader colMaPhuPhi;
        private System.Windows.Forms.ColumnHeader colTenPhuPhi;
        private System.Windows.Forms.ColumnHeader colGiaPhuPhi;
        private MaterialSkin.Controls.MaterialButton btXoaPhuPhi;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialTextBox tbTrangThai;
    }
}