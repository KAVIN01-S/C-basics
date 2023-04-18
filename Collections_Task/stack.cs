using System;


namespace collection
{
    //Exampl class for SortedList
    class Stack_Example
    {
        //Main method
        public static void main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();

            //Push method to add elements into stack
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            //Count method to display the number elements in the stack
            Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);

            //peek to display the elemnt in the top of the stack
            Console.WriteLine("Element int the top of the stack is :"+myStack.Peek());

            //Traversing through stack
            Console.WriteLine("Elements in the stack are");
            while (myStack.Count > 0)
            {
                //pop method to remove element in the top of the stack
                Console.Write(myStack.Pop() + ",");
            }
            Console.WriteLine();

            Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);


            myStack.Push(5);
            myStack.Push(6);
            myStack.Push(7);

            //Contains method to check whether the assigned element is present in the stack
            if(myStack.Contains(2))
            {
                Console.WriteLine("Yes, element 2 is in the stack");
            }
            else
            {
                Console.WriteLine("No, the element is not present in the stack");
            }

            //Delete all the elements in the stack
            myStack.Clear();

        }
    }
}