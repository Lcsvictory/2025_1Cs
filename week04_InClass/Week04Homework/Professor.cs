using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04Homework
{
    class Professor : Member
    {

        public Professor(string number, string name, Department dept) : base(number, name, dept)
        {
            
        }


        public override string ToString()
        {
            return $"[{Number}]{Name}";
        }
    }
}
