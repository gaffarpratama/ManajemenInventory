using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManajemenInventory
{
    public class ManajerKelola
    {
        private List<Barang> objBarang;

        public ManajerKelola()
        {
            objBarang = new List<Barang>();
        }

        public void TambahBarang(Barang request)
        {
            objBarang.Add(request);
            Console.WriteLine();
            Console.WriteLine("Data Barang berhasil ditambah");
            Console.WriteLine();
        }

        public void GetAllBarang()
        {
            foreach (Barang barang in objBarang)
            {
                Console.WriteLine(barang.id + ", " + barang.nama_barang + ", " + barang.jumlah);
            }
            Console.WriteLine("\n");
        }

        public int GetBarangIndex(int id)
        {
            int index = 0;
            foreach(Barang barang in objBarang)
            {
                if(barang.id == id)
                {
                    index = objBarang.IndexOf(barang);
                    break;
                }
            }
            return index;
        }

        public Barang GetBarang(int id)
        {
            return objBarang[id];
        }

        public void UbahBarang(int index, BarangUpdate request)
        {
            objBarang[index].nama_barang = request.nama_barang;
            objBarang[index].jumlah = request.jumlah;
        }

        public void HapusBarang(int index)
        {
            objBarang.RemoveAt(index);
        }
    }
}
