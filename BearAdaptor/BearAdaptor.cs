using System;
using BearAdapter;


namespace BearAdaptor
{
    public class BearAdaptor : IDog
    {
        private readonly IBear _bear;

        private Random _random; 


        public BearAdaptor(IBear bear)
        {
            _bear = bear;
            _random = new Random();
        }


        public void Bark()
        {
            _bear.Roar();
        }

        public void Fetch(object objectToFetch)
        {
            _bear.LookAt(objectToFetch);
            _bear.GoTowards(objectToFetch);
            _bear.TryEat(objectToFetch);

            if(_random.NextDouble() < 0.05)
            {
                
            }
            
        }        
    }
}