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

namespace Picture_Viewer
{
    public partial class FormXemAnh : MetroForm
    {

        #region Khaibaobien

        String duongDan = null;
        int count = 0;
        public int chucNangDangChon = 0;
        #endregion




        #region hamcustom


        public bool kiemTraCheck()
        {
            if (checkBoxHinh1.CheckState == CheckState.Checked)
                return true;
            if (checkBoxHinh2.CheckState == CheckState.Checked)
                return true;
            if (checkBoxHinh3.CheckState == CheckState.Checked)
                return true;
            if (checkBoxHinh4.CheckState == CheckState.Checked)
                return true;
            if (checkBoxHinh5.CheckState == CheckState.Checked)
                return true;
            if (checkBoxHinh6.CheckState == CheckState.Checked)
                return true;
            if (checkBoxHinh7.CheckState == CheckState.Checked)
                return true;
            if (checkBoxHinh8.CheckState == CheckState.Checked)
                return true;
            if (checkBoxHinh9.CheckState == CheckState.Checked)
                return true;
            if (checkBoxHinh10.CheckState == CheckState.Checked)
                return true;
            if (checkBoxHinh11.CheckState == CheckState.Checked)
                return true;
            if (checkBoxHinh12.CheckState == CheckState.Checked)
                return true;
            if (checkBoxHinh13.CheckState == CheckState.Checked)
                return true;
            if (checkBoxHinh14.CheckState == CheckState.Checked)
                return true;
            if (checkBoxHinh15.CheckState == CheckState.Checked)
                return true;

            return false;
        }

        
        public int tinhSoTrang(int dem)
        {
            int soTrang = 0;
            if (dem != 0)
            {
                if (dem >= 15)
                {
                    int tam = dem % 15;
                    if (tam == 0)
                    {
                        soTrang = dem / 15;
                    }
                    else
                    {
                        soTrang = (dem / 15) + 1;
                    }

                }
                else
                {
                    soTrang = 1;
                }
            }
            return soTrang;
        }


        public void hienThiBoxAnhTrong(PictureBox boxAnh)
        {
            boxAnh.Image = null;
            boxAnh.Name = null;
        }
        public void hienThiBoxAnh(HinhAnh anh, PictureBox boxAnh)
        {
            try
            {
                if (anh != null)
                {
                    boxAnh.Image = new Bitmap(@anh.DuongDan);
                    boxAnh.Name = anh.DuongDan;
                }

            }
            catch (Exception ex)
            {

            }
        }


        public void hienThiAnh(List<HinhAnh> danhSachAnh)
        {
            HinhAnh anhtrong = new HinhAnh();
            anhtrong.DuongDan = "";

            for (int i = 0; i < danhSachAnh.Count; i++)
            {

                if (danhSachAnh[i] != null)
                {
                    switch (i)
                    {
                        case 0:

                            hienThiBoxAnh(danhSachAnh[i], hinhAnh1);


                            break;
                        case 1:

                            hienThiBoxAnh(danhSachAnh[i], hinhAnh2);


                            break;
                        case 2:

                            hienThiBoxAnh(danhSachAnh[i], hinhAnh3);
                            break;
                        case 3:

                            hienThiBoxAnh(danhSachAnh[i], hinhAnh4);
                            break;
                        case 4:

                            hienThiBoxAnh(danhSachAnh[i], hinhAnh5);
                            break;
                        case 5:

                            hienThiBoxAnh(danhSachAnh[i], hinhAnh6);
                            break;
                        case 6:

                            hienThiBoxAnh(danhSachAnh[i], hinhAnh7);
                            break;
                        case 7:

                            hienThiBoxAnh(danhSachAnh[i], hinhAnh8);
                            break;
                        case 8:

                            hienThiBoxAnh(danhSachAnh[i], hinhAnh9);
                            break;
                        case 9:

                            hienThiBoxAnh(danhSachAnh[i], hinhAnh10);
                            break;
                        case 10:

                            hienThiBoxAnh(danhSachAnh[i], hinhAnh11);
                            break;
                        case 11:

                            hienThiBoxAnh(danhSachAnh[i], hinhAnh12);
                            break;
                        case 12:

                            hienThiBoxAnh(danhSachAnh[i], hinhAnh13);
                            break;
                        case 13:

                            hienThiBoxAnh(danhSachAnh[i], hinhAnh14);
                            break;
                        case 14:

                            hienThiBoxAnh(danhSachAnh[i], hinhAnh15);
                            break;
                        default:
                            break;
                    }
                }
            }
        }




        public void disableCheckBox()
        {
            if (hinhAnh1.Name == "")
                checkBoxHinh1.Visible = false;
            if (hinhAnh2.Name == "")
                checkBoxHinh2.Visible = false;
            if (hinhAnh3.Name == "")
                checkBoxHinh3.Visible = false;
            if (hinhAnh4.Name == "")
                checkBoxHinh4.Visible = false;
            if (hinhAnh5.Name == "")
                checkBoxHinh5.Visible = false;
            if (hinhAnh6.Name == "")
                checkBoxHinh6.Visible = false;
            if (hinhAnh7.Name == "")
                checkBoxHinh7.Visible = false;
            if (hinhAnh8.Name == "")
                checkBoxHinh8.Visible = false;
            if (hinhAnh9.Name == "")
                checkBoxHinh9.Visible = false;
            if (hinhAnh10.Name == "")
                checkBoxHinh10.Visible = false;
            if (hinhAnh11.Name == "")
                checkBoxHinh11.Visible = false;
            if (hinhAnh12.Name == "")
                checkBoxHinh12.Visible = false;
            if (hinhAnh13.Name == "")
                checkBoxHinh13.Visible = false;
            if (hinhAnh14.Name == "")
                checkBoxHinh14.Visible = false;
            if (hinhAnh15.Name == "")
                checkBoxHinh15.Visible = false;

        }

