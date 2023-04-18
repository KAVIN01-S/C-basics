using System.Collections;

namespace Collection
{
    //Exampl class for Dictionary
    class List_Example
    {
        public static void main(string[] args)
        {
            //Array of string with city names
            string[] cities_arr = new string[3]{ "Mumbai", "London", "New York" };

            List<string> cities = new List<string>();

            // adding an array in a List
            cities.AddRange(cities);

            //Adding elements to the list 
            cities.Add("Chennai");
            cities.Add("Banglore");
            cities.Add("Coimbatore");
            cities.Add("Mumbai");
            
            //checking whether the specified element is present or not
            var numbers = new List<int>(){ 100, 10, 2550, 4 };
            numbers.Contains(10); // returns true
            numbers.Contains(11); // returns false

            //Sorting
            numbers.Sort();

            //BinarySearch method to search an element in the List

            if(numbers.BinarySearch(10)!=-1)
            {
                Console.WriteLine("Element 10 is found");
            }
            else
            {
                Console.WriteLine("Element 10 is not Found!!");
            }

            //traversing through list
            foreach(var value in numbers)
            {
                Console.WriteLine(value+" ");
            }

            // remove an element
            numbers.Remove(10);
            numbers.RemoveAt(2);

            //Delete all elements from the List
            numbers.Clear();

            //find method to find an element in the list

        }
    }
}