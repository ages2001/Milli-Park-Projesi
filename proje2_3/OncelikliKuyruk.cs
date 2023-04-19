using System;
using System.Collections.Generic;
using System.Collections;

namespace proje2_3
{
    class OncelikliKuyruk
    {
        private List<MilliPark> milliParkList;

        public OncelikliKuyruk()
        {
            this.milliParkList = new List<MilliPark>();
        }

        public bool isEmpty()
        {
            return milliParkList.Count() == 0;
        }

        public void Enqueue(MilliPark milliPark)
        {
            milliParkList.Add(milliPark);
        }

        public MilliPark Dequeue()
        {
            int enKucukHektar = milliParkList.First().Yuzolcumu;
            int index = 0, count = 0;

            foreach (MilliPark milliPark in this.milliParkList)
            {
                if (milliPark.Yuzolcumu < enKucukHektar)
                {
                    enKucukHektar = milliPark.Yuzolcumu;
                    index = count;
                }

                count++;
            }
            
            MilliPark removedMilliPark = milliParkList.ElementAt(index);
            milliParkList.RemoveAt(index);

            return removedMilliPark;
        }
    }
}
