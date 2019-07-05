using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;
using System.Data;

namespace WindowsFormsApp1.DAO
{
    public class PhuTungDAO
    {
        private static PhuTungDAO instance;

        public static PhuTungDAO Instance
        {
                get { if (instance == null) instance = new PhuTungDAO(); return PhuTungDAO.instance; }
                private set { PhuTungDAO.instance = value; }
        }

        private PhuTungDAO() { }

        public List<PhuTung> GetListPhuTung()
        {
            List<PhuTung> list = new List<PhuTung>();

            string query = "SELECT * FROM PhuTung";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                PhuTung PhuTung = new PhuTung(item);
                list.Add(PhuTung);
            }

            return list;
        }

        public List<PhuTung> SearchPhuTungByName(string name)
        {
            List<PhuTung> list = new List<PhuTung>();

            string query = string.Format("SELECT * FROM PhuTung where tenphutung like N'%{0}%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                PhuTung PhuTung = new PhuTung(item);
                list.Add(PhuTung);
            }

            return list;
        }

        public bool InsertPhuTung(string name, int id, float gia)
        {
            string query = string.Format("INSERT dbo.PhuTung ( tenphutung, idHangXe, count, price)VALUES  ( N'{0}', {1}, {2})", name, id, gia);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdatePhuTung(string name, int id, float gia, int idd)
        {
            string query = string.Format("UPDATE dbo.PhuTung SET tenphutung = N'{0}', idHangXe = {1}, price = {2}, WHERE id = {3}", name, id, gia, idd);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeletePhuTung(int idPhuTung)
        {
            string query = string.Format("Delete PhuTung where id = {0}", idPhuTung);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public PhuTung GethangxeByidphutung(int id)
        {
            PhuTung phutung = null;

            string query = "select * from PhuTung where PhuTung.idHangXe = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                phutung = new PhuTung(item);
                return phutung;
            }

            return phutung;
        }


    }
}
