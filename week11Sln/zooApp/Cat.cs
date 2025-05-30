﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class Cat
    {
        public enum COLOR
        {
            WHITE,
            BLACK,
            YELLOW,
            MIXED,

            END,
        }

        private string _name;
        private int _level;
        private COLOR _color;

        public string Name { get { return _name; } }
        public COLOR Color { get { return _color; } }
        public int Level { get { return _level; } }

        public Cat(string name, COLOR color)
        {
            this._name = name;
            this._color = color;
        }

        public string Meow(int count)
        {
            string ret = "";
            for (int i = 0; i < count; i++)
            {
                ret += "야옹~ ";
            }
            return ret;
        }

        public void Eat() { AddLevel(3); }

        public void Play() { AddLevel(2); }

        private bool AddLevel(int level)
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
            return $"CAT : {_name}";
        }
    }
}
