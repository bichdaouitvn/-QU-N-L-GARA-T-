using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApp1.DTO
{
    public class HoaDon
    {
        public HoaDon(int id, DateTime? dateCheckin, DateTime? dateCheckOut, int idKhuSuaChua, int idKhachHang, int status)
        {
            this.Id = id;
            this.DateCheckIn = dateCheckin;
            this.DateCheckOut = dateCheckOut;
            this.IdKhuSuaChua = idKhuSuaChua;
            this.IdKhachHang = idKhachHang;
            this.status = Status;
        }

        public HoaDon(DataRow row)
        {
            this.Id = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["dateCheckin"];

            var dateCheckOutTemp = row["dateCheckOut"];
            if (dateCheckOutTemp.ToString() != "")
                this.DateCheckOut = (DateTime?)dateCheckOutTemp;
            this.IdKhuSuaChua = (int)row["idKhuSuaChua"];
            this.IdKhachHang = (int)row["idKhachHang"];
            this.Status = (int)row["status"];
        }

        private int id;
        private DateTime? dateCheckOut;
        private DateTime? dateCheckIn;
        private int idKhuSuaChua;
        private int idKhachHang;
        private int status;

        public int Id { get => id; set => id = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public int IdKhuSuaChua { get => idKhuSuaChua; set => idKhuSuaChua = value; }
        public int IdKhachHang { get => idKhachHang; set => idKhachHang = value; }
        public int Status { get => status; set => status = value; }
    }
}
