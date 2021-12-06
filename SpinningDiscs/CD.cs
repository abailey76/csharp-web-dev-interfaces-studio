using System;
namespace SpinningDiscs
{
    public class CD : StorageDisk
    {

        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 

        public CD(string name) : base(name)
        {
            Capacity = 734;
            Speed = 52;
        }

        public override void SpinDisk()
        {
            Console.WriteLine("A CD spins at a rate of 200 - 500 rpm");
        }

    }
}