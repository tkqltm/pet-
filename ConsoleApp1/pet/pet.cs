using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.pet
{
    class pet
    {
        public void Run()
        {
            int Rice = 30; // 밥주기
            int play = 30; // 놀아주기
            int Satiety = 50; // 포만감
            int Intimacy = 50; // 친밀도
            int die = 0; // 사망할때
            int bodycheck = Satiety + Intimacy;

            Console.WriteLine("안녕하세요. ");
            Console.WriteLine("명령어는 1번 밥주기, 2번 놀아주기, 3번 몸상태 체크입니다.");
            int number = Convert.ToInt32(Console.ReadLine());


            if (number == 1)
            {
                Console.WriteLine("펫에게 먹을것을 주었습니다. 포만감이 +30이 증가합니다.{0}", Satiety + Rice);
            }
        }
    }
}
