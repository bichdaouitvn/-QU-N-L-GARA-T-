using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;
using System.Data;

namespace WindowsFormsApp1.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }

        private MenuDAO() { }

        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> listMenu = new List<Menu>();

            string query = "SELECT f.tenphutung, bi.count, f.price, f.price*bi.count AS totalPrice  FROM dbo.ThongTinHoaDon AS bi, dbo.HoaDon AS b, dbo.PhuTung AS f WHERE bi.idHoaDon = b.id AND bi.idPhuTung = f.id AND b.status = 0 AND b.status = 0 AND b.idKhuSuaChua =  " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
