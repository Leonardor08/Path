using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Dog : Animal
    {
        readonly Animal animal = new() { Name = "Max" };
        public void Bark()
        {
            Console.WriteLine("{0} está ladrando", animal.Name);
        }
    }
}
