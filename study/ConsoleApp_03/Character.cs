using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_03
{
    class Character
    {
        //private protected public
        private float hp;
        public float HP
        {
            get => hp;
            private set
            {
                hp = value; 
                hp = Math.Clamp(value, 0, maxHp);

                //if(hp < 0 ) hp = 0;
                //if (hp > 0) hp = maxHp;

            }
        }
        protected float maxHp;
        protected float mp;
        protected float maxMp;
        protected int level;
        protected float exp;
        protected const float maxExp = 100; // 상수, 절대 변경불가
        protected float attackPower;
        protected float defencePower;
        protected string name;

        public string Name => name; // Name이라는 프로퍼티를 읽기 전용으로 만들고 읽으면 name을 리턴한다

        //생성자ㅇ
        public Character()
        {
            hp = 100;
            maxHp = 100;
            mp = 50;
            maxMp = 50;
            level = 1;
            exp = 0.0f;
            attackPower = 10.0f;
            defencePower = 5.0f;

            name = "무명";
        }
        public Character(string _name)
        {
            hp = 100;
            maxHp = 100;
            mp = 50;
            maxMp = 50;
            level = 1;
            exp = 0.0f;
            attackPower = 10.0f;
            defencePower = 5.0f;

            this.name = _name;
        }


        public void Attack(Character target)
        {
            Console.WriteLine($"[{name}]가 공격한다");
            target.Defence(attackPower);
        }
        public virtual void Skill() // Skill 함수는 virtual 함수다 = > Skill 함수는 상속받은 클래스에서 덮어쓸 수 있다. (override)
        {
            Console.WriteLine("캐릭터가 스킬을 사용한다");
        }
        void Defence(float damage)
        {
            float default_Damage = damage - defencePower;
            Random r = new Random();
            float randomOffset = r.Next(-2, 3);
            float final_Damage = default_Damage + randomOffset;
            HP -= final_Damage; //파라미터를 사용해서 0~최대치 값 조정
            Console.WriteLine($"└ ─ [{name}]이 {final_Damage} 만큼의 피해를 입었습니다.");
        }
        void LevelUp()
        {

        }
    }

}