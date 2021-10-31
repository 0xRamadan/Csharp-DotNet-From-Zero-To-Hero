using System;

namespace Ep022_Interfaces
{
    class Caterpiller : Vehicle, IDrivable, ILoader, IMaintenanceCaterpiller, IMaintenance
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
        //
        // implementation of interface's method
        public void Load()
        {
            Console.WriteLine("loading...!");
        }

        public void Unload()
        {
            Console.WriteLine("unloading...!");
        }

        // implementing the method explicitly
        void IMaintenanceCaterpiller.Maintenance()
        {
            Console.WriteLine("Maintenace the Caterpiller...!");
        }

        void IMaintenance.Maintenance()
        {
            Console.WriteLine("Maintenace...!");
        }
    }
}
