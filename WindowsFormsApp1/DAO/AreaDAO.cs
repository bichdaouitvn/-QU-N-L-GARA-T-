using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class AreaDAO
    {
        private static AreaDAO instance;

        public static AreaDAO Instance
        {
            get { if (instance == null) instance = new AreaDAO(); return AreaDAO.instance; }
            private set { AreaDAO.instance = value; }
        }

        private AreaDAO() { }

        public static int AreaWeight = 100;
        public static int AreaHeight = 100;

        public List<Area> LoadArealist()
        {
            List<Area> arealist = new List<Area>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetAreaList");

            foreach (DataRow item in data.Rows)
            {
                Area area = new Area(item);
                arealist.Add(area);
            }

            return arealist;
        }

        public Area GetStatusById(int id)
        {
            Area area = null;

            string query = "select * from KhuSuaChua where KhuSuaChua.id = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                area = new Area(item);
                return area;
            }

            return area;
        }

        public void UpdateStatus1(int id)
        {
            string query = "UPDATE dbo.KhuSuaChua SET status = N'Đang được sử dụng' WHERE KhuSuaChua.id = " + id;
            DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
