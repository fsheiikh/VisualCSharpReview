using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityDemoLoan
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog(3);
            Console.WriteLine(dog.speak());

            var chi = new Chihuahua(3);
            Console.WriteLine(chi.speak());

            Console.ReadKey();
            
        }

        class Dog
        {
            private int age;

            public Dog(int a) { age = a; }

            public virtual string speak() { return "Bark!"; }
        }

        class Chihuahua : Dog
        {
            public Chihuahua(int a) : base(a)
            {
            }

            public override string speak()
            {
                return "Yip Yip";
            }
        }

    }
}
