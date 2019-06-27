using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLShopDongHo
{
    public partial class uc_SanPham : UserControl
    {
        LOPDUNGCHUNG model;
        private static uc_SanPham _instance;

        public static uc_SanPham Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_SanPham();
                return _instance;
            }

            set
            {
                _instance = value;
            }
        }

        public uc_SanPham()
        {

            InitializeComponent();
            model = new LOPDUNGCHUNG();

        }
        public void LoadBang()
        {
            String sql = "Select MaMH,TenMH,SoLuong,GiaBan,MaLH from tbMATHANG";
            DataTable tb = model.getDataTable(sql);
            dataGridView1.DataSource = tb;
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            String chuoiTim = "Select MaMH ,TenMH , SoLuong , GiaBan , MaLH from tbMATHANG where MaMH ='" + txt_timkiem.Text +"'";

            int ktra = model.excuteSQL(chuoiTim);
            if (ktra < -1)
            {
                MessageBox.Show("Thông báo", "Mặt hàng bạn tìm không có"); 
            }
            DataTable tb2 = model.getDataTable(chuoiTim);
            dataGridView1.DataSource = tb2;
        }


        private void uc_SanPham_Load(object sender, EventArgs e)
        {
            LoadBang();
            
        }

        private void btn_tatca_Click(object sender, EventArgs e)
        {
            LoadBang();
        }
    }
}
