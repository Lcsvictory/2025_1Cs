using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Week04Homework
{
    public partial class FormManager : Form
    {
        //저장될 파일의 디렉토리 경로를 반환한다.
        public string PATH
        {
            get
            {
                string path = "c:\\class_a";
                if (false == Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                return path;
            }
        }

        public string DepartmentsFullFileName
        {
            get { return Path.Combine(PATH, "departments.txt"); }
        }
        public string ProfessorsFullFileName
        {
            get { return Path.Combine(PATH, "professors.txt"); }
        }
        public string studentsFullFileName
        {
            get { return Path.Combine(PATH, "students.txt"); }
        }

        List<Department> departments;
        List<Professor> professors;
        Dictionary<string, Student> students;

        List<Grade> testGrades;
        TextBox[] tbxTestScores;

        public FormManager()
        {
            InitializeComponent();

            departments = new List<Department>();
            professors = new List<Professor>();
            students = new Dictionary<string, Student>();

            for (int i = 0; i < (int)YEAR.END; i++) {
                cmbYear.Items.Add(Student.YearNames[(YEAR)i]);
            }

            cmbClass.Items
                .AddRange(new object[] { CLASS.A, CLASS.B, CLASS.C });


            for (int i = 0; i < (int)REG_STATUS.END; i++)
            {
                cmbRegStatus.Items.Add(Student.RegNames[(REG_STATUS)i]);
            }
            

            testGrades = new List<Grade>();
            tbxTestScores = new TextBox[] {
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

            //departments[0] = new Department("A001", "컴공");
            //departments[1] = new Department("A002", "항운");
            //departments[2] = new Department("A003", "전기");
            //lbxDepartment.Items.Add(departments[0]);
            //lbxDepartment.Items.Add(departments[1]);
            //lbxDepartment.Items.Add(departments[2]);

            //학과정보를 파일에서 읽어온다
            OpenInfo(ref departments, DepartmentsFullFileName);
            //교수정보를 파일에서 읽어온다.
            OpenInfo(ref professors, ProfessorsFullFileName);
            //학생정보를 파일에서 읽어온다.
            OpenInfo(ref students, studentsFullFileName);
        }

        private void OpenInfo(ref List<Professor> professors, string fileName)
        {
            if (File.Exists(fileName))
            {
                try
                {
                    using (FileStream fs = new FileStream(fileName, FileMode.Open))
                    {
                        using (StreamReader sr = new StreamReader(fs))
                        {
                            while (!sr.EndOfStream)
                            {
                                string data = sr.ReadLine();
                                if (data != null)
                                {
                                    var prof = Professor.Restore(data, departments);
                                    if (prof != null)
                                    {
                                        professors.Add(prof);
                                    }
                                }


                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("교수정보 읽어오는중 에러발생 : " + ex);
                }

            }
        }

        private void OpenInfo(ref List<Department> departments, string fileName)
        {
            if (File.Exists(fileName))
            {
                try
                {
                    using (FileStream fs = new FileStream(fileName, FileMode.Open))
                    {
                        using (StreamReader sr = new StreamReader(fs))
                        {
                            while (sr.EndOfStream == false)
                            {
                                string data = sr.ReadLine();
                                if (data != null)
                                {
                                    var dept = Department.Restore(data);
                                    if (dept != null)
                                    {
                                        departments.Add(dept);
                                        lbxDepartment.Items.Add(dept);
                                    }
                                }


                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("학과정보 읽어오는중 에러발생 : " + ex);
                }

            }
        }

        private void OpenInfo(ref Dictionary<string, Student> students, string fileName)
        {
            if (File.Exists(studentsFullFileName))
            {
                try
                {
                    using (FileStream fs = new FileStream(studentsFullFileName, FileMode.Open))
                    {
                        using (StreamReader sr = new StreamReader(fs))
                        {
                            while (!sr.EndOfStream)
                            {
                                string data = sr.ReadLine();
                                if (data != null)
                                {
                                    var stu = Student.Restore(professors, departments, data);
                                    if (stu != null)
                                    {
                                        students.Add(stu.Number, stu);
                                        lbxDictionary.Items.Add(stu);
                                    }
                                }


                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("학생정보 읽어오는중 에러발생 : " + ex);
                }

            }
        }


        private void btnRegisterDepartment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxDepartmentCode.Text)) {
                MessageBox.Show("학과코드 입력");
                tbxDepartmentCode.Focus();
                return;
            }

            if (string.IsNullOrEmpty(tbxDepartmentName.Text)) {
                MessageBox.Show("학과이름 입력");
                tbxDepartmentName.Focus();
                return;
            }

            if (departments.Any(m => m.Code == tbxDepartmentCode.Text))
            {
                MessageBox.Show("중복 학과코드");
                tbxDepartmentCode.Focus();
                return;
            }


            Department dept = new Department(tbxDepartmentCode.Text, tbxDepartmentName.Text);
            

            departments.Add(dept);

            lbxDepartment.Items.Add(dept);

            SaveInfo(dept, DepartmentsFullFileName);

            //using (FileStream fs = new FileStream(DepartmentsFullFileName, FileMode.Append))
            //{
            //    using (StreamWriter sw = new StreamWriter(fs))
            //    {
            //        sw.WriteLine(dept.Record);
            //    }
            //}

        }
        //수업시간에 추가
        

        private void btnRemoveDepartment_Click(object sender, EventArgs e)
        {
            if (lbxDepartment.SelectedIndex < 0) {
                MessageBox.Show("삭제할 학과를 선택");
                return;
            }

            var target = lbxDepartment.SelectedItem as Department;
            if (target == null) { return; }

            //학과를 참조하는 교수정보가 있다면 삭제불가능함.
            if (professors.Any(m => m.Dept.Equals(target)))
            {
                MessageBox.Show("해당 학과는 참조되고 있으므로 삭제할 수 없습니다.");
                return;
            }
            //학과를 참조하는 학생정보가 있다면 삭제불가능
            if (students.Any(m => m.Value.Dept.Equals(target)))
            {
                MessageBox.Show("해당 학과는 참조되고 있으므로 삭제할 수 없습니다.");
                return;
            }

            for (int i = 0; i < departments.Count; i++) {
                if (departments[i] != null && departments[i] == target) {
                    departments.RemoveAt(i);
                    break;
                }
            }

            lbxDepartment.Items.RemoveAt(lbxDepartment.SelectedIndex);
            lbxDepartment.SelectedIndex = -1;
            try
            {
                DeleteInfo(departments, DepartmentsFullFileName);
                //using (FileStream fs = new FileStream(DepartmentsFullFileName, FileMode.Create))
                //{
                //    using (StreamWriter sw = new StreamWriter(fs))
                //    {
                //        foreach (var dept in departments)
                //        {
                //            if (dept != null)
                //            {
                //                sw.WriteLine(dept.Record);
                //            }
                //        }
                //    }
                //}
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("null참조 발생 : " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("학과정보 삭제중 에러발생 : " + ex.Message);
            }
            finally
            {
                Console.WriteLine("학과 삭제 종료");
            }
            
        }

        //수업시간에 추가
        private void DeleteInfo(List<Department> depts, string fileName)
        {
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Create))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        foreach (var dept in departments)
                        {
                            if (dept != null)
                            {
                                sw.WriteLine(dept.Record);
                            }
                        }
                    }
                }
            } catch (Exception ex)
            {
                throw ex;
            }
            
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabMain.SelectedIndex) {
                case 0:
                    break;
                case 1:
                    cmbProfessorDepartment.Items.Clear();
                    foreach (var department in departments) {
                        if (department != null) {
                            cmbProfessorDepartment.Items.Add(department);
                        }
                    }

                    cmbProfessorDepartment.SelectedIndex = -1;
                    lbxProfessor.Items.Clear();
                    break;
                case 2:
                    cmbDepartment.Items.Clear();
                    foreach (var department in departments) {
                        if (department != null) {
                            cmbDepartment.Items.Add(department);
                        }
                    }

                    ClearStudentInfo();
                    break;
                case 3:
                    //(숙제) 성적처리(TEST)의 모든 Control을 지우는 내용을 만들 것
                    ClearTestScoreInfo();
                    break;
                default:
                    break;
            }
        }

        private void ClearTestScoreInfo()
        {
            lblTestName.Text = string.Empty;

            foreach (var textbox in tbxTestScores) {
                textbox.Text = string.Empty;
            }
        }

        private void cmbProfessorDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProfessorDepartment.SelectedIndex < 0) {
                return;
            }

            lbxProfessor.Items.Clear();

            var department = cmbProfessorDepartment.SelectedItem as Department;

            if (department != null) {
                foreach (var professor in professors) {
                    if (professor != null && professor.Dept.Code == department.Code) {
                        foreach (var i in professors)
                        {
                            Console.WriteLine(i);
                        }
                        Console.WriteLine(professor.Dept.Code);
                        lbxProfessor.Items.Add(professor);
                    }
                }
            }
        }

        private void btnRegisterProfessor_Click(object sender, EventArgs e)
        {
            if (cmbProfessorDepartment.SelectedIndex < 0) {
                MessageBox.Show("학과를 선택");
                cmbProfessorDepartment.Focus();
                return;
            }

            if (false == cmbProfessorDepartment.SelectedItem is Department dept) {
                MessageBox.Show("학과정보에 이상 발생");
                cmbProfessorDepartment.Focus();
                return;
            }

            if (string.IsNullOrEmpty(tbxProfessorNumber.Text)) {
                MessageBox.Show("교수번호 입력");
                tbxProfessorNumber.Focus();
                return;
            }

            if (string.IsNullOrEmpty(tbxProfessorName.Text)) {
                MessageBox.Show("교수이름 입력");
                tbxProfessorName.Focus();
                return;
            }

            for (int i = 0; i < professors.Count; i++) {
                if (professors[i].Number == tbxProfessorNumber.Text) {
                    MessageBox.Show("중복 교수코드");
                    tbxProfessorNumber.Focus();
                    return;
                }
            }

            Professor professor = new Professor(tbxProfessorNumber.Text, tbxProfessorName.Text, dept);
            

            professors.Add(professor);
            lbxProfessor.Items.Add(professor);
            SaveInfo(professor, ProfessorsFullFileName);
            //try
            //{
            //    using (StreamWriter sw = new StreamWriter(ProfessorsFullFileName, append:true))
            //    {
            //        sw.WriteLine(professor.Record);
            //    }
            //} catch (Exception ex) { Console.WriteLine("교수 정보 등록중 에러발생 : " + ex); }
            
        }

        

        private void btnRemoveProfessor_Click(object sender, EventArgs e)
        {
            if (lbxProfessor.SelectedIndex < 0) {
                MessageBox.Show("삭제할 교수를 선택");
                return;
            }

            var target = lbxProfessor.SelectedItem as Professor;
            if (target == null) { return; }

            //교수를 참조하는 학생정보가 있다면 삭제불가능
            if (students.Any(m => m.Value.Advisor.Equals(target)))
            {
                MessageBox.Show("해당 교수는 참조되고 있으므로 삭제할 수 없습니다.");
                return;
            }

            for (int i = 0; i < professors.Count; i++)
            {
                if (professors[i] != null && professors[i] == target)
                {
                    professors.RemoveAt(i);
                    break;
                }
            }

            lbxProfessor.Items.Remove(target);
            lbxProfessor.SelectedIndex = -1;

            DeleteInfo(professors, ProfessorsFullFileName);
            //try
            //{
            //    using (StreamWriter sw = new StreamWriter(ProfessorsFullFileName, append: false))
            //    {
            //        foreach (var i in professors)
            //        {
            //            sw.WriteLine(i.Record);
            //        }

            //    }
            //} catch (Exception ex) { Console.WriteLine("교수정보 삭제중 에러발생 : " + ex); }


        }

        private void DeleteInfo(List<Professor> professors, string fileName)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(fileName, append: false))
                {
                    foreach (var i in professors)
                    {
                        if (i != null)
                        {
                            sw.WriteLine(i.Record);
                        }
                    }

                }
            }
            catch (Exception ex) { Console.WriteLine("교수정보 삭제중 에러발생 : " + ex); }
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAdvisor.Items.Clear();

            if (cmbDepartment.SelectedIndex < 0) {
                return;
            }

            if (false == cmbDepartment.SelectedItem is Department dept) {
                return;
            }

            foreach (var professor in professors) {
                if (professor != null && professor.Dept.Code == dept.Code) {
                    cmbAdvisor.Items.Add(professor);
                }
            }

            cmbAdvisor.SelectedIndex = -1;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearStudentInfo();
            lbxDictionary.SelectedIndex = -1;
        }

        private void ClearStudentInfo()
        {
            tbxNumber.Text = "20";
            tbxName.Text = string.Empty;
            tbxBirthYear.Text = "20";
            tbxBirthMonth.Text = "";
            tbxBirthDay.Text = "";
            cmbDepartment.SelectedIndex = -1;
            cmbAdvisor.SelectedIndex = -1;
            cmbYear.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;
            cmbRegStatus.SelectedIndex = -1;
            tbxAddress.Text = string.Empty;
            tbxContact.Text = string.Empty;

            tbxNumber.ReadOnly = false;
            selectedStudent = null;
            btnRegister.Text = "등록";
        }

        Student selectedStudent = null;

        public bool IsLeapYear(int year)
        {
            return (year % 4 == 0) && ((year % 100 != 0) || (year % 400 == 0));
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (selectedStudent == null) {
                RegisterStudent();
            } else {
                UpdateStudent();          //call
            }
        }

        private void RegisterStudent()
        {
            var number = tbxNumber.Text.Trim();

            if (string.IsNullOrEmpty(number) || number.Length != 8) {
                tbxNumber.Focus();
                return;
            }

            if (string.IsNullOrEmpty(tbxName.Text) || tbxName.Text.Trim().Length < 2) {
                tbxName.Focus();
                return;
            }

            //for, 성능 떨어짐
            //for (int i = 0; i < students.Count; i++) {
            //    var pair = students.ElementAt(i);
            //    if (pair.Key == number) {
            //        tbxNumber.Focus();
            //        return;
            //    }
            //}

            ////foreach
            //foreach (var pair in students) {
            //    if (pair.Key == number) {
            //        tbxNumber.Focus();
            //        return;
            //    }
            //}

            //실제 많이 사용하는 방법1
            if (true == students.ContainsKey(number)) {
                tbxNumber.Focus();
                return;
            }

            Student student = new Student(number, tbxName.Text.Trim());

            int birthYear, birthMonth;// birthDay;
            if (true == int.TryParse(tbxBirthYear.Text, out birthYear)) {
                if (birthYear < 1900 || 9000 < birthYear) {
                    tbxBirthYear.Focus();
                    return;
                }
            } else {
                tbxBirthYear.Focus();
                return;
            }

            if (true == int.TryParse(tbxBirthMonth.Text, out birthMonth)) {
                if (birthMonth < 1 || 12 < birthMonth) {
                    tbxBirthMonth.Focus();
                    return;
                }
            } else {
                tbxBirthMonth.Focus();
                return;
            }

            if (true == int.TryParse(tbxBirthDay.Text, out int birthDay)) {
                if (birthDay < 0 || 31 < birthDay) {
                    tbxBirthDay.Focus();
                    return;
                }
                else if (IsLeapYear(birthYear) && birthMonth == 2 && birthDay > 29)
                {
                    MessageBox.Show("윤년이면서 2월은 최대 29일까지입니다.");
                    tbxBirthDay.Focus();
                    return;
                } else if(!IsLeapYear(birthYear) && birthMonth == 2 && birthDay > 28)
                {
                    MessageBox.Show("2월은 최대 28일까지입니다.");
                    tbxBirthDay.Focus();
                    return;
                }
            } else {
                tbxBirthDay.Focus();
                return;
            }

            student.setBirthInfo(birthYear, birthMonth, birthDay);

            if (cmbDepartment.SelectedIndex < 0) {
                //cmbDepartment.Focus();
                //return;
                student.Dept = null;
            } else {
                student.Dept
                 = (cmbDepartment.SelectedItem as Department);
            }

            if (cmbAdvisor.SelectedIndex < 0) {
                student.Advisor = null;
            } else {
                student.Advisor = (cmbAdvisor.SelectedItem as Professor);
            }

            //if (false == int.TryParse(cmbYear.SelectedItem.ToString(), out student.Year))
            //{
            //    cmbYear.Focus();
            //    return;
            //}
            student.Year = (YEAR) cmbYear.SelectedIndex;

            if (cmbClass.SelectedIndex < 0) {
                cmbClass.Focus();
                return;
            }
            student.Class = (CLASS)cmbClass.SelectedIndex;

            if (cmbRegStatus.SelectedIndex < 0) {
                cmbRegStatus.Focus();
                return;
            }
            student.RegStatus = (REG_STATUS)cmbRegStatus.SelectedIndex;

            student.Address = tbxAddress.Text.Trim();
            student.Contact = tbxContact.Text.Trim();

            students[number] = student;
            lbxDictionary.Items.Add(student);

            SaveInfo(student, studentsFullFileName);
            //try
            //{
            //    using (StreamWriter sw = new StreamWriter(studentsFullFileName, append: true))
            //    {
            //        sw.WriteLine(student.Record);
            //    }
            //} catch (Exception ex) { Console.WriteLine("학생정보 등록중 에러발생 : " + ex); }
        }

        

        private void UpdateStudent() //define
        {
            
            if (string.IsNullOrEmpty(tbxName.Text) || tbxName.Text.Trim().Length < 2) {
                tbxName.Focus();
                return;
            }

            if (true == int.TryParse(tbxBirthYear.Text, out int birthYear)) {
                if (birthYear < 1900 || 9000 < birthYear) {
                    tbxBirthYear.Focus();
                    return;
                }
            } else {
                tbxBirthYear.Focus();
                return;
            }


            if (true == int.TryParse(tbxBirthMonth.Text, out int birthMonth)) {
                if (birthMonth < 1 || 12 < birthMonth) {
                    tbxBirthMonth.Focus();
                    return;
                }
            } else {
                tbxBirthMonth.Focus();
                return;
            }

            if (true == int.TryParse(tbxBirthDay.Text, out int birthDay)) {
                //2월, 달 처리등은 추후 해볼것
                if (birthDay < 0 || 31 < birthDay) {
                    tbxBirthDay.Focus();
                    return;
                }
                else if (IsLeapYear(birthYear) && birthMonth == 2 && birthDay > 29)
                {
                    MessageBox.Show("윤년이면서 2월은 최대 29일까지입니다.");
                    tbxBirthDay.Focus();
                    return;
                }
                else if (!IsLeapYear(birthYear) && birthMonth == 2 && birthDay > 28)
                {
                    MessageBox.Show("2월은 최대 28일까지입니다.");
                    tbxBirthDay.Focus();
                    return;
                }
            } else {
                tbxBirthDay.Focus();
                return;
            }

            if (cmbDepartment.SelectedIndex < 0) {
                //cmbDepartment.Focus();
                return;
            } else {

            }

            if (cmbYear.SelectedIndex < 0) {
                cmbYear.Focus();
                return;
            }

            int year = cmbYear.SelectedIndex;


            if (cmbClass.SelectedIndex < 0) {
                cmbClass.Focus();
                return;
            }

            if (cmbRegStatus.SelectedIndex < 0) {
                cmbRegStatus.Focus();
                return;
            }

            //모든 사항의 확인 및 수정이 끝나면
            //수정완료 메세지를 띄운 후
            //화면을 초기화 상태로 만든다.

            selectedStudent.Name = tbxName.Text.Trim();
            selectedStudent.setBirthInfo(birthYear, birthMonth, birthDay);

            if (cmbDepartment.SelectedIndex < 0) {
                selectedStudent.Dept = null;
            } else {
                selectedStudent.Dept = (cmbDepartment.SelectedItem as Department);
            }

            if (cmbAdvisor.SelectedIndex < 0) {
                selectedStudent.Advisor = null;
            } else {
                selectedStudent.Advisor = (cmbAdvisor.SelectedItem as Professor);
            }

            selectedStudent.Year = (YEAR) year;
            selectedStudent.Class = (CLASS) cmbClass.SelectedIndex;
            selectedStudent.RegStatus = (REG_STATUS)cmbRegStatus.SelectedIndex;
            selectedStudent.Address = tbxAddress.Text.Trim();
            selectedStudent.Contact = tbxContact.Text.Trim();
            
            lbxDictionary.SelectedIndex = -1;
            try
            {
                var lines = File.ReadAllLines(studentsFullFileName).ToList();
                for (int i =0; i < lines.Count;++i)
                {
                    if (lines[i].StartsWith(selectedStudent.Number))
                    {
                        lines[i] = selectedStudent.Record;
                        break;
                    }
                }
                File.WriteAllLines(studentsFullFileName, lines);
            }
            catch (Exception ex) { Console.WriteLine("학생정보 업데이트중 에러발생 : " + ex); }

            MessageBox.Show("수정완료");

            ClearStudentInfo();
        }

        private void lbxDictionary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxDictionary.SelectedIndex < 0) {
                return;
            }

            var student = (lbxDictionary.SelectedItem as Student);

            ClearStudentInfo();

            if (student != null) {
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

            for (int i = 0; i < cmbDepartment.Items.Count; i++) {
                if ((cmbDepartment.Items[i] as Department).Code
                    == student.Dept.Code) {
                    cmbDepartment.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < cmbAdvisor.Items.Count; i++) {
                if ((cmbAdvisor.Items[i] as Professor)
                    == student.Advisor) {
                    cmbAdvisor.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < cmbYear.Items.Count; i++) {
                if ((YEAR) i == student.Year) {
                //if (i == (int)student.Year) {
                    cmbYear.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < cmbClass.Items.Count; i++) {
                if (i == (int)student.Class) {
                    cmbClass.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < cmbRegStatus.Items.Count; i++) {
                if (i == (int)student.RegStatus) {
                    cmbRegStatus.SelectedIndex = i;
                    break;
                }
            }

            tbxAddress.Text = selectedStudent.Address;
            tbxContact.Text = selectedStudent.Contact;

            btnRegister.Text = "수정";
        }

        private void btnTestSearchStudent_Click(object sender, EventArgs e)
        {
            ClearTestScoreInfo();

            var number = tbxTestNumber.Text.Trim();
            if (string.IsNullOrEmpty(number) || number.Length != 8) {
                tbxNumber.Focus();
                return;
            }

            selectedStudent = SearchStudentByNumber(tbxTestNumber.Text);

            if (selectedStudent == null) {
                MessageBox.Show($"{number}학번의 학생 정보가 없음");
                tbxTestNumber.Focus();
                return;
            }

            lblTestName.Text = selectedStudent.Name;

            Grade grade
                = SearchGradeByNumber(selectedStudent.Number);

            if (grade != null) {
                for (int i = 0; i < grade.Count()
                    && i < tbxTestScores.Length; i++) {
                    tbxTestScores[i].Text
                        = grade.Get(i).ToString("0.0");
                }
            }

        }

        Grade SearchGradeByNumber(string number)
        {
            foreach (Grade grade in testGrades) {
                if (grade.StudentNumber == number) {
                    return grade;
                }
            }

            return null;
        }

        private Student SearchStudentByNumber(string number)
        {
            if (students.ContainsKey(number)) {
                return students[number];
            } else {
                return null;
            }
        }

        private void btnTestRegScore_Click(object sender, EventArgs e)
        {
            //추가코드
            lblTestTotalCount.Text = "";
            lblTestAverage.Text = "";


            if (selectedStudent == null) {
                tbxTestNumber.Focus();
                return;
            }

            for (int i = 1; i < tbxTestScores.Length; i++) {
                if (true == string.IsNullOrEmpty(tbxTestScores[i - 1].Text)
                  && false == string.IsNullOrEmpty(tbxTestScores[i].Text)) {
                    tbxTestScores[i - 1].Focus();
                    return;
                }
            }

            var grade
                = SearchGradeByNumber(selectedStudent.Number);

            if (grade == null) {
                grade = new Grade(selectedStudent.Number);
            }

            grade.Clear();

            double temp;
            for (int i = 0; i < tbxTestScores.Length; i++) {
                if (string.IsNullOrEmpty(tbxTestScores[i].Text)) {
                    break;
                }

                if (false == double.TryParse(
                    tbxTestScores[i].Text, out temp)) {
                    tbxTestScores[i].Focus();
                    return;
                }
                grade.Add(temp);
            }

            testGrades.Add(grade);

            //총 과목수 출력
            lblTestTotalCount.Text
                = grade.Count().ToString();
            //평균 출력
            //double sum = 0;
            //foreach (var score in grade.Scores) {
            //    sum += score;
            //}
            //double average = sum / grade.Scores.Count;
            double average = grade.Average();
            lblTestAverage.Text = average.ToString("F1");

        }

        private void SaveInfo(IFile obj, string fileName)
        {
            
            try
            {
                using (StreamWriter sw = new StreamWriter(fileName, append: true))
                {
                    sw.WriteLine(obj.Record);
                }
            }
            catch (Exception ex) { Console.WriteLine("교수/학생/학과 정보 등록중 에러발생 : " + ex); }
        }

        //private void SaveInfo(Student student, string fileName)
        //{
        //    try
        //    {
        //        using (StreamWriter sw = new StreamWriter(fileName, append: true))
        //        {
        //            sw.WriteLine(student.Record);
        //        }
        //    }
        //    catch (Exception ex) { Console.WriteLine("학생정보 등록중 에러발생 : " + ex); }
        //}

        //private void SaveInfo(Department dept, string fileName)
        //{
        //    try
        //    {
        //        using (FileStream fs = new FileStream(fileName, FileMode.Append))
        //        {
        //            using (StreamWriter sw = new StreamWriter(fs))
        //            {
        //                sw.WriteLine(dept.Record);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("학과정보 저장시 에러발생 : " + ex);
        //    }

        //}
    }
}

