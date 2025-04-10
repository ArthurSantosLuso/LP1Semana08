using System;

namespace GameUnit
{
    public class Program
    {
        private static void Main(string[] args)
        {
            MilitaryUnit mu = new MilitaryUnit(2, 10, 4);
            SettlerUnit su = new SettlerUnit();

            Console.WriteLine(mu);
            Console.WriteLine(su);
        }
    }
}
