namespace CommandPattern
{
	// Command
	public abstract class AbstractOperation
	{
		public abstract void Execute();

		public abstract AbstractOperation Inverse { get; }
	}
}