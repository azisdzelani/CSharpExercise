using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generik
{
    class Generiks<T>
    {
        //mendeklerasikan data dengan tipe generik
        private T data;

        //konstruktor dengan parameter bertipe generik
        public Generiks(T data)
        {
            this.data = data;
        }

        //metode untuk mengubah nilai data
        public void SetData(T data)
        {
            this.data = data;
        }

        //metode untuk mengambil nilai data
        public T GetData()
        {
            return data;
        }

        //metode untuk menampilkan type data
        public void ShowType()
        {
            Console.WriteLine("Tipe T:" + data.GetType());
        }
    }
}
