﻿// 메모리에 올라있는 우리 프로그램은 4가지 영역으로 구성되어있다.
// 코드, 데이터, 힙, 스택이다.
// 코드 : 상수, 클래스 선언. 함수의 내용등 수정이 불가능한 것이들 들어가있다.
// 스택 : 함수가 실행되면 스택에 올라가서 메모리용량을 차지하고 함수가 끝나면 사라진다.
// 모든 함수가 종료되고 프로그램이 끝나면 메모리를 차지하던 코드, 데이터, 힙, 스택이 메모리에서 삭제된다
// 함수가 실행되면 함수 안에있는 지역변수를 다 포함할수 있는 크기만큼 메모리를 차지하게 되고
// 함수 안에있는 지역변수들이 그 안을 차지하고 있다.

// 지역변수 안에서 벌어지는 일은 이 안에서 벌어지는 일일 뿐이다 예를 들어 멤버 함수가 있다.
// 아래 Test라는 함수의 인자로 Value 값을 넣었다. 이때 Value 자체가 테스트의 인자로 들어가는것이다니다
// Value는 Main 함수 안에 그대로 있고 0 이라는 값만 Test의 인자로 준다. 그래서 _Dmg는 0을 리턴한다.
// 중요한것은 _Dmg의 값을 어떻게 바꾸는 Value값은 변하지 않는다 _Dmg는 Test함수안에 Value는 Main함수안에 그대로 있다.
// 서로 영향을 받지 않고 값만 넘겨준것이다.
// 함수안의 인자나 변수들은 그 함수 안에서만 위치한다. B 함수에서 계산을 통해 A 변수의 값을 바꿔도 A 변수의 값은 변하지 않는다.
// B함수 안에서만 바뀔뿐이다.값을 인자로 전해준면 받은곳에서는 바뀌고 전해준 곳에서는 바뀌지 않는다.
// 그럼 바꿀려면 다시 바뀐값을 A 변수에 할 당하면 바뀐다. 이걸 값형의 처리 라고 한다.

// 그러나 클래스 로 객체를 만든녀석은 레퍼런스 형이라고 해서 바뀐다. 메모리 위치와 사용법이 다르다
// 실제 만들어진 클래슨 힙 영역에 있다. 이 부분은 'https://youtu.be/Cq4olyGLk3g' 여기를 여러번 보면서 이해하자.
// 프로그램을 만들때 그냥 값을 넣고 클래스를 사용하지말고 한번보면 이해될때까지 그림으로 그려보자

class Player
{
    public void Test(int _Dmg)
    {
        _Dmg = 1000;
    }
}
namespace _08FuncEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Newplayer = new Player();
            int Value = 0;
            Newplayer.Test(Value);

        }
    }
}