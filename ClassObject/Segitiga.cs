using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    class Segiempat
    {
        public double panjang;
        public double lebar;

        //mendifinisikan konstruktor
        public Segiempat()
        {
            panjang = 6;
            lebar = 4;
        }

        //mendefinisikan metode void CetakLuas()
        public void CetakLuas()
        {
            double luas; //variable lokal di dalam metode
            luas = panjang * lebar;

            Console.WriteLine("Luas Segiempat = " + luas);
        }

        //mendefinisikan metode mengembalikan nilai HitungLuas()
        public double HitungLuas()
        {
            double luas;
            luas = panjang * lebar;
            return luas; //mengembalikan nilai
        }

        //mendefinisikan metode dengan dua parameter
        public void IsiData(double p, double l)
        {
            panjang = p;
            lebar = l;
        }

        //mendefinisikan metode untuk menghitung luas
        public double HitungIsi()
        {
            return panjang* lebar;
        }

        //mendefinisikan metode untuk mencetak luas
        public void CetakIsi(string s)
        {
            Console.WriteLine(s + HitungIsi());
        }

    }

    class DemoMetodeVoid
    {
        static void Main()
        {
            Segiempat se1, se2;

            //membuat objek pertama
            se1 = new Segiempat();

            //membuat objek kedua
            se2 = new Segiempat();

            //mengisi data ke dalam objek pertama
            se1.IsiData(8, 8);

            //mengisi data ke dalam objek kedua
            se2.IsiData(10, 9);

            //menampilkan luas
            se1.CetakIsi("Luas objek pertama \t =");
            se2.CetakIsi("Luas objek kedua \t =");

            Console.ReadLine();
        }    
    }

}
