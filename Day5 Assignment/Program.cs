namespace Day5_Assignment
{

    struct Weapon
    {
        public String name;
    }

    struct Soilder
    {
        public Weapon[] weapons;
        public int wIndex;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //weapons 배열 초기화 1번 장착중
            Soilder soilder = new Soilder() { weapons = new Weapon[3], wIndex = 1 };

            soilder.weapons[0].name = "칼";
            soilder.weapons[1].name = "총";
            soilder.weapons[2].name = "뿅망치";


            //인벤토리 출력
            Console.WriteLine("보유중인 무기\n");

            for (int i = 0; i < soilder.weapons.Length; i++)
            {


                Console.Write($"{i + 1}. " + soilder.weapons[i].name);

                //장착중인 무기 표시
                if (soilder.wIndex - 1 == i)
                {
                    Console.WriteLine("  (장착 중) ");
                }
                else
                {
                    Console.WriteLine();
                }
            }


            //무기 선택
            while (true)
            {

                Console.WriteLine("\n몇번 무기를 선택 하겠습니까?");
                int selectNum;

                if (!int.TryParse(Console.ReadLine(), out selectNum))
                {
                    Console.WriteLine("제대로 입력해주세요\n");
                    continue;

                }
                if (0 < selectNum && selectNum < 4)
                {
                    if (selectNum == soilder.wIndex)
                    {
                        Console.WriteLine("현재 들고 있는 무기와 동일합니다 다시 입력해주세요\n");
                    }
                    else
                    {
                        Console.WriteLine($"\n{soilder.weapons[selectNum - 1].name} 장착 완료\n");
                        soilder.wIndex = selectNum;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("제대로 입력해주세요\n");
                }
            }


            //함수 없이 한번 더 출력하고 끝
            for (int i = 0; i < soilder.weapons.Length; i++)
            {


                Console.Write($"{i + 1}. " + soilder.weapons[i].name);

                if (soilder.wIndex - 1 == i)
                {
                    Console.WriteLine("  (장착 중) ");
                }
                else
                {
                    Console.WriteLine();
                }
            }

        }
    }
}
