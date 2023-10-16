using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Critter
{
    internal class Dog : Critter
    {
        public Dog(string critterName) : base(critterName)
        {

        }
        public override void MakeEatNoise()
        {
            Console.WriteLine($"{GetName()} wags its tail and gobbles up the food.");
        }
        public override void MakeSleepNoise()
        {
            Console.WriteLine($"{GetName()} lies down and starts snoring loudly.");
        }
        public override void MakeExerciseNoise()
        {
            Console.WriteLine($"{GetName()} enthusiastically runs and plays around.");
        }
    }
}
