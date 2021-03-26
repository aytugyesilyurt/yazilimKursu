using System;
using System.Collections.Generic;

namespace _4_HW3_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("İzmir");
            sehirler2.Add("İzmir");
            sehirler2.Add("İzmir");
            sehirler2.Add("İzmir");
            sehirler2.Add("İzmir");
            sehirler2.Add("İzmir");
            sehirler2.Add("İzmir");
            sehirler2.Add("İzmir");
            Console.WriteLine(sehirler2.Count);
        }
    }


    class MyList<T>
    {
        // array asıl liste, tempArray geçici kullanılacak olan liste
        T[] _array;
        T[] _tempArray;

        public MyList()
        {
            // Constructor bloğu olarak yeni bir liste oluşturuyoruz
            _array = new T[0];

        }
        public void Add(T item)
        {
            // Listedeki referans tipleri kaybetmemek için geçici listeye atama yapıyoruz.
            // Ardından asıl arrayimizde liste uzunluğu +1 olacak şekilde yeni bir array oluşturuyoruz
            // Yeni liste oluşturduğumuz için önceki değerler kayboldu ( heapte referans numarası değişti ) ama tempArray dizisi hala önceki değerleri tuttuğu için döngü oluşturarak (ilk eleman 0 numaralı olduğu için) _tempArray.Length -1'e kadar olmak üzere _array[i] ile _tempArray[i] değerlerini eşleştiriyoruz
            // En son değere ise ( item olarak Add metotunda kullanıyoruz ) _array dizisinin uzunluğunun bir önceki elemanı olarak kaydediyoruz.


            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }


            item = _array[_array.Length - 1];

        }

        // burası count property oluşturmak için yapıldı // PROPERTY YAPMAYI ANLATMADI
        public int Count
        {

            get { return _array.Length; }
        }

    }
}
