using System;

namespace Queen_sGambit
{
    class Program
    {
		public static void Main(string[] args)
		{
			Move(0);

		}
		static int[] x = new int[8];
		static void Print()
		{
			for (int j = 0; j < 8; j++)
			{
				Console.Write(x[j] + 1);
			}
			Console.Write("\n");
		}
		static int Free(int xx, int yy)
		{
			for (int i = 0; i < yy; i++)
			{
				if ((x[i] == xx) || (Math.Abs(x[i] - xx) == Math.Abs(i - yy)))
				{
					return 0;
				}
			}
			return 1;
		}
		static void Move(int n)
		{
			if (n == 8)
			{
				Print();
			}
			else
			{
				for (int i = 0; i < 8; i++)
				{
					if (Free(i, n) != 0)
					{
						x[n] = i;
						Move(n + 1);
					}
				}
			}
		}

	}
}