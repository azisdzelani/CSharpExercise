using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generik
{
    //kelas utama
    class DemoKelasGenerik
    {
        static void Main()
        {
            //DEMO GENERIK START
            Generiks<int> objGenerik;
            objGenerik = new Generiks<int>(777);

            int i = objGenerik.GetData();
            Console.WriteLine("Nilai: " + i);
            objGenerik.ShowType();

            //DEMO GENERIK IN ARRAY START
            int[] A = { 100,200,300,400,500};

            GenerikInArray<int> obj1;
            obj1 = new GenerikInArray<int>(A);

            //menampilkan isi array
            Console.WriteLine("Array A:");
            obj1.PrintArray();



            Console.ReadKey();

        }
    }
}
