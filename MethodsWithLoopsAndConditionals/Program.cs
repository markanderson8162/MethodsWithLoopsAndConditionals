using System;

namespace MethodsWithLoopsAndConditionals
{
	class Program
	{
		public static void TwoThousandIntegers()
		{
			for (int i = -1000; i < 1000; i++)
			{
				Console.WriteLine(i);
			}

		}

		public static void ByThrees()
		{
			for (int i = 0; i < 999; i += 3)
			{
				Console.WriteLine(i);
			}
		}

		public static void IsNumberEven()
		{
			Console.WriteLine("Type a number and I'll tell you if it's even or odd.");
			int number = int.Parse(Console.ReadLine());
			int newNumber = number % 2;
			string oddOrEven = "";
			bool continueInput = true;
			//if user input != "exit" then keep going

			if (newNumber == 0)
			{
				oddOrEven = "even";


			}
			else if (newNumber != 0)
			{
				oddOrEven = "odd";


			}

			Console.WriteLine($"{number} is {oddOrEven}");

		}

		public static void IsPositiveNegative()
		{
			Console.WriteLine("Type a number and I'll tell you if it's positive or negative.");
			int number = int.Parse(Console.ReadLine());
			int newNumber = number * 1;
			string plusOrMinus = "";

			if (newNumber > 0)
			{
				plusOrMinus = "positive";
			}
			else
			{
				plusOrMinus = "negative";
			}
			Console.WriteLine($"{number} is {plusOrMinus}");

		}

		public static void CanVote()
		{
			Console.WriteLine("What is your age?");
			var ageToVote = int.Parse(Console.ReadLine());
			if (ageToVote >= 18)
			{
				Console.WriteLine("You can vote.");
			}
			else
			{
				Console.WriteLine("You cannot vote");
			}
		}

		public static void RangeFrom10To10()
		{
			Console.WriteLine("Type a number between -10 and 10");
			int number = int.Parse(Console.ReadLine());
			if (number < -10)
			{
				Console.WriteLine("That number is too low!");
			}
			else if (number > 10)
			{
				Console.WriteLine("That number is too high!");
			}
			else
			{
				Console.WriteLine("Okay, thanks.");
			}
		}

		public static void TwelveTables()
		{
			Console.WriteLine("Enter any number and I'll multiply it from 1-12.");
			int number = int.Parse(Console.ReadLine());
			Console.WriteLine("");
			for (int i = 0; i <= 12; i++)
			{
				Console.WriteLine(number * i);
			}

		}

		static void Main(string[] args)
		{
			TwoThousandIntegers();
			ByThrees();
			IsNumberEven();
			IsPositiveNegative();
			CanVote();
			RangeFrom10To10();
			TwelveTables();
		}
	}
}
