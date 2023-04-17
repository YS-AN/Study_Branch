using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Branch.LOL.Class
{
    internal class Unit
    {
        enum Type { Fix, Move, Immune}

        protected string name;
        private Type type;
        protected int hp;
        protected int movePoint;
        private int gold;

        public void Move()
        {
            Console.WriteLine($"{name}가 움직입니다.");
        }

        public void DropGold()
        {
            Console.WriteLine($"{gold}를 떨어트립니다.");
        }
    }
}
