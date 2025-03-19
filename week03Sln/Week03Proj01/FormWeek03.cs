using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week03Proj01
{
    public partial class FormWeek03: Form
    {
        public FormWeek03()
        {
            InitializeComponent();
        }

        private void btnProcess01_Click(object sender, EventArgs e)
        {
            TextBox[] arrTbxData = new TextBox[5];
            arrTbxData[0] = tbxData1;
            arrTbxData[1] = tbxData2;
            arrTbxData[2] = tbxData3;
            arrTbxData[3] = tbxData4;
            arrTbxData[4] = tbxData5;

            //배열은 고정길이. 생성될때 길이를 정함.
            //배열의 길이는 상수값 사용. 다른 배열의 길이 또한 상수값이니
            //다른 배열의 길이로 배열을 생성하는것이 가능.
            //사용자 입력같은 가변값을 배열의 길이로 지정하는것이 안된다는 것이다.

            //배열 요소의 초기값
            //struct : 기본값. ex)int => 0, bool => false ...
            //class : null
            int[] arrIntData = new int[arrTbxData.Length];

            for (int i = 0; i < arrTbxData.Length; i++) {
                if (arrTbxData[i].Text != null && arrTbxData[i].Text != "") {
                    arrIntData[i] = int.Parse(arrTbxData[i].Text);
                } else {

                }
                
            }

            int result = 0;
            if (rbtAdd.Checked) { //add 버튼이 체크되었다면.
                for (int i = 0; i < arrIntData.Length; i++) {
                    result += arrIntData[i];
                }
            } else if (rbtSub.Checked) { //sub 버튼이 체크되었다면.
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++) {
                    result -= arrIntData[i];
                }
            } else if (rbtMul.Checked) { //nul 버튼이 체크되었다면.
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++) {
                    result *= arrIntData[i];
                }
            } else if (rbtDiv.Checked) { //div 버튼이 체크되었다면.
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++) {
                    if (arrIntData[i] != 0) {
                        result /= arrIntData[i];
                    } else {
                        arrTbxData[i].Focus();
                        MessageBox.Show("0으로 나눌 수 없습니다.");
                        return;
                    }
                }
            } else {
                MessageBox.Show("연산을 선택해주세요.");
                return;
            }
                lblResult.Text = result.ToString();
        }

        private void btnProcess02_Click(object sender, EventArgs e)
        {
            TextBox[] arrTbxData = new TextBox[5];
            arrTbxData[0] = tbxData1;
            arrTbxData[1] = tbxData2;
            arrTbxData[2] = tbxData3;
            arrTbxData[3] = tbxData4;
            arrTbxData[4] = tbxData5;

            //배열은 고정길이. 생성될때 길이를 정함.
            //배열의 길이는 상수값 사용. 다른 배열의 길이 또한 상수값이니
            //다른 배열의 길이로 배열을 생성하는것이 가능.
            //사용자 입력같은 가변값을 배열의 길이로 지정하는것이 안된다는 것이다.

            //배열 요소의 초기값
            //struct : 기본값. ex)int => 0, bool => false ...
            //class : null
            int[] arrIntData = new int[arrTbxData.Length];

            for (int i = 0; i < arrTbxData.Length; i++)
            {
                //if (!string.IsNullOrEmpty(arrTbxData[i].Text)) {
                if (false == string.IsNullOrEmpty(arrTbxData[i].Text)) {
                    arrIntData[i] = int.Parse(arrTbxData[i].Text);
                }
                else{

                }

            }

            int result = 0;
            if (rbtAdd.Checked)
            { //add 버튼이 체크되었다면.
                for (int i = 0; i < arrIntData.Length; i++)
                {
                    result += arrIntData[i];
                }
            }
            else if (rbtSub.Checked)
            { //sub 버튼이 체크되었다면.
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++)
                {
                    result -= arrIntData[i];
                }
            }
            else if (rbtMul.Checked)
            { //nul 버튼이 체크되었다면.
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++)
                {
                    result *= arrIntData[i];
                }
            }
            else if (rbtDiv.Checked)
            { //div 버튼이 체크되었다면.
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++)
                {
                    if (arrIntData[i] != 0)
                    {
                        result /= arrIntData[i];
                    }
                    else
                    {
                        arrTbxData[i].Focus();
                        MessageBox.Show("0으로 나눌 수 없습니다.");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("연산을 선택해주세요.");
                return;
            }
            lblResult.Text = result.ToString();
        }
    }
}
