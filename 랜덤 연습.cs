using System;

namespace VS_CODE_CS2
{
    class Program1
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            Console.WriteLine($"랜덤숫자는 {random.Next(1,101)} 입니다");
        }
    }
}