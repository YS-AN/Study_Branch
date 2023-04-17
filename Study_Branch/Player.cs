using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Branch
{
    public class Player
    {
        public string id;
        public int hp;
        public int mp;
        public int ap;

        public void Attack(Monster monster)
        {
            Console.WriteLine("플레이어가 {0}를 공격합니다.", monster);
            monster.TakeDamage(ap);
        }

        public void TakeDamage(int damage)
        {
            Console.WriteLine("플레이어가 공격당합니다2.");
            hp -= damage;
        }

    }
}
