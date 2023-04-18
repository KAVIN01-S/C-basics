using System.Collections;
namespace Collection
{
    class Queue_Example
    {
        public static void Main(string[] args)
        {
            //Object created for Queue class
            Queue queue= new Queue();
            //Elements are added into Queue
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            //Displaying the number of elements
            Console.WriteLine(queue.Count);
            
            Console.WriteLine("Elements in queue before removing an element");
            foreach(var id in queue)
            {
                Console.Write(id+" ");
            }

            //removing the first element from queue
            Console.WriteLine("Element removed");
            Console.WriteLine(queue.Dequeue());

            //element at the front
            Console.WriteLine("Element at the front");
            Console.WriteLine(queue.Peek());

            //checking whether the specified element is present in the queue or not
            if(queue.Contains(4))
            {
                Console.WriteLine("Element 4 is present");
            }

            //Iterating through queue
            foreach(var id in queue)
            {
                Console.Write(id+" ");
            }
            //removes all elements from Queue
            queue.Clear();
        }
    }
}