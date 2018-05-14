using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picture_Viewer
{
    
    public partial class HinhAnh
    {
        CONNECTDataContext ketNoi = new CONNECTDataContext();
        public HinhAnh(String DuongDan, String TenAnh, String GhiChu, String maAlbum, string maTheLoai)
        {
            this.DuongDan = DuongDan;
            this.TenHinh = TenAnh;
            this.GhiChu = GhiChu;
            this.MaAlbum = maAlbum;
            this.MaTheLoai = maTheLoai;
            
        }



        public String layTenTheoDuongDan(String duongDan)
        {
            try
            {
                var ketQua = (from hinh in ketNoi.HinhAnhs
                              where hinh.DuongDan == duongDan
                              select hinh).FirstOrDefault();
                return ketQua.TenHinh;
            }
            catch(Exception)
            {
                return null;
            }
        }

        public List<HinhAnh> layAnhTrangDauTienTheoAlbum(String maAlbum, int batDau, int ketThuc)
        {
            var ketQua = (from anh in ketNoi.HinhAnhs
                          where anh.MaAlbum == maAlbum
                          select anh).Take(ketThuc - batDau + 1).ToList();
            return ketQua;
        }

        public List<HinhAnh> layHinhTheoAlbumTheoTrang(String maAlbum, int boQua, int lay)
        {
            var ketQua = (from hinh in ketNoi.HinhAnhs
                          where hinh.MaAlbum == maAlbum
                          select hinh).Skip(boQua).Take(lay).ToList();
            return ketQua;
        }

        public List<HinhAnh> layHinhTheoMaAlbum(String maAlbum)
        {
            try
            {
                var ketQua = (from hinh in ketNoi.HinhAnhs
                              where hinh.MaAlbum == maAlbum
                              select hinh).ToList();
                return ketQua;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public  List<HinhAnh> layHinhTheoTrang(int boQua, int lay)
        {
            var ketQua = (from hinh in ketNoi.HinhAnhs
                          select hinh).Skip(boQua).Take(lay).ToList();
            return ketQua;

        }
        public bool capNhatAnh(HinhAnh anh)
        {
            try
            {
                var ketQua = from HinhAnh in ketNoi.HinhAnhs
                             where HinhAnh.DuongDan == anh.DuongDan
                             select HinhAnh;
                foreach (var tam in ketQua)
                {
                    tam.TenHinh = anh.TenHinh;
                    tam.MaTheLoai = anh.MaTheLoai;
                    tam.GhiChu = anh.GhiChu;
                    tam.MaAlbum = anh.MaAlbum;

                }
                ketNoi.SubmitChanges();
                return true;

            }
            catch (Exception)
            {
                return false;

            }


        }

        public bool xoaAnhTheoMaTheLoai(String maTheLoai)
        {

            try
            {
                var ketQua = (from hinh in ketNoi.HinhAnhs 
                             where hinh.MaTheLoai == maTheLoai 
                             select hinh).ToList();
                foreach (HinhAnh tam in ketQua)
                {
                    ketNoi.HinhAnhs.DeleteOnSubmit(tam);
                }
                ketNoi.SubmitChanges();
                return true;
                
               
            
            }
            catch (Exception ex)
            {
                return false;

            }
        }

        public bool xoaAnhTheoMaAlbum(String maAlbum)
        {

            try
            {
                var ketQua = (from hinh in ketNoi.HinhAnhs
                              where hinh.MaAlbum == maAlbum
                              select hinh).ToList();
                foreach (HinhAnh tam in ketQua)
                {
                    ketNoi.HinhAnhs.DeleteOnSubmit(tam);
                }
                ketNoi.SubmitChanges();
                return true;



            }
            catch (Exception ex)
            {
                return false;

            }
        }



            
        public bool xoaAnhTheoDuongDan(String duongDan)
        {

            try
            {
                var ketQua = from hinh in ketNoi.HinhAnhs
                              where hinh.DuongDan == duongDan
                              select hinh;
                foreach (HinhAnh tam in ketQua)
                {
                    ketNoi.HinhAnhs.DeleteOnSubmit(tam);
                }
                ketNoi.SubmitChanges();
                return true;



            }
            catch (Exception ex)
            {
                return false;

            }
        }
        public HinhAnh layHinhTheoDuongDan(String duongDan)
        {
            var ketQua = (from hinh in ketNoi.HinhAnhs
                         where hinh.DuongDan == duongDan
                          select hinh).FirstOrDefault() ;
            return ketQua;

        }
        public int demAnh()
        {
            try
            {
                var dem = ketNoi.HinhAnhs.Count();
                return dem;

            }
            catch (Exception)
            {

                return 0;
            }
        }


        public List<HinhAnh> layHinhTheLoaiTheoTrang(String maTheLoai,int boQua, int lay)
        {
            var ketQua = (from hinh in ketNoi.HinhAnhs where hinh.MaTheLoai == maTheLoai
                          select hinh).Skip(boQua).Take(lay).ToList();
            return ketQua; 
        }

        public List<HinhAnh> layHinhTheoMaTheLoai(String maTheLoai)
        {
            try
            {
                var ketQua = (from hinh in ketNoi.HinhAnhs
                              where hinh.MaTheLoai == maTheLoai
                              select hinh).ToList();
                return ketQua;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<HinhAnh> layAnhTrangDauTien(int batDau, int ketThuc)
        {
            var ketQua = (from anh in ketNoi.HinhAnhs
                          select anh).Take(ketThuc - batDau + 1).ToList();
            return ketQua;
        }

        public List<HinhAnh> layAnhTrangDauTienTheoTheLoai(String maTheLoai,int batDau, int ketThuc)
        {
            var ketQua = (from anh in ketNoi.HinhAnhs where anh.MaTheLoai==maTheLoai
                          select anh).Take(ketThuc - batDau + 1).ToList();
            return ketQua;
        }


        public List<HinhAnh> layAnhTheoMaTheLoai(String maTheLoai)
        {
            try
            {
                var ketQua = (from hinh in ketNoi.HinhAnhs
                              where hinh.MaTheLoai == maTheLoai
                              select hinh).ToList();


                return ketQua;
            }
            catch(Exception)
            {
                return null;
            }
        }

        
        public List<HinhAnh> layAnh()
        {
            try
            {
                var ketQua = (from anh in ketNoi.HinhAnhs
                              select anh).ToList();
                return ketQua;
            
            }
            catch (Exception)
            {
                return null;
            }
            
        }
        public  bool ThemAnh()
        {
            try
            {
                ketNoi.HinhAnhs.InsertOnSubmit(this);
                ketNoi.SubmitChanges();
                return true;



            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
