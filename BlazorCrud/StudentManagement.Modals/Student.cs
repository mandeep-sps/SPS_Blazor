using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Modals
{
    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string College { get; set; }
        public Gender Gender { get; set; }
        public Department Department { get; set; } 

    }
}
