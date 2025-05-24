using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04Homework
{
    class Professor : Member
    {

        public string Record
        {
            get { return $"{Number}|{Name}|{Dept.Code}"; }
        }

        public Professor(string number, string name, Department dept) : base(number, name, dept)
        {  
        }

        public static Professor Restore(string data, List<Department> depts)
        {
            string[] temp = data.Trim().Split(new char[] { '|' });
            Department dept = depts.FirstOrDefault(m => m.Code == temp[2]);
            Professor prof = new Professor(temp[0], temp[1], dept);
            return prof;
        }

        public override string ToString()
        {
            return $"[{Number}]{Name}";
        }

        
    }
}
