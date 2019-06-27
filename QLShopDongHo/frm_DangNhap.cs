using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLShopDongHo
{
    public partial class frm_DangNhap : Form
    {
        private int quyen;
        LOPDUNGCHUNG model;
        public frm_DangNhap()
        {
            InitializeComponent();
            model = new LOPDUNGCHUNG();
        }

        public int Quyen
        {
            get
            {
                return quyen;
            }

            set
            {
                quyen = value;
            }
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string sql = "select * from tbTaiKhoan where TenDangNhap = '" + txt_taikhoan.Text + "' and MatKhau = '" + txt_mk.Text + "'";
            int kq = model.excuteSQL(sql);
            if (kq < 1)
            {
                MessageBox.Show("Thông báo", "Đăng nhập thất bại");
            }
            else
            {
                DataTable tb = model.getDataTable(sql);
                Quyen = int.Parse(tb.Rows[0][2].ToString());
                frm_NhanVien_main main = new frm_NhanVien_main();
                main.Quyen = Quyen;
                main.Show();
                
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
