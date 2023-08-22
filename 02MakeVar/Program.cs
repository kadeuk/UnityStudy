using System;


public class MakeVar
{
    public static void Main(string[] args)
    {
        // 변수란 프로그램에서 사용 할 데이터를 임시로 저장해 놓는 그릇
        // 변수선언, 변수에 값 할당, 변수사용 이 세단계를 따르자
        int number;
        number = 1234;
        Console.WriteLine("{0}", number); // 변수의 값을 화면에 표시하는것을 참조한다고 한다.

        // 변수 선언과 동시에 초기화
        int number2 = 7;
        Console.WriteLine("{0}", number2);
        // 숫자가 길면 _ 언더스코어 문자로 가독성을 높혀줄수 있다. 1_234
        // 화면에 표시되는건 1234 이렇게 된다 사람의 가독성을 높혀주기위해 사용한다.
        int number3 = 1_234;
        Console.WriteLine("{0}", number3);

        // 여러개의 변수를 선언하고 같은 값으로 초기화 하기
        int a, b, c;
        a = b = c = 10;
        Console.WriteLine($"{a}, {b}, {c}");

        // 상수 : 변하지 않는 변수, 읽기 전용 변수
        const int MAX = 100; // const 를 선언하면 정수 형식의 상수 선언과 동시에 초기화시켜 줘야하고
                            // 초기화 후에는 바꿀수 없다는 것을 의미
                            // 상수에 새로운 값을 할당하면 에러가 발생한다.
        Console.WriteLine($"{MAX}");



    }
}
