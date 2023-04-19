using System;
using System.Collections.Generic;
using System.Collections;

namespace proje2_3
{
    class MilliPark
    {
        private string milliPark_Adi;
        private List<string> il_Adlari;
        private int ilan_Yili;
        private int yuzolcumu;

        public static List<MilliPark>[] milliParkLists = new List<MilliPark>[2];

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
}
