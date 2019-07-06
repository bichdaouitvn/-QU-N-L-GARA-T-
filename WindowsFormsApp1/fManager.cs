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
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;


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
            LoadArea();
            LoadListKhachHang();
            LoadListPhuTung();
        }

        void LoadArea()
        {
            flp.Controls.Clear();
            List<Area> arealist = AreaDAO.Instance.LoadArealist();

            foreach (Area item in arealist)
            {
                Button btn = new Button() { Width = AreaDAO.AreaWeight, Height = AreaDAO.AreaHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch(item.Status)
                {
                    case "AVAILABLE":
                        btn.BackColor = Color.Azure;
                        break;
                    default:
                        btn.BackColor = Color.Orchid;
                        break;
                }

                flp.Controls.Add(btn);
            }
        }

        void ShowBill(int id)
        {
            lsv.Items.Clear();
            List<WindowsFormsApp1.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (WindowsFormsApp1.DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.Tenphutung.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;

                lsv.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;

            txbTotalPrice.Text = totalPrice.ToString("c", culture);
        }

        void btn_Click(object sender, EventArgs e)
        {
            int areaID = ((sender as Button).Tag as Area).Id;
            lsv.Tag = (sender as Button).Tag;
            ShowBill(areaID);
        }

        void LoadListKhachHang()
        {
            string query = "SELECT KhachHang.hoten as N'Họ tên', KhachHang.diachi as N'Địa chỉ', KhachHang.sodienthoai as N'Số điện thoại', Xe.tenxe as N'Tên xe', Xe.biensoxe as N'Biển số xe', HangXe.tenhangxe as N'Hãng xe' FROM[dbo].[KhachHang] inner join[dbo].[Xe] on KhachHang.idXe = Xe.id inner join[dbo].[HangXe] on Xe.idHangXe = HangXe.id WHERE KhachHang.status =0";
            dataGridView1.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void LoadHangXeIntoCombobox(ComboBox cb)
        {
            cb.DataSource = HangXeDAO.Instance.GetListHangXe();
            cb.DisplayMember = "Tenhangxe";
        }

        void AdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }

        void LoadListPhuTung()
        {
            List<PhuTung> list = PhuTungDAO.Instance.GetListPhuTung();
            cbFood.DataSource = list;
            cbFood.DisplayMember = "Tenphutung";
        }
 

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

            List<KhachHang> SearchKhacHangByName(string name)
        {
            List<KhachHang> listKhachHang = KhachHangDAO.Instance.SearchKhachHangByName(name);

            return listKhachHang;
        }

        private void BtnAddPT_Click(object sender, EventArgs e)
        {
            string tenxe = textBox11.Text;
            string bienso = textBox10.Text;
            int idhangxe = (cbHangXe.SelectedItem as HangXe).Id;
            string tenkh = textBox9.Text;
            string sdt = textBox8.Text;
            string diachi = textBox7.Text;

            if (XeDAO.Instance.InsertXe(tenxe, idhangxe, bienso))
            {
               
                MessageBox.Show("Thêm xe thành công");
                if (insertXe != null)
                    insertXe(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm xe");
            }

            Xe xe = XeDAO.Instance.Getidxebybienso(bienso);
            if (KhachHangDAO.Instance.InsertKhachHang(tenkh, sdt, diachi, xe.Id))
            {
                LoadListKhachHang();
                MessageBox.Show("Thêm khách hàng thành công");
                if (insertKhachHang != null)
                    insertKhachHang(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm khách hàng");
            }


        }

        private event EventHandler insertXe;
        public event EventHandler Insertxe
        {
            add { insertXe += value; }
            remove { insertXe -= value; }
        }

        private event EventHandler insertKhachHang;
        public event EventHandler InsertKhachHang
        {
            add { insertKhachHang+= value; }
            remove { insertKhachHang -= value; }
        }

        private void BtnShowPT_Click(object sender, EventArgs e)
        {
            LoadListKhachHang();
        }

        private void BtnSearchPT_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SearchKhacHangByName(txbSearchKH.Text);
        }

        private void Button2_Click(object sender, EventArgs e)
            {
                Area area = lsv.Tag as Area;

                if (area == null)
                {
                    MessageBox.Show("Hãy chọn khu");
                    return;
                }

                int idHoaDon = BillDAO.Instance.GetUncheckBillIDByTableID(area.Id);
                int idPhuTung = (cbFood.SelectedItem as PhuTung).Id;
                int count = (int)nmr.Value;

                if (idHoaDon == -1)
                {
                    BillDAO.Instance.InsertBill(area.Id);
                    BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), idPhuTung, count);
                }
                else
                {
                    BillInfoDAO.Instance.InsertBillInfo(idHoaDon, idPhuTung, count);
                }

                ShowBill(area.Id);

                LoadArea();
            }

        private void Button1_Click(object sender, EventArgs e)
        {
            Area area = lsv.Tag as Area;

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(area.Id);

            double totalPrice = Convert.ToDouble(txbTotalPrice.Text.Split(',')[0]);
            double finalTotalPrice = totalPrice;

            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho khu : {0}\nTổng tiền \n=> {1} ", area.Name, finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, (float)finalTotalPrice);
                    ShowBill(area.Id);

                    LoadArea();
                }
            }
            string sdt = txbsdtt.Text;
            KhachHangDAO.Instance.UpdateStatus(sdt);
            LoadListKhachHang();
        }

        private void FManager_Load(object sender, EventArgs e)
        {

        }
    }
}
