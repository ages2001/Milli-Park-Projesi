using System;
using System.Collections.Generic;
using System.Collections;

namespace proje2_3
{
    class Program
    {
        static OncelikliKuyruk milliParkList = new OncelikliKuyruk();

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            milliParklarEkle();

            int count = 0;

            while (!milliParkList.isEmpty())
            {
                count++;
                Console.WriteLine("\n\nMilli Park {0}: \n", count);
                Console.WriteLine(milliParkList.Dequeue());
            }
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

            milliParkList.Enqueue(milliPark1);
            milliParkList.Enqueue(milliPark2);
            milliParkList.Enqueue(milliPark3);
            milliParkList.Enqueue(milliPark4);
            milliParkList.Enqueue(milliPark5);
            milliParkList.Enqueue(milliPark6);
            milliParkList.Enqueue(milliPark7);
            milliParkList.Enqueue(milliPark8);
            milliParkList.Enqueue(milliPark9);
            milliParkList.Enqueue(milliPark10);
            milliParkList.Enqueue(milliPark11);
            milliParkList.Enqueue(milliPark12);
            milliParkList.Enqueue(milliPark13);
            milliParkList.Enqueue(milliPark14);
            milliParkList.Enqueue(milliPark15);
            milliParkList.Enqueue(milliPark16);
            milliParkList.Enqueue(milliPark17);
            milliParkList.Enqueue(milliPark18);
            milliParkList.Enqueue(milliPark19);
            milliParkList.Enqueue(milliPark20);
            milliParkList.Enqueue(milliPark21);
            milliParkList.Enqueue(milliPark22);
            milliParkList.Enqueue(milliPark23);
            milliParkList.Enqueue(milliPark24);
            milliParkList.Enqueue(milliPark25);
            milliParkList.Enqueue(milliPark26);
            milliParkList.Enqueue(milliPark27);
            milliParkList.Enqueue(milliPark28);
            milliParkList.Enqueue(milliPark29);
            milliParkList.Enqueue(milliPark30);
            milliParkList.Enqueue(milliPark31);
            milliParkList.Enqueue(milliPark32);
            milliParkList.Enqueue(milliPark33);
            milliParkList.Enqueue(milliPark34);
            milliParkList.Enqueue(milliPark35);
            milliParkList.Enqueue(milliPark36);
            milliParkList.Enqueue(milliPark37);
            milliParkList.Enqueue(milliPark38);
            milliParkList.Enqueue(milliPark39);
            milliParkList.Enqueue(milliPark40);
            milliParkList.Enqueue(milliPark41);
            milliParkList.Enqueue(milliPark42);
            milliParkList.Enqueue(milliPark43);
            milliParkList.Enqueue(milliPark44);
            milliParkList.Enqueue(milliPark45);
            milliParkList.Enqueue(milliPark46);
            milliParkList.Enqueue(milliPark47);
            milliParkList.Enqueue(milliPark48);
        }
    }
}
