using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManajemenInventory
{
    public class Barang
    {
        public int id {  get; set; }
        public string nama_barang { get; set; }
        public int jumlah { get; set; }
    }

    public class BarangUpdate
    {
        public string nama_barang { get; set; }
        public int jumlah { get; set; }
    }
}
