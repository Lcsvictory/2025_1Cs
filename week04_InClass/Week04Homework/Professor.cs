using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04Homework
{
    class Professor : Member, IFile
    {

        public string Record
        {
            get { return $"{Number}|{Name}|{Dept.Code}"; }
        }

        public Professor(string number, string name, Department dept) : base(number, name, dept)
        {  
        }

        public static Professor Restore(string data, List<Department> depts)
        {
            Professor prof = null;
            try
            {
                string[] temp = data.Trim().Split('|');
                Department dept = depts.FirstOrDefault(m => m != null && m.Code == temp[2]);
                prof = new Professor(temp[0], temp[1], dept);
            } catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("저장된 데이터의 포맷이 잘못되었습니다. : " + ex);
                throw ex;
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
            return prof;
        }

        public override string ToString()
        {
            return $"[{Number}]{Name}";
        }

        
    }
}
