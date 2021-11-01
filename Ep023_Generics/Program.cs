using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ep023_Generics
{
    /*
     * Generics useful for:
     *  1. Reusabilty
     *  2. Type Safety
     *  3. Efficiency
     *  
     * 
     * Generic Method: 
     *  a method declared with the type parameter for its return type Or parameter is called generic.
     *  Data type will be determined by the consumer
     *  
     *  
     * Generic Class: 
     *  defined using a type parameter in an angle brackets after the class name 
     *  
     *  
     *  
     * Generic Constraint:
     *  C# allows you to use constraints to restirct client code to specify certain types
     *  while instantialing Generic types. It will give a compile-time error if you try
     *  to instantiate a generic type using a type that is not allowed by the specified 
     *  constraints.
     * 
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            // example: numbers list
            var numbers = new Any<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.DisplayList();
            numbers.RemoveAt(1);
            numbers.DisplayList();
            Console.WriteLine($"length: {numbers.Count}");
            Console.WriteLine($"Empty: {numbers.IsEmpty}");


            // example: People list
            Console.WriteLine("------------------------------");
            var people = new Any<Person>();
            people.Add(new Person("Ali", "Elsayed"  ));
            people.Add(new Person("Gehad", "kasim"  ));
            people.Add(new Person("Nesreen", "Zidan"));
            people.DisplayList();
            people.RemoveAt(1);
            people.DisplayList();
            Console.WriteLine($"length: {people.Count}");
            Console.WriteLine($"Empty: {people.IsEmpty}");

            // example: using  Collection.Generics → library List<T>
            Console.WriteLine("------------------------------");
            var people1 = new List<Person>();
            people1.Add(new Person("Ali", "Elsayed"));
            people1.Add(new Person("Gehad", "kasim"));
            people1.Add(new Person("Nesreen", "Zidan"));
            Console.WriteLine($"length: {people1.Count}");
            Console.WriteLine($"Empty: {people1.Count == 0}");

            // example: using  Collection library  → Arraylist<T> → this way is not type safe.
            Console.WriteLine("------------------------------");

            var arr = new ArrayList();

            arr.Add(1); // intger
            arr.Add("good morning"); // string      // value type
            arr.Add('K'); // char

            arr.Add(new Person("Ahmed", "Jamal")); // reference type
            arr.Add(new { Fname = "Yosry", Lname = "yousef" }); // anonymous type

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }


    public class Person
    {
        private string fname;
        private string lname;

        public Person(string fname, string lname)
        {
            this.fname = fname;
            this.lname = lname;
        }

        public override string ToString()
        {
            return $"'{fname} {lname}'";
        }

    }


    // where T : constraint 1, constraint 2, constraint 3, ...
    // to add more reliability
    class Any<T>
    {
        private T[] _items;

        public void Add(T item)
        {
            if (_items is null)
            {
                _items = new T[] { item };
            }
            else
            {
                var length = _items.Length;
                var dest = new T[length + 1];
                for (int i = 0; i < length; i++)
                {
                    dest[i] = _items[i];
                }
                dest[dest.Length - 1] = item;

                _items = dest;
            }
        }

        public void RemoveAt(int position)
        {
            if (position < 0 || position > _items.Length - 1)
                return;
            var index = 0;
            var dest = new T[_items.Length - 1];
            for (int i = 0; i < _items.Length; i++)
            {
                if (position == i)
                    continue;
                dest[index++] = _items[i];

            }
            _items = dest;
        }

        public bool IsEmpty => _items is null || _items.Length == 0;

        public int Count => _items is null ? 0 : _items.Length;

        public void DisplayList()
        {
            Console.Write("[");
            for (int i = 0; i < _items.Length; i++)
            {
                Console.Write(_items[i]);
                // for last ,
                if(i < _items.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }

    }


}
