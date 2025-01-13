namespace QuanLyPhongTro.Forms
{
    partial class FormHoaDon
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
            this.tbTenPhong = new MaterialSkin.Controls.MaterialTextBox();
            this.tbKhachThue = new MaterialSkin.Controls.MaterialTextBox();
            this.tbTTienPhong = new MaterialSkin.Controls.MaterialTextBox();
            this.tbSoDien = new MaterialSkin.Controls.MaterialTextBox();
            this.tbGiaDien = new MaterialSkin.Controls.MaterialTextBox();
            this.tbTienDien = new MaterialSkin.Controls.MaterialTextBox();
            this.tbGiaNuoc = new MaterialSkin.Controls.MaterialTextBox();
            this.tbTienNuoc = new MaterialSkin.Controls.MaterialTextBox();
            this.tbSoNuoc = new MaterialSkin.Controls.MaterialTextBox();
            this.tbTongTienPhuPhi = new MaterialSkin.Controls.MaterialTextBox();
            this.tbTongTien = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTongTien);
            this.groupBox1.Controls.Add(this.tbTongTienPhuPhi);
            this.groupBox1.Controls.Add(this.tbSoNuoc);
            this.groupBox1.Controls.Add(this.tbTienNuoc);
            this.groupBox1.Controls.Add(this.tbGiaNuoc);
            this.groupBox1.Controls.Add(this.tbTienDien);
            this.groupBox1.Controls.Add(this.tbGiaDien);
            this.groupBox1.Controls.Add(this.tbSoDien);
            this.groupBox1.Controls.Add(this.tbTTienPhong);
            this.groupBox1.Controls.Add(this.tbKhachThue);
            this.groupBox1.Controls.Add(this.tbTenPhong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 319);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hoá Đơn";
            // 
            // tbTenPhong
            // 
            this.tbTenPhong.AnimateReadOnly = false;
            this.tbTenPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTenPhong.Depth = 0;
            this.tbTenPhong.Enabled = false;
            this.tbTenPhong.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbTenPhong.Hint = "Tên Phòng";
            this.tbTenPhong.LeadingIcon = null;
            this.tbTenPhong.Location = new System.Drawing.Point(6, 23);
            this.tbTenPhong.MaxLength = 50;
            this.tbTenPhong.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTenPhong.Multiline = false;
            this.tbTenPhong.Name = "tbTenPhong";
            this.tbTenPhong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbTenPhong.Size = new System.Drawing.Size(402, 36);
            this.tbTenPhong.TabIndex = 1;
            this.tbTenPhong.Text = "";
            this.tbTenPhong.TrailingIcon = null;
            this.tbTenPhong.UseTallSize = false;
            // 
            // tbKhachThue
            // 
            this.tbKhachThue.AnimateReadOnly = false;
            this.tbKhachThue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbKhachThue.Depth = 0;
            this.tbKhachThue.Enabled = false;
            this.tbKhachThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbKhachThue.Hint = "Khách Thuê";
            this.tbKhachThue.LeadingIcon = null;
            this.tbKhachThue.Location = new System.Drawing.Point(6, 65);
            this.tbKhachThue.MaxLength = 50;
            this.tbKhachThue.MouseState = MaterialSkin.MouseState.OUT;
            this.tbKhachThue.Multiline = false;
            this.tbKhachThue.Name = "tbKhachThue";
            this.tbKhachThue.Size = new System.Drawing.Size(402, 36);
            this.tbKhachThue.TabIndex = 2;
            this.tbKhachThue.Text = "";
            this.tbKhachThue.TrailingIcon = null;
            this.tbKhachThue.UseTallSize = false;
            // 
            // tbTTienPhong
            // 
            this.tbTTienPhong.AnimateReadOnly = false;
            this.tbTTienPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTTienPhong.Depth = 0;
            this.tbTTienPhong.Enabled = false;
            this.tbTTienPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbTTienPhong.Hint = "Tiền Phòng";
            this.tbTTienPhong.LeadingIcon = null;
            this.tbTTienPhong.Location = new System.Drawing.Point(6, 107);
            this.tbTTienPhong.MaxLength = 50;
            this.tbTTienPhong.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTTienPhong.Multiline = false;
            this.tbTTienPhong.Name = "tbTTienPhong";
            this.tbTTienPhong.Size = new System.Drawing.Size(402, 36);
            this.tbTTienPhong.TabIndex = 3;
            this.tbTTienPhong.Text = "";
            this.tbTTienPhong.TrailingIcon = null;
            this.tbTTienPhong.UseTallSize = false;
            // 
            // tbSoDien
            // 
            this.tbSoDien.AnimateReadOnly = false;
            this.tbSoDien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSoDien.Depth = 0;
            this.tbSoDien.Enabled = false;
            this.tbSoDien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbSoDien.Hint = "Số Điện";
            this.tbSoDien.LeadingIcon = null;
            this.tbSoDien.Location = new System.Drawing.Point(6, 149);
            this.tbSoDien.MaxLength = 50;
            this.tbSoDien.MouseState = MaterialSkin.MouseState.OUT;
            this.tbSoDien.Multiline = false;
            this.tbSoDien.Name = "tbSoDien";
            this.tbSoDien.Size = new System.Drawing.Size(130, 36);
            this.tbSoDien.TabIndex = 4;
            this.tbSoDien.Text = "";
            this.tbSoDien.TrailingIcon = null;
            this.tbSoDien.UseTallSize = false;
            // 
            // tbGiaDien
            // 
            this.tbGiaDien.AnimateReadOnly = false;
            this.tbGiaDien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGiaDien.Depth = 0;
            this.tbGiaDien.Enabled = false;
            this.tbGiaDien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbGiaDien.Hint = "Giá Điện";
            this.tbGiaDien.LeadingIcon = null;
            this.tbGiaDien.Location = new System.Drawing.Point(142, 149);
            this.tbGiaDien.MaxLength = 50;
            this.tbGiaDien.MouseState = MaterialSkin.MouseState.OUT;
            this.tbGiaDien.Multiline = false;
            this.tbGiaDien.Name = "tbGiaDien";
            this.tbGiaDien.Size = new System.Drawing.Size(130, 36);
            this.tbGiaDien.TabIndex = 5;
            this.tbGiaDien.Text = "";
            this.tbGiaDien.TrailingIcon = null;
            this.tbGiaDien.UseTallSize = false;
            // 
            // tbTienDien
            // 
            this.tbTienDien.AnimateReadOnly = false;
            this.tbTienDien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTienDien.Depth = 0;
            this.tbTienDien.Enabled = false;
            this.tbTienDien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbTienDien.Hint = "Tiền Điện";
            this.tbTienDien.LeadingIcon = null;
            this.tbTienDien.Location = new System.Drawing.Point(278, 149);
            this.tbTienDien.MaxLength = 50;
            this.tbTienDien.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTienDien.Multiline = false;
            this.tbTienDien.Name = "tbTienDien";
            this.tbTienDien.Size = new System.Drawing.Size(130, 36);
            this.tbTienDien.TabIndex = 6;
            this.tbTienDien.Text = "";
            this.tbTienDien.TrailingIcon = null;
            this.tbTienDien.UseTallSize = false;
            // 
            // tbGiaNuoc
            // 
            this.tbGiaNuoc.AnimateReadOnly = false;
            this.tbGiaNuoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGiaNuoc.Depth = 0;
            this.tbGiaNuoc.Enabled = false;
            this.tbGiaNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbGiaNuoc.Hint = "Giá Nước";
            this.tbGiaNuoc.LeadingIcon = null;
            this.tbGiaNuoc.Location = new System.Drawing.Point(142, 191);
            this.tbGiaNuoc.MaxLength = 50;
            this.tbGiaNuoc.MouseState = MaterialSkin.MouseState.OUT;
            this.tbGiaNuoc.Multiline = false;
            this.tbGiaNuoc.Name = "tbGiaNuoc";
            this.tbGiaNuoc.Size = new System.Drawing.Size(130, 36);
            this.tbGiaNuoc.TabIndex = 7;
            this.tbGiaNuoc.Text = "";
            this.tbGiaNuoc.TrailingIcon = null;
            this.tbGiaNuoc.UseTallSize = false;
            // 
            // tbTienNuoc
            // 
            this.tbTienNuoc.AnimateReadOnly = false;
            this.tbTienNuoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTienNuoc.Depth = 0;
            this.tbTienNuoc.Enabled = false;
            this.tbTienNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbTienNuoc.Hint = "Tiền Nước";
            this.tbTienNuoc.LeadingIcon = null;
            this.tbTienNuoc.Location = new System.Drawing.Point(278, 191);
            this.tbTienNuoc.MaxLength = 50;
            this.tbTienNuoc.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTienNuoc.Multiline = false;
            this.tbTienNuoc.Name = "tbTienNuoc";
            this.tbTienNuoc.Size = new System.Drawing.Size(130, 36);
            this.tbTienNuoc.TabIndex = 8;
            this.tbTienNuoc.Text = "";
            this.tbTienNuoc.TrailingIcon = null;
            this.tbTienNuoc.UseTallSize = false;
            // 
            // tbSoNuoc
            // 
            this.tbSoNuoc.AnimateReadOnly = false;
            this.tbSoNuoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSoNuoc.Depth = 0;
            this.tbSoNuoc.Enabled = false;
            this.tbSoNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbSoNuoc.Hint = "Số Nước";
            this.tbSoNuoc.LeadingIcon = null;
            this.tbSoNuoc.Location = new System.Drawing.Point(6, 191);
            this.tbSoNuoc.MaxLength = 50;
            this.tbSoNuoc.MouseState = MaterialSkin.MouseState.OUT;
            this.tbSoNuoc.Multiline = false;
            this.tbSoNuoc.Name = "tbSoNuoc";
            this.tbSoNuoc.Size = new System.Drawing.Size(130, 36);
            this.tbSoNuoc.TabIndex = 9;
            this.tbSoNuoc.Text = "";
            this.tbSoNuoc.TrailingIcon = null;
            this.tbSoNuoc.UseTallSize = false;
            // 
            // tbTongTienPhuPhi
            // 
            this.tbTongTienPhuPhi.AnimateReadOnly = false;
            this.tbTongTienPhuPhi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTongTienPhuPhi.Depth = 0;
            this.tbTongTienPhuPhi.Enabled = false;
            this.tbTongTienPhuPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbTongTienPhuPhi.Hint = "Tổng Tiền Phụ Phí";
            this.tbTongTienPhuPhi.LeadingIcon = null;
            this.tbTongTienPhuPhi.Location = new System.Drawing.Point(6, 233);
            this.tbTongTienPhuPhi.MaxLength = 50;
            this.tbTongTienPhuPhi.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTongTienPhuPhi.Multiline = false;
            this.tbTongTienPhuPhi.Name = "tbTongTienPhuPhi";
            this.tbTongTienPhuPhi.Size = new System.Drawing.Size(402, 36);
            this.tbTongTienPhuPhi.TabIndex = 10;
            this.tbTongTienPhuPhi.Text = "";
            this.tbTongTienPhuPhi.TrailingIcon = null;
            this.tbTongTienPhuPhi.UseTallSize = false;
            // 
            // tbTongTien
            // 
            this.tbTongTien.AnimateReadOnly = false;
            this.tbTongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTongTien.Depth = 0;
            this.tbTongTien.Enabled = false;
            this.tbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbTongTien.Hint = "Tổng Tiền";
            this.tbTongTien.LeadingIcon = null;
            this.tbTongTien.Location = new System.Drawing.Point(6, 275);
            this.tbTongTien.MaxLength = 50;
            this.tbTongTien.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTongTien.Multiline = false;
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.Size = new System.Drawing.Size(402, 36);
            this.tbTongTien.TabIndex = 11;
            this.tbTongTien.Text = "";
            this.tbTongTien.TrailingIcon = null;
            this.tbTongTien.UseTallSize = false;
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 353);
            this.Controls.Add(this.groupBox1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "FormHoaDon";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "FormHoaDon";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox tbSoDien;
        private MaterialSkin.Controls.MaterialTextBox tbTTienPhong;
        private MaterialSkin.Controls.MaterialTextBox tbKhachThue;
        private MaterialSkin.Controls.MaterialTextBox tbTenPhong;
        private MaterialSkin.Controls.MaterialTextBox tbGiaDien;
        private MaterialSkin.Controls.MaterialTextBox tbTienDien;
        private MaterialSkin.Controls.MaterialTextBox tbTongTien;
        private MaterialSkin.Controls.MaterialTextBox tbTongTienPhuPhi;
        private MaterialSkin.Controls.MaterialTextBox tbSoNuoc;
        private MaterialSkin.Controls.MaterialTextBox tbTienNuoc;
        private MaterialSkin.Controls.MaterialTextBox tbGiaNuoc;
    }
}