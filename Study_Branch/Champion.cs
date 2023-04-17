using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Branch
{
    internal class Champion
    {
        private string name;
        protected int hp = 100;
        protected int mp = 30;
        private int attackpoint;
        private int ammor;

        public Champion()
        {
            hp = hp;
            mp = mp;
            attackpoint = attackpoint;
            ammor = ammor;
        }
        public void Move()
        {
            Console.WriteLine($"{name}이 걸어다닙니다.");
        }

        public void Attack(IHitable hitable)
        {
            Console.WriteLine($"{hitable}을 {name}이 공격합니다.");
        }
    }
}
