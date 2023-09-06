using System;

public class Escape
{
    public static void Main()
    {
        // \n 줄바꿈
        Console.WriteLine("안녕\n하세요");
        // \t 탭만큼 들여쓰기
        Console.WriteLine("안녕\t하세요");
        // \r 캐리지리턴. 글자를 출력하고 커서를 줄 맨 앞으로 보낸다.
        Console.WriteLine("또 만나요\r");
        // \' \" 큰 따옴표, 작은따옴표를 표시. 작은따옴표는 그냥 써도 되는듯
        Console.WriteLine(" '낼' '만나요' ");
        Console.WriteLine(" '낼' \"만나요\" ");
        // \\ 백슬레스 표시
        Console.WriteLine(" \\ : 백슬레시 표현");
        // 문자열 앞에 @표시를 붙이면 공백/탭 을 포함해서 문자열로 본다.
        Console.WriteLine(@"한줄                    공백");

        Console.Read();
//edit
    }
}