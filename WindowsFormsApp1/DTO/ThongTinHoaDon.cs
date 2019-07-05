using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace WindowsFormsApp1.DTO
{
    public class ThongTinHoaDon
    {
        public ThongTinHoaDon(int id, int idHoaDon, int idPhuTung, int count)
        {
            this.Id = id;
            this.IdHoaDon = idHoaDon;
            this.IdPhuTung = idPhuTung;
            this.Count = count;
        }

        public ThongTinHoaDon(DataRow row)
        {
            this.Id = (int)row["id"];
            this.IdHoaDon = (int)row["idHoaDon"];
            this.IdPhuTung = (int)row["idPhuTung"];
            this.Count = (int)row["count"];
        }

        private int id;
        private int idHoaDon;
        private int idPhuTung;
        private int count;
        public int Id { get => id; set => id = value; }
        public int IdHoaDon { get => idHoaDon; set => idHoaDon = value; }
        public int IdPhuTung { get => idPhuTung; set => idPhuTung = value; }
        public int Count { get => count; set => count = value; }
    }
}
