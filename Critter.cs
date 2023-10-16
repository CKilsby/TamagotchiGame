using System;
using System.Threading;

namespace Critter
{
    public class Critter
    {
        private bool isAlive;
        private int foodLevel;
        private int tiredness;
        private int exerciseLevel;
        private string name;

        public Critter(string critterName)
        {
            isAlive = true;
            foodLevel = 5;
            tiredness = 0;
            exerciseLevel = 0;
            name = critterName;
        }

        public void Eat()
        {
            MakeEatNoise();
            if (isAlive)
            {
                foodLevel++;
                tiredness++;
                if (foodLevel > 10)
                {
                    Console.WriteLine($"{name} overate.");
                    Die();
                }
                else if (tiredness > 5)
                {
                    Console.WriteLine($"{name} is sleepy from so much food.");
                    Sleep();

                }
            }
        }

        public virtual void MakeEatNoise()
        {

        }
        public virtual void Sleep()
        {
            MakeSleepNoise();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Zzz... ");
                Thread.Sleep(1000);
            }
            tiredness = 0;
            foodLevel -= 3;
            if (foodLevel <= 0)
            {
                Console.WriteLine($"{name} starves to death.");
                Die();
            }
        }

        public virtual void MakeSleepNoise()
        {

        }
        public virtual void Exercise()
        {
            MakeExerciseNoise();
            if (isAlive)
            {
                exerciseLevel++;
                tiredness += 2;
                if (exerciseLevel >= 10)
                {
                    Console.WriteLine($"{name} reached peak fitness!");
                    Console.WriteLine($"{name} is the ultimate critter! You win!");
                }
                else if (tiredness > 5)
                {
                    Console.WriteLine($"{name} is too tired to exercise.");
                    Sleep();
                }
            }
        }
        public virtual void MakeExerciseNoise()
        {

        }

        public bool GetAlive()
        {
            return isAlive;
        }

        private void Die()
        {
            isAlive = false;
        }
        public string GetName()
        {
            return name;
        }
    }
}
