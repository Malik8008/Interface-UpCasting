using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_UpCasting_Task
{
    internal class PDF :MainPrintFile
    {
        public override void Print()
        {
            Console.WriteLine("PDF cap edildi");
        }
    }
}
