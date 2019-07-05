using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get { if (instance == null) instance = new KhachHangDAO(); return KhachHangDAO.instance; }
            private set { KhachHangDAO.instance = value; }
        }

        private KhachHangDAO() { }

        public bool InsertKhachHang(string name, string sodienthoai, string diachi, int idxe)
        {
            string query = string.Format("INSERT dbo.KhachHang ( hoten, diachi, sodienthoai, idXe)VALUES  ( N'{0}', N'{1}', N'{2}', {3})", name, sodienthoai, diachi, idxe);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public List<KhachHang> SearchKhachHangByName(string name)
        {
            List<KhachHang> list = new List<KhachHang>();

            string query = string.Format("SELECT * FROM KhachHang where hoten like N'%{0}%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);


            foreach (DataRow item in data.Rows)
            {
                KhachHang KhachHang = new KhachHang(item);
                list.Add(KhachHang);
            }

            return list;


        }

    }
}
