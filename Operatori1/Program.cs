using Operatori1;
internal class Program
{
    private static void Main(string[] args)
    {
        int a = 2, b = 3;
        if((a++) == 2 | (b++) == 3)
        {
            Console.WriteLine("ok");
        }
        Console.WriteLine($"{a},{b}");

        Razlomak[] razlomci = new Razlomak[3];
        razlomci[0] = new Razlomak(-2, 6);
        //razlomci[1] = razlomci[0];
        razlomci[1] = new Razlomak(-2, 6);
        if (razlomci[0] == razlomci[1])
            Console.WriteLine("isti");
        /*razlomci[2] = razlomci[0] + razlomci[1];
        //razlomci[2] += razlomci[1];
        //razlomci[2] /= razlomci[2];
        //razlomci[2] += (Razlomak)2;
        //Console.WriteLine(razlomci[2].Brojnik + "/"
        // + razlomci[2].Nazivnik);
        Console.WriteLine(razlomci[2]);
        if (razlomci[2])
            Console.Write("Istina");
        else if (!razlomci[2])
            Console.WriteLine("Laz");
        else
            Console.WriteLine("Nesto drugo!");*/
    }
}