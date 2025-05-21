using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04Homework
{
    //Object 클래스를 상속한 Department
    class Department : object
    {
        private string _code;
        private string _name;

        //없으면 자동생성
        public Department(string code, string name)
        {
            this._code = code;
            this._name = name;
        }


        //property 속성
        //getter+setter 한번에 구현
        public string Code
        {
            get { return this._code; }
            private set {
                if (false == string.IsNullOrEmpty(value))
                {
                    this._code = value;
                }
            }
        }

        public string Name
        {
            get { return this._name;  }
            private set
            {
                if (false == string.IsNullOrEmpty(value) && value.Length >= 2)
                {
                    this._name = value;
                }
            }
        }

        public string GetCode()
        {
            return this._code;
        }
        private void SetCode(string code)
        {
            if (false == string.IsNullOrEmpty(code)){
                this._code = code;
            }
        }

        public static Department Restore(string data)
        {
            Department dept = null;

            var temp = data.Trim().Split(new char[] { '|' });
            dept = new Department(temp[0], temp[1]);
            return dept;
        }


        //python의 __str__()와 동일
        public override string ToString()
        {
            return $"[{Code}] {Name}";
        }

        public string Record
        {
            get { return $"{Code}|{Name}"; }
        }
    }
}
