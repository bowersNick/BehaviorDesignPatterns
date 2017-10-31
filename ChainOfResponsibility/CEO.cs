using System;

namespace ChainOfResponsibility
{
	// Concrete Handler
	public class CEO : POApprover
	{
		public CEO(POApprover successor)
		{
			_successor = successor;
		}
		public override void ProcessRequest(decimal price)
		{
			// handle PO if the price is less than $100,000
			if (price <= 100000)
			{
				Console.WriteLine("${0} purchase approved by {1}", price, this.GetType().Name);
			}
			else
			{
				Console.WriteLine("Plan executive meeting to approve ${0} purchase", price);

			}
		}
	}
}