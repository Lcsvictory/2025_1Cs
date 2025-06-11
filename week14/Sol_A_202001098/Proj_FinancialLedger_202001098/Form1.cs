using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



/*
 _incomes, expenditures 딕셔너리에 접근할 방법이 없어서 restore메소드에서 해당 딕셔너리에
정보를 저장하질 않았음.
파일에 저장된 정보를 "복구하기" 버튼을 눌렀을 때 가져오는 식으로 구성했음.
년도별 가계부를 currentFL(FinancialLedger)에 올려두면서 해당년도 가계부만 핸들링하게 했음.
FLs딕셔너리는 각 년도별 FL들의 인스턴스를 담아놓는 딕셔너리임.. 그런데 딱히 쓸모는 없음. incomes와 expenditures에 접근이 안되니까..

 
 */

namespace Proj_FinancialLedger_202001098
{
    public partial class Form1: Form
    {
        private const string income = "i";
        private const string expenditure = "o";
        private const int fileFormatCnt = 4;
        private const string _yearFormat = "yyyyMMdd hhmmssfff";
        private const string BASE_FOLDER_DIR = "..\\..\\financialLedgers\\";
        FinancialLedger currentFL;
        Dictionary<int, FinancialLedger> FLs;
        public Form1()
        {
            InitializeComponent();
            currentFL = null;
            FLs = new Dictionary<int, FinancialLedger>();

            restore();
        }
        private void restore()
        {
            makeDirectory();
            string[] files = Directory.GetFiles(BASE_FOLDER_DIR).Select(p => Path.GetFileName(p)).ToArray();
            //Console.WriteLine("불러온 파일의 명칭들 " + files[0]);
            if (files.Length != 0)
            {
                foreach (string file in files)
                {
                    try
                    {
                        using (StreamReader sr = new StreamReader(returnPath(file)))
                        {
                            int year = int.Parse(file.Split(new char[] { '.' })[0]);

                            int targetAmount = int.Parse(sr.ReadLine());
                            FLs[year] = new FinancialLedger(year, targetAmount); ;
                        }
                    } catch (Exception ex) { Console.WriteLine(ex); }
                }
            }
        }

        private string returnPath(string filename)
        {
            string path = null;
            makeDirectory();
            if (filename.Contains(".txt"))
            {
                path = Path.Combine(BASE_FOLDER_DIR, filename);
            }else
            {
                path = Path.Combine(BASE_FOLDER_DIR, filename + ".txt");
            }
            return path;
        }
        private void makeDirectory()
        {
            if (false == Directory.Exists(BASE_FOLDER_DIR))
            {
                Directory.CreateDirectory(BASE_FOLDER_DIR);
            }
        }
        private bool InvalidInputCheck(TextBox tbx)
        {
            if (string.IsNullOrWhiteSpace(tbx.Text))
            {
                tbx.Focus();
                return true;
            }
            return false;
        }
        
        private bool InvalidYearCheck(int year)
        {
            if (year > DateTime.Today.Year + 30 || year < 1900)
            {
                return true;
            }
            return false;
        }
        private bool InvalidMonthCheck(int month)
        {
            if (month > 12 || month < 1)
            {
                return true;
            }
            return false;
        }
        private bool InvalidDayCheck(int day)
        {
            if (day > 31 || day < 1)
            {
                return true;
            }

            //public bool IsLeapYear(int year)
            //{
            //return (year % 4 == 0) && ((year % 100 != 0) || (year % 400 == 0));
            //}
            //if (month == 2 )
            //{
            //    if (IsLeapYear(year))
            //    {
            //        if (day > 29) { MessageBox.Show("윤년이면서 2월달은 29일까지입니다."); return false; }
            //    }else
            //    {
            //        if (day > 28) { MessageBox.Show("2월달은 28일까지입니다."); return false; }
            //    }
            //}
            return false;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            MakeDefault();
        }

