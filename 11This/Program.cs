
using System.Numerics;

class Player
{ 
    
    // 일반 멤버 변수
    //객체가 만들어질때 마다 하나씩 생긴다.     
    private int HP = 100;

    public void Damage(int damage)
    {
        HP -= damage;
    }

    public int GetHP() 
    { 
        return HP; 
    }

    // 정적 멤버 변수만을 정적 멤버 함수에서 사용할 수 있다
    private static int StTest = 100;

    public static void PVP(Player _Left, Player _Right)
    {
        StTest = 50;
    }
}


namespace _11This
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();
            Player NewPlayer3 = new Player();

            NewPlayer2.Damage(200);

            Console.WriteLine(NewPlayer2.GetHP());
            

            Player.PVP(NewPlayer1, NewPlayer2);


        }
    }
}

// 멤버 함수에서 멤버 변수를 쓸 때 눈에 보이지는 않지만 앞에  this 즉 자기자신의 인자가 생략된것이다.
// 그래서 this.HP라고 표시를 해준다