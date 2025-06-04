using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_FinancialLedger_202001098
{
    class FinancialLedger : Financial
    {
        private int _year;
        private int _targetAmount;

        public int Year { get { return _year; } }
        public int TargetAmount { get { return _targetAmount; } }
        public bool IsBlack { 
            get {   
                if (TargetAmount == 0 && TotalIncome > TotalExpenditure){ return true; }

                if ((TotalIncome - TotalExpenditure) >= TargetAmount){ return true; }

                return false;
            }
        }

        public FinancialLedger(int year)
        {
            _year = year;
            _targetAmount = 0;
        }
        public FinancialLedger(int year, int targetAmount)
        {
            if (targetAmount < 0) { targetAmount = 0; }
            _year = year;
            _targetAmount = targetAmount;
        }

        public override bool RegIncome(DateTime dt, string content, int money)
        {
            if (Year != dt.Year) { return false; }
            return base.RegIncome(dt, content, money);
        }

        public override bool RegIncome(string content, int money)
        {
            if (Year != DateTime.Today.Year) { return false; }
            return base.RegIncome(content, money);
        }

        public override bool RegExpenditure(DateTime dt, string content, int money)
        {
            if (Year != dt.Year) { return false; }
            return base.RegExpenditure(dt, content, money);
        }

        public override bool RegExpenditure(string content, int money)
        {
            if (Year != DateTime.Today.Year) { return false; }
            return base.RegExpenditure(content, money);
        }


    }
}
