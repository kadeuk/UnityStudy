
struct StructData
{
    // 클래스와 비슷한데 안되는 것이 있다.
    // 리터널 초기화. 즉 = 0; 이 안된다 
    // 왜냐하면 = 0; 이 기본이다
    // struct 는 값형이다. 클래스는 레퍼런스 형이라 힙에 저장이되고 struct는 스택에 만들어진다.
    // 중요한 개념은 함수안에 있는 변수를 다른함수에 사용한다고 해서 기존 함수안에 있는 변수가 변하지 않는다는것이다.
    // 새로운 함수에 복사되서 새로운 값이 생겨나는거다. 다른 함수에 참조된다고해서 값이 바뀌지 않는다.
    // 클래스는 다름함수에 들어가면 힙이 변하기 때문에 값이 변한다.
    public int a;

    public void Fund()
    {
        a = 100;

    }
}




namespace _16Struct
{
    class Program
    {
        static void Main(string[] args)
        {
        
            StructData NewData = new StructData();
            NewData.a = 100;    

        }
    }
}