        private void MakeDefault()
        {
            int thisYear = DateTime.Today.Year;
            int thisMonth = DateTime.Today.Month;
            int thisDay = DateTime.Today.Day;
            tbxYear.Text = thisYear.ToString();
            tbxTargetAmount.Text = "0";

            lblTotalIncome.Text = "0원";
            lblTotalExpenditure.Text = "0원";
            lblTotalAmount.Text = "0원";
            lblIsBlack.Text = " ";

            tbxIncomeYear.Text = thisYear.ToString();
            tbxIncomeMonth.Text = thisMonth.ToString();
            tbxIncomeDay.Text = thisDay.ToString();
            tbxIncomeContent.Text = string.Empty;
            tbxIncomeMoney.Text = "0";

            tbxExpenditureYear.Text = thisYear.ToString();
            tbxExpenditureMonth.Text = thisMonth.ToString();
            tbxExpenditureDay.Text = thisDay.ToString();
            tbxExpenditureContent.Text = string.Empty;
            tbxExpenditureMoney.Text = "0";

            tbxFastContent.Text = string.Empty;
            tbxFastMoney.Text = "0";
            
            BlockingInput(true);


            lbxIncome.Items.Clear();
            lbxExpenditure.Items.Clear();
            lbxAll.Items.Clear();
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            

            if (InvalidInputCheck(tbxYear) || InvalidInputCheck(tbxTargetAmount)) { return; }
            

            int year, targetAmount;
            if (false == int.TryParse(tbxYear.Text, out year)) { tbxYear.Focus(); return; }
            if (false == int.TryParse(tbxTargetAmount.Text, out targetAmount)) { tbxTargetAmount.Focus(); return; }

            if (InvalidYearCheck(year)) { return; }
 
            FinancialLedger fl = new FinancialLedger(year, targetAmount);
            currentFL = fl;

            //파일이 없다면 만든다
            if (false == File.Exists(returnPath(year.ToString())))
            {
                try {
                    using (FileStream fs = new FileStream(returnPath(year.ToString()), FileMode.Create)) {
                        using (StreamWriter sw = new StreamWriter(fs)) {
                            sw.WriteLine(targetAmount);
                        }
                    }
                } catch (Exception ex ) { Console.WriteLine(ex); }
            } else
            {
                string[] lines = File.ReadAllLines(returnPath(year.ToString()));

                if (lines.Length > 0)
                {
                    lines[0] = targetAmount.ToString(); // 첫 줄만 수정
                }
                File.WriteAllLines(returnPath(year.ToString()), lines);
            }


            MakeDefault();
            BlockingInput(year, false);
        }

        private void BlockingInput(int year, bool b)
        {
            tbxYear.Enabled = b;
            tbxTargetAmount.Enabled = b;
            tbxIncomeYear.Text = year.ToString();
            tbxIncomeYear.Enabled = b;
            tbxExpenditureYear.Text = year.ToString();
            tbxExpenditureYear.Enabled = b;
            if (DateTime.Today.Year == year)
            {
                tbxFastContent.Enabled = !b;
                tbxFastMoney.Enabled = !b;
            }
            else
            {
                tbxFastContent.Enabled = b;
                tbxFastMoney.Enabled = b;
            }
        }