        public void hienThiTenHinh()
        {
            try
            {
                HinhAnh anhao = new HinhAnh();
                tenHinh1.Text = anhao.layTenTheoDuongDan(hinhAnh1.Name);
                tenHinh2.Text = anhao.layTenTheoDuongDan(hinhAnh2.Name);
                tenHinh3.Text = anhao.layTenTheoDuongDan(hinhAnh3.Name);
                tenHinh4.Text = anhao.layTenTheoDuongDan(hinhAnh4.Name);
                tenHinh5.Text = anhao.layTenTheoDuongDan(hinhAnh5.Name);
                tenHinh6.Text = anhao.layTenTheoDuongDan(hinhAnh6.Name);
                tenHinh7.Text = anhao.layTenTheoDuongDan(hinhAnh7.Name);
                tenHinh8.Text = anhao.layTenTheoDuongDan(hinhAnh8.Name);
                tenHinh9.Text = anhao.layTenTheoDuongDan(hinhAnh9.Name);
                tenHinh10.Text = anhao.layTenTheoDuongDan(hinhAnh10.Name);
                tenHinh11.Text = anhao.layTenTheoDuongDan(hinhAnh11.Name);
                tenHinh12.Text = anhao.layTenTheoDuongDan(hinhAnh12.Name);
                tenHinh13.Text = anhao.layTenTheoDuongDan(hinhAnh13.Name);
                tenHinh14.Text = anhao.layTenTheoDuongDan(hinhAnh14.Name);
                tenHinh15.Text = anhao.layTenTheoDuongDan(hinhAnh15.Name);
            }
            catch (Exception)
            {

            }
        }



        public void hienThongTin(String duongDan)
        {
            try
            {
                TheLoai theLoai = new TheLoai();
                Album alBum = new Album();
                HinhAnh anh = new HinhAnh();
                HinhAnh anh2 = new HinhAnh();
                panelChinhSua.Visible = true;

                textTen.Text = duongDan;
                anh2 = anh.layHinhTheoDuongDan(duongDan);
                textTen.Text = anh2.TenHinh;
                textTheLoai.Text = "";
                textAlbum.Text = "";
                textGhiChu.Text = anh2.GhiChu;

                if (anh2.MaTheLoai != null)
                {
                    String tenTheLoai = theLoai.layTheLoaiTheoMaTheLoai(anh2.MaTheLoai).TenTheLoai;
                    textTheLoai.Text = tenTheLoai;
                }
                if (anh2.MaAlbum != null)
                {
                    String tenAlbum = alBum.layAlbumTheoMaAlbum(anh2.MaAlbum).TenAlbum;
                    textAlbum.Text = tenAlbum;
                }

            }
            catch (Exception)
            {

            }
        }


        public void loadAnhTheLoai()
        {

            conboboxtrangTheLoai.Visible = true;
            comboboxTrangAlbum.Visible = false;
            boxPhanTrang.Visible = false;
            resetLaiBoxAnh();
            TheLoai theLoai = new TheLoai();
            HinhAnh anh = new HinhAnh();
            String maTheLoai = theLoai.layMaTrung(comboboxLocTheLoai.GetItemText(comboboxLocTheLoai.SelectedItem));

            List<HinhAnh> danhSachAnhCungTheLoai = anh.layHinhTheoMaTheLoai(maTheLoai);

            int trangTheoTheLoai = tinhSoTrang(danhSachAnhCungTheLoai.Count);

            hienThiSoTrangTheoTrangTheLoai(trangTheoTheLoai);
            List<HinhAnh> danhSachAnhTheoLoaiTrangDau = anh.layAnhTrangDauTienTheoTheLoai(maTheLoai, 1, 15);


            if (danhSachAnhCungTheLoai.Count >= 15)
                hienThiAnh(danhSachAnhTheoLoaiTrangDau);
            else
                hienThiAnh(danhSachAnhCungTheLoai);

            hienThiTenHinh();

        


        }



        public void loadAnhAlbum()
        {
            conboboxtrangTheLoai.Visible = false;
            comboboxTrangAlbum.Visible = true;
            boxPhanTrang.Visible = false;


            resetLaiBoxAnh();
            Album album = new Album();
            HinhAnh anh = new HinhAnh();
            String maAlbum = album.layMaTrung(comboboxLocAlbum.GetItemText(comboboxLocAlbum.SelectedItem));

            List<HinhAnh> danhSachAnhCungAlbum = anh.layHinhTheoMaAlbum(maAlbum);

            int trangAlbum = tinhSoTrang(danhSachAnhCungAlbum.Count);
            hienThiSoTrangTheoTrangAlbum(trangAlbum);
            List<HinhAnh> danhSachAnhTheoAlbumTrangDau = anh.layAnhTrangDauTienTheoAlbum(maAlbum, 1, 15);


            if (danhSachAnhCungAlbum.Count >= 15)
                hienThiAnh(danhSachAnhTheoAlbumTrangDau);
            else
                hienThiAnh(danhSachAnhCungAlbum);

            hienThiTenHinh();
        }

