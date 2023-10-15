using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1
{
    //Definición de la Clase Person
    public class Person
    {
#nullable disable
        public string Name { get; set; }
        public int Age { get; set; }
        //Se declara el construtor de la clase
        public Person(string name, int age) => (Name, Age) = (name, age); 
        //Método para imprimir los valores
        public void ImprimirValores() => Console.WriteLine($"Hola, soy {Name}, y tengo {Age}");
    }
}
