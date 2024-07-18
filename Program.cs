namespace Day5
{
    internal class Program
    {

        #region 열거형 과제 enum1
        enum movePlace
        {
            마을 = 1, 사냥터, 상점
        }
        #endregion


        #region 열거형 과제 enum2

        enum playerState
        {
            //1부터 시작             9부터 시작
            idle = 1, run, walk, dead = 9
        }

        #endregion

        #region 구조체 과제
        struct XYcoord
        {
            short x;
            short y;
        }

        struct Weapon
        {
            public int Dmg;
            public float Critical;
            public string Name;
        }

        enum CarMaker
        {
            Honda, Audi, BMW, KIA
        }

        struct Car
        {
            public float maxSpeed;
            public int carNumber;
            public CarMaker maker;
        }

        enum ItemType
        {
            방어구, 무기, 소모품
        }

        struct Item
        {
            public string name;
            public int price;
            public ItemType type;
        }
        #endregion
        
        static void Main(string[] args)
        {
           
            #region 배열 과제1
            int[] fourInt = new int[4];

            for(int i=0; i < fourInt.Length; i++)
            {
                Console.WriteLine($"{i+1}번 요소를 입력하여주십시오");

                //잘못된 값 예외처리
                if(!int.TryParse(Console.ReadLine(), out fourInt[i]))
                {
                    i--;
                    continue;
                }
               
                
            }

            Console.WriteLine();

            Console.WriteLine("입력된 요소는 다음과 같습니다");

            foreach(int i in fourInt){
                Console.Write($"{i} ");
            }


            Console.WriteLine();
            Console.WriteLine();

            #endregion


            #region 배열 과제2

            int[,] intArr;
            intArr = new int[4, 4];

            //3의 배수 구하기용 변수
            int mulCnt = 1;

            //요소 삽입 후 출력
            for (int i = 0; i < intArr.GetLength(0); i++)
            {
                for(int j = 0; j < intArr.GetLength(1); j++)
                {
                    intArr[i, j] = 3 * mulCnt;
                    mulCnt++;

                    //변환 전 요소 강조
                    if ((i == 1 && j == 2) || (i == 2 && j ==1)) {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    
                    Console.Write($"{intArr[i, j]}\t");

                    Console.ResetColor();
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //요소 변경
            int tempInt = intArr[1,2];
            intArr[1,2] = intArr[2,1];
            intArr[2, 1] = tempInt;

            //출력
            for (int i = 0; i < intArr.GetLength(0); i++)
            {
                for (int j = 0; j < intArr.GetLength(1); j++)
                {
                    if ((i == 1 && j == 2) || (i == 2 && j == 1))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }

                    Console.Write($"{intArr[i, j]}\t");

                    Console.ResetColor();
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            #endregion
            

            #region 배열 심화 과제

            //인벤 사이즈
            int invenSize;

            //인벤토리 배열
            String[] invenItem;

            //인벤 사이즈 입력과 예외 처리
            do
            {
                Console.WriteLine("1~10 사이의 원하는 인벤토리의 크기를 입력하세요");

                int.TryParse(Console.ReadLine(), out invenSize);

            }while(!(1<= invenSize && invenSize <= 10));

            //입력한 사이즈를 배열에 초기화
            invenItem = new String[invenSize];

            for (int i = 0; i < invenItem.Length; i++)
            {
                invenItem[i] = "비어있음";
            }

            Console.WriteLine($"{invenSize}개 만큼의 인벤토리가 생성되었습니다.");


            //인벤토리 무한 루프
            while (true)
            {
                //인벤토리 선택 변수
                int selectNum;
                Console.WriteLine("\n열람을 원하는 번호를 입력해주시기 바랍니다 (0 종료 11 전부 보기)");
             

                if (!int.TryParse(Console.ReadLine(), out selectNum))
                {
                    Console.WriteLine("올바른 수를 입력해 주세요");
                    continue;
                }

                if (selectNum == 0)
                {
                    break;
                }
                //인벤 전부 보기
                else if (selectNum == 11)
                {
                    Console.WriteLine();
                    foreach (String i in invenItem)
                    {
                        Console.Write($"{i} \t");
                    }
                    Console.WriteLine();
                    continue;
                }
                //인벤토리 크기만큼 예외 처리
                else if (!(1 <= selectNum && selectNum <= invenItem.Length))
                {
                    Console.WriteLine($"1~{invenSize} 사이의 번호를 입력 해주세요");
                    continue;
                }
                //인벤토리에 값 입력
                if (invenItem[selectNum-1] == "비어있음")
                {
                    Console.WriteLine("칸이 비어있습니다. 값을 입력하세요");
                    invenItem[selectNum-1] = Console.ReadLine();
                    Console.WriteLine("\n수납 완료\n");
                }
                else
                {
                    Console.WriteLine($"{invenItem[selectNum-1]} 들어있습니다");
                }

            }
            #endregion

            

            
            /*열거형 연습
         
            //강제 형변환으로 범위 밖일때 예외
            myEnum name3 = (myEnum)18;
 
            if (!Enum.IsDefined(typeof(myEnum), 18))
            {
                Console.WriteLine("범위밖이야");
            }
            */
          


            
            #region 열거형 과제 1

            Console.WriteLine("이동 할 장소를 설정해주세요");
            Console.WriteLine("1. 마을");
            Console.WriteLine("2. 사냥터");
            Console.WriteLine("3. 상점");

            movePlace toDetermine;

            Enum.TryParse(Console.ReadLine(), out toDetermine);
            Console.Clear(); //화면을 지워줍니다

            switch (toDetermine)
            {
                case movePlace.마을:
                    Console.WriteLine("마을로 이동합니다");
                    break;
                case movePlace.사냥터:
                    Console.WriteLine("사냥터로 이동합니다");
                    break;
                case movePlace.상점:
                    Console.WriteLine("상점으로 이동합니다");
                    break;
                default:
                    Console.WriteLine("1,2,3 어느것도 아니에요");
                    break;
            }
            #endregion

            #region 열거형 과제 2

            playerState state;

            while (true)
            {
                Console.WriteLine("\n플레이어의 상태를 입력해주세요 1, 2, 3, 9");
                Enum.TryParse(Console.ReadLine(), out state);

                if (!Enum.IsDefined(typeof(playerState), state))
                {
                    Console.WriteLine("다시 입력해주세요 1, 2, 3, 9");
                    continue;
                }

                Console.WriteLine($"\n{state}\n");

                break;
            }
            #endregion
            


            #region 구조체 과제
            Weapon Sword = new Weapon();
            Sword.Dmg = 30;
            Sword.Critical = 1.5f;
            Sword.Name = "검";

            Weapon Katana = new Weapon();
            Katana.Dmg = 20;
            Katana.Critical = 5.5f;
            Katana.Name = "태도";

            Console.WriteLine($"데미지 {Sword.Dmg} 크리티컬 확률 {Sword.Critical} 이름 {Sword.Name}\t");
            Console.WriteLine($"데미지 {Katana.Dmg} 크리티컬 확률 {Katana.Critical} 이름 {Katana.Name}\t\n");


            Item[] inven = new Item[3];


            Item weapon = new Item();
            //식 단순화
            Item consumable = new();
            //식 단순화+선언하면서 초기화
            Item armor = new() { name = "악몽의 꽃 견갑", price = 500, type = ItemType.방어구 };
          
            weapon.name = "검";
            weapon.price = 200;
            weapon.type = ItemType.무기;

            consumable.name = "포션";
            consumable.price = 50;
            consumable.type = ItemType.소모품;



            inven[0] = weapon;
            inven[1] = consumable;
            inven[2] = armor;
  
            for (int i = 0; i< 3; i++)
            {
                Console.WriteLine(inven[i].name);
                Console.WriteLine(inven[i].price+ "원");
                Console.WriteLine(inven[i].type);
                Console.WriteLine();
            }
            #endregion


        }
    }
}
