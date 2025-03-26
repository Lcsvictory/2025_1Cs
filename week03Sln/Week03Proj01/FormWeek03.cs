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
    //class의 구성요소 : 값(변수) + 기능(메소드)
    public partial class FormWeek03: Form
    {
        TextBox[] arrTbxData; //멤버변수 or instance 변수 or instance field
        
        //class와 동일한 이름
        //반환타입없음
        //1번만호출
        public FormWeek03()
        {
            InitializeComponent();

            arrTbxData = new TextBox[5];
            arrTbxData[0] = tbxData1;
            arrTbxData[1] = tbxData2;
            arrTbxData[2] = tbxData3;
            arrTbxData[3] = tbxData4;
            arrTbxData[4] = tbxData5;
        }

        private void btnProcess01_Click(object sender, EventArgs e)
        {
            //arrTbxData = new TextBox[5];
            //arrTbxData[0] = tbxData1;
            //arrTbxData[1] = tbxData2;
            //arrTbxData[2] = tbxData3;
            //arrTbxData[3] = tbxData4;
            //arrTbxData[4] = tbxData5;

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
            //TextBox[] arrTbxData = new TextBox[5];
            //arrTbxData[0] = tbxData1;
            //arrTbxData[1] = tbxData2;
            //arrTbxData[2] = tbxData3;
            //arrTbxData[3] = tbxData4;
            //arrTbxData[4] = tbxData5;

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

        private void btnProcess03_Click(object sender, EventArgs e)
        {
            //배열    vs    리스트
            //고정길이      가변길이
            //Length        Count
            //
            //String a = "11";
            //a = a + "21";
            //int b = a.Length;
            //MessageBox.Show(b.ToString());//4

            //TextBox[] arrTbxData = new TextBox[5];
            //arrTbxData[0] = tbxData1;
            //arrTbxData[1] = tbxData2;
            //arrTbxData[2] = tbxData3;
            //arrTbxData[3] = tbxData4;
            //arrTbxData[4] = tbxData5;

            //Generic
            List<int> arrIntData = new List<int>();

            for (int i = 0; i < arrTbxData.Length; i++)
            {
                //if (!string.IsNullOrEmpty(arrTbxData[i].Text)) {
                if (false == string.IsNullOrEmpty(arrTbxData[i].Text))
                {
                    arrIntData.Add(int.Parse(arrTbxData[i].Text));
                    //Add(), Insert(), Remove(0, RemoveAt()
                }
                else
                {
                    arrIntData[i] = 0;
                }

            }

            int result = 0;
            if (rbtAdd.Checked)
            { //add 버튼이 체크되었다면.
                for (int i = 0; i < arrIntData.Count; i++)
                {
                    result += arrIntData[i];
                }
            }
            else if (rbtSub.Checked)
            { //sub 버튼이 체크되었다면.
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++)
                {
                    result -= arrIntData[i];
                }
            }
            else if (rbtMul.Checked)
            { //nul 버튼이 체크되었다면.
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++)
                {
                    result *= arrIntData[i];
                }
            }
            else if (rbtDiv.Checked)
            { //div 버튼이 체크되었다면.
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++)
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

        private void btnProcess04_Click(object sender, EventArgs e)
        {
            //TextBox[] arrTbxData = new TextBox[5];
            //arrTbxData[0] = tbxData1;
            //arrTbxData[1] = tbxData2;
            //arrTbxData[2] = tbxData3;
            //arrTbxData[3] = tbxData4;
            //arrTbxData[4] = tbxData5;

            //Generic
            List<int> arrIntData = new List<int>();

            for (int i = 0; i < arrTbxData.Length; i++)
            {
                //if (!string.IsNullOrEmpty(arrTbxData[i].Text)) {
                if (false == string.IsNullOrEmpty(arrTbxData[i].Text))
                {
                    arrIntData.Add(int.Parse(arrTbxData[i].Text));
                    //Add(), Insert(), Remove(0, RemoveAt()
                }
                else
                {
                    //arrIntData.Add(0);
                    //int 타입의 List의 초기값은 0임.
                }

            }
            if (!chkAdd.Checked && !chkSub.Checked && !chkMul.Checked && !chkDiv.Checked)
            //하나라도 선택이 안되었다는건. 전부 false이고 -> !연산이 적용되니 전부true가 되는구나.
            //하나를 선택하면 and조건에서 한 부분만 false가 될테니 이 메세지를 표시되지 않는구나.
            {
                lblResult.Text = "";
                MessageBox.Show("연산을 선택해주세요.");
                return;
            }
            int result = 0;
            string totalResult = "";

            if (chkAdd.Checked)
            { //add 버튼이 체크되었다면.
                for (int i = 0; i < arrIntData.Count; i++)
                {
                    result += arrIntData[i];
                }

                totalResult += $"더하기:{result}";
                totalResult += Environment.NewLine;
            }
            if (chkSub.Checked)
            { //sub 버튼이 체크되었다면.
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++)
                {
                    result -= arrIntData[i];
                }
                totalResult += $"빼기:{result}";
                totalResult += Environment.NewLine;
            }
            if (chkMul.Checked)
            { //nul 버튼이 체크되었다면.
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++)
                {
                    result *= arrIntData[i];
                }
                totalResult += $"곱하기:{result}";
                totalResult += Environment.NewLine;
            }
            if (chkDiv.Checked)
            { //div 버튼이 체크되었다면.
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++)
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
                totalResult += $"나누기:{result}";
                totalResult += Environment.NewLine;
            }
            lblResult.Text = totalResult.ToString();
        }

        private void chkOption_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton[] radioButtons = new RadioButton[] {
                rbtAdd,
                rbtSub,
                rbtDiv,
                rbtMul
            };

            List<CheckBox> checkBoxes = new List<CheckBox> {
                chkAdd,
                chkSub,
                chkDiv,
                chkMul
            };
            var isEng = chkOption.Checked;
            string word;
            
            for (int i = 0; i < radioButtons.Length; i++)
            {
                switch (i)
                {
                    case 0 : 
                        word = isEng ? "Add" : "더하기";
                        break;
                    case 1:
                        word = isEng ? "Sub" : "빼기";
                        break;
                    case 2:
                        word = isEng ? "Mul" : "곱하기";
                        break;
                    case 3:
                        word = isEng ? "Div" : "나누기";
                        break;
                    default: continue; //continue는 절대 만날일이 없구나.
                        //radioButtons.Length = 4로 고정되어있기 때문에.
                }
                radioButtons[i].Text = word;
                checkBoxes[i].Text = word;
            }
        }

        private void btnProcess06_Click(object sender, EventArgs e)
        {
            if (cmbBeverage.SelectedIndex < 0) //콤보박스의 기본값은 -1
            {
                MessageBox.Show("음료를 선택하세요.");
                return;
            }

            //int cmbCnt = cmbBeverage.Items.Count;
            int price;
            //switch(cmbBeverage.Items[cmbBeverage.SelectedIndex].ToString())
            switch (cmbBeverage.SelectedItem.ToString())
            {
                case "아메리카노": 
                    price = 2500;
                    break;
                case "카페라떼":
                    price = 3500;
                    break;
                case "플랫화이트":
                    price = 3800;
                    break;
                default:
                    return;
            }

            var iceoption = chkIce.Checked ? "아이스 " : "";
            var iceprice = chkIce.Checked ? 500 : 0;
            //icePrice = "0"; //type은 int


            lblResult.Text = $"{iceoption}{cmbBeverage.SelectedItem} : {price + iceprice}";

        }

        private void btnProcess07_Click(object sender, EventArgs e)
        {
            if (cmbBeverage.SelectedIndex < 0) //콤보박스의 기본값은 -1
            {
                MessageBox.Show("음료를 선택하세요.");
                return;
            }

            int price;
            switch (cmbBeverage.SelectedItem)
            {
                case 0:
                    price = 2500;
                    break;
                case 1:
                    price = 3500;
                    break;
                case 2:
                    price = 3800;
                    break;
                default:
                    return;
            }

            var iceoption = chkIce.Checked ? "아이스 " : "";
            var iceprice = chkIce.Checked ? 500 : 0;
            //icePrice = "0"; //type은 int


            lblResult.Text = $"{iceoption}{cmbBeverage.SelectedItem} : {price + iceprice}";

        }

        private void btnProcess08_Click(object sender, EventArgs e)
        {
            if (cmbBeverage.SelectedIndex < 0) //콤보박스의 기본값은 -1
            {
                MessageBox.Show("음료를 선택하세요.");
                return;
            }

            var prices = new int[] { 2500, 3500, 3800 };
            int price;
            
            if (cmbBeverage.SelectedIndex < prices.Length)
            {
                price = prices[cmbBeverage.SelectedIndex];
            } else
            {
                return;
            }

                var iceoption = chkIce.Checked ? "아이스 " : "";
            var iceprice = chkIce.Checked ? 500 : 0;
            //icePrice = "0"; //type은 int


            lblResult.Text = $"{iceoption}{cmbBeverage.SelectedItem} : {price + iceprice}";

        }
    }
}
