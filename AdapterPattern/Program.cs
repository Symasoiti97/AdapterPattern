using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IDuck duck = new Duck();
            ITurkey turkey = new Turkey();
            IDuck turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine();
            duck.Fly();
            duck.Quack();

            Console.WriteLine();
            turkey.Fly();
            turkey.Gobble();

            Console.WriteLine();
            turkeyAdapter.Fly();
            turkeyAdapter.Quack();

            Console.WriteLine();
            Action(duck);

            Console.WriteLine();
            Action(turkeyAdapter);

            Console.ReadKey();
        }

        private static void Action(IDuck duck)
        {
            duck.Fly();
            duck.Quack();
        }
    }
}
