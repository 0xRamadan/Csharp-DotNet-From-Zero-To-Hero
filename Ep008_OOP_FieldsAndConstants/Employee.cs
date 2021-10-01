using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008withEngEssam
{
    // <classModifier> class <className>
    // classModifier> -> public, internal (default)
    // {
    // }
    // class block
    /*
     * Class Members:
     * Fields
     * Constants
     * Properties
     * Methods
     * Events
     * Operator 
     * Indexers
     * Constructors
     * Finalizers
     * Nested Types
     */

    public class Employee
    {
        // <AccessModifier> public, private, protected
        // Constant  -> <AccessModifier> const <DataType> <FieldName> = <Value>;

        public const double TAX = 0.03;

        // <AccessModifier> public, private, protected
        // Fields  -> <AccessModifier> <DataType> <FieldName> = <InitialValue>;

        public string FName;
        public string LName;
        public double wage;
        public double LoggedHours;
        public double NetSalary;


    }
}
