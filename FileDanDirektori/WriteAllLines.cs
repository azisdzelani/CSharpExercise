using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileDanDirektori
{
    class WriteAllLines
    {
        //methode WriteAllLines => menulis data yang tersimpan didalam array kedalam file

        public void DemoWriteAllLines()
        {
            string path = @"F:\DATA X\After Office Project";
            Directory.CreateDirectory(path);

            string namaFile = "data1.txt";

            //data yang akan ditulis ke dalam file
            string[] data = {"Baris pertama",
                             "Baris kedua",
                             "Baris ketiga",
                             "Baris keempat",
                             "Baris Kelima"};

            //add data kedalam file
            try
            {
                File.WriteAllLines(Path.Combine(path, namaFile), data);
                Console.WriteLine("File {0} telah terbuat...", Path.Combine(path, namaFile));

                //membaca data dari file
                string[] datas = File.ReadAllLines(Path.Combine(path, namaFile));
                foreach(string d in datas)
                {
                    Console.WriteLine(d + " ");
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("ERROR : {0}", e.Message);
            }
        }
    }
}
