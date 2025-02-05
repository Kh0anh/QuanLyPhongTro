namespace QuanLyPhongTro.Forms
{
    partial class FormThemPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemPhong));
            this.btnHuy = new MaterialSkin.Controls.MaterialButton();
            this.grpPhuPhi = new System.Windows.Forms.GroupBox();
            this.lstPhuPhi = new MaterialSkin.Controls.MaterialListView();
            this.colMaPhuPhi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenPhuPhi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGiaPhuPhi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXoa = new MaterialSkin.Controls.MaterialButton();
            this.cbPhuPhi = new MaterialSkin.Controls.MaterialComboBox();
            this.btnThemPhuPhi = new MaterialSkin.Controls.MaterialButton();
            this.btnThemPhong = new MaterialSkin.Controls.MaterialButton();
            this.txtGhiChu = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSoNuocCu = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSoDienCu = new MaterialSkin.Controls.MaterialTextBox();
            this.txtGiaPhong = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTenPhong = new MaterialSkin.Controls.MaterialTextBox();
            this.grpThemPhong = new System.Windows.Forms.GroupBox();
            this.grpPhuPhi.SuspendLayout();
            this.grpThemPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHuy.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHuy.Depth = 0;
            this.btnHuy.HighEmphasis = true;
            this.btnHuy.Icon = null;
            this.btnHuy.Location = new System.Drawing.Point(525, 260);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHuy.Size = new System.Drawing.Size(73, 36);
            this.btnHuy.TabIndex = 13;
            this.btnHuy.Text = "Hủy Bỏ";
            this.btnHuy.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHuy.UseAccentColor = true;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // grpPhuPhi
            // 
            this.grpPhuPhi.Controls.Add(this.lstPhuPhi);
            this.grpPhuPhi.Controls.Add(this.btnXoa);
            this.grpPhuPhi.Controls.Add(this.cbPhuPhi);
            this.grpPhuPhi.Controls.Add(this.btnThemPhuPhi);
            this.grpPhuPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPhuPhi.Location = new System.Drawing.Point(322, 12);
            this.grpPhuPhi.Name = "grpPhuPhi";
            this.grpPhuPhi.Size = new System.Drawing.Size(400, 239);
            this.grpPhuPhi.TabIndex = 13;
            this.grpPhuPhi.TabStop = false;
            this.grpPhuPhi.Text = "Phụ phí";
            // 
            // lstPhuPhi
            // 
            this.lstPhuPhi.AutoSizeTable = false;
            this.lstPhuPhi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstPhuPhi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPhuPhi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaPhuPhi,
            this.colTenPhuPhi,
            this.colGiaPhuPhi});
            this.lstPhuPhi.Depth = 0;
            this.lstPhuPhi.FullRowSelect = true;
            this.lstPhuPhi.HideSelection = false;
            this.lstPhuPhi.Location = new System.Drawing.Point(6, 65);
            this.lstPhuPhi.MinimumSize = new System.Drawing.Size(200, 100);
            this.lstPhuPhi.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lstPhuPhi.MouseState = MaterialSkin.MouseState.OUT;
            this.lstPhuPhi.Name = "lstPhuPhi";
            this.lstPhuPhi.OwnerDraw = true;
            this.lstPhuPhi.Size = new System.Drawing.Size(388, 174);
            this.lstPhuPhi.TabIndex = 9;
            this.lstPhuPhi.UseCompatibleStateImageBehavior = false;
            this.lstPhuPhi.View = System.Windows.Forms.View.Details;
            // 
            // colMaPhuPhi
            // 
            this.colMaPhuPhi.Text = "Mã";
            // 
            // colTenPhuPhi
            // 
            this.colTenPhuPhi.Text = "Phụ phí";
            this.colTenPhuPhi.Width = 140;
            // 
            // colGiaPhuPhi
            // 
            this.colGiaPhuPhi.Text = "Giá";
            this.colGiaPhuPhi.Width = 140;
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXoa.Depth = 0;
            this.btnXoa.HighEmphasis = true;
            this.btnXoa.Icon = null;
            this.btnXoa.Location = new System.Drawing.Point(329, 20);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoa.Size = new System.Drawing.Size(64, 36);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXoa.UseAccentColor = true;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.cbPhuPhi.IntegralHeight = false;
            this.cbPhuPhi.ItemHeight = 29;
            this.cbPhuPhi.Location = new System.Drawing.Point(6, 20);
            this.cbPhuPhi.MaxDropDownItems = 4;
            this.cbPhuPhi.MouseState = MaterialSkin.MouseState.OUT;
            this.cbPhuPhi.Name = "cbPhuPhi";
            this.cbPhuPhi.Size = new System.Drawing.Size(244, 35);
            this.cbPhuPhi.StartIndex = 0;
            this.cbPhuPhi.TabIndex = 10;
            this.cbPhuPhi.UseTallSize = false;
            // 
            // btnThemPhuPhi
            // 
            this.btnThemPhuPhi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemPhuPhi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThemPhuPhi.Depth = 0;
            this.btnThemPhuPhi.HighEmphasis = true;
            this.btnThemPhuPhi.Icon = null;
            this.btnThemPhuPhi.Location = new System.Drawing.Point(257, 20);
            this.btnThemPhuPhi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThemPhuPhi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemPhuPhi.Name = "btnThemPhuPhi";
            this.btnThemPhuPhi.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThemPhuPhi.Size = new System.Drawing.Size(64, 36);
            this.btnThemPhuPhi.TabIndex = 11;
            this.btnThemPhuPhi.Text = "Thêm";
            this.btnThemPhuPhi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThemPhuPhi.UseAccentColor = false;
            this.btnThemPhuPhi.UseVisualStyleBackColor = true;
            this.btnThemPhuPhi.Click += new System.EventHandler(this.btnThemPhuPhi_Click);
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemPhong.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThemPhong.Depth = 0;
            this.btnThemPhong.HighEmphasis = true;
            this.btnThemPhong.Icon = null;
            this.btnThemPhong.Location = new System.Drawing.Point(606, 260);
            this.btnThemPhong.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThemPhong.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThemPhong.Size = new System.Drawing.Size(116, 36);
            this.btnThemPhong.TabIndex = 13;
            this.btnThemPhong.Text = "Thêm Phòng";
            this.btnThemPhong.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThemPhong.UseAccentColor = false;
            this.btnThemPhong.UseVisualStyleBackColor = true;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.AnimateReadOnly = false;
            this.txtGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGhiChu.Depth = 0;
            this.txtGhiChu.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtGhiChu.Hint = "Ghi chú";
            this.txtGhiChu.LeadingIcon = null;
            this.txtGhiChu.Location = new System.Drawing.Point(6, 246);
            this.txtGhiChu.MaxLength = 50;
            this.txtGhiChu.MouseState = MaterialSkin.MouseState.OUT;
            this.txtGhiChu.Multiline = false;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(310, 50);
            this.txtGhiChu.TabIndex = 8;
            this.txtGhiChu.Text = "";
            this.txtGhiChu.TrailingIcon = null;
            // 
            // txtSoNuocCu
            // 
            this.txtSoNuocCu.AnimateReadOnly = false;
            this.txtSoNuocCu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoNuocCu.Depth = 0;
            this.txtSoNuocCu.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSoNuocCu.Hint = "Số nước cũ";
            this.txtSoNuocCu.LeadingIcon = null;
            this.txtSoNuocCu.Location = new System.Drawing.Point(6, 190);
            this.txtSoNuocCu.MaxLength = 50;
            this.txtSoNuocCu.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSoNuocCu.Multiline = false;
            this.txtSoNuocCu.Name = "txtSoNuocCu";
            this.txtSoNuocCu.Size = new System.Drawing.Size(310, 50);
            this.txtSoNuocCu.TabIndex = 7;
            this.txtSoNuocCu.Text = "";
            this.txtSoNuocCu.TrailingIcon = null;
            // 
            // txtSoDienCu
            // 
            this.txtSoDienCu.AnimateReadOnly = false;
            this.txtSoDienCu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoDienCu.Depth = 0;
            this.txtSoDienCu.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSoDienCu.Hint = "Số điện cũ";
            this.txtSoDienCu.LeadingIcon = null;
            this.txtSoDienCu.Location = new System.Drawing.Point(6, 134);
            this.txtSoDienCu.MaxLength = 50;
            this.txtSoDienCu.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSoDienCu.Multiline = false;
            this.txtSoDienCu.Name = "txtSoDienCu";
            this.txtSoDienCu.Size = new System.Drawing.Size(310, 50);
            this.txtSoDienCu.TabIndex = 6;
            this.txtSoDienCu.Text = "";
            this.txtSoDienCu.TrailingIcon = null;
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.AnimateReadOnly = false;
            this.txtGiaPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGiaPhong.Depth = 0;
            this.txtGiaPhong.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtGiaPhong.Hint = "Giá phòng";
            this.txtGiaPhong.LeadingIcon = null;
            this.txtGiaPhong.Location = new System.Drawing.Point(6, 78);
            this.txtGiaPhong.MaxLength = 50;
            this.txtGiaPhong.MouseState = MaterialSkin.MouseState.OUT;
            this.txtGiaPhong.Multiline = false;
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.Size = new System.Drawing.Size(310, 50);
            this.txtGiaPhong.TabIndex = 1;
            this.txtGiaPhong.Text = "";
            this.txtGiaPhong.TrailingIcon = null;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.AnimateReadOnly = false;
            this.txtTenPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenPhong.Depth = 0;
            this.txtTenPhong.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTenPhong.Hint = "Tên phòng";
            this.txtTenPhong.LeadingIcon = null;
            this.txtTenPhong.Location = new System.Drawing.Point(6, 25);
            this.txtTenPhong.MaxLength = 50;
            this.txtTenPhong.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTenPhong.Multiline = false;
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(310, 50);
            this.txtTenPhong.TabIndex = 0;
            this.txtTenPhong.Text = "";
            this.txtTenPhong.TrailingIcon = null;
            // 
            // grpThemPhong
            // 
            this.grpThemPhong.Controls.Add(this.btnHuy);
            this.grpThemPhong.Controls.Add(this.btnThemPhong);
            this.grpThemPhong.Controls.Add(this.grpPhuPhi);
            this.grpThemPhong.Controls.Add(this.txtGhiChu);
            this.grpThemPhong.Controls.Add(this.txtSoNuocCu);
            this.grpThemPhong.Controls.Add(this.txtSoDienCu);
            this.grpThemPhong.Controls.Add(this.txtGiaPhong);
            this.grpThemPhong.Controls.Add(this.txtTenPhong);
            this.grpThemPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThemPhong.Location = new System.Drawing.Point(6, 27);
            this.grpThemPhong.Name = "grpThemPhong";
            this.grpThemPhong.Size = new System.Drawing.Size(728, 305);
            this.grpThemPhong.TabIndex = 1;
            this.grpThemPhong.TabStop = false;
            this.grpThemPhong.Text = "Thêm phòng";
            // 
            // FormThemPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 338);
            this.Controls.Add(this.grpThemPhong);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormThemPhong";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "FormThemPhong";
            this.Load += new System.EventHandler(this.FormThemPhong_Load);
            this.grpPhuPhi.ResumeLayout(false);
            this.grpPhuPhi.PerformLayout();
            this.grpThemPhong.ResumeLayout(false);
            this.grpThemPhong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnHuy;
        private System.Windows.Forms.GroupBox grpPhuPhi;
        private MaterialSkin.Controls.MaterialListView lstPhuPhi;
        private System.Windows.Forms.ColumnHeader colMaPhuPhi;
        private System.Windows.Forms.ColumnHeader colTenPhuPhi;
        private System.Windows.Forms.ColumnHeader colGiaPhuPhi;
        private MaterialSkin.Controls.MaterialButton btnXoa;
        private MaterialSkin.Controls.MaterialComboBox cbPhuPhi;
        private MaterialSkin.Controls.MaterialButton btnThemPhuPhi;
        private MaterialSkin.Controls.MaterialButton btnThemPhong;
        private MaterialSkin.Controls.MaterialTextBox txtGhiChu;
        private MaterialSkin.Controls.MaterialTextBox txtSoNuocCu;
        private MaterialSkin.Controls.MaterialTextBox txtSoDienCu;
        private MaterialSkin.Controls.MaterialTextBox txtGiaPhong;
        private MaterialSkin.Controls.MaterialTextBox txtTenPhong;
        private System.Windows.Forms.GroupBox grpThemPhong;
    }
}