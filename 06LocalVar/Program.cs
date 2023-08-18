// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// c# 은 고지식한 객체지향이라. 클래스뿐이 모르는 바보다.
// 프로그램의 시작조차도 클래스 안에 묶어놔야 한다.


class Player
{
    // 클래스 안에 있어서 멤버 변수 라고 한다
    int Att;
    int Hp;

    void Fight()
    {
        Console.WriteLine("플레이어가 싸운다");
    }
}

// 게임에서 사용하기 위해서 여기까지 설계 했다고 표현한다.




class Program
{
    static void Main(string[] args)
    {
        // 새로운 플레이어의 이름을 Newplayer라고 해서 만들어라
        // 함수안에 있는 NewPlayer 같은 변수를 지역변수 라고 한다
        // 선언 되는 순간 지역변수는 메모리화 되고  다 사용되면 사라진다 외부에서 사용할 수 없다.

        Player NewPlayer = new Player();
    }
}