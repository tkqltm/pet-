using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Rice = 30; // 밥주기
            int play = 30; // 놀아주기
            int Satiety = 30; // 포만감
            int Intimacy = 30; // 친밀도
            int die = 0; // 사망할때

            Console.WriteLine("안녕하세요.\r\n펫의 이름을 정해주세요.");
            Console.WriteLine();
            string name = Convert.ToString(Console.ReadLine()); // 이름 정하기

            Console.WriteLine("펫의 이름은 {0} 입니다.",name);

            Console.WriteLine("명령어는 1번 밥주기, 2번 놀아주기, 3번 몸상태 체크입니다.");
            while (true)
            {
                int number = Convert.ToInt32(Console.ReadLine()); // 명령어
                switch (number)
                {
                    case 1: // 밥주기
                        if (Satiety > 100)
                        {
                            Console.WriteLine("{1}의 포만감이 100 이상이여서 밥을 줄수가 없습니다.{0}", Satiety, name);
                            break;
                        }
                        else if (Satiety < 70)
                        {
                            Console.WriteLine("{1}에게 먹을것을 주었습니다. 포만감이 +30이 증가합니다.{0}", Satiety += Rice, name);
                            break;
                        }
                        else if (71 <= Satiety && Satiety < 100)
                        {
                            Console.WriteLine("현재 {0} 이/가 배가 부른 상태 (포만감{1})입니다.",name,Satiety);
                            break;
                        }
                        break;
                    case 2: // 놀아주기
                        if (Satiety <= die)
                        {
                        Console.WriteLine("포만감이 너무 낮아 {0}이 사망했습니다.",name);
                        break;
                        }
                        Console.WriteLine("{2}이랑 놀아 주었습니다. 친밀도가 +30 증가하여 {0} 이며 포만감이 -30 감소하여 {1} 입니다.",Intimacy+=play,Satiety-=play,name);
                        break;
                    case 3: // 상태확인
                        Console.WriteLine("{2}의 현재 몸상태는 포만감 {0} 친밀도 {1} 입니다.", Satiety, Intimacy,name);
                        break;
                    default:
                        Console.WriteLine("1~3번 숫자만 입력해주세요.");
                        break;
                }
            }
        }
    }
}
