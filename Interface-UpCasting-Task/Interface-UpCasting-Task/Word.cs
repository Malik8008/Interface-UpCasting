using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_UpCasting_Task
{
    internal class Word:MainPrintFile 
    {
        
        public override void Print()
        {
            Console.WriteLine("Word cap edildi");
        }
    }
}
