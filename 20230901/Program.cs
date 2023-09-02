// 중급 문제 2: 조건문 사용하기
// 변수 age가 20 이상이면 "You are an adult."라고 출력하고,
// 그렇지 않으면 "You are a minor."라고 출력하는 코드를 작성해보세요.

//int age = 10;

//if (age >= 20)
//{
//    Console.WriteLine("You are an adult.");
//}
//else
//{
//    Console.WriteLine("You are a minor.");
//}

// 고급 문제 1: for 루프를 사용한 배열의 합 구하기
// 정수 배열 int[] numbers = { 1, 2, 3, 4, 5}; 가 있을 때,
// for 루프를 사용해 배열의 모든 요소의 합을 구하고 출력하세요.

// 내 답 틀림.
//int[] numbers = { 1, 2, 3, 4, 5 };

//for (int i = 0; i < 6; i++)
//{

//}

// Gpt 답
// numbers.Length 로 인덱스를 돌수 있는걸 잊지말자

//int[] numbers = { 1, 2, 3, 4, 5 };
//int sum = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    sum += numbers[i];
//}

//Console.WriteLine("배열의 합은:" + sum);

//고급 문제 2: 메서드 작성하기
// 인수로 받은 두 정수의 곱을 반환하는 메서드 Multiply를 작성해보세요.
// 그리고 이 메서드를 호출하여 결과를 출력해보세요.
// Gtp 답

//class Gpt
//{
//    public static int Multyply(int x , int y)
//    {
//        return x * y;
//    }

//    static void Main(string[] args)
//    {
//        int a = 10;
//        int b = 20;
//        int c = Multyply(a, b);
//        Console.WriteLine(c);
//    }
//}

//int n = 5;
//int m = 1;

//while(n >= 1)
//{
//    m *= n; 
//    n--;
//}
//Console.WriteLine(m);

//고급 문제 4: 배열과 for 루프
//길이가 5인 정수 배열을 선언하고,
//for 루프를 사용하여 배열의 각 요소에 1부터 5까지의 숫자를 할당하세요.
//그리고 루프를 다시 사용하여 배열의 모든 요소를 출력하세요.

int[] ints = new int[5];

for (int i = 0; i < ints.Length; i++)
{
    ints[i] += i + 1;
}

for (int i = 0; i < ints.Length; i++)
{
    Console.WriteLine(ints[i]);
}