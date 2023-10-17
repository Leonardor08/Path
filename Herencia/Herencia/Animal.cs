using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Animal
    {
        public required string Name { get; set; }

        public void eat()
        {
            Console.WriteLine($"{Name} está comiendo");
        }
    }
}
