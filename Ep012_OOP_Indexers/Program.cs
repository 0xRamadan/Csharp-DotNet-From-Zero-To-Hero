using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ep012_OOP_Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            // working with indexers -> ex: IP Address

            var ip = new IP(122, 156, 123, 124);
            // var ip = new IP("123.123.156.145");

            Console.WriteLine($"IP Address: {ip.Address}");

            var firstSegment = ip[2];
            Console.WriteLine($"First Segment: {firstSegment}");


            // sudoko exmaple
            int[,] inputs = new[,]
            {
                {8, 3, 5, 4, 1, 6, 9, 2, 7},
                {2, 9, 6, 8, 5, 7 ,4, 3, 1},
                {4, 1, 7, 2, 9, 3, 6, 5, 8},
                {5, 6, 9, 1, 3, 4, 7, 8, 2},
                {1, 2, 3, 6, 7, 8, 5, 4, 9},
                {7, 4, 8, 5, 2 ,9, 1, 6, 3},
                {6, 5, 2, 7, 8, 1, 3, 9, 4},
                {9, 8, 1, 3, 4, 5, 2, 7, 6},
                {3, 7, 4, 9, 6, 2, 8, 1, 5}
                };

            var suduko = new Suduko(inputs);
            Console.WriteLine($"index of a suduko: {suduko[5, 5]}");
            Console.ReadKey();
        }
    }

    public class IP
    {
        // create field
        private int[] segments = new int[4];


        // create an indexer
        public int this[int index] 
        { 
            get 
            {
                return segments[index];
            }
            set
            {
                segments[index] = value;
            } 
        }


        // create constructor
        public IP(int segment1, int segment2, int segment3, int segment4)
        {
            segments[0] = segment1;
            segments[1] = segment2;
            segments[2] = segment3;
            segments[3] = segment4;

        }

        /*public IP(string IPAddress) // 123.123.123.123
        {
            // I don't why this error is coming up.
            var segs = IPAddress.Split(".");

            for (int i = 0; i < segs.Length; i++)
            {
                segments[i] = Convert.ToInt32(segs[i]);
            }
        }*/

        // to print for user -- property using body expression method
        public string Address => string.Join(".", segments);


    }

    public class Suduko
    {
        // private field
        private int[,] _matrix;

        // creating a indexer
        public int this[int row, int col]
        {
            get
            {
                // just a validation
                if (row < 0 || row > _matrix.GetLength(0) - 1)
                    return -1;
                if (col < 0 || col > _matrix.GetLength(0) - 1)
                    return -1;

                return _matrix[row, col];

            }
            set
            {
                // just simple validation
                if (value < 0 || value < _matrix.GetLength(0))
                    return;
                _matrix[row, col] = value;
            }
        }

        // constructor
        public Suduko(int[,] matrix)
        {
            this._matrix = matrix;
        }
    }
}
