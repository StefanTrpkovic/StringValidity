using System;
using System.Linq;

namespace StringValidityNamespace
{
	public class StringValidity
	{
		public static string ReadInput()
		{
			return Console.ReadLine();
		}

		public static void Main()
		{
			string inputLine = ReadInput();

			bool isStrinCorrect = IsStringCorrect(inputLine);

			if (!isStrinCorrect)
			{
				if (IsStringCorrectByRemovingChar(inputLine))
				{
					Console.Write("Correct String");
				}
				else
				{
					Console.Write("Not Correct String");
				}
			}
			else
			{
				Console.Write("Correct String");
			}
		}

		public static bool IsStringCorrect(string input)
		{
			int count = input.Count(character => character == input[0]);
			for (int i = 1; i < input.Length; i++)
			{
				int newCount = input.Count(character => character == input[i]);
				if (newCount != count) return false;
			}

			return true;
		}

		public static bool IsStringCorrectByRemovingChar(string input)
		{
			bool isStringOK = false;

			for (int i = 0; i < input.Length; i++)
			{
				bool isCurrentStringOK = true;
				string stringRemoved = input.Remove(i, 1);
				int count = stringRemoved.Count(character => character == stringRemoved[0]);
				for (int j = 1; j < stringRemoved.Length; j++)
				{
					int newCount = stringRemoved.Count(character => character == stringRemoved[j]);
					if (newCount != count)
					{
						isCurrentStringOK = false;
						break;
					}
				}

				if (isCurrentStringOK)
				{
					isStringOK = true;
					break;
				}
			}

			return isStringOK;
		}
	}
}