using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picture_Viewer
{
    public partial class TheLoai
    {
        CONNECTDataContext ketNoi = new CONNECTDataContext();

        public TheLoai(String maTheLoai, String tenTheLoai)
        {
            this.MaTheLoai = maTheLoai;
            this.TenTheLoai = tenTheLoai;
        }

        public TheLoai(String tenTheLoai)
        {
            this.MaTheLoai = tangMaTheLoai();
            this.TenTheLoai = tenTheLoai;
        }
        public List<TheLoai> layTheLoai()
        {
            try
            {
                var ketQua = (from tam in ketNoi.TheLoais select tam).ToList();

                return ketQua;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool capNhat(TheLoai theLoai)
        {
            try
            {
                var ketQua = from hinh in ketNoi.TheLoais
                             where hinh.MaTheLoai == theLoai.MaTheLoai
                             select hinh;
                foreach(var tam in ketQua)
                {
                    tam.TenTheLoai = theLoai.TenTheLoai;
                }

                ketNoi.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
        public bool xoaTheoMaTheLoai(String maTheLoai)
        {
            try
            {
                var ketQua  = from tl in ketNoi.TheLoais where tl.MaTheLoai == maTheLoai select tl;

                foreach (TheLoai tam in ketQua)
                {
                    ketNoi.TheLoais.DeleteOnSubmit(tam);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool kiemTraTrungTheLoai(String tenTheLoai)// bi trung tra ve false ko trung tra ve true
        {
            List<TheLoai> danhSachTheLoai = layTheLoai();
            for (int i = 0; i <= danhSachTheLoai.Count - 1; i++)
            {
                if (danhSachTheLoai[i].TenTheLoai == tenTheLoai)
                    return false;
            }
            return true;
            
        }

        public String layMaTrung(String tenTheLoai)
        {
            String maTrung = "";
            List<TheLoai> danhSachTheLoai = layTheLoai();
            for (int i = 0; i <= danhSachTheLoai.Count - 1; i++)
            {
                if (danhSachTheLoai[i].TenTheLoai == tenTheLoai)
                    maTrung =  danhSachTheLoai[i].MaTheLoai ;
            }
            return maTrung;


        }
        public TheLoai layTheLoaiTheoMaTheLoai(String maTheLoai)
        {
            try
            {
                var ketQua = (from tam in ketNoi.TheLoais where tam.MaTheLoai == maTheLoai select tam).FirstOrDefault();
                return ketQua;


            }
            catch (Exception)
            {
                return null;
            }
        }
        public String tangMaTheLoai()
        {
            List<TheLoai> dem = layTheLoai();
            String maTheLoai = "";
            int day = System.DateTime.Now.Day;
            int moth = System.DateTime.Now.Month;
            int year = System.DateTime.Now.Year;
            int tong = day + moth + year + dem.Count();
            maTheLoai = "tl" + tong.ToString();
            return maTheLoai;
        }

        public bool themTheLoai(TheLoai theLoai)
        {
         
            try
            {
                ketNoi.TheLoais.InsertOnSubmit(theLoai);
                ketNoi.SubmitChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }
        

    }
}
