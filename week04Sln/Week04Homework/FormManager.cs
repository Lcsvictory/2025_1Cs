using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week04Homework
{
    public partial class FormManager : Form
    {
        Department[] departments;
        List<Professor> professors;
        Dictionary<string, Student> students;
        List<Grade> testGrades;
        TextBox[] tbxTestScores;


        public FormManager()
        {
            InitializeComponent();
            departments = new Department[100];
            professors = new List<Professor>();
            students = new Dictionary<string, Student>();
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
            //departments.Append(dept);

            //Department dept = new Department(tbxDepartmentCode.Text, tbxDepartmentName.Text);
            dept.Code = tbxDepartmentCode.Text;
            dept.Name = tbxDepartmentName.Text;

            lbxDepartment.Items.Add(dept);
            //lbxDepartment.Items.Add(dept.Code);
            //lbxDepartment.Items.Add(dept.Name);
            //lbxDepartment.Items.Add($"[{dept.Code}] {dept.Name}");

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
                    foreach (var dept in departments)
                    {
                        if (dept != null)
                        {
                            cmbProfessorDepartment.Items.Add(dept);
                        }
                    }
                    cmbProfessorDepartment.SelectedIndex = -1;
                    lbxProfessor.Items.Clear();
                    break;
                case 2:
                    cmbDepartment.Items.Clear();
                    foreach (var dept in departments)
                    {
                        if (dept != null)
                        {
                            cmbDepartment.Items.Add(dept);
                        }
                    }
                    cmbDepartment.SelectedIndex = -1;
                    cmbAdvisor.SelectedIndex = -1;
                    break;
                default:
                    break;
            }
        }

        private void cmbProfessorDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxProfessor.Items.Clear();

            //as == 타입변환.
            //형변환이 안되면 null return;
            //is == 타입검사.
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
                }else
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
                cmbProfessorDepartment.Focus();
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
            var target = lbxProfessor.SelectedItem as Professor;
            if (target != null)
            {
                professors.Remove(target);
                lbxProfessor.Items.Remove(target);
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
            tbxAddress.Text = "";
            tbxNumber.ReadOnly = false;
        }


        Student selectedStudent = null;
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

        private void RegisterStudent()
        {
            var number = tbxNumber.Text.Trim();
            var name = tbxName.Text.Trim();
            if (string.IsNullOrEmpty(name)) {
                MessageBox.Show("학번을 써주세요");
                tbxNumber.Focus();
                return;
                //학번 이름 구분해서 출력
            }
            if (string.IsNullOrEmpty(number))
            {
                MessageBox.Show("이름을 써주세요");
                tbxName.Focus();
                return;
            }
            if (true == students.ContainsKey(number))
            {
                MessageBox.Show("동일한 학번이 존재합니다.");
                tbxNumber.Focus();
                return;
            }
            Student student = new Student();
            student.Number = number;
            student.Name = name;


            int BirthYear, BirthMonth;//, BirthDay;
            if (int.TryParse(tbxBirthYear.Text, out BirthYear))
            {
                if (BirthYear <= 1960)
                {
                    MessageBox.Show("올바른 년도를 입력해주세요.");
                    tbxBirthYear.Focus();
                    return;
                }
            } else
            {
                MessageBox.Show("년도를 입력하세요.");
                tbxBirthYear.Focus();
                return;
            }

            if (int.TryParse(tbxBirthMonth.Text, out BirthMonth))
            {
                if (BirthMonth < 1 || BirthMonth > 12)
                {
                    MessageBox.Show("올바른 월을 입력해주세요.");
                    tbxBirthMonth.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("월을 입력하세요.");
                tbxBirthMonth.Focus();
                return;
            }

            if (int.TryParse(tbxBirthDay.Text, out int BirthDay))
            {
                if (BirthDay < 1 || BirthDay > 31)
                {
                    MessageBox.Show("올바른 일을 입력해주세요.");
                    tbxBirthDay.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("일을 입력하세요.");
                tbxBirthDay.Focus();
                return;
            }


            student.BirthInfo = new DateTime(BirthYear, BirthMonth, BirthDay);

            if (cmbDepartment.SelectedIndex < 0)
            {
                //cmbDepartment.Focus();
                //return;
                student.DepartmentCode = null;
            }else
            {
                student.DepartmentCode = (cmbDepartment.SelectedItem as Department).Code;
            }
            students[number] = student;
            //students.Add(number, student); 키 중복시 에러
            lbxDictionary.Items.Add(student);
        }

        private void UpdateStudent()
        {
            throw new NotImplementedException();
        }

        private void lbxDictionary_SelectedIndexChanged(object sender, EventArgs e)
        {

            ClearStudentInfo();
            //btnNew_Click(sender, EventArgs.Empty);

            if (lbxDictionary.SelectedIndex < 0)
            {
                return;
            }
            selectedStudent = (lbxDictionary.SelectedItem as Student);

            if (selectedStudent != null){
                DisplaySelectedStudent(selectedStudent);
            }
        }

        private void DisplaySelectedStudent(Student student)
        {
            tbxNumber.ReadOnly = true;
            tbxNumber.Text = student.Number;
            tbxName.Text = student.Name;

            tbxBirthYear.Text = student.BirthInfo.Year.ToString();
            tbxBirthMonth.Text = student.BirthInfo.Month.ToString();
            tbxBirthDay.Text = student.BirthInfo.Day.ToString();
        }

        private void btnTestSearchStudent_Click(object sender, EventArgs e)
        {
            selectedStudent = SearchStudentByNumber(tbxTestNumber.Text);

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
    }
}
