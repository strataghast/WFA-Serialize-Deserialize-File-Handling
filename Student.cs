using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_10_2
{
    [Serializable]
    internal class Student
    {
        public int studentID { get; set; }
        public string studentName { get; set; }
        public string studentAddress { get; set; }
        public float studentMarks { get; set; }
        public string studentGrade { get; set; }
    }
}
