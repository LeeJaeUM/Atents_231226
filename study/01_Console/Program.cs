namespace _01_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Console.WriteLine("Hello, World!");
            Console.Write("고고고고고\n노노노노노노");
            Console.WriteLine("my name is 이재웅");

            string input = Console.ReadLine(); //키볻 입력을 받아서 string 변수 input 에 저장하기

            Console.WriteLine(input); //input 출력
             */
            int check = 0;
            Console.WriteLine("당신의 이름을 입력하세요");
            string nameInput = Console.ReadLine();
            while (check < 3)
            {
                check++;
                Console.WriteLine(nameInput);
            }
            
        }
    }
}
