using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PewarisanDanPolimorfisme
{
    /*
        class NamaKelasTurunan : NamaKelasDasar
        {
           badan class
        }
    */

    //mendifinisikan kelas dasar
    class A
    {
        //data
        private int a;

        //metode Set Nilai a
        public void SetA(int a)
        {
            this.a = a;
        }

        //metode ambil data a
        public int GetA()
        {
            return a;
        }

    }

    //mendefinisikan kelas turunan
    class B : A
    {
        //data
        private int b;

        //metode set B
        public void SetB(int b)
        {
            this.b = b;
        }

        //metode ambil nilai B
        public int GetB()
        {
            return b;
        }

    }

    class C : B
    {
        private int c;

        public void SetC(int c)
        {
            this.c = c;
        }

        public int GetC()
        {
            return c;
        }
    }

    //mendifinisikan kelas utama
    class DemoKelasTurunan1
    {
        static void Main()
        {
            //objek dari kelas turunan
            C obj = new C();

            obj.SetC(100);
            Console.WriteLine(obj.GetC());
            obj.SetB(200);
            Console.WriteLine(obj.GetB());
            obj.SetA(300);
            Console.WriteLine(obj.GetA());

            Console.ReadKey();
        }
    } 
}
