using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class DictionaryManager<Tx, Ty>
    {
        // W4 HW3 E ÇOK BENZİYOR 
        // key ve value değerleri için iki farklı array oluşturuyoruz
        Tx[] keys;
        Ty[] values;

        public DictionaryManager()
        {
            // constructor olarak new class yapıldığında 0 elemanlı bir array oluşturuyoruz
            keys = new Tx[0];
            values = new Ty[0];
        }

        public void Add(Tx key, Ty value)
        {
            Tx[] tempArrayX = keys;
            Ty[] tempArrayY = values;

            keys = new Tx[keys.Length + 1];
            values = new Ty[values.Length + 1];


            for (int i = 0; i < tempArrayX.Length; i++)
            {
                keys[i] = tempArrayX[i];

            }

            for (int j = 0; j < tempArrayY.Length; j++)
            {
                values[j] = tempArrayY[j];

            }

            key = keys[keys.Length - 1];
            value = values[values.Length - 1];

        }

        public int Count
        {
            get { return keys.Length; }
        }

    }
}
