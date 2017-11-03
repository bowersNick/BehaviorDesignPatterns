namespace InterpreterPattern
{
	public class Number : RpnExpression
	{
		protected int _value = 0;

		public Number(int value)
		{
			_value = value;
		}
		public override int Interpret()
		{
			return _value;
		}
	}
}