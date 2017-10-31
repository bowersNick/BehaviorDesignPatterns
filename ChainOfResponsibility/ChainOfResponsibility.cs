﻿namespace ChainOfResponsibility
{
	public static class ChainOfResponsibility
	{
		public static void ChainCall()
		{
			// set up PO system
			var poSystem = new POSystem();

			// feed some purchase order requests into the chain
			poSystem.ProcessRequest(1000);
			poSystem.ProcessRequest(20000);
			poSystem.ProcessRequest(300000);
		}
	}
}
