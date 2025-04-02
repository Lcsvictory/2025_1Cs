using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04Homework
{
    class Professor
    {
        public string DepartmentCode;
        public string Number;
        public string Name;

        public Professor(string number, string name, string departmentCode)
        {
            this.Number = number;
            this.Name = name;
            this.DepartmentCode = departmentCode;
        }

        public override string ToString()
        {
            return $"[{this.Number}] {this.Name}";
        }
    }
}
