using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Branch
{
    public class Monster
    {
        public string name;
        public int hp;
        public int ap;

        public void GetDamage(int damage)
        {
            hp -= damage;
            Console.WriteLine("몬스터가 공격당합니다.");
        }
    }
}
