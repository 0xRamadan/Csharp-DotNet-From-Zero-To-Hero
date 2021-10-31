
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ep021_Inheritance
{
    class ExplainingInheritance
    {
        // Why Inheritance??
        // 1. Reusability
        // 2. Maintainability
        // 3. Extensibility

        // Constrains:
        // -> A Class can only inherite from only one class.
        // -> A Sealed Class you don't have the right to inherite from.




        // Notes:
        // -> Cannot directly initiate an object from an abstract Class.
        // -> Virtual keyword: when you used in method that means that this method can be override in the inheriting class.
        // -> Sealed Class: Sealed member can not overriden in the derived class.
        // -> Object Class: is the Ultimate Base Class for all .Net Types.
        // -> ToString() Method → is a Default Textual Representation.
        // -> The base class's constructor are accessable to the derived class but are never automatically inherited.


        static void Main1(string[] args)
        {
            Eagle eagle = new Eagle();

            eagle.Move();    // from Animal Class
            eagle.Fly();     // from Eagle Class

            // UpCasting: Create a base class reference from a subclass reference.
            Animal animal = eagle;
            animal.Move(); // can only access the move method -- cannot access fly method.

            // DownCasting; create a subclass reference from a base class reference.

            Eagle eagle2 = (Eagle)animal;

            eagle2.Move();
            eagle2.Fly();

            // Falcon falcon = (Falcon)animal; // this way will cause a Cast Expection.

            Falcon falcon = animal as Falcon;


            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        public string Name { get; set; }
        public virtual void Move()
        {
            Console.WriteLine("Moving...");
        }


        // override on ToString() Method
        public override string ToString()
        {
            return $"Animal: {Name}";
        }

        // this method can only be inherited within the Inheriting class 
        protected void create()
        {
            Console.WriteLine("Creating");
        }
    }
    class Eagle : Animal
    {
        public void Fly()
        {
            Console.WriteLine("Flying...");
        }

        // override the move method
        public override void Move()
        {
            base.Move();
            // override here
            Console.WriteLine("overriding the Move method form the Eagle Class that Inheriate from the base class Animal");
        }


        public void hold()
        {
            create();
        }
    }
    class Falcon : Animal
    {
        public void Fly()
        {
            Console.WriteLine("Flying...");
        }
    }
}