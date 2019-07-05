using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class BillInfo
    {
        public BillInfo(int id, int billID, int idPhuTung, int count)
        {
            this.Id = id;
            this.BillID = billID;
            this.IdPhuTung = idPhuTung;
            this.Count = count;
        }

        public BillInfo(DataRow row)
        {
            this.Id = (int)row["id"];
            this.BillID = (int)row["idHoaDon"];
            this.IdPhuTung = (int)row["idPhuTung"];
            this.Count = (int)row["count"];
        }
        private int count;
        private int idPhuTung;
        private int billID;
        private int id;

        public int Count { get => count; set => count = value; }
        public int IdPhuTung { get => idPhuTung; set => idPhuTung = value; }
        public int BillID { get => billID; set => billID = value; }
        public int Id { get => id; set => id = value; }
    }
}
