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
        public Monster(string name, int hp, int ap)
        {
            this.name = name;
            this.hp = hp;
            this.ap = ap;
        }

        public virtual void TakeDamage(int damage)
        {
            hp -= damage;
            Console.WriteLine("몬스터가 공격당합니다.");
        }
    }

    public class Slime : Monster
    {
        public string name;
        public int hp;
        public int ap;

        public Slime(string name, int hp, int ap) : base(name, hp, ap)
        {
            this.name = name;
            this.hp = hp;
            this.ap = ap;
        }

        public override void TakeDamage(int damage)     // 몬스터 테이크데미지 가상 메서드 오버라이드로  재정의
        {
            hp -= damage;
            Console.WriteLine("{0}이 데미지를 받아 독을 뿜었습니다. 남은 체력 : {1}", name, hp);
        }
    }
}
