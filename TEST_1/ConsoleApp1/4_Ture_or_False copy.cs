namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Game status
            Console.WriteLine("\n=== 게임 상태 ===");
            bool isGameRunning = true;
            bool isPaused = false;
            bool isDoorOpen = false;
            bool isPlayerAlive = true;

            Console.WriteLine($"게임 실행 중 : {isGameRunning}");
            Console.WriteLine($"일시정지 : {isPaused}");
            Console.WriteLine($"문 열림 : {isDoorOpen}");
            Console.WriteLine($"플레이어 생존 : {isPlayerAlive}");

            // Character status
            Console.WriteLine("\n=== 캐릭터 상태 ===");
            int health = 80;
            bool isHealthy = false;
            bool isInDanger = false;

            Console.WriteLine($"체력 : {health}");
            Console.WriteLine($"건강 상태 : {isHealthy}");
            Console.WriteLine($"위험 상태 : {isInDanger}");
        }
    }
}