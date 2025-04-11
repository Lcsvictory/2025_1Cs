using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04Homework
{
    class FileIO
    {
        public static string studentPath = @"..\..\datas\studentInfo.txt";
        public static string professorPath = @"..\..\datas\professorInfo.txt";
        public static string departmentPath = @"..\..\datas\departmentInfo.txt";
        public static string gradePath = @"..\..\datas\gradeInfo.txt";
        private string[] paths;
        private string testPath = @"..\..\datas\test.txt";

        private string doesFile = string.Empty;
        public FileIO(string f1)
        {

            paths = new string[] { studentPath, professorPath, departmentPath, gradePath};
            if (studentPath== f1)
                doesFile = studentPath;
            else if (professorPath == f1)
                doesFile = professorPath;
            else if (departmentPath == f1)
                doesFile = departmentPath;
            else if (gradePath == f1)
                doesFile = gradePath;
            else
                doesFile = testPath;
        }    

        //한줄쓰기
        public void LineWrite(string recordStr)
        {
            try
            {
                using (StreamWriter wr = new StreamWriter(doesFile, append: true))
                {
                    //recordStr을 그대로 입력한다.
                    wr.WriteLine(recordStr);
                }
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        //저장할때 쓰기
        public void Write(List<Professor> professors)
        {
            try
            {
                using (StreamWriter wr = new StreamWriter(doesFile, append: false))
                {
                    foreach (var prof in professors)
                    {
                        if (prof != null)
                        {
                            Console.WriteLine("Write(professors) : " + prof.FileWrite());
                            wr.WriteLine(prof.FileWrite());
                        }
                        
                    }
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Write(Department[] departments)
        {
            try
            {
                using (StreamWriter wr = new StreamWriter(doesFile, append: false))
                {
                    foreach (var dept in departments)
                    {
                        if (dept != null)
                        {
                            wr.WriteLine(dept.FileWrite());
                        }
                        
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Write(Dictionary<string,Student> students)
        {
            try
            {
                using (StreamWriter wr = new StreamWriter(doesFile, append: false))
                {
                    foreach (var k in students.Keys)
                    {
                        wr.WriteLine(students[k].FileWrite());
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Write(List<Grade> grades)
        {
            try
            {
                using (StreamWriter wr = new StreamWriter(doesFile, append: false))
                {
                    foreach (var grade in grades)
                    {
                        wr.WriteLine(grade.FileWrite());
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //실행할때 읽기
        public List<string> Read()
        {
            if (!File.Exists(doesFile))
            {
                return new List<string>();
            }

            List<string> result = new List<string>();
            try
            {
                using (StreamReader re = new StreamReader(doesFile))
                {
                    string line = re.ReadLine();
                    while (line != null)
                    {
                        result.Add(line);
                        line = re.ReadLine();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return result;
        }





        //public void StudentUpdate()
        //{
           
        //}
    }
}
