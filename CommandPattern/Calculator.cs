using System.Collections.Generic;

namespace CommandPattern
{
	// Invoker
	public class Calculator
	{
		// the undo command stack
		protected Stack<AbstractOperation> undoStack = new Stack<AbstractOperation>();

		public void Invoke(AbstractOperation operation)
		{
			operation.Execute();
			undoStack.Push(operation);
		}

		public void Undo()
		{
			var operation = undoStack.Pop();
			operation.Inverse.Execute();
		}
	}
}