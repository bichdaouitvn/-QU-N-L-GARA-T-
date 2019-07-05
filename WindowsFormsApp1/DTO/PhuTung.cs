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
        public PhuTung(int id, string tenphutung, int idHangXe, float price, int count)
        {
            this.Id = id;
            this.Tenphutung = tenphutung;
            this.IdHangXe = idHangXe;
            this.Price = price;
            this.Count = count;
        }

        public PhuTung(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Tenphutung = row["tenphutung"].ToString();
            this.IdHangXe = (int)row["idHangXe"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.Count = (int)row["count"];
        }

        private string tenphutung;
        private int id;
        private int idHangXe;
        private float price;
        private int count;

        public string Tenphutung { get => tenphutung; set => tenphutung = value; }
        public int Id { get => id; set => id = value; }
        public int IdHangXe { get => idHangXe; set => idHangXe = value; }
        public float Price { get => price; set => price = value; }
        public int Count { get => count; set => count = value; }
    }
}
