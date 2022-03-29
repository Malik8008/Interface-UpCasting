using System;

namespace Interface_UpCasting_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            MainPrintFile word = new Word();
            word.Print();

            MainPrintFile excel = new Excel();
            excel.Print();

            MainPrintFile pdf = new PDF();
            pdf.Print();
        

        }

    }   
}
