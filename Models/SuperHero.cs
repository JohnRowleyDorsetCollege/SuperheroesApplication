using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes.Models
{
    public abstract class SuperHero
    {
        public abstract string Name { get; }

        public abstract void Fly();

        //{
        //    Console.WriteLine($"I am {Name} and I am flying");
        //}
    }

    public class SuperMan : SuperHero
    {
        public override string Name => "SuperMan";

        public override void Fly()
        {
            Console.WriteLine($"I am {Name} and I am flying");
        }
    }



}
