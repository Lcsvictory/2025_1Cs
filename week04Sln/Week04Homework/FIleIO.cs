using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04Homework
{
    class FIleIO
    {
        private string studentPath = @"..\..\datas\studentInfo.txt";
        private string professorPath = @"..\..\datas\professorInfo.txt";
        private string departmentPath = @"..\..\datas\departmentInfo.txt";
        private string gradePath = @"..\..\datas\gradeInfo.txt";
        private string[] paths;
        private string testPath = @"..\..\datas\test.txt";

        private string doesFile = string.Empty;
        public FIleIO(string f1)
        {

            paths = new string[] { studentPath, professorPath, departmentPath, gradePath};
            if (nameof(studentPath) == f1)
                doesFile = studentPath;
            else if (nameof(professorPath) == f1)
                doesFile = professorPath;
            else if (nameof(departmentPath) == f1)
                doesFile = departmentPath;
            else if (nameof(gradePath) == f1)
                doesFile = gradePath;
            else
                doesFile = testPath;
        }    

        public void Write(string recordStr)
        {

            using (StreamWriter wr = new StreamWriter(doesFile, append: true))
            {
                //recordStr을 그대로 입력한다.
                wr.WriteLine(recordStr);
            }
        }

        public void Read()
        {
            foreach (var i in paths){
                if (!File.Exists(i))
                {
                    return;
                }
            }
           //using (StreamReader re = new StreamReader())
        }
    }
}
