using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_FinancialLedger_202001098
{
    abstract class Financial
    {
        //수입정보
        protected Dictionary<DateTime, Info> _incomes = new Dictionary<DateTime, Info>();
        //지출정보
        protected Dictionary<DateTime, Info> _expenditures = new Dictionary<DateTime, Info>();

        //전체 수입액
        public int TotalIncome { 
            get
            {
                int tot = 0;
                foreach (var i in _incomes)
                {
                    tot += i.Value.Money;
                }
                return tot;
            }
        }
        //전체 지출액
        public int TotalExpenditure {
            get
            {
                int tot = 0;
                foreach (var i in _expenditures)
                {
                    tot += i.Value.Money;
                }
                return tot;
            }
        }
    
        //특정 기간에 사용한 내역을 기록할때.
        public virtual bool RegIncome(DateTime dt, string content, int money)
        {
            //금액이 0보다작다면 기록불가
            if (money < 0) return false;
            Info i = new Info(content, money);
            _incomes[dt] = i;
            return true;
        }
        // 지금 당장 기입하려고 할 때.
        public virtual bool RegIncome(string content, int money)
        {
            if (money < 0) return false;
            Info i = new Info(content, money);
            _incomes[DateTime.Today] = i;
            return true;
        }

        public virtual bool RegExpenditure(DateTime dt, string content, int money)
        {
            //금액이 0보다작다면 기록불가
            if (money < 0) return false;
            Info i = new Info(content, money);
            _expenditures[dt] = i;
            return true;
        }
        //지금 당장 기입
        public virtual bool RegExpenditure(string content, int money)
        {
            if (money < 0) return false;
            Info i = new Info(content, money);
            _expenditures[DateTime.Today] = i;
            return true;
        }
    }
}
