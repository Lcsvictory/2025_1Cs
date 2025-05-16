using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zooAppHomeWork
{
    internal class Cat : Animal
    {
        public Cat(string name, COLOR color) : base(name, color){ }
        public string Meow(int count)
        {
            string ret = "";
            for (int i = 0; i < count; i++)
            {
                ret += "야옹~ ";
            }
            return ret;
        }

        //기본으로 하이딩을 지원.
        public new void Play() { AddLevel(200); }

        //override
        public override void Eat() { AddLevel(300); }

        protected override bool AddLevel(int level)
        {
            if (level < 0)
            {
                return false;
            }
            if (_level + level > 2000)
            {
                _level = 2000;
                return false;
            }
            else
            {
                _level += level;
                return true;
            }
        }

        public override string ToString()
        {
            return $"CAT : {Name}";
        }
    }
}
