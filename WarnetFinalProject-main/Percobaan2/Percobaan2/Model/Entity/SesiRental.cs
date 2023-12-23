using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Percobaan2.Model.Entity
{
    public class SesiRental
    {
        public int ID_SesiRental { get; set; }
        public int WaktuMulai { get; set; }
        public int WaktuSelesai { get; set; }
        public int Durasi { get; set; }
        public string Username { get; set; }
        public int ID_Komputer { get; set; }
        public int Password { get; set; }
        public int Total_Rental { get; set; }


    }
}
