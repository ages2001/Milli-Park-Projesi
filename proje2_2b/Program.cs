using System;
using System.Collections;
using System.Collections.Generic;

namespace proje2_2b
{
    class MilliPark
    {
        private string milliPark_Adi;
        private List<string> il_Adlari;
        private int ilan_Yili;
        private int yuzolcumu;

        public static Queue[] milliParkLists = new Queue[2];

        public MilliPark(string milliPark_Adi, int ilan_Yili, int yuzolcumu)
        {
            this.milliPark_Adi = milliPark_Adi;
            this.il_Adlari = new List<string>();
            this.ilan_Yili = ilan_Yili;
            this.yuzolcumu = yuzolcumu;
        }

        public void ilEkle(string ilAdi)
        {
            this.il_Adlari.Add(ilAdi);
        }

        public string MilliPark_Adi
        {
            get { return this.MilliPark_Adi; }
            set { this.MilliPark_Adi = value; }
        }

        public int Ilan_Yili
        {
            get { return this.ilan_Yili; }
            set { this.ilan_Yili = value; }
        }

        public int Yuzolcumu
        {
            get { return this.yuzolcumu; }
            set { this.yuzolcumu = value; }
        }

        public override string ToString()
        {
            string output = "Milli park Adi: " + this.milliPark_Adi + "\nMilli parkin ilan yili: "
                + Convert.ToString(this.ilan_Yili) + "\nMilli parkin yuzolcumu: " + Convert.ToString(this.yuzolcumu) + " hektar\nMilli parkin bulundugu iller: ";

            foreach (string il in this.il_Adlari)
                output += il + " ";

            return output;
        }
    }

    class Queue
    {
        private int maxSize;
        private MilliPark[] milliParkList;
        private int bas;
        private int son;
        private int sizeOfList;

        public Queue(int maxSize)
        {
            this.maxSize = maxSize;
            milliParkList = new MilliPark[maxSize];
            bas = 0;
            son = -1;
            sizeOfList = 0;
        }

        public void Enqueue(MilliPark milliPark)
        {
            if (son + 1 == maxSize)
                son = -1;

            milliParkList[++son] = milliPark;
            sizeOfList++;
        }

        public MilliPark Dequeue()
        {
            MilliPark removedMilliPark = milliParkList[bas++];

            if (bas == maxSize)
                bas = 0;

            sizeOfList--;
            return removedMilliPark;
        }

        public MilliPark peekFront()
        {
            return milliParkList[bas];
        }

        public bool isEmpty()
        {
            return sizeOfList == 0;
        }

        public bool isFull()
        {
            return sizeOfList == maxSize;
        }

        public int Size()
        {
            return sizeOfList;
        }
    }

    class Program
    {
        static void listYazdir(Queue list1, Queue list2)
        {
            Console.WriteLine("\n15000 hektardan kucuk milli parklar: \n");

            int list1toplam = 0, list2toplam = 0, count1 = 0, count2 = 0;

            while (!list1.isEmpty())
            {
                count1++;
                MilliPark removedMilliPark = list1.Dequeue();
                Console.WriteLine("\nMilli park {0}: \n", count1);
                Console.WriteLine(removedMilliPark);
                list1toplam += removedMilliPark.Yuzolcumu;
            }

            Console.WriteLine("\n\n15000 hektar ve daha buyuk milli parklar: \n");

            while (!list2.isEmpty())
            {
                count2++;
                MilliPark removedMilliPark = list2.Dequeue();
                Console.WriteLine("\nMilli park {0}: \n", count2);
                Console.WriteLine(removedMilliPark);
                list2toplam += removedMilliPark.Yuzolcumu;
            }

            Console.WriteLine("\n\n15000 hektardan kucuk milli parklarin hektarlarinin toplami: {0} hektar\n", list1toplam);
            Console.WriteLine("15000 hektar ve daha buyuk milli parklarin hektarlarinin toplami: {0} hektar\n", list2toplam);
            Console.WriteLine("Tum milli park hektarlarin toplami: {0} hektar\n", list1toplam + list2toplam);
        }

        static void milliParkEkle(MilliPark milliPark)
        {
            if (milliPark.Yuzolcumu < 15000)
                MilliPark.milliParkLists[0].Enqueue(milliPark);

            else
                MilliPark.milliParkLists[1].Enqueue(milliPark);
        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            MilliPark.milliParkLists[0] = new Queue(48);
            MilliPark.milliParkLists[1] = new Queue(48);

            milliParklarEkle();

            listYazdir(MilliPark.milliParkLists[0], MilliPark.milliParkLists[1]);
        }

