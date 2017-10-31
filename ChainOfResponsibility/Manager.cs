using System;

namespace ChainOfResponsibility
{
	// Concrete Handler
	public class Manager : POApprover
	{
		public Manager(POApprover successor)
		{
			_successor = successor;
		}
		public override void ProcessRequest(decimal price)
		{
			// handle PO if the price is less than $10,000
			if (price <= 10000)
			{
				Console.WriteLine("${0} purchase approved by {1}", price, this.GetType().Name);
			}
			else if (_successor != null)
			{
				// pass the request to the successor
				_successor.ProcessRequest(price);
			}
		}
	}
}