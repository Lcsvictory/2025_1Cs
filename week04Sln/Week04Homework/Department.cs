using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04Homework
{
    class Department : Object
    {
        public string Code;
        public string Name;

        //public Department(string code, string name)
        //{
        //    this.Code = code;
        //    this.Name = name;
        //}

        public override string ToString()
        {
            return $"[{this.Code}] {this.Name}";
        }
    }
}