        public void resetCheckbox()
        {
            checkBoxHinh1.CheckState = CheckState.Unchecked;
            checkBoxHinh2.CheckState = CheckState.Unchecked;
            checkBoxHinh3.CheckState = CheckState.Unchecked;
            checkBoxHinh4.CheckState = CheckState.Unchecked;
            checkBoxHinh5.CheckState = CheckState.Unchecked;
            checkBoxHinh6.CheckState = CheckState.Unchecked;
            checkBoxHinh7.CheckState = CheckState.Unchecked;
            checkBoxHinh8.CheckState = CheckState.Unchecked;
            checkBoxHinh9.CheckState = CheckState.Unchecked;
            checkBoxHinh10.CheckState = CheckState.Unchecked;
            checkBoxHinh11.CheckState = CheckState.Unchecked;
            checkBoxHinh12.CheckState = CheckState.Unchecked;
            checkBoxHinh13.CheckState = CheckState.Unchecked;
            checkBoxHinh14.CheckState = CheckState.Unchecked;
            checkBoxHinh15.CheckState = CheckState.Unchecked;
        }
        public void loadAnhTuDaTa()
        {

            boxPhanTrang.Visible = true;
            comboboxTrangAlbum.Visible = false;
            conboboxtrangTheLoai.Visible = false;

            HinhAnh anh = new HinhAnh();

            int dem = anh.demAnh();
            List<HinhAnh> danhSachAnhTrangDau;
            hienThiSoTrang(tinhSoTrang(dem));
            if (dem >= 15)
            {
                danhSachAnhTrangDau = anh.layAnhTrangDauTien(1, 15);
                hienThiAnh(danhSachAnhTrangDau);
            }
            else
            {
                danhSachAnhTrangDau = anh.layAnh();
                hienThiAnh(danhSachAnhTrangDau);
            }

        }
        public void xemAnhFullHD(PictureBox boxAnh)
        {
            hinhXemFull.Visible = true;


            this.Theme = MetroThemeStyle.Dark;
            this.Style = MetroColorStyle.Black;


            String duongDanHinh = boxAnh.Name;
            try
            {
                hinhXemFull.Image = new Bitmap(@duongDanHinh);
            }
            catch (Exception)
            {

            }

            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            hinhXemFull.Visible = true;
            pictureBox1.Parent = hinhXemFull;
            pictureBox2.Parent = hinhXemFull;
            pictureBox3.Parent = hinhXemFull;
        }
        public bool resetLaiBoxAnh()
        {
            hinhAnh1.Name = "";
            hinhAnh2.Name = "";
            hinhAnh3.Name = "";
            hinhAnh4.Name = "";
            hinhAnh5.Name = "";
            hinhAnh6.Name = "";
            hinhAnh7.Name = "";
            hinhAnh8.Name = "";
            hinhAnh9.Name = "";
            hinhAnh10.Name = "";
            hinhAnh11.Name = "";
            hinhAnh12.Name = "";
            hinhAnh13.Name = "";
            hinhAnh14.Name = "";
            hinhAnh15.Name = "";
            hinhAnh1.Image = null;
            hinhAnh2.Image = null;
            hinhAnh3.Image = null;
            hinhAnh4.Image = null;
            hinhAnh5.Image = null;
            hinhAnh6.Image = null;
            hinhAnh7.Image = null;
            hinhAnh8.Image = null;
            hinhAnh9.Image = null;
            hinhAnh10.Image = null;
            hinhAnh11.Image = null;
            hinhAnh12.Image = null;
            hinhAnh13.Image = null;
            hinhAnh14.Image = null;
            hinhAnh15.Image = null;
            tenHinh1.Text = "";
            tenHinh2.Text = "";
            tenHinh3.Text = "";
            tenHinh4.Text = "";
            tenHinh5.Text = "";
            tenHinh6.Text = "";
            tenHinh7.Text = "";
            tenHinh8.Text = "";
            tenHinh9.Text = "";
            tenHinh10.Text = "";
            tenHinh11.Text = "";
            tenHinh12.Text = "";
            tenHinh13.Text = "";
            tenHinh14.Text = "";
            tenHinh15.Text = "";
            return true;

        }


        public void hienThiSoTrangTheoTrangAlbum(int soTrang)
        {

            try
            {
                comboboxTrangAlbum.Items.Clear();
                if (soTrang == 0)
                    comboboxTrangAlbum.Items.Add(1);
                for (int i = 1; i <= soTrang; i++)
                {
                    comboboxTrangAlbum.Items.Add(i);

                }
                comboboxTrangAlbum.SelectedIndex = 0;
            }
            catch (Exception)
            {

            }

        }


        public void hienThiSoTrang(int soTrang)
        {

            try
            {
                boxPhanTrang.Items.Clear();
                for (int i = 1; i <= soTrang; i++)
                {
                    boxPhanTrang.Items.Add(i);
                }
                boxPhanTrang.SelectedIndex = 0;
            }
            catch (Exception)
            {

            }
        }
        public void hienThiSoTrangTheoTrangTheLoai(int soTrang)
        {


            try
            {
                conboboxtrangTheLoai.Items.Clear();
                if (soTrang == 0)
                {
                    conboboxtrangTheLoai.Items.Add(1);

                }
                for (int i = 1; i <= soTrang; i++)
                {
                    conboboxtrangTheLoai.Items.Add(i);
                }
                conboboxtrangTheLoai.SelectedIndex = 0;
            }
            catch (Exception)
            {

            }
        }


