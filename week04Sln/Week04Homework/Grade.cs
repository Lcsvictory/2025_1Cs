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
        //public static int MAX_GRADE_COUNT = 9;
        //private static int MAX_GRADE_COUNT = 9;
        //const = static + const
        public const int MAX_GRADE_COUNT = 9; //전역변수, 상수

        public string StudentNumber;
#if false
        public List<double> Scores = new List<double>();

        public double GetAverage()
        {

            if (this.Scores.Count == 0)
            {
                return -1.0;
            }

            double sum = 0;
            foreach (var score in this.Scores)
            {
                sum += score;
            }
            double average = sum / this.Scores.Count;
            return average;
            
        }
#else
        private List<double> _scores = new List<double>();

        public double GetAverage()
        {

            if (this._scores.Count == 0)
            {
                return -1.0;
            }
            //return _scores.Average();
            double average = _scores.Sum() / _scores.Count;
            return average;

        }
#endif

        //public Dictionary<string, double> Scores = new Dictionary<string, double>();


        public int ScoresCount()
        {
            return this._scores.Count;
        }
        public double GetScores(int i)
        {
            if (0 <= i && 1 < _scores.Count)
            {
                return this._scores[i];
            }
            return 0.0;
        }

        public void Clear()
        {
            this._scores.Clear();
        }

        public bool Add(double score)
        {
            if (0.0 > score || score > 4.5)
            {
                return false;
            }
            //if (_scores.Count >= MAX_GRADE_COUNT)
            //if (_scores.Count >= this.MAX_GRADE_COUNT)
            if (_scores.Count >= Grade.MAX_GRADE_COUNT)
            {
                return false;
            }
            this._scores.Add(score);
            return true;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        //public string FileWrite()
        //{
        //    string tempStr = string.Empty;
        //    tempStr += this.StudentNumber + "-=-";
        //    foreach (var k in Scores.Keys)
        //    {
        //        tempStr += k + ":";
        //        tempStr += Scores[k].ToString() + ",";
        //    }
        //    return tempStr;
        //}
    }
}
