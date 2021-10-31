using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ep022_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Honda honda = new Honda("Honda", "sportage", 2014);
            honda.Move();
            Caterpiller caterpiller = new Caterpiller("caterpiller", "giller", 2020);
            caterpiller.Move();
            caterpiller.Load();
            Console.ReadKey();
        }
    }
}
