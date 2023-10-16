using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Critter
{
    internal class Cat : Critter
    {
        public Cat(string critterName) : base(critterName)
        {

        }
        public override void MakeEatNoise()
        {
            Console.WriteLine($"{GetName()} purrs while eating.");
        }
        public override void MakeSleepNoise()
        {
            Console.WriteLine($"{GetName()} curls up and snoozes.");
        }
        public override void MakeExerciseNoise()
        {
            Console.WriteLine($"{GetName()} lazily stretches and exercises.");
        }
    }
}
