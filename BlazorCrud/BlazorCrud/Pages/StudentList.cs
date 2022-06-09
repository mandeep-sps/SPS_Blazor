using StudentManagement.Modals;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Pages
{
    public class StudentListBase : ComponentBase 
    {
        public IEnumerable<Student> Students { get; set; }
        protected override async Task OnInitializedAsync()
        {
            await Task.Run(StudentList);
        }
        private void StudentList()
        {
            System.Threading.Thread.Sleep(3000);
            Student s1 = new Student
            {
                RollNo = 1802644,
                Name = "sundram",
                College = "Chandigarh Engineering College",
                Gender = Gender.Male,
                Department = Department.IT
            };
            Student s2 = new Student
            {
                RollNo = 1803295,
                Name = "shivam",
                College = "Chandigarh Engineering College",
                Gender = Gender.Male,
                Department = Department.CSE
            };
            Student s3 = new Student
            {
                RollNo = 1802652,
                Name = "sunaina",
                College = "Chandigarh Engineering College",
                Gender = Gender.Female,
                Department = Department.ME
            };
            Student s4 = new Student
            {
                RollNo = 1503264,
                Name = "vishal",
                College = "Chandigarh College Of Engineering ",
                Gender = Gender.Male,
                Department = Department.ECE
            };

            Students = new List<Student> { s1,s2,s3,s4 };
        }
    }
}
