namespace ChainOfResponsibility
{
	// Handler
	public abstract class POApprover
	{
		// the reference to the next handler in the chain
		protected POApprover _successor;

		/// <summary>
		///  Process a request
		/// </summary>

		public abstract void ProcessRequest(decimal price);
	}
}