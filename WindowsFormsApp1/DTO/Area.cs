using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApp1.DTO
{
    public class Area
    {
        public Area(int id, string name, string status)
        {
            this.Id = id;
            this.Name = name;
            this.Status = status;
        }

        public Area(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Status = row["status"].ToString();
        }

        private int id;
        private string name;
        private string status;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
    }
}
