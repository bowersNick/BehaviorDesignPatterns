namespace ChainOfResponsibility
{
	/// <summary>
	/// The POSystem client class
	/// </summary>
	public class POSystem
	{
		// the PO approval chain
		protected POApprover approvalChain = null;


		public POSystem()
		{
			// set up a chain of purchase order approvers
			approvalChain = new Manager(
					new VicePresident(
					new CEO(null)));
		}

		public void ProcessRequest(decimal price)
		{
			approvalChain.ProcessRequest(price);
		}
	}
}