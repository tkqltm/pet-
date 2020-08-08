using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public enum ETrainingMenu { SIT = 1, HAND, JUMP, DOWN, BITE, BARK }

	struct Data
	{
		public ETrainingMenu trainingMenu;
		public string name; // 이름
		public int satiety; // 포만감
		public int intimacy; // 친밀도
	}

	public class Pet
	{
		Data data = new Data();

		public void SetName()
		{
			TextManager.Instance.HorizontalLine(ELinePosition.UP, 50, 1);
			Console.WriteLine("펫의 이름을 정해주세요!");

			//Console.Write("입력: ");
			data.name = TextManager.Instance.Input();

			Console.WriteLine("펫의 이름은 {0} 입니다.", data.name);


		}

		public void Eat(int satietyPoint)
		{
			Console.WriteLine("밥을 먹었습니다.");
			Console.WriteLine("{0}의 포만감이 +{1} 증가 하였습니다.", data.name, satietyPoint);
			data.satiety += satietyPoint;
		}

		public void Play(int intimacyPoint) // 놀아주기 
		{
			Console.WriteLine("{0}를 놀아주어서 친밀도가 +{1} 증가 하였습니다.", data.name, intimacyPoint);
			data.intimacy += intimacyPoint;
		}

		public void Info()
		{
			Console.WriteLine("펫의 이름 : {0}", data.name);
			Console.WriteLine("포만감 : {0}", data.satiety);
			Console.WriteLine("친밀도 : {0}", data.intimacy);
		}

		public void TRAINING()
		{
			TextManager.Instance.HorizontalLine(ELinePosition.UP, 50, 1);

			Console.Write("1.앉아 ");
			Console.Write("2.손 ");
			Console.Write("3.점프 ");
			Console.Write("4.누워 ");
			Console.Write("5.짖어 ");
			Console.Write("6.물어 ");

			TextManager.Instance.SetSpace(1);
			data.trainingMenu = (ETrainingMenu)Convert.ToInt32(TextManager.Instance.Input());

			switch (data.trainingMenu)
			{
				case ETrainingMenu.SIT:
					Console.WriteLine("SIT");
					break;

				case ETrainingMenu.HAND:
					break;

				case ETrainingMenu.JUMP:
					break;

				case ETrainingMenu.DOWN:
					break;

				case ETrainingMenu.BITE:
					break;

				case ETrainingMenu.BARK:
					break;
			}


			/*
				 /\_/\✿
				/ ๑_๑ \ 
				|>   <|
				\-----/--o
				 u   u
		ㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁ


				 /\_/\
				/ >_< \
				|>   <|
				\-----/--o			
		ㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁ

				 /\_/\
				/ \ / \
			   <|  ㅁ |>
				\-----/--o			
		ㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁ


			*/
		}
		public void Behavior(EKind kind)
		{
			switch (kind)
			{
				case EKind.EAT:
					Eat(10);
					break;

				case EKind.PLAY:
					Play(15);
					break;

				case EKind.INFO:
					Info();
					break;

				case EKind.TRAINING:
					TRAINING();
					break;
			}
		}
	}


	/*
	 데이터적인 성격이 강하면 = 변수
	 기능적인 성격이 강하면 = 함수
	*/
}
