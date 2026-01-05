namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = "=== RPG 게임 ==="; 
            string playerName = "Bluey"; 
            string rank = "A등급"; 
            string symbol = "★"; 
            string greeting = "게임에 오신 것을 환영합니다!"; 

            Console.WriteLine(title);
            Console.WriteLine($"플레이어: {playerName}");
            Console.WriteLine($"등급: {rank} {symbol}");
            Console.WriteLine(greeting);
        }
    }
}