        #endregion


        
        public FormXemAnh()
        {
            InitializeComponent();
        }


       
        private void XemAnh_Load(object sender, EventArgs e)
        {
            boxPhanTrang.Visible = true;
            TheLoai theLoaia = new TheLoai();
            List<TheLoai> danhSachTheLoai = theLoaia.layTheLoai();
            for (int i = 0; i <= danhSachTheLoai.Count - 1; i++)
            {
                comboboxTheLoai.Items.Add(danhSachTheLoai[i].TenTheLoai);
                comboboxLocTheLoai.Items.Add(danhSachTheLoai[i].TenTheLoai);
            }
            Album albuma = new Album();
            List<Album> danhSachAlbum = albuma.layAlbum();
            for (int i = 0; i <= danhSachAlbum.Count - 1; i++)
            { 
                comboboxAlbum.Items.Add(danhSachAlbum[i].TenAlbum);
                comboboxLocAlbum.Items.Add(danhSachAlbum[i].TenAlbum);
            }
            
                

                if (chucNangDangChon != 1)
                {
                    HinhAnh anh = new HinhAnh();

                    chucNangDangChon = 1;

                    int dem = anh.demAnh();
                    List<HinhAnh> danhSachAnhTrangDau;
                    hienThiSoTrang(tinhSoTrang(dem));
                    if (dem >= 15)
                    {
                        danhSachAnhTrangDau = anh.layAnhTrangDauTien(1, 15);
                        hienThiAnh(danhSachAnhTrangDau);
                    }
                    else
                    {
                        danhSachAnhTrangDau = anh.layAnh();
                        hienThiAnh(danhSachAnhTrangDau);
                    }

                    disableCheckBox();

                }

            
            HinhAnh anhao = new HinhAnh();
            try {
                tenHinh1.Text = anhao.layTenTheoDuongDan(hinhAnh1.Name);
                tenHinh2.Text = anhao.layTenTheoDuongDan(hinhAnh2.Name);
                tenHinh3.Text = anhao.layTenTheoDuongDan(hinhAnh3.Name);
                tenHinh4.Text = anhao.layTenTheoDuongDan(hinhAnh4.Name);
                tenHinh5.Text = anhao.layTenTheoDuongDan(hinhAnh5.Name);
                tenHinh6.Text = anhao.layTenTheoDuongDan(hinhAnh6.Name);
                tenHinh7.Text = anhao.layTenTheoDuongDan(hinhAnh7.Name);
                tenHinh8.Text = anhao.layTenTheoDuongDan(hinhAnh8.Name);
                tenHinh9.Text = anhao.layTenTheoDuongDan(hinhAnh9.Name);
                tenHinh10.Text = anhao.layTenTheoDuongDan(hinhAnh10.Name);
                tenHinh11.Text = anhao.layTenTheoDuongDan(hinhAnh11.Name);
                tenHinh12.Text = anhao.layTenTheoDuongDan(hinhAnh12.Name);
                tenHinh13.Text = anhao.layTenTheoDuongDan(hinhAnh13.Name);
                tenHinh14.Text = anhao.layTenTheoDuongDan(hinhAnh14.Name);
                tenHinh15.Text = anhao.layTenTheoDuongDan(hinhAnh15.Name);
            }
            catch(Exception)
            {

            }
           

           

        }

    

        
       
       
        private void boxPhanTrang_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Int32.Parse(boxPhanTrang.SelectedIndex.ToString()) != 0)
            {
                resetLaiBoxAnh();

            }

            int soTrang = Int32.Parse(boxPhanTrang.SelectedIndex.ToString());
            HinhAnh anh = new HinhAnh();
            List<HinhAnh> danhSachAnhTheoTang = anh.layHinhTheoTrang(soTrang * 15, 15);      
            hienThiAnh(danhSachAnhTheoTang);


