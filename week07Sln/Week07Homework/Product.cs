using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week07Homework
{
    class Product
    {
        public string Code;
        public string Name;
        public int Price;
        public int Stock;
        public DateTime RegDate;

        
        public Product(string pc, string pn, int pp, int ps, DateTime prd)
        {
            this.Code = pc;
            this.Name = pn;
            this.Price = pp;
            this.Stock = ps;
            this.RegDate = prd;
        }

        public int CalPrice(int count)
        {
            if (count < 0 || count > Stock)
            {
                return -1;
            }
            return count * SalePrice();
        }

        public int SalePrice()
        {
            //등록일자가 오늘로부터 30일 이전인가.
            if ((DateTime.Now - this.RegDate).TotalDays >= 30)
            {
                return this.Price * 80 / 100;
            }
            return this.Price;
        }

        public override string ToString()
        {
            return $"[{this.Code}] {this.Name}";
        }
    }
}
