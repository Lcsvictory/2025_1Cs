using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week02Proj01
{
    public partial class FormMain: Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnOutput01_Click(object sender, EventArgs e)
        {
            bool isToggle = chkToggle.Checked;
            
            if (isToggle)
            {
                string data1 = tbxInput1.Text;
                string data2 = tbxInput2.Text;
                string result = data1 + data2; //문자열 연결 (산술연산자 아님)
                lblResult.Text = result;
            } else {
                int data1 = int.Parse(tbxInput1.Text);
                int data2 = int.Parse(tbxInput2.Text);
                int result = data1 + data2; //산술연산자
                lblResult.Text = result.ToString();
            }
        }

        private void btnOutput02_Click(object sender, EventArgs e)
        {
            if (chkToggle.Checked == false) { 
                int data1 = int.Parse(tbxInput1.Text);
                int data2 = int.Parse(tbxInput2.Text);
                int result = data1 + data2; //더하기
                lblResult.Text = "더하기: " + result.ToString();
            } else {
                int data1 = int.Parse(tbxInput1.Text);
                int data2 = int.Parse(tbxInput2.Text);
                int result = data1 - data2; //빼기
                lblResult.Text = "빼기: " + result; //문자열 + 숫자 = 문자열
            }
        }

        private void btnOutput03_Click(object sender, EventArgs e)
        {
            int data1 = int.Parse(tbxInput1.Text);
            int data2 = int.Parse(tbxInput2.Text);
            if (chkToggle.Checked == false) {
                int result = data1 + data2; //더하기
                lblResult.Text = string.Format("더하기:{0}", result);
            } else {
                int result = data1 - data2; //빼기
                lblResult.Text = $"빼기: {result}"; //문자열 보간
            }
        }

        private void btnOutput04_Click(object sender, EventArgs e)
        {
            double data1 = double.Parse(tbxInput1.Text);
            double data2 = double.Parse(tbxInput2.Text);
            if (chkToggle.Checked == false){
                double result = data1 + data2; //더하기
                lblResult.Text = string.Format("더하기:{0}", result);
            } else {
                double result = data1 - data2; //빼기
                lblResult.Text = $"빼기: {result}"; //문자열 보간
            }
        }

        private void btnOutput05_Click(object sender, EventArgs e)
        {
            lblResult.Text = tbxInput1.Text;
            lblResult.Text += Environment.NewLine; // "\r\n"
            //lblResult.Text = Environment.NewLine;
            lblResult.Text += tbxInput1.Text.GetType();
            //lblResult.Text = tbxInput1.Text.GetType(); //Type 타입임. Text는 string인데 Type 타입을 붙이니까 에러.
            lblResult.Text += Environment.NewLine;

            lblResult.Text += tbxInput1.Text[0];
            //lblResult.Text = tbxInput1.Text[0]; // char타입
            lblResult.Text += Environment.NewLine;
            lblResult.Text += tbxInput1.Text[0].GetType();


            lblResult.Text += Environment.NewLine;
            char test1 = tbxInput1.Text[0];
            char test3 = '가';
            //c언어 char = 1byte (ascii)
            //c#, java char = 2byte (unicode) UTF-8

            byte result1 = (byte)test1; // 부호없는 정수 1byte
            sbyte result1_1 = (sbyte)test1; // 부호있는 정수 1byte

            short result2 = (short)test1; // 부호있는 2byte
            ushort result3 = test1; // 부호없는 2byte (unsigned)
            //int , uint, long, ulong
            //int 4byte, long 8byte

            lblResult.Text += $"{test1}, {result1}, {result2}, {result3}, {test3}";
        }

        private void btnOutput06_Click(object sender, EventArgs e)
        {
            //정수 -> 실수 : ok
            //실수 -> 정수 : 처리필요
            //작은 숫자 -> 큰 숫자 : ok
            //큰 숫자 -> 작은 숫자 : 처리 필요
            int data1 = short.Parse(tbxInput1.Text);
            float data2 = (float) double.Parse(tbxInput2.Text);
            long data3 = long.Parse(tbxInput3.Text);
            int data4 = (int) data3;

            double result1 = data1 + data2 + data3 + data4; // float 니까.
            lblResult.Text += result1.ToString();


            lblResult.Text += "\r\n";
            lblResult.Text += "\n";
            
            //정수 : byte 1byte, char 2byte, short 2byte, int 4byte, long 8byte,
            //실수 : float 4byte, double 8byte

            // (int)1.9 + (int)1.6 => 2
            long result2 = data1 + (long)data2 + data3 + data4; // 정수 + 실수 = 실수
            lblResult.Text += result2.ToString();

            lblResult.Text += "\r\n";
            lblResult.Text += "\n";

            //(int)(1.9 + 1.6) => 3
            long result3 = (long)(data1 + data2 + data3 + data4); // 정수 + 실수 = 실수
            lblResult.Text += result3.ToString();
        }
    }
}