            hienThiTenHinh();
            disableCheckBox();
         

        }

        
        private void hinhAnh1_Click(object sender, EventArgs e)
        {
            duongDan = hinhAnh1.Name;
            hienThongTin(duongDan);
        }

        private void hinhAnh1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void panelChinhSua_MouseLeave(object sender, EventArgs e)
        {
         
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {

            HinhAnh anh = new HinhAnh();
            TheLoai theLoai = new TheLoai();
            Album alBum = new Album();
            anh.DuongDan = duongDan;
            anh.TenHinh = textTen.Text;
            anh.GhiChu = textGhiChu.Text;


            String maTheLoai = "";
            String maAlBum = "";





            //kiem tra trung the loai va album
            if (textTheLoai.Text != "" && theLoai.kiemTraTrungTheLoai(textTheLoai.Text.ToLower()) == false)
            {

                
                maTheLoai = theLoai.layMaTrung(textTheLoai.Text.ToLower());

            }

            if (textAlbum.Text != "" && alBum.kiemTraTrungAlbum(textAlbum.Text.ToLower()) == false)
            {

             
                maAlBum = alBum.layMaTrung(textAlbum.Text.ToLower());
            }




            if (textTheLoai.Text != "" && theLoai.kiemTraTrungTheLoai(textTheLoai.Text.ToLower()) == true)
            {

                TheLoai themMoi = new TheLoai(textTheLoai.Text);
                themMoi.themTheLoai(themMoi);
                maTheLoai = themMoi.MaTheLoai;
            }
            if (textAlbum.Text != "" && alBum.kiemTraTrungAlbum(textAlbum.Text.ToLower()) == true)
            {

                Album themMoi = new Album(textAlbum.Text);
                themMoi.themAlbum(themMoi);
                maAlBum = themMoi.MaAlbum;
            }



            List<HinhAnh> danhSachCheckBox = new List<HinhAnh>();
            if (checkBoxHinh1.CheckState == CheckState.Checked)
            {
                HinhAnh hinh1 = new HinhAnh();
                hinh1 = hinh1.layHinhTheoDuongDan(hinhAnh1.Name);
                danhSachCheckBox.Add(hinh1);
            }
            if (checkBoxHinh2.CheckState == CheckState.Checked)
            {
                HinhAnh hinh2 = new HinhAnh();
                hinh2 = hinh2.layHinhTheoDuongDan(hinhAnh2.Name);
                danhSachCheckBox.Add(hinh2);

            }
            if (checkBoxHinh3.CheckState == CheckState.Checked)
            {
                HinhAnh hinh3 = new HinhAnh();
                hinh3 = hinh3.layHinhTheoDuongDan(hinhAnh3.Name);
                danhSachCheckBox.Add(hinh3);

            }
            if (checkBoxHinh4.CheckState == CheckState.Checked)
            {
                HinhAnh hinh4 = new HinhAnh();
                hinh4 = hinh4.layHinhTheoDuongDan(hinhAnh4.Name);
                danhSachCheckBox.Add(hinh4);
            }
            if (checkBoxHinh5.CheckState == CheckState.Checked)
            {
                HinhAnh hinh5 = new HinhAnh();
                hinh5 = hinh5.layHinhTheoDuongDan(hinhAnh5.Name);
                danhSachCheckBox.Add(hinh5);
            }
            if (checkBoxHinh6.CheckState == CheckState.Checked)
            {
                HinhAnh hinh6 = new HinhAnh();
                hinh6 = hinh6.layHinhTheoDuongDan(hinhAnh6.Name);
                danhSachCheckBox.Add(hinh6);
            }
            if (checkBoxHinh7.CheckState == CheckState.Checked)
            {
                HinhAnh hinh7 = new HinhAnh();
                hinh7 = hinh7.layHinhTheoDuongDan(hinhAnh7.Name);
                danhSachCheckBox.Add(hinh7);
            }
            if (checkBoxHinh8.CheckState == CheckState.Checked)
            {
                HinhAnh hinh8 = new HinhAnh();
                hinh8 = hinh8.layHinhTheoDuongDan(hinhAnh8.Name);
                danhSachCheckBox.Add(hinh8);
            }
            if (checkBoxHinh9.CheckState == CheckState.Checked)
            {
                HinhAnh hinh9 = new HinhAnh();
                hinh9 = hinh9.layHinhTheoDuongDan(hinhAnh9.Name);
                danhSachCheckBox.Add(hinh9);
            }
            if (checkBoxHinh10.CheckState == CheckState.Checked)
            {
                HinhAnh hinh10 = new HinhAnh();
                hinh10 = hinh10.layHinhTheoDuongDan(hinhAnh10.Name);
                danhSachCheckBox.Add(hinh10);
            }
            if (checkBoxHinh11.CheckState == CheckState.Checked)
            {
                HinhAnh hinh11 = new HinhAnh();
                hinh11 = hinh11.layHinhTheoDuongDan(hinhAnh11.Name);
                danhSachCheckBox.Add(hinh11);
            }
            if (checkBoxHinh12.CheckState == CheckState.Checked)
            {
                HinhAnh hinh12 = new HinhAnh();
                hinh12 = hinh12.layHinhTheoDuongDan(hinhAnh12.Name);
                danhSachCheckBox.Add(hinh12);
            }
            if (checkBoxHinh13.CheckState == CheckState.Checked)
            {
                HinhAnh hinh13 = new HinhAnh();
                hinh13 = hinh13.layHinhTheoDuongDan(hinhAnh13.Name);
                danhSachCheckBox.Add(hinh13);
            }
            if (checkBoxHinh14.CheckState == CheckState.Checked)
            {
                HinhAnh hinh14 = new HinhAnh();
                hinh14 = hinh14.layHinhTheoDuongDan(hinhAnh14.Name);
                danhSachCheckBox.Add(hinh14);
            }
            if (checkBoxHinh15.CheckState == CheckState.Checked)
            {
                HinhAnh hinh15 = new HinhAnh();
                hinh15 = hinh15.layHinhTheoDuongDan(hinhAnh15.Name);
                danhSachCheckBox.Add(hinh15);
            }
            anh.MaTheLoai = maTheLoai;
            anh.MaAlbum = maAlBum;
            anh.TenHinh = textTen.Text;
            anh.GhiChu = textGhiChu.Text;
            
            if (kiemTraCheck() == true)
            {
                if (thayDoiTheLoai == true)
                {

                    for (int i = 0; i <= danhSachCheckBox.Count - 1; i++)
                    {
                        HinhAnh hinhTam = new HinhAnh();
                        hinhTam.DuongDan = danhSachCheckBox[i].DuongDan;
                        hinhTam.MaTheLoai = maTheLoai;
                        hinhTam.MaAlbum = anh.layHinhTheoDuongDan(danhSachCheckBox[i].DuongDan).MaAlbum;
                        hinhTam.TenHinh = anh.layTenTheoDuongDan(danhSachCheckBox[i].DuongDan);
                        hinhTam.GhiChu = (anh.layHinhTheoDuongDan(danhSachCheckBox[i].DuongDan)).GhiChu;
                        anh.capNhatAnh(hinhTam);
                    }

                }
                if (thayDoiAlbum == true)
                {
                    for (int i = 0; i <= danhSachCheckBox.Count - 1; i++)
                    {
                        HinhAnh hinhTam = new HinhAnh();
                        hinhTam.DuongDan = danhSachCheckBox[i].DuongDan;
                        hinhTam.MaTheLoai = anh.layHinhTheoDuongDan(danhSachCheckBox[i].DuongDan).MaTheLoai;
                        hinhTam.MaAlbum = maAlBum;
                        hinhTam.TenHinh = anh.layTenTheoDuongDan(danhSachCheckBox[i].DuongDan);
                        hinhTam.GhiChu = (anh.layHinhTheoDuongDan(danhSachCheckBox[i].DuongDan)).GhiChu;
                        anh.capNhatAnh(hinhTam);
                    }

                    if (thayDoiAlbum == true && thayDoiTheLoai == true)
                    {
                        for (int i = 0; i <= danhSachCheckBox.Count - 1; i++)
                        {
                            HinhAnh hinhTam = new HinhAnh();
                            hinhTam.DuongDan = danhSachCheckBox[i].DuongDan;
                            hinhTam.MaTheLoai = maTheLoai;
                            hinhTam.MaAlbum = maAlBum;
                            hinhTam.TenHinh = anh.layTenTheoDuongDan(danhSachCheckBox[i].DuongDan);
                            hinhTam.GhiChu = (anh.layHinhTheoDuongDan(danhSachCheckBox[i].DuongDan)).GhiChu;
                            anh.capNhatAnh(hinhTam);


                        }
                    }

                }
            }

      
                if (textAlbum.Text == "" && textTheLoai.Text == "")
                    MetroMessageBox.Show(Owner, "Bạn Chưa Điền Thông Tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                else
                    MetroMessageBox.Show(Owner, "Cập Nhật Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);

                anh.capNhatAnh(anh);


                panelChinhSua.Visible = false;
                tenHinh1.Text = anh.layTenTheoDuongDan(hinhAnh1.Name);
                tenHinh2.Text = anh.layTenTheoDuongDan(hinhAnh2.Name);
                tenHinh3.Text = anh.layTenTheoDuongDan(hinhAnh3.Name);
                tenHinh4.Text = anh.layTenTheoDuongDan(hinhAnh4.Name);
                tenHinh5.Text = anh.layTenTheoDuongDan(hinhAnh5.Name);
                tenHinh6.Text = anh.layTenTheoDuongDan(hinhAnh6.Name);
                tenHinh7.Text = anh.layTenTheoDuongDan(hinhAnh7.Name);
                tenHinh8.Text = anh.layTenTheoDuongDan(hinhAnh8.Name);
                tenHinh9.Text = anh.layTenTheoDuongDan(hinhAnh9.Name);
                tenHinh10.Text = anh.layTenTheoDuongDan(hinhAnh10.Name);
                tenHinh11.Text = anh.layTenTheoDuongDan(hinhAnh11.Name);
                tenHinh12.Text = anh.layTenTheoDuongDan(hinhAnh12.Name);
                tenHinh13.Text = anh.layTenTheoDuongDan(hinhAnh13.Name);
                tenHinh14.Text = anh.layTenTheoDuongDan(hinhAnh14.Name);
                tenHinh15.Text = anh.layTenTheoDuongDan(hinhAnh15.Name);





                resetCheckbox();
                thayDoiTheLoai = false;
                thayDoiAlbum = false;
            
        }

        private void panelChinhSua_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void hinhAnh2_Click(object sender, EventArgs e)
        {
            
            duongDan = hinhAnh2.Name;
            hienThongTin(duongDan);
            
        }

        private void hinhAnh3_Click(object sender, EventArgs e)
        {
            duongDan = hinhAnh3.Name;
            hienThongTin(duongDan);
            
        }

        private void hinhAnh4_Click(object sender, EventArgs e)
        {
            duongDan = hinhAnh4.Name;
            hienThongTin(duongDan);
            
        }

        private void hinhAnh5_Click(object sender, EventArgs e)
        {
            duongDan = hinhAnh5.Name;
            hienThongTin(duongDan);
            
        }

        private void hinhAnh6_Click(object sender, EventArgs e)
        {
            duongDan = hinhAnh6.Name;
            hienThongTin(duongDan);
            
        }

        private void hinhAnh7_Click(object sender, EventArgs e)
        {
            duongDan = hinhAnh7.Name;
            hienThongTin(duongDan);
            
        }

        private void hinhAnh8_Click(object sender, EventArgs e)
        {
            duongDan = hinhAnh8.Name;
            hienThongTin(duongDan);
            
        }

        private void hinhAnh9_Click(object sender, EventArgs e)
        {
            duongDan = hinhAnh9.Name;
            hienThongTin(duongDan);
            
        }

        private void hinhAnh10_Click(object sender, EventArgs e)
        {
            duongDan = hinhAnh10.Name;
            hienThongTin(duongDan);
            
        }

        private void hinhAnh11_Click(object sender, EventArgs e)
        {
            duongDan = hinhAnh11.Name;
            hienThongTin(duongDan);
            
        }

        private void hinhAnh12_Click(object sender, EventArgs e)
        {
            duongDan = hinhAnh12.Name;
            hienThongTin(duongDan);
            
        }

        private void hinhAnh13_Click(object sender, EventArgs e)
        {
            duongDan = hinhAnh13.Name;
            hienThongTin(duongDan);
            

        }

        private void hinhAnh14_Click(object sender, EventArgs e)
        {
            duongDan = hinhAnh14.Name;
            hienThongTin(duongDan);
            
        }

        private void hinhAnh15_Click(object sender, EventArgs e)
        {
            duongDan = hinhAnh15.Name;
            hienThongTin(duongDan);

        }

        public void hienPanelThongTin(String doiTuong)
        {
        }

        private void hinhAnh1_MouseHover(object sender, EventArgs e)
        {
            tooltipHinhAnh.Show("DoubleClic Để Xem Toàn Màn Hình", hinhAnh1);
           
           
           

        }

        private void hinhAnh1_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void FormXemAnh_MouseClick(object sender, MouseEventArgs e)
        {
            panelChinhSua.Visible = false;
        }

        private void hinhAnh2_MouseHover(object sender, EventArgs e)
        {
        }

        private void hinhAnh2_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void btnThoat2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hinhAnh11_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            HinhAnh anh = new HinhAnh();
          
            

            List<HinhAnh> danhSachCheckBox = new List<HinhAnh>();
            if (checkBoxHinh1.CheckState == CheckState.Checked)
            {
                HinhAnh hinh1 = new HinhAnh();
                hinh1 = hinh1.layHinhTheoDuongDan(hinhAnh1.Name);
                danhSachCheckBox.Add(hinh1);
            }
            if (checkBoxHinh2.CheckState == CheckState.Checked)
            {
                HinhAnh hinh2 = new HinhAnh();
                hinh2 = hinh2.layHinhTheoDuongDan(hinhAnh2.Name);
                danhSachCheckBox.Add(hinh2);

            }
            if (checkBoxHinh3.CheckState == CheckState.Checked)
            {
                HinhAnh hinh3 = new HinhAnh();
                hinh3 = hinh3.layHinhTheoDuongDan(hinhAnh3.Name);
                danhSachCheckBox.Add(hinh3);

            }
            if (checkBoxHinh4.CheckState == CheckState.Checked)
            {
                HinhAnh hinh4 = new HinhAnh();
                hinh4 = hinh4.layHinhTheoDuongDan(hinhAnh4.Name);
                danhSachCheckBox.Add(hinh4);
            }
            if (checkBoxHinh5.CheckState == CheckState.Checked)
            {
                HinhAnh hinh5 = new HinhAnh();
                hinh5 = hinh5.layHinhTheoDuongDan(hinhAnh5.Name);
                danhSachCheckBox.Add(hinh5);
            }
            if (checkBoxHinh6.CheckState == CheckState.Checked)
            {
                HinhAnh hinh6 = new HinhAnh();
                hinh6 = hinh6.layHinhTheoDuongDan(hinhAnh6.Name);
                danhSachCheckBox.Add(hinh6);
            }
            if (checkBoxHinh7.CheckState == CheckState.Checked)
            {
                HinhAnh hinh7 = new HinhAnh();
                hinh7 = hinh7.layHinhTheoDuongDan(hinhAnh7.Name);
                danhSachCheckBox.Add(hinh7);
            }
            if (checkBoxHinh8.CheckState == CheckState.Checked)
            {
                HinhAnh hinh8 = new HinhAnh();
                hinh8 = hinh8.layHinhTheoDuongDan(hinhAnh8.Name);
                danhSachCheckBox.Add(hinh8);
            }
            if (checkBoxHinh9.CheckState == CheckState.Checked)
            {
                HinhAnh hinh9 = new HinhAnh();
                hinh9 = hinh9.layHinhTheoDuongDan(hinhAnh9.Name);
                danhSachCheckBox.Add(hinh9);
            }
            if (checkBoxHinh10.CheckState == CheckState.Checked)
            {
                HinhAnh hinh10 = new HinhAnh();
                hinh10 = hinh10.layHinhTheoDuongDan(hinhAnh10.Name);
                danhSachCheckBox.Add(hinh10);
            }
            if (checkBoxHinh11.CheckState == CheckState.Checked)
            {
                HinhAnh hinh11 = new HinhAnh();
                hinh11 = hinh11.layHinhTheoDuongDan(hinhAnh11.Name);
                danhSachCheckBox.Add(hinh11);
            }
            if (checkBoxHinh12.CheckState == CheckState.Checked)
            {
                HinhAnh hinh12 = new HinhAnh();
                hinh12 = hinh12.layHinhTheoDuongDan(hinhAnh12.Name);
                danhSachCheckBox.Add(hinh12);
            }
            if (checkBoxHinh13.CheckState == CheckState.Checked)
            {
                HinhAnh hinh13 = new HinhAnh();
                hinh13 = hinh13.layHinhTheoDuongDan(hinhAnh13.Name);
                danhSachCheckBox.Add(hinh13);
            }
            if (checkBoxHinh14.CheckState == CheckState.Checked)
            {
                HinhAnh hinh14 = new HinhAnh();
                hinh14 = hinh14.layHinhTheoDuongDan(hinhAnh14.Name);
                danhSachCheckBox.Add(hinh14);
            }
            if (checkBoxHinh15.CheckState == CheckState.Checked)
            {
                HinhAnh hinh15 = new HinhAnh();
                hinh15 = hinh15.layHinhTheoDuongDan(hinhAnh15.Name);
                danhSachCheckBox.Add(hinh15);
            }

            for(int i=0;i<=danhSachCheckBox.Count-1;i++)
            {
                anh.xoaAnhTheoDuongDan(danhSachCheckBox[i].DuongDan);
            }
            danhSachCheckBox.Clear();




            MetroMessageBox.Show(this, "Xóa Thành Công.", "Thông Báo", MessageBoxButtons.OK);
            loadAnhTuDaTa();

            resetCheckbox();

            if (comboboxLocTheLoai.SelectedIndex > -1)
                loadAnhTheLoai();
            else if (comboboxAlbum.SelectedIndex > -1)
                loadAnhAlbum();
            else
            loadAnhTuDaTa();
          

        }


        

       
        private void hinhAnh1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {


            xemAnhFullHD(hinhAnh1);
            
        }


        

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            hinhXemFull.Visible = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            this.Theme = MetroThemeStyle.Light;
            this.Style = MetroColorStyle.Blue;
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            count = count - 1;
            if (count < 0)
                count = 0;
            HinhAnh loadAnh = new HinhAnh();
            List<HinhAnh> dataAnh = loadAnh.layAnh();
            hinhXemFull.Image = new Bitmap(@dataAnh[count].DuongDan);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HinhAnh anh = new HinhAnh();

            try
            {
                count = count + 1;
                if (count > anh.layAnh().Count())
                    count = anh.layAnh().Count();
                HinhAnh loadAnh = new HinhAnh();
                List<HinhAnh> dataAnh = loadAnh.layAnh();
                hinhXemFull.Image = new Bitmap(@dataAnh[count].DuongDan);
            }
            catch (Exception ex)
            {

            }
        }

        private void hinhAnh2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            xemAnhFullHD(hinhAnh2);
           
          
        }

        private void hinhAnh3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            xemAnhFullHD(hinhAnh3);
        }

        private void hinhAnh4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            xemAnhFullHD(hinhAnh4);
        }

        private void hinhAnh5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            xemAnhFullHD(hinhAnh5);
        }

        private void hinhAnh6_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            xemAnhFullHD(hinhAnh6);
        }

        private void hinhAnh7_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            xemAnhFullHD(hinhAnh7);
        }

        private void hinhAnh8_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            xemAnhFullHD(hinhAnh8);
        }

        private void hinhAnh9_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            xemAnhFullHD(hinhAnh9);
        }

        private void hinhAnh11_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            xemAnhFullHD(hinhAnh11);
        }

        private void hinhAnh10_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            xemAnhFullHD(hinhAnh10);
        }

        private void hinhAnh12_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            xemAnhFullHD(hinhAnh12);
        }

        private void hinhAnh13_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            xemAnhFullHD(hinhAnh13);
        }

        private void hinhAnh14_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            xemAnhFullHD(hinhAnh14);
        }

        private void hinhAnh15_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            xemAnhFullHD(hinhAnh15);
        }

        private void FormXemAnh_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnAo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                count = count - 1;
                if (count < 0)
                    count = 0;
                HinhAnh loadAnh = new HinhAnh();
                List<HinhAnh> dataAnh = loadAnh.layAnh();
                hinhXemFull.Image = new Bitmap(@dataAnh[count].DuongDan);
            }
            if(e.KeyCode == Keys.Right)
            {
                HinhAnh anh = new HinhAnh();

                try
                {
                    count = count + 1;
                    if (count > anh.layAnh().Count())
                        count = anh.layAnh().Count();
                    HinhAnh loadAnh = new HinhAnh();
                    List<HinhAnh> dataAnh = loadAnh.layAnh();
                    hinhXemFull.Image = new Bitmap(@dataAnh[count].DuongDan);
                }
                catch (Exception ex)
                {

                }
            }

        }

        private void metroButton1_KeyDown(object sender, KeyEventArgs e)
        {
           

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hinhXemFull_Click(object sender, EventArgs e)
        {

        }

        private void buttonleft_Click(object sender, EventArgs e)
        {

        }

        private void xepTheoTheLoai_Click(object sender, EventArgs e)
        {

        }

        private void xepTheoTheLoai_DropDownClosed(object sender, EventArgs e)
        {
           
        }

        private void comboboxTheLoai_Click(object sender, EventArgs e)
        {
            
        }

        private void comboboxTheLoai_DropDownClosed(object sender, EventArgs e)
        {
            
        }

        private void comboboxTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

           
            textTheLoai.Text = comboboxTheLoai.GetItemText(comboboxTheLoai.SelectedItem);
        }

        private void comboboxAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            textAlbum.Text = comboboxAlbum.GetItemText(comboboxAlbum.SelectedItem);
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

      
        private void comboboxLocTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

            loadAnhTheLoai();
            disableCheckBox();
            
           

        }

        private void conboboxtrangTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetLaiBoxAnh();
            int sotrang = Int32.Parse(conboboxtrangTheLoai.SelectedIndex.ToString());
            HinhAnh anh = new HinhAnh();
            TheLoai theLoai = new TheLoai();
            String maTheLoai = theLoai.layMaTrung(comboboxLocTheLoai.GetItemText(comboboxLocTheLoai.SelectedItem));
            List<HinhAnh> danhSachAnhTheoTrangTheoTheLoai = anh.layHinhTheLoaiTheoTrang(maTheLoai, sotrang * 15, 15);
            hienThiAnh(danhSachAnhTheoTrangTheoTheLoai);
            hienThiTenHinh();
        }

        private void comboboxTrangAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetLaiBoxAnh();
            int sotrang = Int32.Parse(comboboxTrangAlbum.SelectedIndex.ToString());
            HinhAnh anh = new HinhAnh();
            Album album = new Album();
            String maAlbum = album.layMaTrung(comboboxLocAlbum.GetItemText(comboboxLocAlbum.SelectedItem));
            List<HinhAnh> danhSachAnhTheoTrangTheoAlbum = anh.layHinhTheoAlbumTheoTrang(maAlbum, sotrang * 15, 15);
            hienThiAnh(danhSachAnhTheoTrangTheoAlbum);
            hienThiTenHinh();

        }

        


        private void comboboxLocAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {


            loadAnhAlbum();
            disableCheckBox();
           
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

            loadAnhTuDaTa();

        }

        private void hinhAnh2_MouseHover_1(object sender, EventArgs e)
        {
            tooltipHinhAnh.Show("DoubleClic Để Xem Toàn Màn Hình", hinhAnh2);
        }

        private void hinhAnh1_DragLeave(object sender, EventArgs e)
        {
           
        }
        int dem = 0;
        void btn_Click(object sender, EventArgs e)
        {
            dem++;
        }
        private void btn_chonFileXoa_Click(object sender, EventArgs e)
        {
            

           

        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            btnChonAnh.Click += btn_Click;
            if (dem % 2 == 0)
            {

                checkBoxHinh1.Visible = true;
                checkBoxHinh2.Visible = true;
                checkBoxHinh3.Visible = true;
                checkBoxHinh4.Visible = true;
                checkBoxHinh5.Visible = true;
                checkBoxHinh6.Visible = true;
                checkBoxHinh7.Visible = true;
                checkBoxHinh8.Visible = true;
                checkBoxHinh9.Visible = true;
                checkBoxHinh10.Visible = true;
                checkBoxHinh11.Visible = true;
                checkBoxHinh12.Visible = true;
                checkBoxHinh13.Visible = true;
                checkBoxHinh14.Visible = true;
                checkBoxHinh15.Visible = true;
            }
            else
            {
                checkBoxHinh1.Visible = false;
                checkBoxHinh2.Visible = false;
                checkBoxHinh3.Visible = false;
                checkBoxHinh4.Visible = false;
                checkBoxHinh5.Visible = false;
                checkBoxHinh6.Visible = false;
                checkBoxHinh7.Visible = false;
                checkBoxHinh8.Visible = false;
                checkBoxHinh9.Visible = false;
                checkBoxHinh10.Visible = false;
                checkBoxHinh11.Visible = false;
                checkBoxHinh12.Visible = false;
                checkBoxHinh13.Visible = false;
                checkBoxHinh14.Visible = false;
                checkBoxHinh15.Visible = false;

            }

            disableCheckBox();
                
        }

        private void tenHinh7_Click(object sender, EventArgs e)
        {

        }

        private void tenHinh6_Click(object sender, EventArgs e)
        {

        }
        bool thayDoiTheLoai = false;
        bool thayDoiAlbum = false;
        private void textTheLoai_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textAlbum_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void textTheLoai_KeyUp(object sender, KeyEventArgs e)
        {
            thayDoiTheLoai = true;

        }

        private void textAlbum_KeyUp(object sender, KeyEventArgs e)
        {
            thayDoiAlbum = true;
        }



        

    }
    
}