        static void milliParklarEkle()
        {
            MilliPark milliPark1 = new MilliPark("Abant Gölü Millî Parkı", 2022, 1262);
            milliPark1.ilEkle("Bolu");

            MilliPark milliPark2 = new MilliPark("Ağrı Dağı Millî Parkı", 2004, 88015);
            milliPark2.ilEkle("Ağrı");
            milliPark2.ilEkle("Iğdır");

            MilliPark milliPark3 = new MilliPark("Aladağlar Millî Parkı", 1995, 55064);
            milliPark3.ilEkle("Adana");
            milliPark3.ilEkle("Kayseri");
            milliPark3.ilEkle("Niğde");

            MilliPark milliPark4 = new MilliPark("Altınbeşik Mağarası Millî Parkı", 1994, 1147);
            milliPark4.ilEkle("Antalya");

            MilliPark milliPark5 = new MilliPark("Altındere Vadisi Millî Parkı", 1987, 4468);
            milliPark5.ilEkle("Trabzon");

            MilliPark milliPark6 = new MilliPark("Başkomutan Tarihî Millî Parkı", 1981, 34834);
            milliPark6.ilEkle("Afyon");
            milliPark6.ilEkle("Kütahya");
            milliPark6.ilEkle("Uşak");

            MilliPark milliPark7 = new MilliPark("Beydağları Sahil Millî Parkı", 1972, 31166);
            milliPark7.ilEkle("Antalya");

            MilliPark milliPark8 = new MilliPark("Beyşehir Gölü Millî Parkı", 1993, 86855);
            milliPark8.ilEkle("Konya");

            MilliPark milliPark9 = new MilliPark("Boğazköy-Alacahöyük Millî Parkı", 1988, 2600);
            milliPark9.ilEkle("Çorum");

            MilliPark milliPark10 = new MilliPark("Botan Vadisi Millî Parkı", 2019, 11384);
            milliPark10.ilEkle("Siirt");

            MilliPark milliPark11 = new MilliPark("Derebucak Çamlık Mağaraları Millî Parkı", 2022, 1147);
            milliPark11.ilEkle("Konya");

            MilliPark milliPark12 = new MilliPark("Dilek Yarımadası-Büyük Menderes Deltası Millî Parkı", 1966, 27598);
            milliPark12.ilEkle("Aydın");

            MilliPark milliPark13 = new MilliPark("Gala Gölü Millî Parkı", 2005, 6087);
            milliPark13.ilEkle("Edirne");

            MilliPark milliPark14 = new MilliPark("Güllük Dağı Millî Parkı", 1970, 6700);
            milliPark14.ilEkle("Antalya");

            MilliPark milliPark15 = new MilliPark("Hakkâri Cilo ve Sat Dağları Millî Parkı", 2020, 27500);
            milliPark15.ilEkle("Hakkari");

            MilliPark milliPark16 = new MilliPark("Hatila Vadisi Millî Parkı", 1994, 16944);
            milliPark16.ilEkle("Artvin");

            MilliPark milliPark17 = new MilliPark("Honaz Dağı Millî Parkı", 1995, 9429);
            milliPark17.ilEkle("Denizli");

            MilliPark milliPark18 = new MilliPark("Ilgaz Dağı Millî Parkı", 1976, 1118);
            milliPark18.ilEkle("Çankırı");
            milliPark18.ilEkle("Kastamonu");

            MilliPark milliPark19 = new MilliPark("İğneada Longoz Ormanları Millî Parkı", 2007, 3155);
            milliPark19.ilEkle("Kırklareli");

            MilliPark milliPark20 = new MilliPark("İstiklâl Yolu Tarihî Millî Parkı", 2018, 235);
            milliPark20.ilEkle("Ankara");
            milliPark20.ilEkle("Çankırı");
            milliPark20.ilEkle("Kastamonu");

            MilliPark milliPark21 = new MilliPark("Kaçkar Dağları Millî Parkı", 1994, 52970);
            milliPark21.ilEkle("Artvin");
            milliPark21.ilEkle("Erzurum");
            milliPark21.ilEkle("Rize");

            MilliPark milliPark22 = new MilliPark("Karagöl-Sahara Millî Parkı", 1994, 3251);
            milliPark22.ilEkle("Artvin");

            MilliPark milliPark23 = new MilliPark("Karatepe-Aslantaş Millî Parkı", 1958, 4143);
            milliPark23.ilEkle("Osmaniye");

            MilliPark milliPark24 = new MilliPark("Kazdağı Millî Parkı", 1994, 20935);
            milliPark24.ilEkle("Balıkesir");

            MilliPark milliPark25 = new MilliPark("Kızıldağ Millî Parkı", 1969, 55106);
            milliPark25.ilEkle("Isparta");

            MilliPark milliPark26 = new MilliPark("Kop Dağı Müdafaası Tarihî Millî Parkı", 2016, 6335);
            milliPark26.ilEkle("Bayburt");
            milliPark26.ilEkle("Erzurum");

            MilliPark milliPark27 = new MilliPark("Kovada Gölü Millî Parkı", 1970, 6551);
            milliPark27.ilEkle("Isparta");

            MilliPark milliPark28 = new MilliPark("Köprülü Kanyon Millî Parkı", 1973, 35719);
            milliPark28.ilEkle("Antalya");

            MilliPark milliPark29 = new MilliPark("Kuşcenneti Millî Parkı", 1959, 17058);
            milliPark29.ilEkle("Balıkesir");

            MilliPark milliPark30 = new MilliPark("Küre Dağları Millî Parkı", 2000, 37753);
            milliPark30.ilEkle("Bartın");
            milliPark30.ilEkle("Kastamonu");

            MilliPark milliPark31 = new MilliPark("Malazgirt Meydan Muharebesi Tarihî Millî Parkı", 2018, 238);
            milliPark31.ilEkle("Muş");

            MilliPark milliPark32 = new MilliPark("Marmaris Millî Parkı", 1996, 29206);
            milliPark32.ilEkle("Muğla");

            MilliPark milliPark33 = new MilliPark("Munzur Vadisi Millî Parkı", 1971, 42674);
            milliPark33.ilEkle("Tunceli");

            MilliPark milliPark34 = new MilliPark("Nemrut Dağı Millî Parkı", 1988, 13827);
            milliPark34.ilEkle("Adıyaman");
            milliPark34.ilEkle("Malatya");

            MilliPark milliPark35 = new MilliPark("Nene Hatun Tarihî Millî Parkı", 2009, 387);
            milliPark35.ilEkle("Erzurum");

            MilliPark milliPark36 = new MilliPark("Sakarya Meydan Muharebesi Tarihî Millî Parkı", 2015, 13850);
            milliPark36.ilEkle("Ankara");

            MilliPark milliPark37 = new MilliPark("Saklıkent Millî Parkı", 1996, 1643);
            milliPark37.ilEkle("Antalya");
            milliPark37.ilEkle("Muğla");

            MilliPark milliPark38 = new MilliPark("Sarıçalı Dağı Millî Parkı", 2021, 1024);
            milliPark38.ilEkle("Ankara");

            MilliPark milliPark39 = new MilliPark("Sarıkamış-Allahuekber Dağları Millî Parkı", 2004, 22520);
            milliPark39.ilEkle("Erzurum");
            milliPark39.ilEkle("Kars");

            MilliPark milliPark40 = new MilliPark("Soğuksu Millî Parkı", 1959, 1186);
            milliPark40.ilEkle("Ankara");

            MilliPark milliPark41 = new MilliPark("Spil Dağı Millî Parkı", 1968, 6801);
            milliPark41.ilEkle("İzmir");
            milliPark41.ilEkle("Manisa");

            MilliPark milliPark42 = new MilliPark("Sultansazlığı Millî Parkı", 2006, 24358);
            milliPark42.ilEkle("Kayseri");

            MilliPark milliPark43 = new MilliPark("Tek Tek Dağları Millî Parkı", 2007, 19335);
            milliPark43.ilEkle("Şanlıurfa");

            MilliPark milliPark44 = new MilliPark("Troya Tarihî Millî Parkı", 1996, 13517);
            milliPark44.ilEkle("Çanakkale");

            MilliPark milliPark45 = new MilliPark("Uludağ Millî Parkı", 1961, 13024);
            milliPark45.ilEkle("Bursa");

            MilliPark milliPark46 = new MilliPark("Yedigöller Millî Parkı", 1965, 1623);
            milliPark46.ilEkle("Bolu");

            MilliPark milliPark47 = new MilliPark("Yozgat Çamlığı Millî Parkı", 1958, 517);
            milliPark47.ilEkle("Yozgat");

            MilliPark milliPark48 = new MilliPark("Yumurtalık Lagünü Millî Parkı", 2008, 16980);
            milliPark48.ilEkle("Adana");

            milliParkEkle(milliPark1);
            milliParkEkle(milliPark2);
            milliParkEkle(milliPark3);
            milliParkEkle(milliPark4);
            milliParkEkle(milliPark5);
            milliParkEkle(milliPark6);
            milliParkEkle(milliPark7);
            milliParkEkle(milliPark8);
            milliParkEkle(milliPark9);
            milliParkEkle(milliPark10);
            milliParkEkle(milliPark11);
            milliParkEkle(milliPark12);
            milliParkEkle(milliPark13);
            milliParkEkle(milliPark14);
            milliParkEkle(milliPark15);
            milliParkEkle(milliPark16);
            milliParkEkle(milliPark17);
            milliParkEkle(milliPark18);
            milliParkEkle(milliPark19);
            milliParkEkle(milliPark20);
            milliParkEkle(milliPark21);
            milliParkEkle(milliPark22);
            milliParkEkle(milliPark23);
            milliParkEkle(milliPark24);
            milliParkEkle(milliPark25);
            milliParkEkle(milliPark26);
            milliParkEkle(milliPark27);
            milliParkEkle(milliPark28);
            milliParkEkle(milliPark29);
            milliParkEkle(milliPark30);
            milliParkEkle(milliPark31);
            milliParkEkle(milliPark32);
            milliParkEkle(milliPark33);
            milliParkEkle(milliPark34);
            milliParkEkle(milliPark35);
            milliParkEkle(milliPark36);
            milliParkEkle(milliPark37);
            milliParkEkle(milliPark38);
            milliParkEkle(milliPark39);
            milliParkEkle(milliPark40);
            milliParkEkle(milliPark41);
            milliParkEkle(milliPark42);
            milliParkEkle(milliPark43);
            milliParkEkle(milliPark44);
            milliParkEkle(milliPark45);
            milliParkEkle(milliPark46);
            milliParkEkle(milliPark47);
            milliParkEkle(milliPark48);
        }
    }
}
