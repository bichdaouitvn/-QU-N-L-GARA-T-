using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApp1.DTO
{
    public class KhachHang
    {
        public KhachHang(int id, string hoten, string sodienthoai, string diachi, int idXe)
        {
            this.Id = id;
            this.Hoten = hoten;
            this.Sodienthoai = sodienthoai;
            this.Diachi = diachi;
            this.IdXe = idXe;
        }

        public KhachHang(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Hoten = row["hoten"].ToString();
            this.Sodienthoai  = row["sodienthoai"].ToString();
            this.Diachi = row["diachi"].ToString();
            this.IdXe = (int)row["idxe"];
        }

        private int id;
        private string hoten;
        private string sodienthoai;
        private string diachi;
        private int idXe;
        public string Hoten { get => hoten; set => hoten = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sodienthoai { get => sodienthoai; set => sodienthoai = value; }
        public int IdXe { get => idXe; set => idXe = value; }
        public int Id { get => id; set => id = value; }
    }
}
