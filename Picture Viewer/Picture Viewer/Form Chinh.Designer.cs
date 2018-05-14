namespace Picture_Viewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChinh));
            this.listAnh = new System.Windows.Forms.FlowLayoutPanel();
            this.moThuMuc = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.mainToolip = new MetroFramework.Components.MetroToolTip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.btnXemAnhFull = new MetroFramework.Controls.MetroTile();
            this.btnXemAnh = new MetroFramework.Controls.MetroTile();
            this.btnThemAnh = new MetroFramework.Controls.MetroTile();
            this.piHinhAnhFull = new System.Windows.Forms.PictureBox();
            this.btnThoat = new MetroFramework.Controls.MetroTile();
            this.labelTenAnh = new MetroFramework.Controls.MetroLabel();
            this.labelAlbum = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.labelTheLoai = new MetroFramework.Controls.MetroLabel();
            this.panelThongTin = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.piHinhAnhFull)).BeginInit();
            this.panelThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // listAnh
            // 
            this.listAnh.AutoScroll = true;
            this.listAnh.Location = new System.Drawing.Point(23, 579);
            this.listAnh.Name = "listAnh";
            this.listAnh.Size = new System.Drawing.Size(1339, 166);
            this.listAnh.TabIndex = 2;
            // 
            // moThuMuc
            // 
            this.moThuMuc.FileName = "openFileDialog1";
            // 
            // mainToolip
            // 
            this.mainToolip.Style = MetroFramework.MetroColorStyle.Blue;
            this.mainToolip.StyleManager = null;
            this.mainToolip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(148, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 42);
            this.label1.TabIndex = 16;
            this.label1.Text = "Thêm Ảnh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(469, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 42);
            this.label2.TabIndex = 17;
            this.label2.Text = "Xem Ảnh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Snap ITC", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(818, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(400, 42);
            this.label3.TabIndex = 18;
            this.label3.Text = "Chỉnh Sửa Thông Tin";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(1292, 16);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(32, 23);
            this.metroTile1.TabIndex = 15;
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileImage = global::Picture_Viewer.Properties.Resources.Minus_Math__32px;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click_3);
            // 
            // btnXemAnhFull
            // 
            this.btnXemAnhFull.ActiveControl = null;
            this.btnXemAnhFull.Location = new System.Drawing.Point(697, 14);
            this.btnXemAnhFull.Name = "btnXemAnhFull";
            this.btnXemAnhFull.Size = new System.Drawing.Size(100, 91);
            this.btnXemAnhFull.TabIndex = 9;
            this.btnXemAnhFull.Tag = "3";
            this.btnXemAnhFull.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXemAnhFull.TileImage = global::Picture_Viewer.Properties.Resources.Edit_Image_96px;
            this.btnXemAnhFull.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXemAnhFull.UseCustomBackColor = true;
            this.btnXemAnhFull.UseSelectable = true;
            this.btnXemAnhFull.UseTileImage = true;
            this.btnXemAnhFull.Click += new System.EventHandler(this.btnXemAnhFull_Click);
            this.btnXemAnhFull.MouseHover += new System.EventHandler(this.btnXemAnhFull_MouseHover);
            // 
            // btnXemAnh
            // 
            this.btnXemAnh.ActiveControl = null;
            this.btnXemAnh.Location = new System.Drawing.Point(363, 14);
            this.btnXemAnh.Name = "btnXemAnh";
            this.btnXemAnh.Size = new System.Drawing.Size(100, 91);
            this.btnXemAnh.TabIndex = 5;
            this.btnXemAnh.Tag = "2";
            this.btnXemAnh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXemAnh.TileImage = global::Picture_Viewer.Properties.Resources.Thumbnails_96px;
            this.btnXemAnh.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXemAnh.UseCustomBackColor = true;
            this.btnXemAnh.UseSelectable = true;
            this.btnXemAnh.UseTileImage = true;
            this.btnXemAnh.Click += new System.EventHandler(this.btnXemAnh_Click);
            this.btnXemAnh.MouseHover += new System.EventHandler(this.btnXemAnh_MouseHover);
            // 
            // btnThemAnh
            // 
            this.btnThemAnh.ActiveControl = null;
            this.btnThemAnh.Location = new System.Drawing.Point(26, 14);
            this.btnThemAnh.Name = "btnThemAnh";
            this.btnThemAnh.Size = new System.Drawing.Size(100, 91);
            this.btnThemAnh.TabIndex = 6;
            this.btnThemAnh.Tag = "1";
            this.btnThemAnh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThemAnh.TileImage = global::Picture_Viewer.Properties.Resources._80;
            this.btnThemAnh.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThemAnh.UseCustomBackColor = true;
            this.btnThemAnh.UseSelectable = true;
            this.btnThemAnh.UseTileImage = true;
            this.btnThemAnh.Click += new System.EventHandler(this.metroTile1_Click);
            this.btnThemAnh.MouseHover += new System.EventHandler(this.btnThemAnh_MouseHover);
            // 
            // piHinhAnhFull
            // 
            this.piHinhAnhFull.Location = new System.Drawing.Point(26, 133);
            this.piHinhAnhFull.Name = "piHinhAnhFull";
            this.piHinhAnhFull.Size = new System.Drawing.Size(955, 435);
            this.piHinhAnhFull.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piHinhAnhFull.TabIndex = 11;
            this.piHinhAnhFull.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.ActiveControl = null;
            this.btnThoat.Location = new System.Drawing.Point(1330, 16);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(32, 23);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThoat.TileImage = global::Picture_Viewer.Properties.Resources.Delete_32px;
            this.btnThoat.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThoat.UseCustomBackColor = true;
            this.btnThoat.UseSelectable = true;
            this.btnThoat.UseTileImage = true;
            this.btnThoat.Click += new System.EventHandler(this.metroTile1_Click_1);
            this.btnThoat.MouseHover += new System.EventHandler(this.btnThoat_MouseHover_1);
            // 
            // labelTenAnh
            // 
            this.labelTenAnh.Location = new System.Drawing.Point(127, 88);
            this.labelTenAnh.Name = "labelTenAnh";
            this.labelTenAnh.Size = new System.Drawing.Size(152, 19);
            this.labelTenAnh.TabIndex = 16;
            this.labelTenAnh.Text = "...............";
            this.labelTenAnh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAlbum
            // 
            this.labelAlbum.Location = new System.Drawing.Point(127, 212);
            this.labelAlbum.Name = "labelAlbum";
            this.labelAlbum.Size = new System.Drawing.Size(152, 19);
            this.labelAlbum.TabIndex = 18;
            this.labelAlbum.Text = "...............";
            this.labelAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(47, 88);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(62, 19);
            this.metroLabel6.TabIndex = 19;
            this.metroLabel6.Text = "Tên Ảnh";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(47, 152);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(65, 19);
            this.metroLabel5.TabIndex = 20;
            this.metroLabel5.Text = "Thể Loại";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(47, 212);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(53, 19);
            this.metroLabel3.TabIndex = 21;
            this.metroLabel3.Text = "Album";
            // 
            // labelTheLoai
            // 
            this.labelTheLoai.Location = new System.Drawing.Point(127, 152);
            this.labelTheLoai.Name = "labelTheLoai";
            this.labelTheLoai.Size = new System.Drawing.Size(152, 19);
            this.labelTheLoai.TabIndex = 22;
            this.labelTheLoai.Text = "...............";
            this.labelTheLoai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelThongTin
            // 
            this.panelThongTin.BackgroundImage = global::Picture_Viewer.Properties.Resources.frame_clipart_navy_blue_9;
            this.panelThongTin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelThongTin.Controls.Add(this.labelTheLoai);
            this.panelThongTin.Controls.Add(this.metroLabel3);
            this.panelThongTin.Controls.Add(this.metroLabel5);
            this.panelThongTin.Controls.Add(this.metroLabel6);
            this.panelThongTin.Controls.Add(this.labelAlbum);
            this.panelThongTin.Controls.Add(this.labelTenAnh);
            this.panelThongTin.HorizontalScrollbarBarColor = true;
            this.panelThongTin.HorizontalScrollbarHighlightOnWheel = false;
            this.panelThongTin.HorizontalScrollbarSize = 10;
            this.panelThongTin.Location = new System.Drawing.Point(1002, 200);
            this.panelThongTin.Name = "panelThongTin";
            this.panelThongTin.Size = new System.Drawing.Size(360, 279);
            this.panelThongTin.TabIndex = 13;
            this.panelThongTin.VerticalScrollbarBarColor = true;
            this.panelThongTin.VerticalScrollbarHighlightOnWheel = false;
            this.panelThongTin.VerticalScrollbarSize = 10;
            this.panelThongTin.Visible = false;
            // 
            // FormChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.panelThongTin);
            this.Controls.Add(this.btnXemAnhFull);
            this.Controls.Add(this.btnXemAnh);
            this.Controls.Add(this.btnThemAnh);
            this.Controls.Add(this.piHinhAnhFull);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.listAnh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormChinh";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PictureView_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.piHinhAnhFull)).EndInit();
            this.panelThongTin.ResumeLayout(false);
            this.panelThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel listAnh;
        private System.Windows.Forms.OpenFileDialog moThuMuc;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private MetroFramework.Components.MetroToolTip mainToolip;
        private MetroFramework.Controls.MetroTile btnThoat;
        private System.Windows.Forms.PictureBox piHinhAnhFull;
        private MetroFramework.Controls.MetroTile btnXemAnh;
        private MetroFramework.Controls.MetroTile btnThemAnh;
        private MetroFramework.Controls.MetroTile btnXemAnhFull;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroLabel labelTenAnh;
        private MetroFramework.Controls.MetroLabel labelAlbum;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel labelTheLoai;
        private MetroFramework.Controls.MetroPanel panelThongTin;
    }
}

