using System;

namespace Ep022_Interfaces
{
    /*
     * 
    Abstract class is meant to be used as the base class from which
    other classess are derived. The derived class is expected to 
    provide an implementations for the member function that are not
    implemented in the base class. A derived class that implement 
    all the missing.

    */

    abstract class Vehicle  // abstract type 
    {
        protected Vehicle(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        protected string Brand { get; set; }
        protected String Model { get; set; }
        protected int Year { get; set; }

    }
}
