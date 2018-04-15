using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiDanPengindeks
{
    /*
         MENDEFINISIKAN PROPERTI

         TipeData NamaProperti
         {
             set{kode untuk pengisian nilai}
             get{kode untuk pengambilan nilai}
         } 
     */

    class Segiempat
    {
        //data
        private double panjang;
        private double lebar;

        //construct
        public Segiempat(double p, double l)
        {
            panjang = p;
            lebar = l;
        }

        //mendefinisikan properti panjang
        public double Panjang
        {
            set { panjang = value; }
            get { return panjang; }
        }

        //mendefinisikan properti lebar
        public double Lebar
        {
            set { lebar = value; }
            get { return lebar; }
        }

        //metode untuk menghitung luas
        private double HitungLuas()
        {
            return panjang * lebar;
        }

        //metode untuk mencetak data
        public void CetakData()
        {
            Console.WriteLine("panjang \t =" + panjang);
            Console.WriteLine("lebar \t =" + lebar);
        }

        //metode untuk mencetak luas
        public void CetakLuas()
        {
            Console.WriteLine("Luas \t = " + HitungLuas());
        }
    }

    class DemoProperti1
    {
        static void Main()
        {
            //membuat objek dari kelas segiempat
            Segiempat se = new Segiempat(8, 6);

            //menampilkan data dan luas segiempat
            Console.WriteLine("Keadaan Awal");
            se.CetakData();
            se.CetakLuas();

            //mengubah data melalui properti
            Console.WriteLine("Keadaan Akhir");
            se.Panjang = 10;
            se.Lebar = 10;
            se.CetakData();
            se.CetakLuas();

            Console.ReadKey();
        }
    }
}
