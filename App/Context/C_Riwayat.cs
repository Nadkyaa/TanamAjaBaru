using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanamAja.App.Core;

namespace TanamAja.App.Context
{
    internal class C_Riwayat : DatabaseWrapper
    {
        private static string table = "Transaksi";

        // Metode untuk mengambil semua data Tukang Kebun
        public static DataTable All()
        {
            string query = @"
                SELECT 
                    t.id_Transaksi,
                    t.Nama,
                    t.Alamat_Lahan,
                    t.Luas_Lahan,
                    t.Nama_Bibit,
                    t.Harga,
                    t.Tanggal_Transaksi;
                FROM 
                    Transaksi t";

            DataTable dataRiwayat  = queryExecutor(query);
            return dataRiwayat;
        }
    }
}
