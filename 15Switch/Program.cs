namespace _12While
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            // True인  case 만 실행 후 종료
            // default는 else의 역할을 한다.
            switch (a)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 100:
                    Console.WriteLine("100입니다.");
                    break;
                default:
                    break;
            }
            

        }
    }
}
