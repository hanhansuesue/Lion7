namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // //상수 : 값을 변경할 수 없는 변수
            // const double Pi = 3.14159; //상수 Pi 선언 및 초기화 
            // const int MaxScore = 100; //정수형 상수 선언

            // //출력
            // Console.WriteLine("Pi: " + Pi);
            // Conasole.WriteLine("Max Score: " + MaxScore);

            // //상수 : 값을 변경할 수 없는 변수
            // const double Pi = 3.14159; //상수 Pi 선언 및 초기화 
            // const int MaxScore = 100; //정수형 상수 선언

            // //출력
            // Console.WriteLine("Pi: " + Pi);
            // Console.WriteLine("Max Score: " + MaxScore);

            // using System;
{
    static void Main(string[] args)
    {
        // 게임 설정 상수
        const int MAX_PLAYER_COUNT = 4;      // 최대 플레이어 수
        const int STARTING_GOLD = 1000;      // 시작 골드
        const double PI = 3.14159;           // 원주율
        const string GAME_VERSION = "1.0.0"; // 게임 버전
        
        // 상수 사용
        Console.WriteLine("=== 게임 설정 ===");
        Console.WriteLine($"최대 플레이어: {MAX_PLAYER_COUNT}명");
        Console.WriteLine($"시작 골드: {STARTING_GOLD}G");
        Console.WriteLine($"버전: {GAME_VERSION}");
        
        // 상수는 변경 불가
        // MAX_PLAYER_COUNT = 5;  // ❌ 컴파일 오류!
        
       
    }
}

        }
    }
}