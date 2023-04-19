using System;
using System.Collections.Generic;
using System.Collections;

namespace proje2_4b
{
    class OncelikliKuyruk
    {
        private List<int> tamsayiList;

        public OncelikliKuyruk()
        {
            this.tamsayiList = new List<int>();
        }

        public bool isEmpty()
        {
            return tamsayiList.Count() == 0;
        }

        public void Enqueue(int tamsayi)
        {
            this.tamsayiList.Add(tamsayi);
        }

        public int Dequeue()
        {
            int enKucukUrunSayisi = tamsayiList.First();
            int index = 0, count = 0;

            foreach (int urunSayisi in this.tamsayiList)
            {
                if (urunSayisi < enKucukUrunSayisi)
                {
                    enKucukUrunSayisi = urunSayisi;
                    index = count;
                }

                count++;
            }

            int removedUrunSayisi = tamsayiList.ElementAt(index);
            tamsayiList.RemoveAt(index);

            return removedUrunSayisi;
        }

        public int Size()
        {
            return tamsayiList.Count();
        }
    }
}
