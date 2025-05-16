using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zooAppHomeWork
{
    internal class Dog : Animal
    {
        
        private int _year;

        
        public int Year
        {
            get { return _year; }
        }

        public Dog(string name, COLOR color, int year) : base(name, color)
        {
            this._year = year;
        }

        //오버라이딩
        public override void Eat() { AddLevel(30); }

        //하이딩
        public new void Play() { AddLevel(20); }

        public string Bark(int count)
        {
            string ret = "";
            for (int i = 0; i < count; i++)
            {
                ret += "월! ";
            }
            return ret;
        }

        protected override bool AddLevel(int level)
        {
            if (level < 0)
            {
                return false;
            }
            if (_level + level > 100)
            {
                _level = 100;
                return false;
            } else
            {
                _level += level;
                return true;
            }
        }
        public override string ToString()
        {
            return $"DOG : {Name}";
        }
    }
}
