using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // add class IO untuk menggunakan file

namespace FileDanDirektori
{
    class MembuatFileDanDirektori
    {
        public void DemoFile1()
        {
            string path = @"F:\DATA X\After Office Project";

            // membuat direktori
            Directory.CreateDirectory(path);

            string namaFile = "contoh.txt";

            //membuat file F:\DATA X\After Office Project\contoh.txt
            FileStream fs = File.Create(Path.Combine(path, namaFile));

            //menulis data kedalam file
            for(byte i=0; i<100; i++)
            {
                fs.WriteByte(i);
            }

            Console.WriteLine("Data berhasil disimpan");
            //menutup file
            fs.Close();

            //membaca data dari dalam file
            try
            {
                byte[] data = File.ReadAllBytes(Path.Combine(path, namaFile));
                foreach(byte b in data)
                {
                    Console.Write(b + " ");
                }
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
