using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    //T saadece tipini belirtmek için başka bişey de yazılabilir
    class MyList<T>
    {
        T[] items;
        //constructor --> classı newlediğin ( yeni kayıt oluşturduğun ) anda çaalışan fonksiyon
        public MyList()
        {
            items = new T[0]; // 0 elemanlı dizi oluştur
        }
        public void Add(T item)
        {
            T[] tempArray = items;  // Dizideki önceki elemanlar kaybolmasın diye geçici bir diziye atadık
            items = new T[items.Length+1]; // Dizinin uzunluğuna 1 ekle (1 arttır)

            for (int i = 0; i < tempArray.length; i++)
            {
                items[i] = tempArray[i];        // tempArraydaki verileri items dizisine aktar ( kopyala yapıştır / ata )
            }

            items[items.Length - 1] = item;     // gelen veriyi listenin son itemi olarak kaydet
        }


        //public int Length

    }
}
