using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.IO;
using System.Threading;

namespace Picture_Viewer
{
    public partial class FormChinh : MetroForm
    {

        
        public FormChinh()
        {
            InitializeComponent();
        }



        void pic_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            String tenTheLoai = "";
            String tenAlbum ="";
            HinhAnh anh = new HinhAnh();
            TheLoai theLoai = new TheLoai();
            Album alBum = new Album();
            anh = anh.layHinhTheoDuongDan(pic.Name);
            if (anh.MaTheLoai != null)
            {
                try 
                { 
                    tenTheLoai = theLoai.layTheLoaiTheoMaTheLoai(anh.MaTheLoai).TenTheLoai; 
                }
                catch(Exception)
                {

                }
            }
            
            if(anh.MaAlbum!=null)
                try
                {
                    tenAlbum = alBum.layAlbumTheoMaAlbum(anh.MaAlbum).TenAlbum;
                }
                catch(Exception)
                {
                    
                }
            
                
                piHinhAnhFull.Image = pic.Image;
               
                labelTenAnh.Text = anh.TenHinh;
                panelThongTin.Visible = true;
                labelTheLoai.Text = tenTheLoai;
                labelAlbum.Text = tenAlbum;
               
                

                
      
          
            
            
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
           

           
            loadAnhRaFlow();
           
           
            
           
            
        }






        public void loadAnhRaFlow()
        {
            HinhAnh hinhAnh = new HinhAnh();
            List<HinhAnh> dataAnh = hinhAnh.layAnh();
            
            try
            {
                piHinhAnhFull.Image = new Bitmap(@dataAnh[0].DuongDan);
                if (dataAnh != null)
                {
                    for (int i = 0; i <= dataAnh.Count - 1; i++)
                    {
                        PictureBox pic = new PictureBox();
                        pic.Image = new Bitmap(@dataAnh[i].DuongDan);
                        pic.Name = dataAnh[i].DuongDan;
                        pic.Height = 190;
                        pic.Width = 200;
                        pic.SizeMode = PictureBoxSizeMode.Zoom;
                        listAnh.Controls.Add(pic);
                        pic.Click += new EventHandler(pic_Click);


                    }
                }
            }
            catch (Exception ex)
            {

            }
        }


        
        private void btnXemAnh_Click(object sender, EventArgs e)
        {
          
            FormXemAnh xem = new FormXemAnh();
            xem.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            
            String[] files = null;
            try
            {
                files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
               
                
                

                if (result == DialogResult.OK)
                {
                    int i = 0;
                    while (files != null)
                    {
                        if (files[i].EndsWith(".jpg") || files[i].EndsWith(".png") || files[i].EndsWith(".GIF") || files[i].EndsWith(".bmp") || files[i].EndsWith(".jpeg"))
                        {
                            HinhAnh anh = new HinhAnh();
                            anh.DuongDan = files[i];
                            anh.TenHinh = Path.GetFileNameWithoutExtension(files[i]);
                           
                            
                            anh.ThemAnh();
                        }
                        i++;
                    }

                }
            }
            catch (Exception )
            {

            }




            loadAnhRaFlow();
                    
          

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemAnh_MouseHover(object sender, EventArgs e)
        {
            mainToolip.Show("Nhấp Vào Để Thêm Ảnh", btnThemAnh);
           
        }

        private void btnXemAnh_MouseHover(object sender, EventArgs e)
        {
            
            mainToolip.Show("Nhấp Vào Để Xem Ảnh Dạng Lưới", btnXemAnh);
        }

        private void btnThoat_MouseHover(object sender, EventArgs e)
        {
            mainToolip.Show("Thoát", btnThoat);
           
        }

        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoat_MouseHover_1(object sender, EventArgs e)
        {
            mainToolip.Show("Thoát", btnThoat);
        }

        private void picVersion_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void btnXemAnhFull_Click(object sender, EventArgs e)
        {
            QuanLyDanhMuc form = new QuanLyDanhMuc();
            form.Show();
        }

        private void btnXemAnhFull_MouseHover(object sender, EventArgs e)
        {
            mainToolip.Show("Quản Lý Album Thể Loại ", btnXemAnhFull);
        }

        private void PictureView_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void metroTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
          


        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void btnQuanLyDanhMuc_MouseHover(object sender, EventArgs e)
        {
         
        }

        private void metroTile1_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void metroTile1_Click_3(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelAn_MouseHover(object sender, EventArgs e)
        {
         
        }

        private void panelAn_MouseLeave(object sender, EventArgs e)
        {
           
        }
        
    }
}
