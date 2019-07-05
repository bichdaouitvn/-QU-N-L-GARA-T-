using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApp1.DTO
{
    public class Menu
    {
        public Menu(string tenphutung, int count, float price, float totalPrice = 0)
        {
            this.Tenphutung = tenphutung;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }

        public Menu(DataRow row)
        {
            this.Tenphutung = row["tenphutung"].ToString();
            this.Count = (int)row["count"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.TotalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());
        }

        private float totalPrice;
        private float price;
        private int count;
        private string tenphutung;

        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
        public float Price { get => price; set => price = value; }
        public int Count { get => count; set => count = value; }
        public string Tenphutung { get => tenphutung; set => tenphutung = value; }
    }
}
