namespace Respirációs_kvóciens_kiszámítása
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem mondja meg mennyi CO2 keletkezik kilégzéskor: ");
            int co2 = int.Parse(Console.ReadLine());
            Console.Write("Kérem mondja meg mennyi O2 keletkezik kilégzéskor: ");
            int o2 = int.Parse(Console.ReadLine());

            double RQ = co2 / o2;
            if (RQ == 0.8)
            {
                Console.WriteLine("Az értéke megfelelő!");
            }
            else if (RQ < 1.8)
            {
                Console.WriteLine("A szervezete a zsírokból nyeri az energiát");
            }
            else if (RQ > 1.8)
            {
                Console.WriteLine("A szervezete a szénhidrátokból nyeri az energiát");
            }
        }
    }
}