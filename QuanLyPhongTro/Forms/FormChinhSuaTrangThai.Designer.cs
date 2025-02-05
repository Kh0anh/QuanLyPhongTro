namespace QuanLyPhongTro.Forms
{
    partial class FormChinhSuaTrangThai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChinhSuaTrangThai));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHuyChinhSua = new MaterialSkin.Controls.MaterialButton();
            this.btnLuuChinhSua = new MaterialSkin.Controls.MaterialButton();
            this.tbNguoiThue = new MaterialSkin.Controls.MaterialTextBox();
            this.cbTrangThai = new MaterialSkin.Controls.MaterialComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHuyChinhSua);
            this.groupBox1.Controls.Add(this.btnLuuChinhSua);
            this.groupBox1.Controls.Add(this.tbNguoiThue);
            this.groupBox1.Controls.Add(this.cbTrangThai);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chỉnh sửa trạng thái";
            // 
            // btnHuyChinhSua
            // 
            this.btnHuyChinhSua.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHuyChinhSua.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHuyChinhSua.Depth = 0;
            this.btnHuyChinhSua.HighEmphasis = true;
            this.btnHuyChinhSua.Icon = null;
            this.btnHuyChinhSua.Location = new System.Drawing.Point(35, 123);
            this.btnHuyChinhSua.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHuyChinhSua.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuyChinhSua.Name = "btnHuyChinhSua";
            this.btnHuyChinhSua.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHuyChinhSua.Size = new System.Drawing.Size(132, 36);
            this.btnHuyChinhSua.TabIndex = 3;
            this.btnHuyChinhSua.Text = "Huỷ Chỉnh Sửa";
            this.btnHuyChinhSua.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHuyChinhSua.UseAccentColor = true;
            this.btnHuyChinhSua.UseVisualStyleBackColor = true;
            this.btnHuyChinhSua.Click += new System.EventHandler(this.btnHuyChinhSua_Click);
            // 
            // btnLuuChinhSua
            // 
            this.btnLuuChinhSua.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLuuChinhSua.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLuuChinhSua.Depth = 0;
            this.btnLuuChinhSua.HighEmphasis = true;
            this.btnLuuChinhSua.Icon = null;
            this.btnLuuChinhSua.Location = new System.Drawing.Point(175, 123);
            this.btnLuuChinhSua.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLuuChinhSua.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLuuChinhSua.Name = "btnLuuChinhSua";
            this.btnLuuChinhSua.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLuuChinhSua.Size = new System.Drawing.Size(131, 36);
            this.btnLuuChinhSua.TabIndex = 2;
            this.btnLuuChinhSua.Text = "Lưu Chỉnh Sửa";
            this.btnLuuChinhSua.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLuuChinhSua.UseAccentColor = false;
            this.btnLuuChinhSua.UseVisualStyleBackColor = true;
            this.btnLuuChinhSua.Click += new System.EventHandler(this.btnLuuChinhSua_Click);
            // 
            // tbNguoiThue
            // 
            this.tbNguoiThue.AnimateReadOnly = false;
            this.tbNguoiThue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNguoiThue.Depth = 0;
            this.tbNguoiThue.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbNguoiThue.Hint = "Người thuê";
            this.tbNguoiThue.LeadingIcon = null;
            this.tbNguoiThue.Location = new System.Drawing.Point(6, 64);
            this.tbNguoiThue.MaxLength = 50;
            this.tbNguoiThue.MouseState = MaterialSkin.MouseState.OUT;
            this.tbNguoiThue.Multiline = false;
            this.tbNguoiThue.Name = "tbNguoiThue";
            this.tbNguoiThue.Size = new System.Drawing.Size(300, 50);
            this.tbNguoiThue.TabIndex = 1;
            this.tbNguoiThue.Text = "";
            this.tbNguoiThue.TrailingIcon = null;
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.AutoResize = false;
            this.cbTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbTrangThai.Depth = 0;
            this.cbTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbTrangThai.DropDownHeight = 118;
            this.cbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrangThai.DropDownWidth = 121;
            this.cbTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Hint = "Trạng Thái";
            this.cbTrangThai.IntegralHeight = false;
            this.cbTrangThai.ItemHeight = 29;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Đang được thuê",
            "Phòng trống"});
            this.cbTrangThai.Location = new System.Drawing.Point(6, 23);
            this.cbTrangThai.MaxDropDownItems = 4;
            this.cbTrangThai.MouseState = MaterialSkin.MouseState.OUT;
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(300, 35);
            this.cbTrangThai.StartIndex = 0;
            this.cbTrangThai.TabIndex = 0;
            this.cbTrangThai.UseTallSize = false;
            this.cbTrangThai.SelectedIndexChanged += new System.EventHandler(this.cbTrangThai_SelectedIndexChanged);
            // 
            // FormChinhSuaTrangThai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 201);
            this.Controls.Add(this.groupBox1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormChinhSuaTrangThai";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "FormChinhSuaTrangThai";
            this.Load += new System.EventHandler(this.FormChinhSuaTrangThai_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialComboBox cbTrangThai;
        private MaterialSkin.Controls.MaterialTextBox tbNguoiThue;
        private MaterialSkin.Controls.MaterialButton btnHuyChinhSua;
        private MaterialSkin.Controls.MaterialButton btnLuuChinhSua;
    }
}