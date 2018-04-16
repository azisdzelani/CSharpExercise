using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PenangananEksepsi
{
    class DemoEksepsi
    {
        public void DemoPenggunaanFinally()
        {
            StreamReader file = null;

            //membuat array dengan 5 element bertipe int
            int[] A = new int[5];
            string baris;
            
            try
            {
                //mengakses file di path F:\DATA X\After Office Project
                file = new StreamReader(@"F:\DATA X\After Office Project\data.txt");

                //membaca isi file baris demi baris

                int i = 0;
                while((baris = file.ReadLine()) != null)
                {
                    //menyalin baris data dari file ke array
                    A[i] = Convert.ToInt32(baris);
                    Console.WriteLine("A[{0}] = {1}", i, A[i]);
                    i++;
                }
            }
            catch (FileNotFoundException) // catch yang pertama untuk menghandle jika file tidak ditemukan
            {
                Console.WriteLine("ERROR : File Tidak Ditemukan.");
            }
            catch(IndexOutOfRangeException) // catch yang kedua untuk menghandle jika jumlah data tidak sesuai dengan element array
            {
                Console.WriteLine("ERROR : " + "Indeks Array diluar rentang.");
            }
            finally // walaupun terkena eksepsion code di dalam finally tetap akan di eksekusi
            {
                if(file != null)
                {
                    file.Close(); // menutup file
                }
            } 
        }
    }
}
