using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    class HoaDonDAO
    {
        private static HoaDonDAO instance;

        public static HoaDonDAO Instance
        {
            get { if (instance == null) instance = new HoaDonDAO(); return HoaDonDAO.instance; }
            private set { HoaDonDAO.instance = value; }
        }

        private HoaDonDAO() { }
    }
}
