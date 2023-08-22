using System;

class IntegerDemo
{
    static void Main(string[] args)
    {
        int min = Int32.MinValue;
        int max = Int32.MaxValue;
        long lmax = Int64.MaxValue;

        Console.WriteLine($"int 변수의 최솟값: {min}");
        Console.WriteLine($"int 변수의 최댓값: {max}");
        Console.WriteLine($"long 변수의 최댓값: {lmax}");
        // 부호 없는 데이터 형식: byte, ushort, uint, ulong 은 - 값이 없어서 정수로만 두배가 된다.
        // sbyte는 128 byte 는 255 . int는 21억 uint는 42억

        // double : 실수형 데이터 형식 (64비트 부동 소수점 숫자)
    }
}