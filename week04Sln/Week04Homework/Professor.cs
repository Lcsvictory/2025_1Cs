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
        public string Number { get; set; } 
        public string Name { get; set; }

        public Professor(string number, string name, string departmentCode)
        {
            this.Number = number;
            this.Name = name;
            this.DepartmentCode = departmentCode;
        }

        public Professor()
        {

        }

        public override string ToString()
        {
            return $"[{this.Number}] {this.Name}";
        }

        /// <summary>
        /// 텍스트 파일에 저장할 문자열을 생성합니다.
        /// </summary>
        /// <returns>생성된 문자열 반환.</returns>
        public string FileWrite()
        {
            return $"{this.DepartmentCode}-=-{this.Number}-=-{this.Name}";
        }
    }
}
