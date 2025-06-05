using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_FinancialLedger_202001098
{
    public partial class Form1: Form
    {
        FileStream currentFile;
        FinancialLedger currentFL;
        StreamWriter sw;
        public Form1()
        {
            InitializeComponent();
            currentFile = null;
            currentFL = null;
            sw = null;

        }
        private const string BASE_FOLDER_DIR = "..\\..\\financialLedgers\\";
        private string returnPath(string filename)
        {
            string path = null;
            makeDirectory();
            path = Path.Combine(BASE_FOLDER_DIR, filename + ".txt");
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

            if (currentFile != null)
            {
                currentFile.Close();
                currentFile = null;
            }
            if (sw != null)
            {
                sw.Close();
                sw = null;
            }
            
            BlockingInput(true);
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


            if (false == File.Exists(returnPath(year.ToString())))
            {
                try {
                    using (FileStream fs = new FileStream(returnPath(year.ToString()), FileMode.Create)){ }
                } catch (Exception ex ) { Console.WriteLine(ex); }
            }

            currentFile = new FileStream(returnPath(year.ToString()), FileMode.Append);
            BlockingInput(year, false);
        }

        private void BlockingInput(int year, bool b)
        {
            tbxIncomeYear.Text = year.ToString();
            tbxIncomeYear.Enabled = b;
            tbxExpenditureYear.Text = year.ToString();
            tbxExpenditureYear.Enabled = b;
            tbxFastContent.Enabled = b;
            tbxFastMoney.Enabled = b;
        }

        private void BlockingInput(bool b)
        {
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
            if (InvalidInputCheck(tbxIncomeYear))    { return; }
            if (InvalidInputCheck(tbxIncomeMonth))   { return; }
            if (InvalidInputCheck(tbxIncomeDay))     { return; }
            if (InvalidInputCheck(tbxIncomeContent)) { return; }
            if (InvalidInputCheck(tbxIncomeMoney))   { return; }

            string content = tbxIncomeContent.Text;
            int year = int.Parse(tbxIncomeYear.Text); //Year는 유저가 수정할 수 없으니 반드시 올바른값임.
            int month, day, money;
            if (false == int.TryParse(tbxIncomeMonth.Text, out month)) { tbxIncomeMonth.Focus(); return; }
            if (false == int.TryParse(tbxIncomeDay.Text, out day))     { tbxIncomeDay.Focus();   return; }
            if (false == int.TryParse(tbxIncomeMoney.Text, out money)) { tbxIncomeMoney.Focus(); return; }
            
            if (InvalidMonthCheck(month)) { return; }
            if (InvalidDayCheck(day))     { return; }

            DateTime dt = new DateTime(year, month, day);
            currentFL.RegIncome(dt, content, money);

            if (currentFile != null)
            {
                sw = new StreamWriter(currentFile);
                sw.WriteLine($"{dt.ToString()},{content},{money}");
                sw.Close();
            }
            

        }
    }
}
