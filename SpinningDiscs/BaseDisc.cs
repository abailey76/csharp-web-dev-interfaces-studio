using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        public string Name { get; set; }
        public double TotalCapacity { get; set; }
        public double CapacityUsed { get; set; } = 0;
        public string DiscType { get; set; }

        public List<string> DiscContents { get; }

        public BaseDisc(string name, double totalCapacity, string discType)
        {
            Name = name;
            TotalCapacity = totalCapacity;
            DiscType = discType;
        }

        public void WriteToDisc(double data)
        {
            if (data + CapacityUsed > TotalCapacity)
            {
                Console.WriteLine("Not enough space.");
                return;
            }
            CapacityUsed += data;
            TotalCapacity -= data;
        }

        public double CheckRemainingSpace()
        {
            return TotalCapacity - CapacityUsed;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Disc Name: {Name}\nTotal Space: {TotalCapacity}\nSpace Used: {CapacityUsed}\nSpace Remaining: {CheckRemainingSpace()}");
        }
    }
}
