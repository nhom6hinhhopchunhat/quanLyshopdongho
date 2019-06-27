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
    public partial class frm_main : Form
    {
        private int quyen;

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

        public frm_main()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Sanpham_Click(object sender, EventArgs e)
        {
            if(!panel_phai.Contains(uc_SanPham.Instance)){
                panel_phai.Controls.Add(uc_SanPham.Instance);
                uc_SanPham.Instance.Dock = DockStyle.Fill;
                uc_SanPham.Instance.BringToFront();
             
            }
            else{
                uc_SanPham.Instance.BringToFront();
            }
        }

        private void qUẢNLÝSẢNPHẨMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Quyen == 2)
            {
                MessageBox.Show("Không có quyền truy cập chức năng này");
            }
            else
            {


            }
        }
    }
}
