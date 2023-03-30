using System;

namespace VS_CODE_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int num = random.Next(1,101);   
            Console.Write("1 ~ 100까지의 숫자를 입력해주세요 : ");

            int input = 0;
            while(input != num) 
            {
                input = int.Parse(Console.ReadLine());

                if(input > num)
                {
                    Console.WriteLine("제 마음속의 수는 그것보다 작습니다.....");
                }
                else if(input < num)
                {
                    Console.WriteLine("제 마음속의 수는 그것보다 큽니다.......");
                }
                else
                {
                    Console.WriteLine("제 마음속의 수는 그것입니다!!");
                }
            }

        }
    }
}
