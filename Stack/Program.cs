using System;

namespace StackImplementation
{

	class Program
	{
		static void Main(string[] args)
		{
			Stack myStack = new Stack();

			myStack.Push(10);
			myStack.Push(20);
			myStack.Push(30);
			myStack.Push(40);
			myStack.PrintStack();
			myStack.Peek();
			Console.WriteLine("Item popped from Stack : {0}", myStack.Pop());
			myStack.PrintStack();
		}
	}
	public class Stack
	{
		static readonly int MAX = 1000;
		int top;
		int[] stack = new int[MAX];

		bool IsEmpty()
		{
			return (top < 0);
		}
		public Stack()
		{
			top = -1;
		}
		public bool Push(int data)
		{
			if (top >= MAX)
			{
				Console.WriteLine("stack overflow");
				return false;
			}
			else
			{
				stack[++top] = data;
				return true;
			}
		}

		public int Pop()
		{
			if (top < 0)
			{
				Console.WriteLine("stack underflow");
				return 0;
			}
			else
			{
				int value = stack[top--];
				return value;
			}
		}

		public void Peek()
		{
			if (top < 0)
			{
				Console.WriteLine("stack underflow");
				return;
			}
			else
				Console.WriteLine("The top element in the Stack : {0}", stack[top]);
		}

		public void PrintStack()
		{
			if (top < 0)
			{
				Console.WriteLine("stack underflow");
				return;
			}
			else
			{
				Console.WriteLine("Items in Stack are :");
				for (int i = top; i >= 0; i--)
				{
					Console.WriteLine(stack[i]);
				}
			}
		}
	}

	
}
