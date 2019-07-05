using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApp1.DTO
{
    public class PhuTung
    {
        public PhuTung(int id, string tenphutung, int idHangXe, float price)
        {
            this.Id = id;
            this.Tenphutung = tenphutung;
            this.IdHangXe = idHangXe;
            this.Price = price;
        }

        public PhuTung(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Tenphutung = row["tenphutung"].ToString();
            this.IdHangXe = (int)row["idHangXe"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
        }

        private string tenphutung;
        private int id;
        private int idHangXe;
        private float price;

        public string Tenphutung { get => tenphutung; set => tenphutung = value; }
        public int Id { get => id; set => id = value; }
        public int IdHangXe { get => idHangXe; set => idHangXe = value; }
        public float Price { get => price; set => price = value; }
    }
}
