using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public enum EKind
	{
		INFO = 1, EAT, PLAY, TRAINING, WAR, SHOWER, SLEEP, NONE
	}

	public class LogicManager : Singleton<LogicManager>
	{
		Pet pet = new Pet();

		public void SetPet()
		{
			pet.SetName();
		}

		public void ShowCommand()
		{
			TextManager.Instance.HorizontalLine(ELinePosition.UP, 50, 1);

			Console.Write("1.정보보기 ");
			Console.Write("2.밥주기 ");
			Console.Write("3.놀아주기 ");
			Console.Write("4.훈련하기 ");

			TextManager.Instance.SetSpace(1);
		}

		public void ShowInputInfo(EKind kind)
		{
			switch (kind)
			{
				case EKind.EAT:
					Console.WriteLine("밥주기 선택");
					break;

				case EKind.PLAY:
					Console.WriteLine("놀아주기 선택");
					break;

				case EKind.INFO:
					Console.WriteLine("정보보기 선택");
					break;

				case EKind.TRAINING:
					Console.WriteLine("훈련하기 선택");
					break;

			}
		}

		public void Logic()
		{
			EKind kind;

			// 유저에게 명령어를 보여준다.
			ShowCommand();

			// 유저가 명령어를 입력한다.
			kind = (EKind)Convert.ToInt32(TextManager.Instance.Input());

			// 유저가 입력한 명령어를 출력 해준다.
			ShowInputInfo(kind); // Kind _kind  = kind;

			// 유저가 입력한 명령어에 따라 펫이 행동한다.
			pet.Behavior(kind);

		}

	}
}
