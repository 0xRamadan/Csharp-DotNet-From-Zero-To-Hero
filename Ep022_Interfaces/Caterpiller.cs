using System;

namespace Ep022_Interfaces
{
    class Caterpiller : Vehicle, IDrivable, ILoader
    {
        public Caterpiller(string brand, string model, int year) : base(brand, model, year)
        {

        }


        public void Move()
        {
            Console.WriteLine("Moving...!");
        }

        public void Stop()
        {
            Console.WriteLine("Stoping...!");
        }
        // implementation of interface's method
        public void Load()
        {
            Console.WriteLine("loading...!");
        }

        public void Unload()
        {
            Console.WriteLine("unloading...!");
        }
    }
}
