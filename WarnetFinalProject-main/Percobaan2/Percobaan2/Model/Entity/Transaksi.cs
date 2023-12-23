using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Percobaan2.Model.Entity
{
    internal class Transaksi
    {
        public int ID_Transaksi { get; set; }
        public int Tanggal_Transaksi { get; set; }
        public int ID_SesiRental { get; set; }
        public int ID_Layanan_Tambahan { get; set; }
        public int ID_Operator { get; set; }
        public int Total_BIAYA { get; set; }
    }
}
