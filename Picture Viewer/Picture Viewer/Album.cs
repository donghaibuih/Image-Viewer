using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picture_Viewer
{
    public partial class Album
    {
        CONNECTDataContext ketNoi = new CONNECTDataContext();
        public Album(String maAlbum, String tenAlbum)
        {
            this.MaAlbum = maAlbum;
            this.TenAlbum = tenAlbum;
        }

        public Album(String album)
        {
            this.MaAlbum = tangMa();
            this.TenAlbum = album;
        }


        
        public List<Album> layAlbum()
        {
            try
            {
                var ketQua = (from tam in ketNoi.Albums select tam).ToList();

                return ketQua;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool themAlbum(Album album)
        {

            try
            {
                ketNoi.Albums.InsertOnSubmit(album);
                ketNoi.SubmitChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }

        public bool kiemTraTrungAlbum(String tenAlbum)
        {
            List<Album> danhSachAlbum = layAlbum();
            for (int i = 0; i <= danhSachAlbum.Count - 1; i++)
            {
                if (danhSachAlbum[i].TenAlbum == tenAlbum)
                    return false;
            }
            return true;


        }


        
        public bool capNhat(Album album)
        {
            try
            {
                var ketQua = from ab in ketNoi.Albums
                             where ab.MaAlbum == album.MaAlbum
                             select ab;
                foreach (var tam in ketQua)
                {
                    tam.TenAlbum = album.TenAlbum;
                }

                ketNoi.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
        public String layMaTrung(String tenAlbum)
        {
            String maTrung = "";
            List<Album> danhSachAlbum = layAlbum();
            for (int i = 0; i <= danhSachAlbum.Count - 1; i++)
            {
                if (danhSachAlbum[i].TenAlbum == tenAlbum)
                    maTrung = danhSachAlbum[i].MaAlbum;
            }
            return maTrung;


        }
        public String tangMa()
        {
            List<Album> dem = layAlbum();
            String maAlbum = "";
            int day = System.DateTime.Now.Day;
            int moth = System.DateTime.Now.Month;
            int year = System.DateTime.Now.Year;
            int tong = day + moth + year + dem.Count();
            maAlbum = "ab" + tong.ToString();
            return maAlbum;
        }
        public Album layAlbumTheoMaAlbum(String maAlbum)
        {
            try
            {
                var ketQua = (from tam in ketNoi.Albums where tam.MaAlbum == maAlbum select tam).FirstOrDefault();
                return ketQua;
            }
            catch(Exception)
            {
                return null;
            }

        }
    }
}
