using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04Homework
{

    enum YEAR
    {
        ONE ,
        TWO ,
        THREE ,
        FOUR ,

        END, // END = 4
    }

    enum CLASS
    {
        A,
        B,
        C,

        END,
    }
    

    class Student {


        public Student(string number, string name)
        {
            //property로 필드에 접근하고있다.
            this.Number = number;
            this.Name = name;
        }

        public static Dictionary<YEAR, string> YearNames = new Dictionary<YEAR, string>()
        {
            {YEAR.ONE, "1학년"}, 
            {YEAR.TWO, "2학년"},
            {YEAR.THREE, "3학년"},
            {YEAR.FOUR, "4학년 (심화)"},
        };
        
        public string Number { get; private set; } //학번
        
        public string Name { get; private set; } //이름
        public DateTime BirthInfo { get; private set; } //생년월일
        public void setBirthInfo (int year, int month, int day)
        {
            BirthInfo = new DateTime(year, month, day);
        }


        public string DepartmentCode { get; set; } //학과코드
        public string AdvisorNumber { get; set; } //지도교수번호
        public YEAR Year { get; set; } // 학년
        public CLASS Class { get; set; } // 반
        public string RegStatus { get; set; } //재적상태
        public string Address { get; set; } //주소

        private string _contact;//연락처 
        public string Contact
        {
            get { return _contact; }
            set { this._contact = value; }
        }
        public override string ToString() {
            return $"[{this.Number}]{this.Name}";
        }
    }
}
