using ConsoleApp1;
using System;

public enum ELinePosition
{
	UP, DOWN
}

public class TextManager : Singleton<TextManager>
{
	public void HorizontalLine(ELinePosition linePosition = ELinePosition.UP, int lineSize = 0, int spaceSize = 0)
	{
		switch (linePosition)
		{
			case ELinePosition.UP:
				SetSpace(spaceSize);
				SetLine(lineSize);
				break;

			case ELinePosition.DOWN:
				SetSpace(1);
				SetLine(lineSize);
				SetSpace(spaceSize);
				break;
		}
	}

	public void SetLine(int lineSize)
	{
		if (lineSize == 0)
		{
			Console.WriteLine("--------------------------------------------------");
			return;
		}

		for (int idx = 0; idx < lineSize; idx++)
		{
			Console.Write("-");
		}
		Console.WriteLine("");
	}

	public void SetSpace(int spaceSize)
	{
		for (int idx = 0; idx < spaceSize; idx++)
		{
			Console.WriteLine("");
		}
	}

	public string Input()
	{
		HorizontalLine(ELinePosition.UP);

		SetSpace(1);
		Console.Write("입력: ");
		string text = Console.ReadLine();
		return text;
	}
}


/*
---------------------------------
1. 선택 2. 선ㄴ택 3. 정보보기 4.선택 선택: 3
---------------------------------

--------------
정보
포만감: 10
--------------

--------------
정보보기
포만감: 10
--------------

--------------------
x 스페이스가
정보보기
포만감: 10
------------------

------------------
1칸들어가면
선택1:
정보보기 선택
-----------------

--------------------
정보보기
포만감: 10
--------------

*/