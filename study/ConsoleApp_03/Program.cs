namespace ConsoleApp_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------Hello, World!");
            //my.hp = 10; 아준나쁜코드
            //my.HP = 100;    //get set 사용- 하지만 set은 막아둠
            //float f = my.HP;

            //Character my = new Character(); //메모리를 할당하여 클래스를 생성(인스턴스화) 했다.
            //my.Skill();
            //Character enemyTemp = new Character("적"); //메모리를 할당하여 클래스를 생성(인스턴스화) 했다.
            //enemyTemp.Skill();

            Player player = new Player("나");
            player.Skill();
            Enemy enemy = new Enemy("고블린");
            enemy.Skill();

            Console.WriteLine($" [{player.Name}]와 [{enemy.Name}]의 죽음의 싸움 시작");
            bool isBattleEnd = false;
            bool anyTurn = true;
            int roundCount = 1;
            while (!isBattleEnd)
            {
                Console.WriteLine($"\n------ {roundCount} 라운드 ------");
                Console.WriteLine($" [{player.Name}]의 체력 = {player.HP} ---  [{enemy.Name}]의 체력 = {enemy.HP}\n");
                if (anyTurn)
                {
                    player.Attack(enemy);
                    anyTurn = false;
                }
                else
                {
                    enemy.Attack(player);
                    anyTurn = true;
                }
                if(player.HP <= 0 || enemy.HP <= 0) 
                {
                    isBattleEnd = true;
                    if(player.HP > 0) 
                    {
                        Console.WriteLine($" [{player.Name}]의 승리!!");
                    }
                    else
                    {
                        Console.WriteLine($" [{enemy.Name}]의 승리......");
                    }
                }
                roundCount++;
            }

            //Character test = new Player(); //자식 클래스의 인스턴스는 부모타입의 변수에 저장할 수 있다.
            //test.Skill();
            //Character test2 = new Player(); //자식 클래스의 인스턴스는 부모타입의 변수에 저장할 수 있다.
            //test2.Attack();

            ///실습
            ///적과 나 중에 한 명이 죽을 때까지 한 번씩 공격하기
            ///죽을 때 누가 죽었는지 출력이 되어야한다.
            ///한 명이 죽으면 프록램 종료

            Console.WriteLine("PRogarm End--------------");
        }
    }
}
