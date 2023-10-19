using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Animal
    {
        public virtual string MakeSound()
        {
            return "maybe barking dk";
        }
    }

    class Dog : Animal
    {
        public override string MakeSound()
        {
            return "bark bark";
        }
    }

    class Cat : Animal 
    { 
        public override string MakeSound()
        {
            return "meow";
        } 
    }
}
