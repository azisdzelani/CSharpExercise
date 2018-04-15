using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegasiMetodeEkpresiLamda
{
    // delegasi => digunakan untuk memanggil metode tanpa menggunakan objek maupun nama objek nya

    //mendeklarasikan tipe delegasi harus diluar class
    delegate double OperasiBilangan(double a, double b);

    class Delegasi
    {
        static double Tambah(double bil1, double bil2)
        {
            return bil1 + bil2;
        }
    }
}
