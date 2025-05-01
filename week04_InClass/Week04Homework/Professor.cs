using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04Homework
{
    class Professor
    {


        public string DepartmentCode { get; set; }
        private string _number;
        private string _name;
        public string Number
        {
            get { return this._number; }
        }

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        

        public Professor(string number, string name, string deptCode)
        {
            this.Name = name;
            this._number = number;
            this.DepartmentCode = deptCode;
        }


        public override string ToString()
        {
            return $"[{Number}]{Name}";
        }
    }
}
