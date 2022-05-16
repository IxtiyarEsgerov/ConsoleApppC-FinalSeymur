using ConsoleApppSeymur.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApppSeymur.Models
{
    class Group
    {
        public string No;
        Categories Category;
        bool _Isonline;
        int _limit;
        public static int Count;
        private List<Student> _generalyStudent;
        public List<Student> GeneralyStudent { get { return _generalyStudent;}  }
        public int limit { get { return _limit; } }

        public bool Isonline
        {
            get { return _Isonline; }
            set {
                _Isonline = value;
                
                _limit = value ? 15 : 10;
            }
        }
        static Group() {
            Count = 100;
        }
        public Group(bool online, Categories category)
        {
            
            Isonline = online;
            
            _generalyStudent = Isonline ?  new List<Student>(15) :  new List<Student>(10);

            switch (category)
            {
                 case Categories.Programming:
                    No= $"P" + Count;
                    break;
                case Categories.Design:
                    No = $"D" + Count;
                    break;
                case Categories.System_Admistrator:
                    No = $"S" + Count;
                    break;
                default:
                    break;
            }
            Category = category;
            Count++;
        }
        public override string ToString()
        {
            return $" Group number - {No} \n Category of group -  {Category} \n Number of students in the group - {GeneralyStudent.Count}";
        }

    }
}
