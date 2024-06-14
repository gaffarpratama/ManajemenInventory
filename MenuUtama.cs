using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManajemenInventory
{
    public class MenuUtama
    {
        private readonly ManajerKelola manajerKelola;
        private readonly MenuKelola menuKelola;

        public MenuUtama ()
        {
            manajerKelola = new ManajerKelola ();
            DisplayMenuUtama();
        }

        public void DisplayMenuUtama ()
        {
            int pilihan = 0;
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Menu Utama:");
                Console.WriteLine("1. Kelola Data Barang");
                Console.WriteLine("2. Lihat Data Barang");
                Console.WriteLine("3. Keluar\n");
                Console.Write("Pilihan anda: ");
                try
                {
                    pilihan = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex) { }
                switch (pilihan)
                {
                    case 1:
                        var mkelola = new MenuKelola(manajerKelola);
                        break;
                    case 2:
                        Console.WriteLine("Menu Lihat Data Barang");
                        manajerKelola.GetAllBarang();
                        break;
                    case 3:
                        Console.WriteLine("Exit App ...");
                        break;
                }
                if (pilihan == 3)
                    loop = false;
            }
        }
    }
}
