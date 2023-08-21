﻿namespace _12While
{
    class Program
    {
        static void Main(string[] args)
        {
            // for (초기화문; 조건문; 증감문;)
            // {
            //    실행코드
            // }
            // 순서 : 초기화문 -> 조건문 -> 실행코드 -> 증감문 -> 조건문 -> 실행코드 -> 증감문 반복
            // 초기화문은 밖으로 뺄수 있다.
            // 클래스의 함수 안에서 만 사용가능하다. 
            // 클래스 안에 함수 밖에서는 사용불가능하다.
            // 모든 함수의 중괄호 안에서만 사용가능하다 while문도 똑같다.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            // i++; : 단항연산자
            // 단항연산자: 변수 하나와 연산자만 있으면 실행되는 연상자를 단항연산자라고 한다.
            // 정수형일때 ++ 을 하게 되면 1씩 증가한다.
            // 정수형일때 -- 을 하게 되면 1씩 감소한다.

        }
    }
}



