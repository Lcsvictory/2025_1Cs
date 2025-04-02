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
    public partial class FormManager: Form
    {
        Department[] departments;
        List<Professor> professors;
        //ArrayList[] professors1;


        public FormManager()
        {
            InitializeComponent();
            departments = new Department[10];
            professors = new List<Professor>();
        }

        private void btnRegisterDepartment_Click(object sender, EventArgs e)
        {

            int index = -1;
            for (int i = 0; i < departments.Length; i++) {
                if (departments[i] == null) {
                    if (index < 0)
                    {
                        index = i;
                    } 
                    //break;
                } else {
                    if (departments[i].Code == tbxDepartmentCode.Text){
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
            tbxDepartmentName.Text = "";
        }

        private void btnRemoveDepartment_Click(object sender, EventArgs e)
        {
            //SelectedIndex의 기본값 = -1
            if (lbxDepartment.SelectedIndex < 0) {
                MessageBox.Show("삭제할 항목을 선택하세요.");
                return;
            }
            //같은 객체인가? (값이 같은지를 체크하는게 아님.)
            if (lbxDepartment.SelectedItem is Department) {
                var target = (Department)lbxDepartment.SelectedItem;
                int i;
                for (i = 0; i < departments.Length; i++) {
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
                        cmbProfessorDepartment.Items.Add(prof);
                    }
                }
            }
        }
    }
}
