using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generik
{
    class GenerikInArray<T>
    {
        //data bertipe array dari tipe generik
        private T[] data;
        private int length;

        //konstruktor
        public GenerikInArray(T[] data)
        {
            this.data = data;
            length = data.Length;
        }

        //properti Length(bersifat read only)
        //untuk mengetahui jumlah elemen array
        public int Length
        {
            get { return length; }
        }

        //metode untuk mencari indeks array
        //berdasarkan nilai yang dimasukan
        public int IndexOf(T val)
        {
            int index = -1; //jika tidak ditemukan
            for(int i=0; i<length; i++)
            {
                //hati" oeperator == tidak dapat diterapkan
                //ke tipe generik
                // if(data[i] == val) { -> SALAH

                if(data[i].Equals(val))
                {
                    index = i;
                    //jika sudah ditemukan, pengulangan dihentikan
                    break;
                }
            }
            return index;
        }

        //metode untuk mencari nilai elemen array
        //berdasarkan index yang dimasukan
        public T ValueOf(int index)
        {
            return data[index];
        }

        //mengubah nilai elemen array
        //pada index tertentu
        public void SetValue(int index, T val)
        {
            data[index] = val;
        }

        //metode untuk menyalin isi array
        //ke array lain
        public void CopyTo(T[] array)
        {
            for(int i=0; i<length; i++)
            {
                array[i] = data[i];
            }
        }

        //metode untuk menampilkan isi array
        public void PrintArray()
        {
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach(T val in data)
            {
                s.Append(val.ToString() + ",");
            }
            s.Remove(s.Length - 1, 1);
            Console.WriteLine(s);
        }
    }

}
