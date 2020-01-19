using System;

namespace AdapterPattern
{
    internal static class Program
    {
        // Definicja książkowa
        //Tworzymy klasę adapter która implementuje interfejs IDuck, a indyka wstrzykujemy do niej przez konstruktor.
        //Dzięki takiemu zabiegowi można w klasie która z definicji jest kaczką (implementuje interfejs IDuck) podmienić zachowanie kwakania na 
        //gęganie :) 
        //public void Quack()
        //{
        //    _turkey.Gobble();
        //}

        private static void Main()
        {
            var turkey = new WildTurkey();
            var adapter = new TurkeyAdapter(turkey);

            Tester(adapter);
        }

        private static void Tester(IDuck duck)
        {
            duck.Fly();
            duck.Quack();
        }
    }
}
