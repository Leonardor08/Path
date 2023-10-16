using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Deconstruct
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age) => (Name, Age) = (name, age);

        public void Deconstruct(out string name, out int age)
        {
            name = Name;
            age = Age;
        }
    }
}
