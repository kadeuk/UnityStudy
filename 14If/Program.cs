namespace _12While
{
    class Program
    {
        static void Main(string[] args)
        {
            // if, for, while 다 조건이 참일 경우에만 실행된다. 
            // 다만 if는 한번만 실행된다.
            // if가 거짓일때 else if 실행
            // if, else if 가 거짓일때 else 실행
            int i = 0;
            if (i == 1)
            {
                Console.WriteLine("출력");
            }
            else if (i == 2)
            {
                Console.WriteLine("else if 입니다.");
            }
            else
            {
                Console.WriteLine("모두 거짓이라 else가 실행됩니다.");
            }

        }
    }
}
