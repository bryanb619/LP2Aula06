using System;
using BearAdapter;


namespace BearAdaptor
{
    public class BearAdaptor : IDog
    {
        private readonly IBear _bear;


        public BearAdaptor(IBear bear)
        {
            _bear = bear;
        }


        public void Bark()
        {
            _bear.Roar();
        }

        public void Fetch(object objectToFetch)
        {
            
        }

        
    }
}