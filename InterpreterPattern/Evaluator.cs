using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
	public class Evaluator
	{
		public RpnExpression Parse(string text)
		{
			Stack<RpnExpression> stack = new Stack<RpnExpression>();

			// parse the text
			string[] words = text.Split(' ');
			foreach (string word in words)
			{
				RpnExpression lhs = null, rhs = null;
				switch (word)
				{
					case "+":
						rhs = stack.Pop();
						lhs = stack.Pop();
						stack.Push(new Add(lhs, rhs));
						break;

					case "-":
						rhs = stack.Pop();
						lhs = stack.Pop();
						stack.Push(new Subtract(lhs, rhs));
						break;

					case "*":
						rhs = stack.Pop();
						lhs = stack.Pop();
						stack.Push(new Multiply(lhs, rhs));
						break;

					case "/":
						rhs = stack.Pop();
						lhs = stack.Pop();
						stack.Push(new Divide(lhs, rhs));
						break;

					default:
						int number = int.Parse(word);
						stack.Push(new Number(number));
						break;
				}
			}
			return stack.Pop();
		}
	}
}
