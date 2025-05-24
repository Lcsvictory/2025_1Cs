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
    
    enum REG_STATUS
    {
        ENROLLED,
        GRADUATED,
        ONLEAVE,
        EXPELLED,

        END,
    }

    class Student : Member
    {


        public Student(string number, string name) : base(number,name, null)
        {
            
        }
        public Student(string number, string name, Department dept) : base(number, name, dept)
        {
            
        }

        public static Dictionary<YEAR, string> YearNames = new Dictionary<YEAR, string>()
        {
            {YEAR.ONE, "1학년"}, 
            {YEAR.TWO, "2학년"},
            {YEAR.THREE, "3학년"},
            {YEAR.FOUR, "4학년 (심화)"},
        };


        public static Dictionary<REG_STATUS, string> RegNames = new Dictionary<REG_STATUS, string>()
        {
            {REG_STATUS.ENROLLED, "재학" },
            {REG_STATUS.GRADUATED, "졸업" },
            {REG_STATUS.ONLEAVE, "휴학" },
            {REG_STATUS.EXPELLED, "퇴학" },
        };

        public DateTime BirthInfo { get; private set; } //생년월일
        public void setBirthInfo (int year, int month, int day)
        {
            BirthInfo = new DateTime(year, month, day);
        }


        public Professor Advisor { get; set; } //지도교수
        public YEAR Year { get; set; } // 학년
        public CLASS Class { get; set; } // 반
        public REG_STATUS RegStatus { get; set; } //재적상태
        public string Address { get; set; } //주소
        public string Contact { get; set; }

        public string Record
        {
            get { return $"{Number}|{Name}|{Dept.Code}|{((int)Year)}|{((int)Class)}|{((int)RegStatus)}|{Advisor.Number}|{BirthInfo.Year}|{BirthInfo.Month}|{BirthInfo.Day}|{Address}|{Contact}"; }
        }

        public static Student Restore(List<Professor> profs, List<Department> depts, string data)
        {
            string[] temp = data.Trim().Split(new char[] { '|' });
            Student st = new Student(temp[0], temp[1])
            {
                Dept = depts.FirstOrDefault(m => m.Code == temp[2]),
                Year = (YEAR)int.Parse(temp[3]),
                Class = (CLASS)int.Parse(temp[4]),
                RegStatus = (REG_STATUS)int.Parse(temp[5]),
                Advisor = profs.FirstOrDefault(m => m.Number == temp[6]),
                BirthInfo = new DateTime(int.Parse(temp[7]), int.Parse(temp[8]), int.Parse(temp[9])),
                Address = temp[10],
                Contact = temp[11]
            };
            return st;
        }

        public override string ToString() {
            return $"[{this.Number}]{this.Name}";
        }
    }
}
