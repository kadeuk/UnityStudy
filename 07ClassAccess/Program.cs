// See https://aka.ms/new-console-template for more information



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    // 객체지향의 캡슐화 은닉화를 대표하는 문법
    // 접근제한 지정자이다.
    // 다 공개하는게 아니고 필요한것만 공개한다

    // 접근제한 지정자는 public , protected , private 세가지가 존재한다
    public int Att; // 외부에도 공개
    protected int Hp; // 자식에게만 공개
    private int Def; // 내부에만 공개
    // 클래스를 만들때 외부에 다 공개한 것은 누구라도 수정할수 있다.
    // 예를 들어  Hp를 공개하면 누구든 플레이어를 죽일수 있다. 
    // 그렇기 때문에 공개해야하는것을 잘 정해야하고
    // 누가 일부러 망칠려고 해도 망칠수 없게 클래스를 만들어라

    // 함수에도 똑같이 적용이 가능하다 
    public void Fight()
    {
        Console.WriteLine("싸운다");
    }
}  // -> 여기까지가 클래스 내부
// -> 여기부터 클래스 외부

namespace _07ClassAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            // 만들어진 객체의 내용을 사용하기 위해서는
            // 객체의 이름. 을 사용한다.
            // 객체가 사용할수 있는 기능이 안보이는것은 접근제한 지정자라는 문법을 사용하지 않아서
            // 외부에 공개하지 않기로 했다.
            
            NewPlayer.Att = 1;
            NewPlayer.Fight();
        }
    }
}