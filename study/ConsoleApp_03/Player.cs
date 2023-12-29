using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_03
{
    internal class Player : Character // Player 클래스가 Character 클래스를 상속 받음
    {
        public Player(string _name)
        {
            name = _name;
        }
        //public void Attack()
        //{
        //    Console.WriteLine("플레이어가 공격한다");
        //}
        protected override float OnSkill()
        {
            //base.Skill(); // Player의 부모클래스의 skill을 사용하고
            Console.WriteLine("플레이어가 파이어볼을 사용한다."); //자신의 코드 실행
            return attackPower * 5.0f;
        }
    }
}
