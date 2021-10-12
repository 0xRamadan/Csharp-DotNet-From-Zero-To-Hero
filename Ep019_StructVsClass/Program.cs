using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ep019_StructVsClass
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitalSize size = new DigitalSize(600000);
            Console.WriteLine(size.Bit);
            Console.WriteLine(size.Byte);
            Console.WriteLine(size.KB);
            Console.WriteLine(size.MB);
            Console.WriteLine(size.GB);
            Console.WriteLine(size.TB);

            Console.WriteLine("-------------------------------");
            // this is going to initialize a new object that has new value to it → 8
            size = size.AddBit(8);
            Console.WriteLine(size.Bit);
            Console.WriteLine(size.Byte);
            Console.WriteLine(size.KB);
            Console.WriteLine(size.MB);
            Console.WriteLine(size.GB);
            Console.WriteLine(size.TB);
            Console.ReadKey();
        }
    }

    struct DigitalSize
    {
        private long bit;

        public string Bit => $"{(bit / bitsInBit):N0} Bit";
        public string Byte => $"{(bit / bitsInByte):N0} Byte";
        public string KB => $"{(bit / bitsInKB):N0} KB";
        public string MB => $"{(bit / bitsInMB):N0} MB";

        public string GB => $"{(bit / bitsInGB):N0} GB";
        public string TB => $"{(bit / bitsInTB):N0} TB";

        private const long bitsInBit = 1;
        private const long bitsInByte = 8;
        private const long bitsInKB = bitsInByte * 1024;
        private const long bitsInMB = bitsInKB * 1024;
        private const long bitsInGB = bitsInMB * 1024;
        private const long bitsInTB = bitsInGB * 1024;


        public DigitalSize(long initialValue)
        {
            this.bit = initialValue;
        }

        public DigitalSize AddBit(long bit)
        {
            return Add(bit, bitsInBit);
        }

        public DigitalSize AddByte(long bit)
        {
            return Add(bit, bitsInByte);
        }
        public DigitalSize AddKB(long bit)
        {
            return Add(bit, bitsInKB);
        }
        public DigitalSize AddMB(long bit)
        {
            return Add(bit, bitsInMB);
        }
        public DigitalSize AddGB(long bit)
        {
            return Add(bit, bitsInGB);
        }
        public DigitalSize AddTB(long bit)
        {
            return Add(bit, bitsInTB);
        }
        private DigitalSize Add(long value, long scale)
        {
            return new DigitalSize(value * scale);
        }





    }
}
