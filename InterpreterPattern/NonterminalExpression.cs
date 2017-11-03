namespace InterpreterPattern
{
	public class Add : RpnExpression
	{
		public RpnExpression _lhs = null;
		public RpnExpression _rhs = null;

		public Add(RpnExpression lhs, RpnExpression rhs)
		{
			_lhs = lhs;
			_rhs = rhs;
		}

		public override int Interpret()
		{
			return _lhs.Interpret() + _rhs.Interpret();
		}
	}

	public class Subtract : RpnExpression
	{
		private RpnExpression _lhs;
		private RpnExpression _rhs;
		public Subtract(RpnExpression lhs, RpnExpression rhs)
		{
			_lhs = lhs;
			_rhs = rhs;
		}
		public override int Interpret()
		{
			return _lhs.Interpret() - _rhs.Interpret();
		}
	}

	public class Divide : RpnExpression
	{

		private RpnExpression _lhs;
		private RpnExpression _rhs;

		public Divide(RpnExpression lhs, RpnExpression rhs)
		{
			_lhs = lhs;
			_rhs = rhs;
		}
		public override int Interpret()
		{
			return _lhs.Interpret() / _rhs.Interpret();
		}
	}

	public class Multiply : RpnExpression
	{
		private RpnExpression _lhs;
		private RpnExpression _rhs;

		public Multiply(RpnExpression lhs, RpnExpression rhs)
		{
			_lhs = lhs;
			_rhs = rhs;
		}
		public override int Interpret()
		{
			return _lhs.Interpret() * _rhs.Interpret();
		}
	}
}