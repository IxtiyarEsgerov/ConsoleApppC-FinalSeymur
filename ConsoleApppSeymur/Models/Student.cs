using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApppSeymur.Models
{
    class Student
    {
        public  int Id=0,EntryPoint;
        public static int Count;
        public string FullName,GroupNo,Type;
       
        public Student(string fullname,string groupno, int entrypoint)
        {
            Id =++Count;
            FullName = fullname;
            GroupNo = groupno;
            EntryPoint = entrypoint;
            Type = EntryPoint>=90 ? "Guaranteed": "Not guaranteed";
           
        }
        public override string ToString()
        {
            return $" Student's Id number - {Id}\n The student's name and surname - {FullName}\n Student's Group Number - {GroupNo}\n Student is guaranteed or not - {Type }";
        }
    }
}
