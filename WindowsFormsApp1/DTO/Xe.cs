using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApp1.DTO
{
    public class Xe
    {
        public Xe(int id, string tenxe, int idHangXe, string biensoxe)
        {
            this.Id = id;
            this.Tenxe = tenxe;
            this.IdHangXe = idHangXe;
            this.Biensoxe = biensoxe;
        }

        public Xe(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Tenxe = row["tenxe"].ToString();
            this.IdHangXe = (int)row["idHangXe"];
            this.Biensoxe = row["biensoxe"].ToString();
        }

        private string tenxe;
        private int idHangXe;
        private string biensoxe;
        private int id;

        public string Tenxe { get => tenxe; set => tenxe = value; }
        public int IdHangXe { get => idHangXe; set => idHangXe = value; }
        public string Biensoxe { get => biensoxe; set => biensoxe = value; }
        public int Id { get => id; set => id = value; }
    }
}
