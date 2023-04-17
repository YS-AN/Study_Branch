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
    public class Snail : Monster
    {
        public string name;
        public int hp;
        public int ap;

        public Snail(string name, int hp, int ap) : base(name, hp, ap)
        {
            this.name = name;
            this.hp = hp;
            this.ap = ap;
        }

        public override void TakeDamage(int damage)     // 몬스터 테이크데미지 가상 메서드 오버라이드로  재정의
        {
            hp -= damage;
            Console.WriteLine("{0}이 데미지를 받았습니다. 남은 체력 : {1}", name, hp);
        }

    }

    public class RedSnail : Snail
    {
        public string name;
        public int hp;
        public int ap;
        public RedSnail(string name, int hp, int ap) : base(name, hp, ap)
        {
            this.name = "빨간달팽이";
            this.hp = 50;
            this.ap = 5;
        }
        public override void TakeDamage(int damage)
        {
            base.TakeDamage(damage);
        }
    }
    public class BlueSnail : Snail
    {
        private string name;
        public int hp;
        public int ap;
        public BlueSnail(string name, int hp, int ap) : base(name, hp, ap)
        {
            this.name = "파란달팽이";
            this.hp = 30;
            this.ap = 3;
        }
        public override void TakeDamage(int damage)
        {
            base.TakeDamage(damage);
        }
    }
}
