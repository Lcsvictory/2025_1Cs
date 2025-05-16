using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zooAppHomeWork
{
    internal abstract class Animal
    {
        private string _name;
        protected int _level;
        protected COLOR _color;

        public string Name
        {
            get { return _name; }
        }
        public int Level
        {
            get { return _level; }
        }
        protected COLOR Color
        {
            get { return _color; }
        }

        public Animal(string name, COLOR color)
        {
            this._name = name;
            this._color = color;
        }
        public virtual void Eat() { AddLevel(3); }

        public void Play() { AddLevel(2); }

        protected abstract bool AddLevel(int level);

        public override string ToString()
        {
            return $"ANIMAL : {_name}";
        }
    }
}
