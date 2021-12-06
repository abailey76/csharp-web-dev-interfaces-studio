using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    internal interface IOpticalDisc
    {
        public void Burn(File file);
        public void DeleteFile(File file);
        public void SpinDisk();
        public void DisplayContent();
        public void OpenFile(int index);
        public int AvailableSpace();


    }
}