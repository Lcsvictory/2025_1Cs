using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week03Homework
{
    public partial class FormMain: Form
    {
        List<string> expressionFix = new List<string>();
        bool isOperator = false;
        bool middleCal = false;
        bool isDecimal = false;
        int paranCnt = 0;

        public FormMain()
        {
            InitializeComponent();

        }

        private List<string> infixToPostfix(List<string> infix)
        {

            List<string> postfix = new List<string>(); //후위표기식
            Stack<string> stack = new Stack<string>(); //후위표기식을 생성하기위한 임시공간 == stack
            foreach (var v in infix)
            {
                if (v == "(") //여는괄호는 어느 연산자보다 가장 우선순위가 높으니 일단 무조건 담음.
                {
                    stack.Push(v);
                }
                else if (v == ")") //닫는괄호면 여는괄호 나올때까지 stack에서 pop함.
                {
                    while (stack.Peek() != "(") //여는괄호면 false임으로 while문 탈출
                    {
                        postfix.Add(stack.Pop());
                    }
                    stack.Pop(); //현 위치는 여는괄호임. 여는괄호는 제거함.
                }
                else if (v == "*" || v == "/"){
                    if (stack.Count == 0)
                    {
                        stack.Push(v);
                        continue;
                    }
                    else if (stack.Peek() == "(")
                    {
                        stack.Push(v);
                        continue;
                    }
                    else
                    {
                        string top;
                        while (stack.Count > 0 && ((top = stack.Peek()) == "*" || top == "/")) //top이 * 혹은 / 일때까지.
                        {
                            postfix.Add(stack.Pop());
                        }
                        stack.Push(v);
                    }
                }
                else if (v == "+" || v == "-")
                {
                    if (stack.Count == 0)
                    {
                        stack.Push(v);
                        continue;
                    }
                    else if (stack.Peek() == "(")
                    {
                        stack.Push(v);
                        continue;
                    } else
                    {
                        string top;
                        while (stack.Count > 0 && ((top = stack.Peek()) == "*" || top == "/" || top == "+" || top == "-")) //자기보다 우선순위가 높은것을 제낀다.
                        {
                            postfix.Add(stack.Pop());
                        }
                        stack.Push(v);
                    }
                } else //숫자일때. 연산자가 아닐때임.
                {
                    postfix.Add(v);
                }


            }
            while (stack.Count != 0)
            {
                postfix.Add(stack.Pop());
            }
            
            return postfix;
        }

        private string listTostring(List<string> postfix)
        {
            string result = "";
            foreach (var i in postfix)
            {
                result += i;
            }
            return result;
        }

        private double resultCalculator(List<string> postfix)
        {
            //lblTest.Text = postfix.ToString();
            double result = 0; //결과 임시저장
            int i = 0;
            //int a1 = 0, a2 = 0;
            while (postfix.Count != 1)
            {
                switch (postfix[i])
                {
                    case "+":
                        result = double.Parse(postfix[i-2]) + double.Parse(postfix[i-1]);
                        postfix.RemoveRange(i-2, 3);
                        postfix.Insert(i-2, result.ToString());
                        i -= 2;
                        break;
                    case "-":
                        result = double.Parse(postfix[i-2]) - double.Parse(postfix[i-1]);
                        postfix.RemoveRange(i - 2, 3);
                        postfix.Insert(i - 2, result.ToString());
                        i -= 2;
                        break;
                    case "*":
                        result = double.Parse(postfix[i-2]) * double.Parse(postfix[i-1]);
                        postfix.RemoveRange(i - 2, 3);
                        postfix.Insert(i - 2, result.ToString());
                        i -= 2;
                        break;
                    case "/":
                        result = double.Parse(postfix[i-2]) / double.Parse(postfix[i-1]);
                        postfix.RemoveRange(i - 2, 3);
                        postfix.Insert(i - 2, result.ToString());
                        i -= 2;
                        break;
                    default:
                        i++;
                        continue;
                }
                
            }
            
            return double.Parse(postfix[0]);
        }

        private List<string> testCaseReturn()
        {
            List<string> testPostfix = new List<string>() { "74", "+", "53", "/", "91", "*", "62", "*", "(", "66", "+", "12", ")" };
            //foreach (var item in "A+B/C*D*(E+F)")
            //{
            //    testPostfix.Add(item.ToString());
            //}
            return testPostfix;
        }

        private void btnOperater_Click(object sender, EventArgs e)
        {
            
            
            Button target = (Button)sender;
            if (isOperator)
            {
                return;
            }
            if (false == string.IsNullOrEmpty(lblNumbers.Text))
            {

               

                if (!middleCal || lblTest.Text[lblTest.Text.Length -1] != ')')
                {
                    lblTest.Text += lblNumbers.Text;
                    expressionFix.Add(lblNumbers.Text);
                }
                if (lblTest.Text[lblTest.Text.Length - 1] == '.')
                {
                    lblTest.Text += "0";
                }

                lblTest.Text += target.Text;


                // 디버깅을 위해 expressionFix 리스트의 상태를 출력
                Console.WriteLine("오퍼레이터 눌렀을때: " + string.Join(" ", expressionFix));

                if (middleCal && (expressionFix[expressionFix.Count - 1] == ")" || expressionFix[expressionFix.Count - 1].All(char.IsDigit))) { 

                    if (paranCnt > 0 && expressionFix[expressionFix.Count - 1] == ")")
                    {
                        lblNumbers.Text = resultCalculator(infixToPostfix(expressionFix)).ToString();
                    } 
                       
                }
                expressionFix.Add(target.Text);

                Console.WriteLine("연산자 클릭시 " + lblTest.Text);
                isOperator = true;
            }

            if (middleCal == false) { middleCal = true; }
            isDecimal = false;

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            if (false == string.IsNullOrEmpty(lblTest.Text) && false == isOperator && lblTest.Text.Length != 1)
            {
                Console.WriteLine("계산버튼시 lblTest.Text: " + lblTest.Text);

                
                if (lblTest.Text[lblTest.Text.Length -1] != ')')
                {
                    lblTest.Text += lblNumbers.Text;
                    expressionFix.Add(lblNumbers.Text);
                }

                if (lblTest.Text[lblTest.Text.Length - 1] == '.')
                {
                    lblTest.Text += "0";
                }
                //lblTest.Text += lblNumbers.Text; //숫자임
                //expressionFix.Add(lblNumbers.Text);


                if ((expressionFix[expressionFix.Count - 1] == ")" || expressionFix[expressionFix.Count - 1].All(char.IsDigit)))
                {
                    if (paranCnt > 0)
                    {
                        while (paranCnt != 0)
                        {
                            expressionFix.Add(")");
                            paranCnt--;

                            lblTest.Text += ")";
                        }

                    }
                    // 디버깅을 위해 expressionFix 리스트의 상태를 출력
                    Console.WriteLine("계산버튼 눌렀을때: " + string.Join(" ", expressionFix));
                    lblNumbers.Text = $"{resultCalculator(infixToPostfix(expressionFix)):F2}";
                }
                
                lblTest.Text += " = ";
                lblTest.Text += lblNumbers.Text;
                isDecimal = false;

            } else
            {
                return;
            }
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button target = (Button)sender;
            if (lblNumbers.Text == "0" || isOperator)
            {
                lblNumbers.Text = target.Text;
            }
            else
            {
                lblNumbers.Text += target.Text;
                //middleCal = true;

            }
            //lblNumbers.Text = target.Text;
            isOperator = false;


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblNumbers.Text = "0";
            lblTest.Text = "";
            middleCal = false;
            isOperator = false;
            expressionFix.Clear();
            isDecimal = false;
        }

        private void btnParen_Click(object sender, EventArgs e)
        {
            Button target = (Button)sender;
            if (target.Text == "(")
            {
                lblTest.Text += "(";
                expressionFix.Add("(");
                paranCnt++;

            }
            else
            {
                if (lblNumbers.Text.Length > 0)
                {
                    
                    lblTest.Text += lblNumbers.Text;
                    lblTest.Text += ")";
                    expressionFix.Add(lblNumbers.Text);
                    expressionFix.Add(")");
                    paranCnt--;

                    
                    isDecimal = false;

                }

            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            Button target = (Button)sender;
            if (!isDecimal)
            {
                lblNumbers.Text += ".";
                isDecimal = true;
            }
        }
    }
}
