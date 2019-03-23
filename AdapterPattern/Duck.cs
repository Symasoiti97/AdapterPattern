using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Duck : IDuck
    {
        public void Quack()
        {
            Console.WriteLine("quack quack");
        }

        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }
    }
}
