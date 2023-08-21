using System.Numerics;

namespace _12While
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool Check = true;
            //// 일반적인 while 문은 조건문 -> 실행코드 -> 조건문 -> 실행코드 이런식으로 실행된다
            //while (Check)
            //{
            //    Console.WriteLine("출력");
            //    Check = false;
            //}

            // do while 문은 조건문이 false라도 한번은 실행후에 다시 조건문을 본다. 그래서 실행코드 -> 조건문 형식이다.
            // 그래서 조건문이 참이면 못빠져 나오기 때문에 빠져나올수 있는 조건을 넣어주고 실행해줘야 한다
            // 무한반복을 하고 싶으면 안 넣어줘도된다
            //Check = false;
            //do
            //{
            //    Console.WriteLine("출력");
            //    Check = false;
            //} while (Check);

            int Count = 0;  
            do
            {
                Count += 1;
                Console.WriteLine(Count);
                
            }while (Count < 10);

        }
    }
}