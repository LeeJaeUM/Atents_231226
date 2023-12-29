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
                //if(hp != value)// 변경되었을 때를 알 수 있는 코드{
                {
                    hp = value;
                    Console.WriteLine($"{name}의 hp는 {hp}가 되었다.");
                    if (hp <= 0)
                    {
                        Die();
                    }
                    hp = Math.Clamp(value, 0, maxHp);
                    //if(hp < 0 ) hp = 0;
                    //if (hp > 0) hp = maxHp;
                }
            }
        }

        public bool IsAlive => hp > 0;

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

        protected const float skillCost = 10.0f;
        private bool CanSkillUse => mp > skillCost;

        Random random;
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

            random = new Random();
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
            random = new Random();
            this.name = _name;
        }


        public void Attack(Character target)
        {
            if (CanSkillUse)
            {
                if( random.NextSingle() < 0.3f)
                {
                    Skill(target);
                }
                else
                {
                    Console.WriteLine($"[{name}]가 공격한다");
                    target.Defence(attackPower);
                }
            }
            else
            {
                Console.WriteLine($"[{name}]가 공격한다");
                target.Defence(attackPower);
            }
        }
        public void Skill(Character target)
        {
            if(mp > skillCost)
            {
                mp -= skillCost;

                //float damage = OnSkill();
                //target.Defence(damage);   
                target.Defence(OnSkill());  //위랑 같은 코드
            }
        }
        protected virtual float OnSkill()  // Skill 함수는 virtual 함수다 = > Skill 함수는 상속받은 클래스에서 덮어쓸 수 있다. (override)
        {
            Console.WriteLine("캐릭터가 스킬을 사용한다");
            return 10.0f;
        }

        void Defence(float damage)
        {
            float default_Damage = damage - defencePower;
            Random r = new Random();
            float randomOffset = r.Next(-2, 3);
            float final_Damage = default_Damage + randomOffset;
            Console.WriteLine($"└ ─ [{name}]이 {final_Damage} 만큼의 피해를 입었습니다.");
            HP -= final_Damage; //파라미터를 사용해서 0~최대치 값 조정
        }
        void LevelUp()
        {

        }
        void Die()
        {
            Console.WriteLine($"[{name}]이 죽었습니다.");
        }
    }

}