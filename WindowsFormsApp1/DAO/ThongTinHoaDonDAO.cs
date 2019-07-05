using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class ThongTinHoaDonDAO
    {
        private static ThongTinHoaDonDAO instance;

        public static ThongTinHoaDonDAO Instance
        {
            get { if (instance == null) instance = new ThongTinHoaDonDAO(); return ThongTinHoaDonDAO.instance; }
            private set { ThongTinHoaDonDAO.instance = value; }
        }

        private ThongTinHoaDonDAO() { }
    }
}
