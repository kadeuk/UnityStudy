/* 일반적인 멤버 변수와 다른점
static을 붙이게 되면
정적 멤버 변수라고 한다.
정적 멤버 변수는 일반적인 멤버변수와 다르게
객체화를 하지 않고도 사용할수 있다.
그 사용법이 클래스의 이름만으로 사용할수가 있다.
아래에 Player.Playercount = 1; 보면 객체화를 하지 않고 바로 사용 가능하다.
이런 정적 멤법 변수는 데이터 영역에 들어가게 된다.
정적 멤버 변수는 모든 객체가 공유하는 하나의 변수가 되어준다. 모든 몬스터의 수등. 
몬스터 100 마리를 정적 멤버 변수로 만들고 플레이어 1,2,3 을 만들고 각자 10마리씩 죽이면
몬스터는 70 마리가 된다. 이때 몬스터 갯수는 데이터에 있고 데이터에서 10을 세면 빼게 된다. 
이런 몬스터 수타 아이템 갯수등 전 영역에서 공통적으로 사용해야할 변수와 데이터를 정적 멤버 변수로 만든다

C#은 어떤 클래스에 존재하는 Main의 이름을 가진 정적멤버 함수에서부터 시작한다.
어떤 프로그램이던지static void Main(string[] args) 이 코드가 있는곳부터 시작한다.
f12를 클래스 이름 위에서 누르면 그 클래스로 타고 들어가서 안의 내용을 볼수있다

정적 클래스란
정적 멤버변수와
정적 멤버 함수 만을 가질수 있는 클래스이다. 다 static이 붙은 것들만 사용가능
*/

class Player
{
    public static int Playercount = 0;
    
    private int At;
    private int Hp = 1;

    
    public int GetHp()
    {
        return Hp;
    }


    
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
            Player Newplayer1 = new Player();
            Player.Playercount = 1;
            Player Newplayer2 = new Player();
            Player.Playercount = 2;
            Player Newplayer3 = new Player();
            Player.Playercount = 3;
            



        }
    }
}
