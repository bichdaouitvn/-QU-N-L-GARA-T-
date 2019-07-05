using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; }
            private set { BillInfoDAO.instance = value; }
        }

        private BillInfoDAO() { }

        public void DeleteBillInfoByFoodID(int id)
        {
            DataProvider.Instance.ExecuteQuery("delete dbo.BillInfo WHERE idFood = " + id);
        }
        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.ThongTinHoaDon WHERE idBill = " + id);

            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }

            return listBillInfo;
        }

        public void InsertBillInfo(int idHoaDon, int idPhuTung, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertBillInfo @idHoaDon , @idPhutung , @count", new object[] { idHoaDon, idPhuTung, count });
        }
    }

}
