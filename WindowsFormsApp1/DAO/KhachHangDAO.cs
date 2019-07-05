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

        public void DeleteKhachHangByFoodID(int id)
        {
            DataProvider.Instance.ExecuteQuery("delete dbo.KhachHang WHERE idFood = " + id);
        }
        public List<KhachHang> GetListKhachHang(int id)
        {
            List<KhachHang> listKhachHang = new List<KhachHang>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.KhachHang WHERE idBill = " + id);

            foreach (DataRow item in data.Rows)
            {
                KhachHang info = new KhachHang(item);
                listKhachHang.Add(info);
            }

            return listKhachHang;
        }

        public void InsertKhachHang(int idBill, int idFood, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertKhachHang @idBill , @idFood , @count", new object[] { idBill, idFood, count });
        }
    }
}
