using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApp1.DTO
{
    public class HangXe
    {
        public HangXe(int id, string tenhangxe)
        {
            this.Id = id;
            this.Tenhangxe = tenhangxe;
        }

        public HangXe(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Tenhangxe = row["tenhangxe"].ToString();
        }

        private int id;
        private string tenhangxe;

        public string Tenhangxe { get => tenhangxe; set => tenhangxe = value; }
        public int Id { get => id; set => id = value; }
    }
}
