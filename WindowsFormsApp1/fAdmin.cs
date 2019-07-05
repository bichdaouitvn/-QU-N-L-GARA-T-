using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DTO;
using WindowsFormsApp1.DAO;
namespace WindowsFormsApp1
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
  
            LoadHangXeIntoCombobox(cbHangPT);
            LoadListPhuTung();
            AddPhuTungBinding();
        }

        void LoadListPhuTung()
        {
            dtgvPT.DataSource = PhuTungDAO.Instance.GetListPhuTung();
        }

        void LoadHangXeIntoCombobox(ComboBox cb)
        {
            cb.DataSource = HangXeDAO.Instance.GetListHangXe();
            cb.DisplayMember = "Tenhangxe";
        }


        void AddPhuTungBinding()
        {
            txbPTID.DataBindings.Add(new Binding("Text", dtgvPT.DataSource, "id", true, DataSourceUpdateMode.Never));
            txbPTName.DataBindings.Add(new Binding("Text", dtgvPT.DataSource, "tenphutung", true, DataSourceUpdateMode.Never));
            txbPrice.DataBindings.Add(new Binding("Text", dtgvPT.DataSource, "price", true, DataSourceUpdateMode.Never));
            txbsoluong.DataBindings.Add(new Binding("Text", dtgvPT.DataSource, "count", true, DataSourceUpdateMode.Never));
        }

        private void BtnAddPT_Click(object sender, EventArgs e)
        {
            string name = txbPTName.Text;
            int idhangxe = (cbHangPT.SelectedItem as HangXe).Id;
            float price = float.Parse(txbPrice.Text);
            int soluong = Convert.ToInt32(txbsoluong.Text);

            if (PhuTungDAO.Instance.InsertPhuTung(name, idhangxe, soluong, price))
            {
                MessageBox.Show("Thêm phụ tùng thành công");
                LoadListPhuTung();
                if (insertPhuTung != null)
                    insertPhuTung(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm phụ tùng");
            }
        }

        private void BtnDeletePT_Click(object sender, EventArgs e)
        {
            int id =Convert.ToInt32(txbPTID.Text);

            if (PhuTungDAO.Instance.DeletePhuTung(id))
            {
                MessageBox.Show("Xóa phụ tùng thành công");
                LoadListPhuTung();
                if (deletePhuTung != null)
                    deletePhuTung(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa phụ tùng");
            }
        }

        private void BtnEditPT_Click(object sender, EventArgs e)
        {
            string name = txbPTName.Text;
            int idhangxe = (cbHangPT.SelectedItem as HangXe).Id;
            float price = float.Parse(txbPrice.Text);
            int soluong = Convert.ToInt32(txbsoluong.Text);
            int id = Convert.ToInt32(txbPTID.Text);

            if (PhuTungDAO.Instance.UpdatePhuTung(name, idhangxe, soluong, price, id))
            {
                MessageBox.Show("Sửa phụ tùng thành công");
                LoadListPhuTung();
                if (updatePhuTung != null)
                    updatePhuTung(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa phụ tùng");
            }

        }

        private event EventHandler insertPhuTung;
        public event EventHandler InsertPhuTung
        {
            add { insertPhuTung += value; }
            remove { insertPhuTung -= value; }
        }

        private event EventHandler deletePhuTung;
        public event EventHandler DeletePhuTung
        {
            add { deletePhuTung += value; }
            remove { deletePhuTung -= value; }
        }

        private event EventHandler updatePhuTung;
        public event EventHandler UpdatePhuTung
        {
            add { updatePhuTung += value; }
            remove { updatePhuTung -= value; }
        }

        private void TxbPTID_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (dtgvPT.SelectedCells.Count > 0)
                {
                    int id = (int)dtgvPT.SelectedCells[0].OwningRow.Cells["idHangXe"].Value;

                    PhuTung phutung = PhuTungDAO.Instance.GethangxeByidphutung(id);

                    cbHangPT.SelectedItem = phutung;

                    int index = -1;
                    int i = 0;
                    foreach (HangXe item in cbHangPT.Items)
                    {
                        if (item.Id == phutung.IdHangXe)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }

                    cbHangPT.SelectedIndex = index;
                }
            }
            catch { }
        }
    }
}
