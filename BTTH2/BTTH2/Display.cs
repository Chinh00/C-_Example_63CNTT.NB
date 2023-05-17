using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH2
{
    interface IDisplay {
        string Name { get; }
    }
    internal class Dog : IDisplay
    {
        public string Name { get; set; } = "Dog";
    }
    internal class Cat : IDisplay
    {
        public string Name { get; set; } = "Cat";
        /*public static void Main(string[] args) {
            IDisplay animal = new Dog();
            Console.WriteLine(animal.Name);
            animal = new Cat();
            Console.WriteLine(animal.Name);
        }*/
    }

}
