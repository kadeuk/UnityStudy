using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    // 접근제한 지정자를 입력하지 않으면
    // 디폴트는 private 이 일반적이다
    // 가능하면 기본 속성들은 외부에서 접근하지 못하게 하는게 좋다.
    // 왜냐하면 아무나 Hp를 0으로 만들어버리면 캐릭터가 바로 죽어버리기 때문이다. 
    // 게임파일은 다른사람들이 수정할 수 있기때문에 기본 속성들은 감춰두는것이 좋다.
    // 그래서 함수를 만들어서 외부에서 사용한다.
    private int At;
    private int Hp = 1;

    // return 값이란 객체가 자신의 상태를 외부에 알려주는 용도로 사용한다.
    // 외부에 알려주는 순간 함수가 끝나게 된다.
    public int GetHp()
    {
        return Hp;
    }


    // 이렇게 함수로 만들어서 외부에서 사용한다.
    // int Hp는 인자다 .인자는 여러개일수 있다
    public void Damage1(int _Dmg)
    {
        Hp = Hp - _Dmg;
    }

    public void Damage2(int _Dmg, int _SubDmg)
    {
        Hp = Hp - _Dmg;
        Hp = Hp - _SubDmg;
    }
}

namespace _08FuncEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Newplayer = new Player();

            // 외부의 값을 받아서 객체의 값을 변화시키기 위해 함수를 선언한다
            Newplayer.Damage1(10);
            Newplayer.Damage2(10, 20);
            Console.WriteLine(Newplayer.GetHp());

        }
    }
}