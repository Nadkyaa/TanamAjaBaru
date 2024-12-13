using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanamAja.App.Models
{
    internal class M_Riwayat
    {
        public int Id_Transaksi { get; set; }
        public int Nama { get; set; }
        public int Alamat_Lahan { get; set; }
        public int Luas_Lahan { get; set; }
        public int Nama_Bibit { get; set; }
        public int Harga {  get; set; }
        public int Tanggal_Transaksi { get; set; }
    }
}
