using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01_5
{
    public class Student
    {
        public string studentId { get; set; }
        public string studentName { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public Student()
        {
        }
        public Student(string studentId, string studentName, int age, string address, string phone)
        {
            this.studentId = studentId;
            this.studentName = studentName;
            this.age = age;
            this.address = address;
            this.phone = phone;
        }
    }
}
