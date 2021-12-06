using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class StorageDisk : IOpticalDisc
    {
        private static int NextID = 1;
        public int ID { get; }
        public double Speed { get; set; }
        public int Capacity { get; set; }
        public string Name { get; set; }
        public List<File> Volume { get; set; }
        public bool IsWritable { get; set; } = true;
        public bool IsReWritable { get; set; } = true;


        protected StorageDisk(int capacity, string name)
        {
            Capacity = capacity;
            Name = name;
            Volume = new List<File>();
            ID = NextID;
            NextID++;
        }
        public StorageDisk(string name)
        {
            Name = name;
            Volume = new List<File>();
            ID = NextID;
            NextID++;
        }


        public void DeleteFile(File file)
        {
            if (IsReWritable)

            {
                try
                {
                    Volume.Remove(file);
                    Console.WriteLine($"{file.Name} has been removed.");
                }
                catch (Exception e)
                {
                    Console.WriteLine("No such file exists");
                }
            }
            else
            {
                Console.WriteLine("This disk is not Rewrittable");
            }
        }

        public abstract void SpinDisk();


        public void DisplayContent()
        {
            Console.WriteLine($"\n\n\tVolume: {Name}\n\n" +
                $"\t\t# of Files: {Volume.Count}\n\n" +
                $"\t\tAvailable Space: {AvailableSpace()}mb\n\n" +
                $"\t------------- Files -------------\n");
            int i = 1;
            foreach (File file in Volume)
            {
                Console.WriteLine($"\ttrack:{i}   {file}");
                i++;
            }
        }

        virtual public void OpenFile(int index)
        {
            Console.WriteLine($"\n\n{Volume[index].Content}");
        }

        public void Burn(File newFile)
        {
            if (AvailableSpace() - newFile.Size <= Capacity)
            {
                Volume.Add(newFile);
                Console.WriteLine($"Added: { newFile.Name}.{newFile.Type} to Disk: {Name}");
            }
            else
            {
                Console.WriteLine($"NOT ENOUGH SPACE! Could not add { newFile.Name}.{newFile.Type} to Disk: {Name}");
            }
        }

        public int AvailableSpace()
        {
            int total = 0;
            foreach (File file in Volume)
            {
                total += file.Size;
            };
            return Capacity - total;
        }

        public void SpinDisc()
        {
            throw new NotImplementedException();
        }

        public void ReadData()
        {
            throw new NotImplementedException();
        }
    }
}