        private void BlockingInput(bool b)
        {
            tbxYear.Enabled = b;
            tbxTargetAmount.Enabled = b;
            tbxIncomeYear.Enabled = b;
            tbxExpenditureYear.Enabled = b;
            tbxFastContent.Enabled = b;
            tbxFastMoney.Enabled = b;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegIncome_Click(object sender, EventArgs e)
        {
            if (currentFL == null)
            {
                MessageBox.Show("가계부를 저장하거나 불러와야 합니다.");
                return;
            }

            if (InvalidInputCheck(tbxIncomeYear))    { return; }
            if (InvalidInputCheck(tbxIncomeMonth))   { return; }
            if (InvalidInputCheck(tbxIncomeDay))     { return; }
            if (InvalidInputCheck(tbxIncomeContent)) { return; }
            if (InvalidInputCheck(tbxIncomeMoney))   { return; }

            string content = tbxIncomeContent.Text;
            string displayStr = null;
            int year = int.Parse(tbxIncomeYear.Text); //Year는 유저가 수정할 수 없으니 반드시 올바른값임.
            int month, day, money;
            if (false == int.TryParse(tbxIncomeMonth.Text, out month)) { tbxIncomeMonth.Focus(); return; }
            if (false == int.TryParse(tbxIncomeDay.Text, out day))     { tbxIncomeDay.Focus();   return; }
            if (false == int.TryParse(tbxIncomeMoney.Text, out money)) { tbxIncomeMoney.Focus(); return; }
            
            if (InvalidMonthCheck(month)) { return; }
            if (InvalidDayCheck(day))     { return; }

            DateTime dt = new DateTime(year, month, day);
            TimeSpan ts = DateTime.Now - DateTime.Today;
            dt = dt.Add(ts);

            if (currentFL != null)
            {
                currentFL.RegIncome(dt, content, money);
            }

            try
            {
                using (FileStream fs = new FileStream(returnPath(year.ToString()), FileMode.Append))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        displayStr = $"{income},{dt.ToString(_yearFormat)},{content},{money}";
                        sw.WriteLine(displayStr);
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }

            DisplayInfo(displayStr);
        }

        private void DisplayInfo(string datas)
        {
            if (currentFL == null) return;
            int amount = currentFL.TotalIncome - currentFL.TotalExpenditure;
            lblTotalIncome.Text = currentFL.TotalIncome.ToString("N0") + "원";
            lblTotalExpenditure.Text = currentFL.TotalExpenditure.ToString("N0") + "원";
            lblTotalAmount.Text = amount.ToString("N0") + "원";
            lblIsBlack.Text = currentFL.IsBlack ? "흑자" : "적자";

            string[] temp = datas.Split(new char[] { ',' });
            string date = temp[1].Substring(0, 8);
            int money = int.Parse(temp[3]);
            if (temp[0] == income)
            {
                lbxIncome.Items.Add($"[수입]({date}) {temp[2]} : {money.ToString("N0")}원");
                lbxAll.Items.Add($"[수입]({date}) {temp[2]} : {money.ToString("N0")}원");
            }else
            {
                lbxExpenditure.Items.Add($"[지출]({date}) {temp[2]} : {money.ToString("N0")}원");
                lbxAll.Items.Add($"[지출]({date}) {temp[2]} : {money.ToString("N0")}원");
            }

        }

        private void DisplayInfo()
        {
            if (currentFL == null) return;
            int amount = currentFL.TotalIncome - currentFL.TotalExpenditure;
            lblTotalIncome.Text = currentFL.TotalIncome.ToString("N0") + "원";
            lblTotalExpenditure.Text = currentFL.TotalExpenditure.ToString("N0") + "원";
            lblTotalAmount.Text = amount.ToString("N0") + "원";
            lblIsBlack.Text = currentFL.IsBlack ? "흑자" : "적자";

        }

        private void btnRegExpenditure_Click(object sender, EventArgs e)
        {
            if (currentFL == null)
            {
                MessageBox.Show("가계부를 저장하거나 불러와야 합니다.");
                return;
            }

            if (InvalidInputCheck(tbxExpenditureYear)) { return; }
            if (InvalidInputCheck(tbxExpenditureMonth)) { return; }
            if (InvalidInputCheck(tbxExpenditureDay)) { return; }
            if (InvalidInputCheck(tbxExpenditureContent)) { return; }
            if (InvalidInputCheck(tbxExpenditureMoney)) { return; }

            string content = tbxExpenditureContent.Text;
            string displayStr = null;
            int year = int.Parse(tbxExpenditureYear.Text); //Year는 유저가 수정할 수 없으니 반드시 올바른값임.
            int month, day, money;
            if (false == int.TryParse(tbxExpenditureMonth.Text, out month)) { tbxExpenditureMonth.Focus(); return; }
            if (false == int.TryParse(tbxExpenditureDay.Text, out day)) { tbxExpenditureDay.Focus(); return; }
            if (false == int.TryParse(tbxExpenditureMoney.Text, out money)) { tbxExpenditureMoney.Focus(); return; }

            if (InvalidMonthCheck(month)) { return; }
            if (InvalidDayCheck(day)) { return; }

            DateTime dt = new DateTime(year, month, day);
            TimeSpan ts = DateTime.Now - DateTime.Today;
            dt = dt.Add(ts);

            if (currentFL != null)
            {
                currentFL.RegExpenditure(dt, content, money);
            }


            try
            {
                using (FileStream fs = new FileStream(returnPath(year.ToString()), FileMode.Append))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        displayStr = $"{expenditure},{dt.ToString(_yearFormat)},{content},{money}";
                        sw.WriteLine(displayStr);
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }

            DisplayInfo(displayStr);
        }

        private void btnFastRegIncome_Click(object sender, EventArgs e)
        {
            if (currentFL == null)
            {
                MessageBox.Show("가계부를 저장하거나 불러와야 합니다.");
                return;
            }

            if (InvalidInputCheck(tbxFastContent)) { return; }
            if (InvalidInputCheck(tbxFastMoney)) { return; }

            DateTime now = DateTime.Now;
            string content = tbxFastContent.Text;
            string displayStr = null;
            int money;
            if (false == int.TryParse(tbxFastMoney.Text, out money)) { tbxFastMoney.Focus(); return; }

            if (currentFL != null)
            {
                currentFL.RegIncome(content, money);
            }


            try
            {
                using (FileStream fs = new FileStream(returnPath(now.Year.ToString()), FileMode.Append))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        displayStr = $"{income},{now.ToString(_yearFormat)},{content},{money}";
                        sw.WriteLine(displayStr);
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }

            DisplayInfo(displayStr);
        }

        private void btnFastRegExpenditure_Click(object sender, EventArgs e)
        {

            if (currentFL == null)
            {
                MessageBox.Show("가계부를 저장하거나 불러와야 합니다.");
                return;
            }
            if (InvalidInputCheck(tbxFastContent)) { return; }
            if (InvalidInputCheck(tbxFastMoney)) { return; }

            DateTime now = DateTime.Now;
            string displayStr = null;
            string content = tbxFastContent.Text;
            int money;
            if (false == int.TryParse(tbxFastMoney.Text, out money)) { tbxFastMoney.Focus(); return; }

            if (currentFL != null)
            {
                currentFL.RegExpenditure(content, money);
            }

            try
            {
                using (FileStream fs = new FileStream(returnPath(now.Year.ToString()), FileMode.Append))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        displayStr = $"{expenditure},{now.ToString(_yearFormat)},{content},{money}";
                        sw.WriteLine(displayStr);
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }

            DisplayInfo(displayStr);
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            

            if (InvalidInputCheck(tbxYear)) { return; }
            int year;
            if (false == int.TryParse(tbxYear.Text, out year)) { tbxYear.Focus(); return; }

            if (InvalidYearCheck(year)) { return; }
            

            if (FLs.ContainsKey(year))
                currentFL = FLs[year];
            else
            {
                MessageBox.Show("해당 연도의 가계부가 존재하지 않습니다.");
                return;
            }

            MakeDefault();
            string[] datas = File.ReadAllLines(returnPath(year.ToString()));
            if (datas.Length > 1)
            {
                for (int i = 1; i < datas.Length; i++)
                {
                    string[] temp = datas[i].Trim().Split(new char[] { ',' });
                    if (temp.Length != fileFormatCnt) { return; }

                    string content = null;
                    int money = 0;
                    if (temp[0] == income)
                    {
                        // 20240908 = 8자리, 시간까지는 표시하지 않겠다.
                        string date = temp[1].Substring(0, 8);
                        content = temp[2];
                        money = int.Parse(temp[3]);

                        lbxIncome.Items.Add($"[수입]({date}) {content} : {money.ToString("N0")}원");
                        lbxAll.Items.Add($"[수입]({date}) {content} : {money.ToString("N0")}원");
                        
                        DateTime dt = DateTime.ParseExact(temp[1], _yearFormat, null);
                        currentFL.RegIncome(dt, content, money);
                    }
                    else //expenditure
                    {
                        string date = temp[1].Substring(0, 8);
                        content = temp[2];
                        money = int.Parse(temp[3]);

                        lbxExpenditure.Items.Add($"[지출]({date}) {content} : {money.ToString("N0")}원");
                        lbxAll.Items.Add($"[지출]({date}) {content} : {money.ToString("N0")}원");
                        
                        DateTime dt = DateTime.ParseExact(temp[1], _yearFormat, null);
                        currentFL.RegExpenditure(dt, content, money);
                    }
                }

            }
            BlockingInput(year, false);
            DisplayInfo();
        }

        
    }
}
