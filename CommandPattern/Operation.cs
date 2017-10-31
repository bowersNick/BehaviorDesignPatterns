using System;

namespace CommandPattern
{
	// ConcreteCommand
	public class Operation : AbstractOperation
	{
		// the math library to use (the receiver)
		private readonly MathLib _mathlib; // = null;

		// the math operation to use
		private readonly string _operation; // = null;

		// the argument to use
		private readonly int _argument; // = 0;

		/// <summary>
		/// Initializes a new instance of the <see cref="CalculateExample"/>
		/// </summary>

		public Operation(MathLib mathlib, string operation, int argument)
		{
			_mathlib = mathlib;
			_operation = operation;
			_argument = argument;
		}


		public override void Execute()
		{
			switch (_operation)
			{
				case "+":
					_mathlib.Add(_argument);
					break;

				case "-":
					_mathlib.Subtract(_argument);
					break;

				case "*":
					_mathlib.Multiply(_argument);
					break;

				case "/":
					_mathlib.Division(_argument);
					break;

				default:
					throw new InvalidOperationException("Invalid math operation");
			}
			;
		}

		public override AbstractOperation Inverse
		{
			get
			{
				switch (_operation)
				{
					case "+":
						return new Operation(_mathlib, "-", _argument);

					case "-":
						return new Operation(_mathlib, "+", _argument);

					case "*":
						return new Operation(_mathlib, "/", _argument);

					case "/":
						return new Operation(_mathlib, "*", _argument);

					default:
						return null;
				}
			}
		}
	}
}