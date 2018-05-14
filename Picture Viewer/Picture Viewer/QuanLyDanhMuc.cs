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
    public partial class QuanLyDanhMuc : MetroForm
    {
        public QuanLyDanhMuc()
        {
            InitializeComponent();
        }

        private void FullScreen_Load(object sender, EventArgs e)
        {
            Album tl2 = new Album();
            gridDanhSachAlbum.DataSource = tl2.layAlbum();
            gridDanhSachAlbum.Columns[0].HeaderText = "Album";
            gridDanhSachAlbum.Columns[1].HeaderText = "Tên Album";
            gridDanhSachAlbum.Columns[0].Width = 650;
            gridDanhSachAlbum.Columns[1].Width = 650;
            TheLoai tl = new TheLoai();
            gridDanhSachTheLoai.DataSource = tl.layTheLoai();
            gridDanhSachTheLoai.Columns[0].HeaderText = "Mã Thể Loại";
            gridDanhSachTheLoai.Columns[1].HeaderText = "Tên Thể Loại";
            gridDanhSachTheLoai.Columns[0].Width = 650;
            gridDanhSachTheLoai.Columns[1].Width = 650;
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {


        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtTenTheLoai_Click(object sender, EventArgs e)
        {

        }

        private void gridDanhSachTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridDanhSachTheLoai_Click(object sender, EventArgs e)
        {
            try
            {

                txtTenTheLoai.Text = gridDanhSachTheLoai.CurrentRow.Cells[1].Value.ToString();
            }

            catch (Exception)
            {

            }

        }

        private void btnThemTheLoai_Click(object sender, EventArgs e)
        {
            TheLoai tl = new TheLoai();
            if (tl.kiemTraTrungTheLoai(txtTenTheLoai.Text) == true && txtTenTheLoai.Text != "")
            {
                tl.TenTheLoai = txtTenTheLoai.Text;
                tl.MaTheLoai = tl.tangMaTheLoai();
                tl.themTheLoai(tl);
                MetroMessageBox.Show(Owner, "Thêm Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
            }
            else if (txtTenTheLoai.Text == "")
            {
                MetroMessageBox.Show(Owner, "Bạn Chưa Thêm Tên Thể Loại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);

            }
            else
            {
                MetroMessageBox.Show(Owner, "Trùng Thể Loại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);

            }
            gridDanhSachTheLoai.DataSource = tl.layTheLoai();


        }

        private void btnXoaTheLoai_Click(object sender, EventArgs e)
        {
            TheLoai tl = new TheLoai();
            try
            {
                String maTheLoai = gridDanhSachTheLoai.CurrentRow.Cells[0].ToString();
                if (maTheLoai != null)
                    tl.xoaTheoMaTheLoai(gridDanhSachTheLoai.CurrentRow.Cells[0].ToString());
            }
            catch (Exception)
            {

            }




        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            TheLoai tl = new TheLoai();

            try
            {
                String maTheLoai = gridDanhSachTheLoai.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception)
            {

            }

            if (txtTenTheLoai.Text != null && gridDanhSachTheLoai.CurrentRow.Cells[0].Value.ToString() != "")
            {
                tl.MaTheLoai = gridDanhSachTheLoai.CurrentRow.Cells[0].Value.ToString();
                tl.TenTheLoai = txtTenTheLoai.Text;
                tl.capNhat(tl);
                gridDanhSachTheLoai.DataSource = tl.layTheLoai();

            }


            MetroMessageBox.Show(Owner, "Cập Nhật Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void metroTabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {




        }

        private void metroTabControl1_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {





        }


        private void metroTabControl1_TabIndexChanged(object sender, EventArgs e)
        {
        }

        private void metroTabControl1_RightToLeftChanged(object sender, EventArgs e)
        {


        }

        private void btnThemAlbum_Click(object sender, EventArgs e)
        {
            Album tl = new Album();
            if (tl.kiemTraTrungAlbum(txtTenAlbum.Text) == true && txtTenAlbum.Text != "")
            {
                tl.TenAlbum = txtTenAlbum.Text;
                tl.MaAlbum = tl.tangMa();
                tl.themAlbum(tl);
                MetroMessageBox.Show(Owner, "Thêm Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
            }
            else if (txtTenAlbum.Text == "")
            {
                MetroMessageBox.Show(Owner, "Bạn Chưa Thêm Tên Album.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
            }
            else
            {
                MetroMessageBox.Show(Owner, "Trùng Album.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);

            }
            gridDanhSachAlbum.DataSource = tl.layAlbum();


        }

        private void btncapNhatAlbum_Click(object sender, EventArgs e)
        {
            Album tl = new Album();

            try
            {
                String maAlbum = gridDanhSachAlbum.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception)
            {

            }

            if (txtTenAlbum.Text != null && gridDanhSachAlbum.CurrentRow.Cells[0].Value.ToString() != "")
            {
                tl.MaAlbum = gridDanhSachAlbum.CurrentRow.Cells[0].Value.ToString();
                tl.TenAlbum = txtTenAlbum.Text;
                tl.capNhat(tl);
                gridDanhSachAlbum.DataSource = tl.layAlbum();

            }


            MetroMessageBox.Show(Owner, "Cập Nhật Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);

        }

        private void gridDanhSachAlbum_Click(object sender, EventArgs e)
        {
            try
            {
                txtTenAlbum.Text = gridDanhSachAlbum.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception)
            {
                
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnxoaThuocTheLoai_Click(object sender, EventArgs e)
        {
            String maTheLoai2 = "";
          
            HinhAnh hinh = new HinhAnh();
            TheLoai tl = new TheLoai();
            maTheLoai2 = tl.layMaTrung(txtTenTheLoai.Text);
            hinh.xoaAnhTheoMaTheLoai(maTheLoai2);

            MetroMessageBox.Show(Owner, "Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void bntxoaAnhThuocAlbum_Click(object sender, EventArgs e)
        {
            Album ab = new Album();
            HinhAnh hinh = new HinhAnh();
            String maAlbum = ab.layMaTrung(txtTenAlbum.Text);
            hinh.xoaAnhTheoMaAlbum(maAlbum);
            MetroMessageBox.Show(Owner, "Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
