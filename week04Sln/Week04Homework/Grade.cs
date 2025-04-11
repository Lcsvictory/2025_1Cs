using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Week04Homework
{
    class Grade
    {
        public static int MAX_GRADE_COUNT = 9;

        public string StudentNumber;
        //public List<double> Scores = new List<double>();
        public Dictionary<string, double> Scores = new Dictionary<string, double>();

        public override string ToString()
        {
            return base.ToString();
        }

        public string FileWrite()
        {
            string tempStr = string.Empty;
            tempStr += this.StudentNumber + "-=-";
            foreach (var k in Scores.Keys)
            {
                tempStr += k + ":";
                tempStr += Scores[k].ToString() + ",";
            }
            return tempStr;
        }
    }
}
