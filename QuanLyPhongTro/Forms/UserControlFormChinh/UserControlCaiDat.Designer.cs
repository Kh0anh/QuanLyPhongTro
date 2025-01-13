namespace QuanLyPhongTro.Forms.UserControlFormChinh
{
    partial class UserControlCaiDat
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbGiaDien = new MaterialSkin.Controls.MaterialTextBox();
            this.tbGiaNuoc = new MaterialSkin.Controls.MaterialTextBox();
            this.btCapNhatGiaDienNuoc = new MaterialSkin.Controls.MaterialButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvPhuPhi = new MaterialSkin.Controls.MaterialListView();
            this.colMaPhuPhi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenPhuPhi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGiaPhuPhi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbGiaPhuPhi = new MaterialSkin.Controls.MaterialTextBox();
            this.btThemPhuPhi = new MaterialSkin.Controls.MaterialButton();
            this.tbTenPhuPhi = new MaterialSkin.Controls.MaterialTextBox();
            this.btXoaPhuPhi = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btCapNhatGiaDienNuoc);
            this.groupBox1.Controls.Add(this.tbGiaNuoc);
            this.groupBox1.Controls.Add(this.tbGiaDien);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giá Điện Nước";
            // 
            // tbGiaDien
            // 
            this.tbGiaDien.AnimateReadOnly = false;
            this.tbGiaDien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGiaDien.Depth = 0;
            this.tbGiaDien.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbGiaDien.Hint = "Giá Điện";
            this.tbGiaDien.LeadingIcon = null;
            this.tbGiaDien.Location = new System.Drawing.Point(6, 23);
            this.tbGiaDien.MaxLength = 50;
            this.tbGiaDien.MouseState = MaterialSkin.MouseState.OUT;
            this.tbGiaDien.Multiline = false;
            this.tbGiaDien.Name = "tbGiaDien";
            this.tbGiaDien.Size = new System.Drawing.Size(160, 36);
            this.tbGiaDien.TabIndex = 0;
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
            this.tbGiaNuoc.Location = new System.Drawing.Point(6, 65);
            this.tbGiaNuoc.MaxLength = 50;
            this.tbGiaNuoc.MouseState = MaterialSkin.MouseState.OUT;
            this.tbGiaNuoc.Multiline = false;
            this.tbGiaNuoc.Name = "tbGiaNuoc";
            this.tbGiaNuoc.Size = new System.Drawing.Size(160, 36);
            this.tbGiaNuoc.TabIndex = 1;
            this.tbGiaNuoc.Text = "";
            this.tbGiaNuoc.TrailingIcon = null;
            this.tbGiaNuoc.UseTallSize = false;
            // 
            // btCapNhatGiaDienNuoc
            // 
            this.btCapNhatGiaDienNuoc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCapNhatGiaDienNuoc.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btCapNhatGiaDienNuoc.Depth = 0;
            this.btCapNhatGiaDienNuoc.HighEmphasis = true;
            this.btCapNhatGiaDienNuoc.Icon = null;
            this.btCapNhatGiaDienNuoc.Location = new System.Drawing.Point(73, 110);
            this.btCapNhatGiaDienNuoc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btCapNhatGiaDienNuoc.MouseState = MaterialSkin.MouseState.HOVER;
            this.btCapNhatGiaDienNuoc.Name = "btCapNhatGiaDienNuoc";
            this.btCapNhatGiaDienNuoc.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btCapNhatGiaDienNuoc.Size = new System.Drawing.Size(93, 36);
            this.btCapNhatGiaDienNuoc.TabIndex = 3;
            this.btCapNhatGiaDienNuoc.Text = "Cập Nhật";
            this.btCapNhatGiaDienNuoc.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btCapNhatGiaDienNuoc.UseAccentColor = true;
            this.btCapNhatGiaDienNuoc.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btXoaPhuPhi);
            this.groupBox2.Controls.Add(this.tbTenPhuPhi);
            this.groupBox2.Controls.Add(this.btThemPhuPhi);
            this.groupBox2.Controls.Add(this.tbGiaPhuPhi);
            this.groupBox2.Controls.Add(this.lvPhuPhi);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(184, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 393);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phụ Phí";
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
            this.lvPhuPhi.Location = new System.Drawing.Point(6, 106);
            this.lvPhuPhi.MinimumSize = new System.Drawing.Size(200, 100);
            this.lvPhuPhi.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvPhuPhi.MouseState = MaterialSkin.MouseState.OUT;
            this.lvPhuPhi.Name = "lvPhuPhi";
            this.lvPhuPhi.OwnerDraw = true;
            this.lvPhuPhi.Size = new System.Drawing.Size(469, 281);
            this.lvPhuPhi.TabIndex = 10;
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
            this.colTenPhuPhi.Width = 180;
            // 
            // colGiaPhuPhi
            // 
            this.colGiaPhuPhi.Text = "Giá";
            this.colGiaPhuPhi.Width = 180;
            // 
            // tbGiaPhuPhi
            // 
            this.tbGiaPhuPhi.AnimateReadOnly = false;
            this.tbGiaPhuPhi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGiaPhuPhi.Depth = 0;
            this.tbGiaPhuPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbGiaPhuPhi.Hint = "Giá Phụ Phí";
            this.tbGiaPhuPhi.LeadingIcon = null;
            this.tbGiaPhuPhi.Location = new System.Drawing.Point(6, 64);
            this.tbGiaPhuPhi.MaxLength = 50;
            this.tbGiaPhuPhi.MouseState = MaterialSkin.MouseState.OUT;
            this.tbGiaPhuPhi.Multiline = false;
            this.tbGiaPhuPhi.Name = "tbGiaPhuPhi";
            this.tbGiaPhuPhi.Size = new System.Drawing.Size(220, 36);
            this.tbGiaPhuPhi.TabIndex = 4;
            this.tbGiaPhuPhi.Text = "";
            this.tbGiaPhuPhi.TrailingIcon = null;
            this.tbGiaPhuPhi.UseTallSize = false;
            // 
            // btThemPhuPhi
            // 
            this.btThemPhuPhi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btThemPhuPhi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btThemPhuPhi.Depth = 0;
            this.btThemPhuPhi.HighEmphasis = true;
            this.btThemPhuPhi.Icon = null;
            this.btThemPhuPhi.Location = new System.Drawing.Point(233, 64);
            this.btThemPhuPhi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btThemPhuPhi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btThemPhuPhi.Name = "btThemPhuPhi";
            this.btThemPhuPhi.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btThemPhuPhi.Size = new System.Drawing.Size(123, 36);
            this.btThemPhuPhi.TabIndex = 4;
            this.btThemPhuPhi.Text = "Thêm Phụ Phí";
            this.btThemPhuPhi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btThemPhuPhi.UseAccentColor = false;
            this.btThemPhuPhi.UseVisualStyleBackColor = true;
            // 
            // tbTenPhuPhi
            // 
            this.tbTenPhuPhi.AnimateReadOnly = false;
            this.tbTenPhuPhi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTenPhuPhi.Depth = 0;
            this.tbTenPhuPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbTenPhuPhi.Hint = "Tên Phụ Phí";
            this.tbTenPhuPhi.LeadingIcon = null;
            this.tbTenPhuPhi.Location = new System.Drawing.Point(6, 22);
            this.tbTenPhuPhi.MaxLength = 50;
            this.tbTenPhuPhi.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTenPhuPhi.Multiline = false;
            this.tbTenPhuPhi.Name = "tbTenPhuPhi";
            this.tbTenPhuPhi.Size = new System.Drawing.Size(220, 36);
            this.tbTenPhuPhi.TabIndex = 11;
            this.tbTenPhuPhi.Text = "";
            this.tbTenPhuPhi.TrailingIcon = null;
            this.tbTenPhuPhi.UseTallSize = false;
            // 
            // btXoaPhuPhi
            // 
            this.btXoaPhuPhi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btXoaPhuPhi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btXoaPhuPhi.Depth = 0;
            this.btXoaPhuPhi.HighEmphasis = true;
            this.btXoaPhuPhi.Icon = null;
            this.btXoaPhuPhi.Location = new System.Drawing.Point(364, 64);
            this.btXoaPhuPhi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btXoaPhuPhi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btXoaPhuPhi.Name = "btXoaPhuPhi";
            this.btXoaPhuPhi.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btXoaPhuPhi.Size = new System.Drawing.Size(111, 36);
            this.btXoaPhuPhi.TabIndex = 12;
            this.btXoaPhuPhi.Text = "Xoá Phụ Phí";
            this.btXoaPhuPhi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btXoaPhuPhi.UseAccentColor = true;
            this.btXoaPhuPhi.UseVisualStyleBackColor = true;
            // 
            // UserControlCaiDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControlCaiDat";
            this.Size = new System.Drawing.Size(800, 400);
            this.Load += new System.EventHandler(this.UserControlCaiDat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton btCapNhatGiaDienNuoc;
        private MaterialSkin.Controls.MaterialTextBox tbGiaNuoc;
        private MaterialSkin.Controls.MaterialTextBox tbGiaDien;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialButton btXoaPhuPhi;
        private MaterialSkin.Controls.MaterialTextBox tbTenPhuPhi;
        private MaterialSkin.Controls.MaterialButton btThemPhuPhi;
        private MaterialSkin.Controls.MaterialTextBox tbGiaPhuPhi;
        private MaterialSkin.Controls.MaterialListView lvPhuPhi;
        private System.Windows.Forms.ColumnHeader colMaPhuPhi;
        private System.Windows.Forms.ColumnHeader colTenPhuPhi;
        private System.Windows.Forms.ColumnHeader colGiaPhuPhi;
    }
}
