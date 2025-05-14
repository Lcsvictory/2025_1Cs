using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{

    class Dog : Animal
    {
        
        //private string _name;
        //private int _level;
        //부모가 가진 필드를 뭐하러 자식에서 또 만들지?

        //상속받은 필드와 이름이 같아도 new 키워드를 통해 별도의 필드를 생성 가능.
        //_dogColor같은 변수로 이름을 바꾸는게 더 나을듯.

        //private new COLOR _color;

        private int _year;

        //public string Name { get { return _name; } }
        //public COLOR Color { get { return _color; } }
        //public int Level { get { return _level; } }
        public int Year { get { return _year; } }

        public Dog(string name, COLOR color, int year) : base(name,color)
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
            if (_level + level <= 100)
            {
                _level += level;
                return true;
            }
            else
            {
                _level = 100;
                return false;
            }
        }

        public override string ToString()
        {
            return $"DOG : {Name}";
        }
    }
}
