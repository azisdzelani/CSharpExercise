using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class DemoObjekString
    {
        static void Main()
        {
            MethodDanPropertiString();
            MengaksesKarakterString();
            Substring();

            Console.ReadLine();
        }

        static void MethodDanPropertiString()
        {
            // dalam c# string dianggap sebagai objek, karena objek, maka string mempunyai properti dan method
            // berikut cara mengakses properti dan method

            string s = "Pemrograman C#";

            //mengakses properti
            Console.WriteLine(s.Length);

            //memanggil method
            Console.WriteLine(s.ToUpper());
            Console.WriteLine(s.ToLower());

        }

        static void MengaksesKarakterString()
        {
            string s = "Pemrograman C#";

            for(int i=0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
        }

        static void Substring()
        {
            // dengan substring(), kita dapat menentukan indeks awal dan jumlah karakter yang ingin disalin
            // Substring(int indeks, intJumlahKarakter)

            string s1, s2;

            s1 = "Belajar Pemrograman C#";
            s2 = s1.Substring(7, 15);

            //menampilkan string
            Console.WriteLine(s1);

            Console.WriteLine(s2);

        }
    }
}
