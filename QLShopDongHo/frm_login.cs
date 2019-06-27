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
    public partial class frm_login : Form
    {
        LOPDUNGCHUNG model;
        public frm_login()
        {
            InitializeComponent();
            model = new LOPDUNGCHUNG();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            
                string sql = "select * from tbTaiKhoan where TenDangNhap = '" + txt_taikhoan.Text
                    + "' and MatKhau ='" + txt_matkhau.Text + "'";
                int kq = model.excuteSQL(sql);
                //if (kq < 0)
                //{
                //    MessageBox.Show("bạn đã nhập sai tài khoản hoặc mật khẩu");
                //}
                //else
                {
                    DataTable tb = model.getDataTable(sql);
                    frm_main main = new frm_main();
                    main.Quyen = int.Parse(tb.Rows[0][2].ToString());
                    main.Show();
                  
                }
            
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
