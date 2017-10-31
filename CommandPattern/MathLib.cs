namespace CommandPattern
{
	// Receiver
	public class MathLib
	{
		// the current value of the math library
		protected int _value = 0;

		public int Value
		{
			get { return _value; }
		}

		/// <summary>
		/// Perform the additiona action
		/// </summary>
		public void Add(int argument)
		{
			_value += argument;
		}

		/// <summary>
		/// Perform the subraction action
		/// </summary>
		public void Subtract(int argument)
		{
			_value -= argument;
		}

		/// <summary>
		/// Perform the multiplication action
		/// </summary>
		public void Multiply(int argument)
		{
			_value *= argument;
		}

		/// <summary>
		/// Perform the division action
		/// </summary>
		public void Division(int argument)
		{
			_value /= argument;
		}

		public void Action()
		{
			throw new System.NotImplementedException();
		}
	}
}