



class Player
{
    int AT = 10;
    int HP = 50;
    int MAXHP = 100;

    // 그 객체의 멤버변수와 관련되 코드를 두번이상 복붙할꺼면 함수로 만들어라
    public void PrintHp()
    {
        if (HP != 100)
        {
            MaxHeal();
            Console.WriteLine("");
            Console.WriteLine($"현제 플레이어의 HP는 {HP}입니다.");
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine($"HP가 모두 회복 되었습니다.");
        }
        
    }


    // HP앞에는 this.HP가 있어서. 객체마다의 HP가 되는거다. 
    // 이렇게 public으로 int 변수를 쓰는게 아니고 함수로 만들어서 int 변수의 변화를 줘야한다.
    // 그리고 함수 MaxHeal() 안에는 MaxHeal(Player this)가 숨겨져있다.
    public void MaxHeal()
    {
        HP = MAXHP;
        PrintHp();
        return;
    }

    public void StatusRender()
    {
        Console.WriteLine("---------------------------");
        Console.WriteLine($"공격력: {AT}");
        Console.WriteLine($"체력: {HP}/{MAXHP}");
        Console.WriteLine("---------------------------");
    }
}

class Monster
{
    int AT = 10;
    int HP = 50;

    public void StatusRender()
    {
        Console.WriteLine("---------------------------");
        Console.WriteLine($"공격력: {AT}");
        Console.WriteLine($"체력: {HP}/{MAXHP}");
        Console.WriteLine("---------------------------");
    }
}


// enum 을 만들때는에러나 혹은 잘못된 선택에 관헌것도 만든다.
enum STARTSELECT
{
    SELECTTOWN,
    SELECTBATTLE,
    NONESELECT,
}


namespace TextRpg001
{
    class Program
    {
        
        // 초기 선택
        // 1. 마을로 간다
        // 2. 싸움터로 간다.
        // 마을의 내용
        // 마을에 도착했습니다. 출력
        // 1. 여관에 들른다.
        // 2. 공격력을 강화한다.
        // 3. 나간다.


        // 어디로 갈지 선택하는 함수
        static STARTSELECT StartSelect()
        {
            Console.Clear();
            Console.WriteLine("1. 마을");
            Console.WriteLine("2. 배틀");
            Console.WriteLine("어디로 가시겠습니까?");

            ConsoleKeyInfo CKI = Console.ReadKey();

            Console.WriteLine("");

            switch (CKI.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("마을로 이동합니다.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTTOWN;
                case ConsoleKey.D2:
                    Console.WriteLine("배틀을 시작합니다.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTBATTLE;
                default:
                    Console.WriteLine("잘못된 선택입니다.");
                    Console.ReadKey();
                    return STARTSELECT.NONESELECT;

            }

           
        }
        static void Town(Player _Player)
        {
            while (true)
            {
                Console.Clear();
                _Player.StatusRender();
                Console.WriteLine("마을에서 무슨일을 하시겠습니까?");
                Console.WriteLine("1. 체력을 회복한다");
                Console.WriteLine("2. 무기를 강화한다");
                Console.WriteLine("3. 마을을 나간다");

                Console.WriteLine("");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        _Player.MaxHeal();
                        
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("무기를 강화합니다.");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                        return;
                }
            }
            
        }

        static void Battle(Player _Player)
        {
            //Console.WriteLine("아직 개장하지 않았습니다.");
            //Console.ReadKey();

            while (true)
            {
                _Player.StatusRender();
            }

        }

        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            while (true)
            {
                STARTSELECT SelectCheck =  StartSelect();

                switch (SelectCheck)
                {
                    case STARTSELECT.SELECTTOWN:
                        Town(NewPlayer);
                        break;
                    case STARTSELECT.SELECTBATTLE:
                        Battle();
                        break;
                }   
            }
        }
    }
}