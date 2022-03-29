using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_UpCasting_Task
{
    internal class Excel :MainPrintFile
    {
        public override void Print()
        {
            Console.WriteLine("Excel cap edildi");
        }
    }
}
