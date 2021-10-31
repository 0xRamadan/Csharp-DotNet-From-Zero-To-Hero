using System;

namespace Ep22_Interfaces
{
    class Honda : Vehicle, IDrivable // concrete class
    {
        public Honda(string brand, string model, int year): base(brand, model, year)
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
    }
}
