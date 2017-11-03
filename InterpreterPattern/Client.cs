using System;

namespace InterpreterPattern
{
	public class Client
	{
		private static RpnExpression _rpnResult;

		public static void Main()
		{
			string result;
			Console.Write("Enter q to quit, otherwise...");
			do
			{
				Console.Write("Enter RPN expression: ");
				result = Console.ReadLine();

				Evaluator evaluator = new Evaluator();
				_rpnResult = evaluator.Parse(result);
				Console.WriteLine("Result: {0}", _rpnResult.Interpret());

			} while (!result.Contains("q"));
		}
	}
}