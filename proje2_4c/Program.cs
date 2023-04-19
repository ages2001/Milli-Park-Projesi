namespace proje2_4c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Kasalarda PQ kullanimi, Queue kullanimina gore zaman kazanci saglandi. Ortalama islem tamamlama suresi, PQ da kisaldi.\n" +
                "Ancak PQ nun time complexity si daha yuksek oldugundan Queue ye gore daha yavas calisir. ");
        }
    }
}
