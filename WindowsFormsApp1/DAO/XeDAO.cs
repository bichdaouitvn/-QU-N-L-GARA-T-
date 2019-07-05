using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;
using System.Data;


namespace WindowsFormsApp1.DAO
{
    public class XeDAO
    {
        private static XeDAO instance;

        public static XeDAO Instance
        {
            get { if (instance == null) instance = new XeDAO(); return XeDAO.instance; }
            private set { XeDAO.instance = value; }
        }

        private XeDAO() { }

        public Xe Getidxebybienso(string biensoxe)
        {
            Xe xe = null;

            string query = string.Format("select * from Xe where Xe.biensoxe = N'{0}'", biensoxe);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                xe = new Xe(item);
                return xe;
            }

            return xe;
        }

    }
}
