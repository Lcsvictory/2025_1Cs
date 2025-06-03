using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#if false
namespace Week04Homework
{
    class Grade
    {
        //static field
        public static int MAX_GRADE_COUNT = 9;

        //instance field
        public string StudentNumber;
        public List<double> Scores = new List<double>();

        //instance method
        public double Average()
        {
            if (this.Scores.Count == 0) {
                return -1.0;
            }

            double sum = 0.0;
            foreach (var score in this.Scores) {
                sum += score;
            }
            return sum / Scores.Count;
        }
    }
}
#else
namespace Week04Homework
{
    class Grade : IFile
    {
        public const int MAX_GRADE_COUNT = 9;

        private string _studentNumber;
        public string StudentNumber
        {
            get { return this._studentNumber; }
        }

        public string Record {
            get {
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < _scores.Count; i++)
                {
                    builder.Append(_scores[i] + "|");
                }
                return $"{builder}"; 
            }
        }

        public Grade(string sNumber)
        {
            this._studentNumber = sNumber;
        }

        private List<double> _scores = new List<double>();

        public static Grade Restore(string data, string sNumber)
        {
            Grade g1 = null;
            try
            {
                string[] temp = data.Trim().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                
                if (temp.Length > MAX_GRADE_COUNT) { return null; }

                g1 = new Grade(sNumber);
                for (int i = 0; i < temp.Length; ++i) {
                    g1._scores.Add(double.Parse(temp[i]));
                }
            } catch (Exception ex)
            {
                Console.WriteLine("학점 가져오는중 에러 발생 : " + ex);
            }
            return g1;
        }

        public int Count()
        {
            return _scores.Count;
        }
        public double Get(int i)
        {
            return _scores[i];
        }

        //instance method
        public double Average()
        {
            if (this._scores.Count == 0) {
                return -1.0;
            }

            double sum = 0.0;
            foreach (var score in this._scores) {
                sum += score;
            }
            return sum / _scores.Count;
        }

        public void Clear()
        {
            _scores.Clear();
        }

        public bool Add(double score)
        {
            //score범위 확인 

            //if (_scores.Count >= MAX_GRADE_COUNT) {
            //if (_scores.Count >= this.MAX_GRADE_COUNT) {
            if (_scores.Count >= Grade.MAX_GRADE_COUNT) {
                return false;
            }

            _scores.Add(score);
            return true;
        }
    }
}
#endif