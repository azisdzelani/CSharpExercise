using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PenangananEksepsi 
{
    /*
        eksepsi adalah kesalahan yang terjadi saat program sedang berjalan

        try
        {
            statement yang memungkinkan terjadinya exsepsi
        }
        catch(TipeEksepsi ReferensiEksepsi)
        {
            kode penanganan eksepsi
        }
        
    */
    class Program 
    {
        static void Main(string[] args)
        {
            DemoException1();
            Console.WriteLine();
            DemoException2();
            Console.ReadKey();
        }

        static void DemoException1()
        {
            int x = 9, y = 0;

            try
            {
                x /= y;
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR, Terjadi pembagian nol ");
                Console.WriteLine("PESAN ," + e.Message);
                //Environment.Exit(1);
            }
        }

        static void DemoException2()
        {
            int[] a = { 10, 20, 30, 40, 50};
            try
            {
                for(int i=0; i<=5; i++)
                {
                    Console.Write("a[{0}] =", i );
                    Console.WriteLine(a[i]);
                }
            }
            catch
            {
                Console.WriteLine("ERROR : Indeks diluar rentang ." );

            }
        }

        static void DemoFinally()
        {
            StreamReader file = null;

            //membuat array dengan 5 element bertipe int
            int[] A = new int[5];

            string baris;

            try
            {
                //mengakses file di directory
                file = new StreamReader(@"F:\DATA X\After Office Project\Belajar C#\Data.txt");

                //membaca isi file baris demi baris
                int i = 0;
                while ((baris = file.ReadLine()) != null)
                {
                    A[i] = Int32.Parse(baris);
                    Console.WriteLine("A[{0}] : ", A)
                }
            }
        }
    }

}
