﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Week04Homework
{
    public partial class FormManager : Form
    {
        Department[] departments;
        List<Professor> professors;
        Dictionary<string, Student> students;
        List<Grade> testGrades;
        TextBox[] tbxTestScores;
        Student selectedStudent = null;

        FileIO dp;
        FileIO st;
        FileIO pr;
        FileIO gr;
        

        public FormManager()
        {
            InitializeComponent();
            departments = new Department[100];
            professors = new List<Professor>();
            students = new Dictionary<string, Student>();
            testGrades = new List<Grade>();
            tbxTestScores = new TextBox[]
            {
                tbxTestScore1,
                tbxTestScore2,
                tbxTestScore3,
                tbxTestScore4,
                tbxTestScore5,
                tbxTestScore6,
                tbxTestScore7,
                tbxTestScore8,
                tbxTestScore9,
            };

            

            for (int i = 1; i < 5; i++)
            {
                cmbYear.Items.Add(i);
            }
            for (char j = 'A'; j < 'D'; j++)
            {
                cmbClass.Items.Add(j);
            }
            cmbRegStatus.Items.Add("재학");
            cmbRegStatus.Items.Add("졸업");
            cmbRegStatus.Items.Add("휴학");
            cmbRegStatus.Items.Add("자퇴");

            //Read() = txt파일에서 정보 읽어와서 문자열로 리턴함.
            dp = new FileIO(FileIO.departmentPath);
            registerDepartment(dp.Read());
            st = new FileIO(FileIO.studentPath);
            registerStudent(st.Read());
            pr = new FileIO(FileIO.professorPath);
            registerProfessor(pr.Read());
            gr = new FileIO(FileIO.gradePath);
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            var target = sender as TextBox;
            if (target != null && target.Name == "tbxProfessorNumber")
            {
                tbxDepartmentCode_KeyDown(sender, e);
            }
            else
            {
                tbxDepartmentName_KeyDown(sender, e);
            }
        }

        //파일에서 읽어온 문자열을 실제 타입으로 변환하는메소드
        private void registerDepartment(List<string> l1)
        {
            int index = 0;
            foreach (string line in l1)
            {
                Department dept = new Department();
                string[] items = line.Split(new string[] {"-=-"}, StringSplitOptions.RemoveEmptyEntries);//빈 문자열은 가져오지 마라.
                
                Type type = dept.GetType(); //Student타입을 가져옴.
                FieldInfo[] fields = type.GetFields(); //이 클래스에 존재하는 필드를 가져옴.

                if (items.Length == fields.Length)
                {
                    dept.Code = items[0];
                    dept.Name = items[1];
                }
                departments[index] = dept;
                lbxDepartment.Items.Add(dept);
                index++;
            }

        }

        //파일에서 읽어온 문자열을 실제 타입으로 변환하는메소드
        private void registerStudent(List<string> l1)
        {
            foreach (string line in l1)
            {
                Student student = new Student();
                string[] items = line.Split(new string[] { "-=-" }, StringSplitOptions.RemoveEmptyEntries);//빈 문자열은 가져오지 마라.
                Type type = student.GetType();
                FieldInfo[] fields = type.GetFields();
                if (items.Length == fields.Length)
                {
                    student.Number = items[0];
                    student.Name = items[1];
                    student.BirthInfo = DateTime.Parse(items[2]);
                    student.DepartmentCode = items[3];
                    student.AdvisorNumber = items[4];
                    student.Year = int.Parse(items[5]);
                    student.Class = items[6];
                    student.RegStatus = items[7];
                    student.Address = items[8];
                    student.Contact = items[9];
                    
                }
                Console.WriteLine(student.Contact);
                students[student.Number] = student;
                lbxDictionary.Items.Add(student);
            }

        }

        //파일에서 읽어온 문자열을 실제 타입으로 변환하는메소드
        private void registerProfessor(List<string> l1)
        {
            foreach (string line in l1)
            {
                Professor prof = new Professor();
                string[] items = line.Split(new string[] { "-=-" }, StringSplitOptions.RemoveEmptyEntries);//빈 문자열은 가져오지 마라.
                Type type = prof.GetType();
                FieldInfo[] fields = type.GetFields();
                if (items.Length == fields.Length)
                {
                    prof.DepartmentCode = items[0];
                    prof.Number = items[1];
                    prof.Name = items[2];

                }
                professors.Add(prof);
                lbxProfessor.Items.Add(prof);
            }

        }

        private void btnRegisterDepartment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxDepartmentCode.Text))
            {
                MessageBox.Show("학과코드를 입력하세요.");
                tbxDepartmentCode.Focus();
                return;
            }
            if (string.IsNullOrEmpty(tbxDepartmentName.Text))
            {
                MessageBox.Show("학과이름을 입력하세요.");
                tbxDepartmentName.Focus();
                return;
            }
            int index = -1;
            for (int i = 0; i < departments.Length; i++)
            {
                if (departments[i] == null)
                {
                    if (index < 0)
                    {
                        index = i;
                    }
                    //break;
                }
                else
                {
                    if (departments[i].Code == tbxDepartmentCode.Text)
                    {
                        MessageBox.Show("중복된 코드가 존재합니다.");
                        tbxDepartmentCode.Focus();
                        return;
                    }
                }
            }
            if (index == -1)
            {
                MessageBox.Show("더이상 배열의 공간이 없습니다. ");
                return;
            }
            Department dept = new Department();
            departments[index] = dept;
            
            dept.Code = tbxDepartmentCode.Text;
            dept.Name = tbxDepartmentName.Text;

            lbxDepartment.Items.Add(dept);


            tbxDepartmentCode.Text = "";
            tbxDepartmentCode.Focus();
            tbxDepartmentName.Text = "";
        }

        private void btnRemoveDepartment_Click(object sender, EventArgs e)
        {
            //SelectedIndex의 기본값 = -1
            if (lbxDepartment.SelectedIndex < 0)
            {
                MessageBox.Show("삭제할 항목을 선택하세요.");
                return;
            }
            //같은 객체인가? (값이 같은지를 체크하는게 아님.)
            if (lbxDepartment.SelectedItem is Department)
            {
                var target = (Department)lbxDepartment.SelectedItem;
                int i;
                for (i = 0; i < departments.Length; i++)
                {
                    if (departments[i] != null && departments[i] == target)
                    {
                        departments[i] = null;
                        break;
                    }
                }

                //lbxDepartment.Items.RemoveAt(i); //i는 departments를 기준으로 수행됨으로 lbxDepart...의 선택된 인덱스와 다름.
                lbxDepartment.Items.RemoveAt(lbxDepartment.SelectedIndex);

                lbxDepartment.SelectedIndex = -1;
            }
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabMain.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    cmbProfessorDepartment.Items.Clear();
                    lbxProfessor.Items.Clear();
                    cmbProfessorDepartment.SelectedIndex = -1;
                    foreach (var dept in departments)
                    {
                        if (dept != null)
                        {
                            Console.WriteLine("tabMain_SelectedIndexChanged() : " + dept);
                            cmbProfessorDepartment.Items.Add(dept);
                        }
                    }
                    
                    break;
                case 2:
                    cmbDepartment.Items.Clear();
                    cmbDepartment.SelectedIndex = -1;
                    cmbAdvisor.SelectedIndex = -1;
                    foreach (var dept in departments)
                    {
                        if (dept != null)
                        {
                            cmbDepartment.Items.Add(dept);
                        }
                    }
                    
                    break;

                case 3:
                    foreach (var tbxScore in tbxTestScores)
                    {
                        tbxScore.Text = string.Empty;
                    }
                    lblTestTotalCount.Text = string.Empty;
                    lblTestAverage.Text = string.Empty;
                    break;
                default:
                    break;
            }
        }

        private void cmbProfessorDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProfessorDepartment.SelectedIndex < 0)
            {
                return;
            }
            lbxProfessor.Items.Clear();


            var dept = cmbProfessorDepartment.SelectedItem as Department;

            if (dept != null)
            {
                foreach (var prof in professors)
                {
                    if (prof != null && dept.Code == prof.DepartmentCode)
                    {
                        lbxProfessor.Items.Add(prof);
                    }
                }
            }
        }

        private void tbxDepartmentCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // 삐소리 제거.

                SendKeys.Send("{TAB}");  // Tab 키 누름 효과 발생.
            }
        }

        private void tbxDepartmentName_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // 삐소리 제거.

                var target = sender as TextBox;
                if (target != null && target.Name == "tbxDepartmentName")
                {
                    btnRegisterDepartment_Click(sender, e);
                } else
                {
                    btnRegisterProfessor_Click(sender, e);
                }



            }
        }



        private void btnRegisterProfessor_Click(object sender, EventArgs e)
        {
            if (cmbProfessorDepartment.Items.Count <= 0)
            {
                MessageBox.Show("학과정보를 먼저 등록하세요.");
                tabMain.SelectedIndex = 0;
                return;
            }
            if (cmbProfessorDepartment.SelectedIndex < 0)
            {
                MessageBox.Show("소속학과를 선택하세요.");
                //cmbProfessorDepartment.Focus();
                return;
            }
            if (string.IsNullOrEmpty(tbxProfessorNumber.Text))
            {
                MessageBox.Show("교수번호를 입력하세요.");
                tbxProfessorNumber.Focus();
                return;
            }
            if (string.IsNullOrEmpty(tbxProfessorName.Text))
            {
                MessageBox.Show("학과이름을 입력하세요.");
                tbxProfessorName.Focus();
                return;
            }


            //professors.Add(); //원본 객체에 아이템 추가.
            //var newList = professors.Append(); //아이템을 추가한 새로운 객체 반환.
            foreach (var prof1 in professors)
            {
                if (prof1.Number == tbxProfessorNumber.Text)
                {
                    MessageBox.Show("동일한 교수번호가 이미 존재합니다.");
                    tbxProfessorNumber.Focus();
                    return;
                }
            }
            string deptcode = cmbProfessorDepartment.SelectedItem.ToString();
            int rightBigParen = deptcode.IndexOf("]") - 1;

            deptcode = deptcode.Substring(1, rightBigParen);
            Professor prof = new Professor(tbxProfessorNumber.Text, tbxProfessorName.Text, deptcode);
            professors.Add(prof);
            lbxProfessor.Items.Add(prof);

            tbxProfessorNumber.Text = "";
            tbxProfessorNumber.Focus();
            tbxProfessorName.Text = "";


        }

        private void tbxProfessorNumber_KeyDown(object sender, KeyEventArgs e)
        {
            keyDown(sender, e);
        }

        private void tbxProfessorName_KeyDown(object sender, KeyEventArgs e)
        {
            keyDown(sender, e);
        }

        private void btnRemoveProfessor_Click(object sender, EventArgs e)
        {
            if (lbxProfessor.SelectedIndex < 0)
            {
                MessageBox.Show("삭제할 항목을 선택하세요.");
                return;
            }
            var target = professors[lbxProfessor.SelectedIndex];
            if (target != null)
            {
                professors.Remove(target);
                lbxProfessor.Items.RemoveAt(lbxProfessor.SelectedIndex);
            }

            lbxProfessor.SelectedIndex = -1;

        }
        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAdvisor.Items.Clear();
            if (cmbDepartment.SelectedItem == null)
            {
                return;
            }
            string deptcode = cmbDepartment.SelectedItem.ToString();

            int rightBigParen = deptcode.IndexOf("]") - 1;

            deptcode = deptcode.Substring(1, rightBigParen);

            foreach (var prof in professors)
            {
                if (prof != null && deptcode == prof.DepartmentCode)
                {
                    cmbAdvisor.Items.Add(prof);
                }
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearStudentInfo();
            lbxDictionary.SelectedIndex = -1;
        }

        private void ClearStudentInfo()
        {
            tbxNumber.Text = "20";
            tbxName.Text = "";
            tbxBirthYear.Text = "20";
            tbxBirthMonth.Text = "";
            tbxBirthDay.Text = "";
            cmbDepartment.SelectedIndex = -1;
            cmbAdvisor.SelectedIndex = -1;
            cmbYear.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;
            cmbRegStatus.SelectedIndex = -1;
            tbxAddress.Text = "";
            tbxContact.Text = "";
            tbxNumber.ReadOnly = false;
            selectedStudent = null;
            btnRegister.Text = "등록";
        }


        
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (selectedStudent == null)
            {
                RegisterStudent();
            } else
            {
                UpdateStudent();
            }
        }


        private Student makeStudent(string number)
        {
            var name = tbxName.Text.Trim();
            if (string.IsNullOrEmpty(name) || name.Length < 2)
            {
                tbxName.Focus();
                return null;
            }
            Student student = new Student();
            student.Number = number;
            student.Name = name;


            int BirthYear, BirthMonth;//, BirthDay;
            if (int.TryParse(tbxBirthYear.Text, out BirthYear))
            {
                if (BirthYear < 1900 || BirthYear > 9000)
                {
                    tbxBirthYear.Focus();
                    return null;
                }
            }
            else
            {
                tbxBirthYear.Focus();
                return null;
            }

            if (int.TryParse(tbxBirthMonth.Text, out BirthMonth))
            {
                if (BirthMonth < 1 || BirthMonth > 12)
                {
                    tbxBirthMonth.Focus();
                    return null;
                }
            }
            else
            {
                tbxBirthMonth.Focus();
                return null;
            }

            if (int.TryParse(tbxBirthDay.Text, out int BirthDay))
            {
                if (BirthDay < 1 || BirthDay > 31)
                {
                    tbxBirthDay.Focus();
                    return null;
                }
            }
            else
            {
                tbxBirthDay.Focus();
                return null;
            }


            student.BirthInfo = new DateTime(BirthYear, BirthMonth, BirthDay);

            if (cmbDepartment.SelectedIndex < 0)
            {
                //cmbDepartment.Focus();
                //return;
                student.DepartmentCode = null;
            }
            else
            {
                student.DepartmentCode = (cmbDepartment.SelectedItem as Department).Code;
            }

            if (cmbAdvisor.SelectedIndex < 0)
            {
                student.AdvisorNumber = null;
            }
            else
            {
                Professor p1 = cmbAdvisor.SelectedItem as Professor;
                if (p1 != null)
                {
                    student.AdvisorNumber = p1.Number;
                }

            }

            if (cmbYear.SelectedIndex < 0)
            {
                cmbYear.Focus();
                return null;
            }
            else
            {
                if (int.TryParse(cmbYear.SelectedItem.ToString(), out int temp1))
                {
                    student.Year = temp1;
                }
                else
                {
                    return null;
                }
            }

            if (cmbClass.SelectedIndex < 0)
            {
                cmbClass.Focus();
                return null;
            }
            else
            {
                student.Class = cmbClass.SelectedItem.ToString();
            }

            if (cmbRegStatus.SelectedIndex < 0)
            {
                cmbRegStatus.Focus();
                return null;
            }
            else
            {
                student.RegStatus = cmbRegStatus.SelectedItem.ToString();
            }

            if (string.IsNullOrEmpty(tbxAddress.Text))
            {
                tbxAddress.Focus();
                return null;
            }
            else
            {
                student.Address = tbxAddress.Text;
            }

            if (string.IsNullOrEmpty(tbxContact.Text))
            {
                tbxContact.Focus();
                return null;
            }
            else
            {
                student.Contact = tbxContact.Text;
            }
            return student;
        }

        private bool makeUpdatestudent(Student student)
        {
            var name = tbxName.Text.Trim();
            if (string.IsNullOrEmpty(name) || name.Length < 2)
            {
                tbxName.Focus();
                return false;
            }
            student.Name = name;


            int BirthYear, BirthMonth;//, BirthDay;
            if (int.TryParse(tbxBirthYear.Text, out BirthYear))
            {
                if (BirthYear < 1900 || BirthYear > 9000)
                {
                    tbxBirthYear.Focus();
                    return false;
                }
            }
            else
            {
                tbxBirthYear.Focus();
                return false;
            }

            if (int.TryParse(tbxBirthMonth.Text, out BirthMonth))
            {
                if (BirthMonth < 1 || BirthMonth > 12)
                {
                    tbxBirthMonth.Focus();
                    return false;
                }
            }
            else
            {
                tbxBirthMonth.Focus();
                return false;
            }

            if (int.TryParse(tbxBirthDay.Text, out int BirthDay))
            {
                if (BirthDay < 1 || BirthDay > 31)
                {
                    tbxBirthDay.Focus();
                    return false;
                }
            }
            else
            {
                tbxBirthDay.Focus();
                return false;
            }


            student.BirthInfo = new DateTime(BirthYear, BirthMonth, BirthDay);

            if (cmbDepartment.SelectedIndex < 0)
            {
                student.DepartmentCode = null;
            }
            else
            {
                student.DepartmentCode = (cmbDepartment.SelectedItem as Department).Code;
            }

            if (cmbAdvisor.SelectedIndex < 0)
            {
                student.AdvisorNumber = null;
            }
            else
            {
                Professor p1 = cmbAdvisor.SelectedItem as Professor;
                if (p1 != null)
                {
                    student.AdvisorNumber = p1.Number;
                }

            }

            if (cmbYear.SelectedIndex < 0)
            {
                cmbYear.Focus();
                return false;
            }
            else
            {
                if (int.TryParse(cmbYear.SelectedItem.ToString(), out int temp1))
                {
                    student.Year = temp1;
                }
                else
                {
                    return false;
                }
            }

            if (cmbClass.SelectedIndex < 0)
            {
                cmbClass.Focus();
                return false;
            }
            else
            {
                student.Class = cmbClass.SelectedItem.ToString();
            }

            if (cmbRegStatus.SelectedIndex < 0)
            {
                cmbRegStatus.Focus();
                return false;
            }
            else
            {
                student.RegStatus = cmbRegStatus.SelectedItem.ToString();
            }

            if (string.IsNullOrEmpty(tbxAddress.Text))
            {
                tbxAddress.Focus();
                return false;
            }
            else
            {
                student.Address = tbxAddress.Text;
            }

            if (string.IsNullOrEmpty(tbxContact.Text))
            {
                tbxContact.Focus();
                return false;
            }
            else
            {
                student.Contact = tbxContact.Text;
            }
            return true;
        }


        private void RegisterStudent()
        {
            
            var number = tbxNumber.Text.Trim();

            if (string.IsNullOrEmpty(number) || number.Length != 8)
            {
                tbxNumber.Focus();
                return;
            }
            if (students.ContainsKey(number))
            {
                MessageBox.Show("동일한 학번이 존재합니다.");
                tbxNumber.Focus();
                return;
            }

            Student st1 = makeStudent(number); 
            if (st1 == null)
            {
                MessageBox.Show("학생정보에 올바르지 않은 값이 포함되어 있습니다.");
                return;
            }
            students[number] = st1;
            //students.Add(number, student); 키 중복시 에러
            lbxDictionary.Items.Add(st1);
        }


        private void UpdateStudent()
        {
            //수정은 학번을 고칠 수 없다.
            //학번을 제외한 모든 사항은 위의 RegisterStudent()와 동일하게 진행
            //한다.
            //모든 사항의 확인 및 수정이 끝나면
            //수정완료 메세지를 띄운 후
            //화면을 초기화 상태로 만든다.


            if (makeUpdatestudent(selectedStudent))
            {
                MessageBox.Show("학생정보를 수정했습니다.");
                students[selectedStudent.Number] = selectedStudent;
                //lbxDictionary.Items.Remove(selectedStudent);
                //lbxDictionary.Items.Add(selectedStudent);
                ClearStudentInfo();
            } else
            {
                MessageBox.Show("학생정보 수정과정에서 문제가 발생하였습니다.");
            }



        }

        private void lbxDictionary_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lbxDictionary.SelectedIndex < 0)
            {
                return;
            }
            
            Student student = (lbxDictionary.SelectedItem as Student);
            ClearStudentInfo();
            if (student != null){
                DisplaySelectedStudent(student);
            }
        }

        private void DisplaySelectedStudent(Student student)
        {
            selectedStudent = student;
            tbxNumber.ReadOnly = true;
            tbxNumber.Text = student.Number;
            tbxName.Text = student.Name;

            tbxBirthYear.Text = student.BirthInfo.Year.ToString();
            tbxBirthMonth.Text = student.BirthInfo.Month.ToString();
            tbxBirthDay.Text = student.BirthInfo.Day.ToString();

            for (int i = 0; i < cmbDepartment.Items.Count; i++)
            {
                if (student.DepartmentCode == (cmbDepartment.Items[i] as Department).Code)
                {
                    cmbDepartment.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < cmbAdvisor.Items.Count; i++)
            {
                if (student.AdvisorNumber == (cmbAdvisor.Items[i] as Professor).Number)
                {
                    cmbAdvisor.SelectedIndex = i;
                    break;
                }
            }
            //지도교수,학년,반,재적상태,주소,연락처의 정보를 가져와 설정한다.

            for (int i = 0; i < cmbYear.Items.Count; i++)
            {
                if (student.Year == int.Parse(cmbYear.Items[i].ToString()))
                {
                    cmbYear.SelectedIndex = i;
                    break;
                }
            }
            for (int i = 0; i < cmbClass.Items.Count; i++)
            {
                if (student.Class == cmbClass.Items[i].ToString())
                {
                    cmbClass.SelectedIndex = i;
                    break;
                }
            }
            for (int i = 0; i < cmbRegStatus.Items.Count; i++)
            {
                if (student.RegStatus == cmbRegStatus.Items[i].ToString())
                {
                    cmbRegStatus.SelectedIndex = i;
                    break;
                }
            }
            tbxAddress.Text = student.Address.ToString();
            tbxContact.Text = student.Contact.ToString();

            btnRegister.Text = "수정";
        }

        private void btnTestSearchStudent_Click(object sender, EventArgs e)
        {
            ClearTestScoreInfo();
            var number = tbxTestNumber.Text.Trim();
            
            

            if (string.IsNullOrEmpty(number) || number.Length != 8)
            {
                tbxTestNumber.Focus();
                MessageBox.Show("올바른 학번을 입력하세요.");
                return;
            }


            selectedStudent = SearchStudentByNumber(number);

            if (selectedStudent == null)
            {
                MessageBox.Show("검색한 학번은 존재하지 않습니다");
                tbxTestNumber.Focus();
                return;
            }

            lblTestName.Text = selectedStudent.Name;

            var grade = SearchGradeByNumber(selectedStudent.Number);

#if false
            if (grade != null)
            {
                for (int i = 0; i < grade.Scores.Count && i < tbxTestScores.Length; i++)
                {
                    tbxTestScores[i].Text = grade.Scores[i].ToString("0.0");
                }
            }
#else
            if (grade != null)
            {
                for (int i = 0; i < grade.ScoresCount() && i < tbxTestScores.Length; i++)
                {
                    tbxTestScores[i].Text = grade.GetScores(i).ToString("0.0");
                }
            }
#endif

            //if (grade != null)
            //{
            //    //int j = 0;
            //    //foreach(var textScore in tbxTestScores)
            //    //{
            //    //    textScore.Text = grade.Scores[j].ToString("0.0");
            //    //    j++;
            //    //}

            //    for (int i = 0; i < grade.Scores.Count && i < tbxTestScores.Length; i++)
            //    {
            //        tbxTestScores[i].Text = grade.Scores[i].ToString("0.0");
            //    }
            //}
        }

        private Grade SearchGradeByNumber(string number)
        {
            if (testGrades != null)
            {
                foreach (Grade grd in testGrades)
                {
                    if (grd != null && grd.StudentNumber.Equals(number))
                    {
                        return grd;
                    }
                }
            }
            
            return null;
        }

        private Student SearchStudentByNumber(string number)
        {
            if (students.ContainsKey(number)) //python에서 get()과 비슷함.
            {
                return students[number];
            } else
            {
                return null;
            }
        }
   
        private void ClearTestScoreInfo()
        {
            //tbxTestNumber.Text = string.Empty;
            lblTestName.Text = string.Empty;
            foreach (var v in tbxTestScores)
            {
                v.Text = string.Empty;
            }
            lblTestTotalCount.Text = string.Empty;
            lblTestAverage.Text = string.Empty;
        }

        private void btnFileTest_Click(object sender, EventArgs e)
        {
            
        }

        private void FormManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            dp.Write(departments);
            st.Write(students);
            pr.Write(professors);
        }

        private void btnTestRegScore_Click(object sender, EventArgs e)
        {
            if (selectedStudent == null)
            {
                tbxTestNumber.Focus();
                return;
            }
            
            for (int i = 1; i < tbxTestScores.Length; i++)
            {
                if (string.IsNullOrEmpty(tbxTestScores[i - 1].Text) && !string.IsNullOrEmpty(tbxTestScores[1].Text))
                {
                    tbxTestScores[i - 1].Focus();
                    return;
                }
            }


            var grade = SearchGradeByNumber(selectedStudent.Number);
            if (grade == null)
            {
                Console.WriteLine("grade가 null이므로 새로 만들었음.");
                grade = new Grade()
                {
                    StudentNumber = selectedStudent.Number
                };
            }

#if false
            grade.Scores.Clear();


            double temp;
            for (int i = 0; i < tbxTestScores.Length; i++)
            {
                if (string.IsNullOrEmpty(tbxTestScores[i].Text))
                {
                    break;
                }

                if (false == double.TryParse(tbxTestScores[i].Text, out temp))
                {
                    tbxTestScores[i].Focus();
                    return;
                }
                grade.Scores.Add(temp);
            }
#else
            grade.Clear();


            double temp;
            for (int i = 0; i < tbxTestScores.Length; i++)
            {
                if (string.IsNullOrEmpty(tbxTestScores[i].Text))
                {
                    break;
                }

                if (false == double.TryParse(tbxTestScores[i].Text, out temp))
                {
                    tbxTestScores[i].Focus();
                    return;
                }
                Console.WriteLine(temp);
                if (!grade.Add(temp))
                {
                    Console.WriteLine("grade에 추가하지 못헀음.");
                }
            }
#endif
            testGrades.Add(grade);

            lblTestTotalCount.Text = grade.ScoresCount().ToString();

            lblTestAverage.Text = grade.GetAverage().ToString();



        }
    }
}
