using System;
using System.Collections.Generic;
using System.Text;

namespace Praktika_Task_2
{
    internal class Student
    {
        public string Fullname;
        public string GroupNo;
        public int AvgPoint;

        public Student(string fullname, string groupno, int avgpoint)
        {
            Fullname = fullname;
            GroupNo = groupno;
            AvgPoint = avgpoint;
        }
    }
}
