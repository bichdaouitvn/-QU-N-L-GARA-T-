using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1
{
    public partial class fManager : Form
    {
        public fManager()
        {
            InitializeComponent();
            LoadData();
        }
        
        void LoadData()
        {
            LoadHangXeIntoCombobox(cbHangXe);
        }

        void LoadHangXeIntoCombobox(ComboBox cb)
        {
            cb.DataSource = HangXeDAO.Instance.GetListHangXe();
            cb.DisplayMember = "Tenhangxe";
        }

        private void AdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }

  
    }
}
