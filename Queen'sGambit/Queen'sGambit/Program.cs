using System;

namespace Queen_sGambit
{
	class Program
	{
		public static void Main(string[] args)
		{
			Move(0);

		}
		// TODO [print - bechdavs x masivs, pasuxi inaxeba 8 elementian masivsshi]
		static int[] x = new int[8];
		static void Print()
		{
			for (int j = 0; j < 8; j++)
			{
				Console.Write(x[j] + 1);
			}
			Console.Write("\n");
		}
		// ? [Free- amowmebs aris tuara konkretuli ujra dartymis kvesh akamde dadebuli lazierebisagan]
		static int Free(int xx, int yy)
		{
			for (int i = 0; i < yy; i++)
			{
				// ! [1. erti da igive striqonshi hoardevs 2 lazieri]
				// ! [2. diagonalze aris tuara ori lazieri]
				if ((x[i] == xx) || (Math.Abs(x[i] - xx) == Math.Abs(i - yy)))
				{
					return 0;
				}
			}
			return 1;
		}
		// [Rekursiuli function Move]
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
