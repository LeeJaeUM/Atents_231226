using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_03
{
    internal class Enemy : Character
    {
        public Enemy(string _name) 
        {
            name = _name;
        }
        public override void Skill()
        {
            Console.WriteLine("적은 도끼를 던진다");
        }
    }
}
