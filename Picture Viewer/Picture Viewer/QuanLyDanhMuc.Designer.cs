namespace Picture_Viewer
{
    partial class QuanLyDanhMuc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlQuanLy = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btnxoaThuocTheLoai = new MetroFramework.Controls.MetroButton();
            this.btnCapNhat = new MetroFramework.Controls.MetroButton();
            this.btnThemTheLoai = new MetroFramework.Controls.MetroButton();
            this.txtTenTheLoai = new MetroFramework.Controls.MetroTextBox();
            this.gridDanhSachTheLoai = new MetroFramework.Controls.MetroGrid();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btncapNhatAlbum = new MetroFramework.Controls.MetroButton();
            this.btnThemAlbum = new MetroFramework.Controls.MetroButton();
            this.txtTenAlbum = new MetroFramework.Controls.MetroTextBox();
            this.gridDanhSachAlbum = new MetroFramework.Controls.MetroGrid();
            this.btnThoat = new MetroFramework.Controls.MetroTile();
            this.bntxoaAnhThuocAlbum = new MetroFramework.Controls.MetroButton();
            this.tabControlQuanLy.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDanhSachTheLoai)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDanhSachAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlQuanLy
            // 
            this.tabControlQuanLy.Controls.Add(this.metroTabPage1);
            this.tabControlQuanLy.Controls.Add(this.metroTabPage2);
            this.tabControlQuanLy.Location = new System.Drawing.Point(10, 20);
            this.tabControlQuanLy.Name = "tabControlQuanLy";
            this.tabControlQuanLy.SelectedIndex = 1;
            this.tabControlQuanLy.Size = new System.Drawing.Size(1366, 768);
            this.tabControlQuanLy.TabIndex = 0;
            this.tabControlQuanLy.UseSelectable = true;
            this.tabControlQuanLy.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            this.tabControlQuanLy.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.metroTabControl1_Selecting);
            this.tabControlQuanLy.Selected += new System.Windows.Forms.TabControlEventHandler(this.metroTabControl1_Selected);
            this.tabControlQuanLy.TabIndexChanged += new System.EventHandler(this.metroTabControl1_TabIndexChanged);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.btnxoaThuocTheLoai);
            this.metroTabPage1.Controls.Add(this.btnCapNhat);
            this.metroTabPage1.Controls.Add(this.btnThemTheLoai);
            this.metroTabPage1.Controls.Add(this.txtTenTheLoai);
            this.metroTabPage1.Controls.Add(this.gridDanhSachTheLoai);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1358, 726);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Quản Lý Thể Loại";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            this.metroTabPage1.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // btnxoaThuocTheLoai
            // 
            this.btnxoaThuocTheLoai.Location = new System.Drawing.Point(365, 17);
            this.btnxoaThuocTheLoai.Name = "btnxoaThuocTheLoai";
            this.btnxoaThuocTheLoai.Size = new System.Drawing.Size(151, 23);
            this.btnxoaThuocTheLoai.TabIndex = 10;
            this.btnxoaThuocTheLoai.Text = "Xóa Ảnh Thuộc Thể Loại";
            this.btnxoaThuocTheLoai.UseSelectable = true;
            this.btnxoaThuocTheLoai.Click += new System.EventHandler(this.btnxoaThuocTheLoai_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(273, 17);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 9;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseSelectable = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThemTheLoai
            // 
            this.btnThemTheLoai.Location = new System.Drawing.Point(179, 17);
            this.btnThemTheLoai.Name = "btnThemTheLoai";
            this.btnThemTheLoai.Size = new System.Drawing.Size(75, 23);
            this.btnThemTheLoai.TabIndex = 7;
            this.btnThemTheLoai.Text = "Thêm ";
            this.btnThemTheLoai.UseSelectable = true;
            this.btnThemTheLoai.Click += new System.EventHandler(this.btnThemTheLoai_Click);
            // 
            // txtTenTheLoai
            // 
            // 
            // 
            // 
            this.txtTenTheLoai.CustomButton.Image = null;
            this.txtTenTheLoai.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.txtTenTheLoai.CustomButton.Name = "";
            this.txtTenTheLoai.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTenTheLoai.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTenTheLoai.CustomButton.TabIndex = 1;
            this.txtTenTheLoai.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTenTheLoai.CustomButton.UseSelectable = true;
            this.txtTenTheLoai.CustomButton.Visible = false;
            this.txtTenTheLoai.Lines = new string[0];
            this.txtTenTheLoai.Location = new System.Drawing.Point(11, 17);
            this.txtTenTheLoai.MaxLength = 32767;
            this.txtTenTheLoai.Name = "txtTenTheLoai";
            this.txtTenTheLoai.PasswordChar = '\0';
            this.txtTenTheLoai.PromptText = "Tên Thể Loại";
            this.txtTenTheLoai.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTenTheLoai.SelectedText = "";
            this.txtTenTheLoai.SelectionLength = 0;
            this.txtTenTheLoai.SelectionStart = 0;
            this.txtTenTheLoai.ShortcutsEnabled = true;
            this.txtTenTheLoai.Size = new System.Drawing.Size(138, 23);
            this.txtTenTheLoai.TabIndex = 6;
            this.txtTenTheLoai.UseSelectable = true;
            this.txtTenTheLoai.WaterMark = "Tên Thể Loại";
            this.txtTenTheLoai.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTenTheLoai.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gridDanhSachTheLoai
            // 
            this.gridDanhSachTheLoai.AllowUserToResizeRows = false;
            this.gridDanhSachTheLoai.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridDanhSachTheLoai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDanhSachTheLoai.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridDanhSachTheLoai.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDanhSachTheLoai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDanhSachTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDanhSachTheLoai.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridDanhSachTheLoai.EnableHeadersVisualStyles = false;
            this.gridDanhSachTheLoai.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridDanhSachTheLoai.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridDanhSachTheLoai.Location = new System.Drawing.Point(2, 46);
            this.gridDanhSachTheLoai.Name = "gridDanhSachTheLoai";
            this.gridDanhSachTheLoai.ReadOnly = true;
            this.gridDanhSachTheLoai.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDanhSachTheLoai.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridDanhSachTheLoai.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridDanhSachTheLoai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDanhSachTheLoai.Size = new System.Drawing.Size(1356, 391);
            this.gridDanhSachTheLoai.TabIndex = 5;
            this.gridDanhSachTheLoai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDanhSachTheLoai_CellClick);
            this.gridDanhSachTheLoai.Click += new System.EventHandler(this.gridDanhSachTheLoai_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.bntxoaAnhThuocAlbum);
            this.metroTabPage2.Controls.Add(this.btncapNhatAlbum);
            this.metroTabPage2.Controls.Add(this.btnThemAlbum);
            this.metroTabPage2.Controls.Add(this.txtTenAlbum);
            this.metroTabPage2.Controls.Add(this.gridDanhSachAlbum);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1358, 726);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Quản Lý Album";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            this.metroTabPage2.Click += new System.EventHandler(this.metroTabPage2_Click);
            // 
            // btncapNhatAlbum
            // 
            this.btncapNhatAlbum.Location = new System.Drawing.Point(274, 10);
            this.btncapNhatAlbum.Name = "btncapNhatAlbum";
            this.btncapNhatAlbum.Size = new System.Drawing.Size(75, 23);
            this.btncapNhatAlbum.TabIndex = 13;
            this.btncapNhatAlbum.Text = "Cập Nhật";
            this.btncapNhatAlbum.UseSelectable = true;
            this.btncapNhatAlbum.Click += new System.EventHandler(this.btncapNhatAlbum_Click);
            // 
            // btnThemAlbum
            // 
            this.btnThemAlbum.Location = new System.Drawing.Point(180, 10);
            this.btnThemAlbum.Name = "btnThemAlbum";
            this.btnThemAlbum.Size = new System.Drawing.Size(75, 23);
            this.btnThemAlbum.TabIndex = 12;
            this.btnThemAlbum.Text = "Thêm ";
            this.btnThemAlbum.UseSelectable = true;
            this.btnThemAlbum.Click += new System.EventHandler(this.btnThemAlbum_Click);
            // 
            // txtTenAlbum
            // 
            // 
            // 
            // 
            this.txtTenAlbum.CustomButton.Image = null;
            this.txtTenAlbum.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.txtTenAlbum.CustomButton.Name = "";
            this.txtTenAlbum.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTenAlbum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTenAlbum.CustomButton.TabIndex = 1;
            this.txtTenAlbum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTenAlbum.CustomButton.UseSelectable = true;
            this.txtTenAlbum.CustomButton.Visible = false;
            this.txtTenAlbum.Lines = new string[0];
            this.txtTenAlbum.Location = new System.Drawing.Point(12, 10);
            this.txtTenAlbum.MaxLength = 32767;
            this.txtTenAlbum.Name = "txtTenAlbum";
            this.txtTenAlbum.PasswordChar = '\0';
            this.txtTenAlbum.PromptText = "Tên Album";
            this.txtTenAlbum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTenAlbum.SelectedText = "";
            this.txtTenAlbum.SelectionLength = 0;
            this.txtTenAlbum.SelectionStart = 0;
            this.txtTenAlbum.ShortcutsEnabled = true;
            this.txtTenAlbum.Size = new System.Drawing.Size(138, 23);
            this.txtTenAlbum.TabIndex = 11;
            this.txtTenAlbum.UseSelectable = true;
            this.txtTenAlbum.WaterMark = "Tên Album";
            this.txtTenAlbum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTenAlbum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gridDanhSachAlbum
            // 
            this.gridDanhSachAlbum.AllowUserToResizeRows = false;
            this.gridDanhSachAlbum.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridDanhSachAlbum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDanhSachAlbum.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridDanhSachAlbum.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDanhSachAlbum.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridDanhSachAlbum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDanhSachAlbum.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridDanhSachAlbum.EnableHeadersVisualStyles = false;
            this.gridDanhSachAlbum.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridDanhSachAlbum.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridDanhSachAlbum.Location = new System.Drawing.Point(3, 39);
            this.gridDanhSachAlbum.Name = "gridDanhSachAlbum";
            this.gridDanhSachAlbum.ReadOnly = true;
            this.gridDanhSachAlbum.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDanhSachAlbum.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridDanhSachAlbum.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridDanhSachAlbum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDanhSachAlbum.Size = new System.Drawing.Size(1356, 391);
            this.gridDanhSachAlbum.TabIndex = 10;
            this.gridDanhSachAlbum.Click += new System.EventHandler(this.gridDanhSachAlbum_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ActiveControl = null;
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.Location = new System.Drawing.Point(1336, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(33, 29);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.TileImage = global::Picture_Viewer.Properties.Resources.Delete_32px;
            this.btnThoat.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThoat.UseCustomBackColor = true;
            this.btnThoat.UseSelectable = true;
            this.btnThoat.UseTileImage = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // bntxoaAnhThuocAlbum
            // 
            this.bntxoaAnhThuocAlbum.Location = new System.Drawing.Point(371, 10);
            this.bntxoaAnhThuocAlbum.Name = "bntxoaAnhThuocAlbum";
            this.bntxoaAnhThuocAlbum.Size = new System.Drawing.Size(151, 23);
            this.bntxoaAnhThuocAlbum.TabIndex = 14;
            this.bntxoaAnhThuocAlbum.Text = "Xóa Ảnh Thuộc Album";
            this.bntxoaAnhThuocAlbum.UseSelectable = true;
            this.bntxoaAnhThuocAlbum.Click += new System.EventHandler(this.bntxoaAnhThuocAlbum_Click);
            // 
            // QuanLyDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.tabControlQuanLy);
            this.Name = "QuanLyDanhMuc";
            this.Load += new System.EventHandler(this.FullScreen_Load);
            this.tabControlQuanLy.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDanhSachTheLoai)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDanhSachAlbum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControlQuanLy;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroButton btnCapNhat;
        private MetroFramework.Controls.MetroButton btnThemTheLoai;
        private MetroFramework.Controls.MetroTextBox txtTenTheLoai;
        private MetroFramework.Controls.MetroGrid gridDanhSachTheLoai;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton btncapNhatAlbum;
        private MetroFramework.Controls.MetroButton btnThemAlbum;
        private MetroFramework.Controls.MetroTextBox txtTenAlbum;
        private MetroFramework.Controls.MetroGrid gridDanhSachAlbum;
        private MetroFramework.Controls.MetroTile btnThoat;
        private MetroFramework.Controls.MetroButton btnxoaThuocTheLoai;
        private MetroFramework.Controls.MetroButton bntxoaAnhThuocAlbum;


    }
}