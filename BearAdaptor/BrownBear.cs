using System;
using BearAdapter;

namespace BearAdaptor
{
    public class BrownBear : IBear
    {
        public bool Hibernating { get; set; }

        private readonly Random _random;


        public Bear()
        {
            _random = new Random();

            Hibernating = _random.NextDouble() < 0.3;
        }


        public void GoTowards(object objectToWalkTowards)
        {
            if (!Hibernating) { Console.WriteLine("Going towards object");}

            else {Console.WriteLine("ZZZ... I don't wanna move");}
        }

        public void LookAt(object objectToLookAt)
        {   

            if (!Hibernating) { Console.WriteLine("Looking");}

            else {Console.WriteLine("ZZZ... no way I'm looking");}
        }

        public void Roar()
        {
            if (!Hibernating) { Console.WriteLine("Roooar");}

            else {Console.WriteLine("ZZZ... you roar");}
        }

        public bool TryEat(object objectToEat)
        {   

            if (!Hibernating) 
            { 
                if(_random.NextDouble() < 0.5)
                {   
                    Console.WriteLine("Ate this delicious meal");
                    return true;
                }
                else
                {
                    Console.WriteLine("No gain no pain");
                    return false;
                }
                   
            }

            else
            { 
                Console.WriteLine("ZZZ... sleepy time");
                return false;
            }
        }
    }
}