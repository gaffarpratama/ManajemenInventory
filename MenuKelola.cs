using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManajemenInventory
{
    public class MenuKelola
    {
        private readonly ManajerKelola manajerKelola;

        public MenuKelola(ManajerKelola manajerKelola)
        {
            this.manajerKelola = manajerKelola;
            DisplayMenuKelola();
        }

        public void DisplayMenuKelola()
        {
            int pilihan = 0;
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("\nMenu Kelola Barang:");
                Console.WriteLine("1. Tambah Data Barang");
                Console.WriteLine("2. Ubah Data Barang");
                Console.WriteLine("3. Hapus Data Barang");
                Console.WriteLine("4. Kembali ke Menu Utama\n");
                Console.Write("Pilihan anda: ");
                try
                {
                    pilihan = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex) { }
                switch (pilihan)
                {
                    case 1:
                        TambahData();
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        UbahData();
                        Console.WriteLine();
                        break;
                    case 3:
                        HapusData();
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("Kembali ke Menu Utama\n");
                        break;
                }
                if (pilihan == 4 )
                    loop = false;
            }
        }

        public void TambahData()
        {
            Console.WriteLine("\nTambah Data Barang\n");
            try
            {
                Console.Write("ID: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nama Barang: ");
                string nama_barang = Console.ReadLine();
                Console.Write("Jumlah: ");
                int jumlah = Convert.ToInt32(Console.ReadLine());

                var new_request = new Barang()
                {
                    id = id,
                    nama_barang = nama_barang,
                    jumlah = jumlah
                };
                manajerKelola.TambahBarang(new_request);
            }
            catch (Exception ex) { }
        }

        public void UbahData()
        {
            Console.WriteLine("\nUbah Data Barang\n");
            try
            {
                Console.Write("ID Barang yang ingin diubah: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Data Barang yang akan diubah:");
                int index = manajerKelola.GetBarangIndex(id);
                Barang barang = manajerKelola.GetBarang(index);
                Console.WriteLine(barang.id + ", " + barang.nama_barang + ", " + barang.jumlah + "\n");
                Console.Write("Nama barang baru: ");
                string nama_baru = Console.ReadLine();
                Console.Write("Jumlah baru: ");
                int jumlah_baru = Convert.ToInt32(Console.ReadLine());

                var request_baru = new BarangUpdate()
                {
                    nama_barang = nama_baru,
                    jumlah = jumlah_baru
                };
                if (nama_baru != null && jumlah_baru != null)
                {
                    manajerKelola.UbahBarang(index, request_baru);
                    Console.WriteLine("Data barang telah berhasil dibuah");
                }
            }
            catch (Exception ex) { }
        }

        public void HapusData()
        {
            Console.WriteLine("\nHapus Data Barang\n");
            try
            {
                Console.Write("ID Barang yang ingin dihapus: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Data Barang yang akan dihapus:");
                int index = manajerKelola.GetBarangIndex(id);
                Barang barang = manajerKelola.GetBarang(index);
                Console.WriteLine(barang.id + ", " + barang.nama_barang + ", " + barang.jumlah + "\n");
                Console.Write("Anda yakin akan menghapus data ini? [Y/T]\t");
                char jawab = Convert.ToChar(Console.Read());

                if(jawab == 'Y' | jawab == 'y')
                {
                    manajerKelola.HapusBarang(index);
                    Console.WriteLine("Data Barang telah berhasil dihapus");
                }
            }
            catch (Exception ex) { }
        }
    }
}
