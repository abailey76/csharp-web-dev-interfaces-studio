using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.

            CD cd1 = new CD("Backup LaunchCode Documents");
            DVD dvd1 = new DVD("Backup Lecture Recodings");
            File file1 = new File("LC101 - JavaScript", 50, "pdf",
                "This is the full set of instructions all boiled down to a few " +
                "sentences and simple injected into your head\n");
            File file2 = new File("LC101 - Java", 150, "pdf",
                "This is the full set of instructions all boiled down to a few " +
                "sentences and simple injected into your head\n");
            File file3 = new File("LC101 - C#", 250, "pdf",
                "This is the full set of instructions all boiled down to a few " +
                "sentences and simple injected into your head\n");
            File file4 = new File("LC101 - Python", 260, "pdf",
                "This is the full set of instructions all boiled down to a few " +
                "sentences and simple injected into your head\n");
            cd1.Burn(file1);
            cd1.Burn(file2);
            cd1.Burn(file3);
            cd1.Burn(file4);

            // TODO: Call each CD and DVD method to verify that they work as expected.
            cd1.SpinDisk();
            dvd1.SpinDisk();
            cd1.DisplayContent();
            cd1.OpenFile(1);
            cd1.DeleteFile(file4);
            cd1.DisplayContent();
        }
    }
}