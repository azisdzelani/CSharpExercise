using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDanDirektori
{
    class Program : MembuatFileDanDirektori
    {
        static void Main(string[] args)
        {
            MembuatFileDanDirektori me = new MembuatFileDanDirektori();
            WriteAllLines wa = new WriteAllLines();
            //me.DemoFile1();
            wa.DemoWriteAllLines();

            Console.ReadLine();
        }
    }
}
