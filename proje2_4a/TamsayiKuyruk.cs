using System;
using System.Collections.Generic;
using System.Collections;

namespace proje2_4a
{
    class TamsayiKuyruk
    {
        private List<int> tamsayiList;

        public TamsayiKuyruk()
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
            int removedTamsayi = this.tamsayiList.First();
            this.tamsayiList.Remove(this.tamsayiList.First());

            return removedTamsayi;
        }

        public int Size()
        {
            return tamsayiList.Count();
        }
    }
}
