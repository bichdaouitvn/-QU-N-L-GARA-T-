using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;
using System.Data;


namespace WindowsFormsApp1.DAO
{
    public class HangXeDAO
    {
        private static HangXeDAO instance;

        public static HangXeDAO Instance
        {
            get { if (instance == null) instance = new HangXeDAO(); return HangXeDAO.instance; }
            private set { HangXeDAO.instance = value; }
        }

        private HangXeDAO() { }

        public List<HangXe> GetListHangXe()
        {
            List<HangXe> list = new List<HangXe>();

            string query = "select * from HangXe";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                HangXe hangxe = new HangXe(item);
                list.Add(hangxe);
            }

            return list;
        }

     
    }
    
    
}
