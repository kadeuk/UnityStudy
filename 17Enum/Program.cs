
// Enum은 사용자 정의 자료형중 하나다. 개발자가 만드는 자료형
// class , struct, Enum


// 상태를 표현하는 것중에 
// 나만의 것을 가지고 싶을때 사용한다.
// 상수의 집합이다.
// 인덱스는 0 부터 매겨지고 중간에 10이라고 값을 주면 다음부터는 자동으로 11이된다
enum ITEMTYPE
{
    EQUIQ,
    POTION,
    QUEST,
    NONESELECT
}

class Item
{
    public ITEMTYPE ItemType = ITEMTYPE.NONESELECT;
}

namespace _22Enum
{
    class Program
    {
        static void Main(string[] args) 
        {
            Item NewItem = new Item();
            NewItem.ItemType = ITEMTYPE.QUEST;

            ITEMTYPE Type = ITEMTYPE.QUEST;

          }
    }
}