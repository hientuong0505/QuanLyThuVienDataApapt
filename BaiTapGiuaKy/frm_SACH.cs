using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapGiuaKy
{
    public partial class frm_SACH : Form
    {
        public frm_SACH()
        {
            InitializeComponent();
        }
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public void LoadSach()
        {
            string sql = "Select * from SACH";
            dataGridView1.DataSource = lopchung.LoadDuLieu(sql);
        }

        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            string sql = "insert into SACH values ('" + txt_MASACH.Text + "','" + txt_TENSACH.Text + "')";
            lopchung.ThemXoaSua(sql);
            LoadSach();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from SACH where MASACH = '" + txt_MASACH.Text + "'";
            lopchung.ThemXoaSua(sql);
            LoadSach();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            string sql = "Update SACH set TENSACH = N'" + txt_TENSACH.Text + "' where MASACH = '" + txt_MASACH.Text + "'";
            lopchung.ThemXoaSua(sql);
            LoadSach();
        }

        private void frm_SACH_Load(object sender, EventArgs e)
        {
            LoadSach();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MASACH.Text = dataGridView1.CurrentRow.Cells["MASACH"].Value.ToString();
            txt_TENSACH.Text = dataGridView1.CurrentRow.Cells["TENSACH"].Value.ToString();
        }


    }
}
