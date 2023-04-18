using System;

namespace collection
{
    //Exampl class for Dictionary
    class Dictionary_Example
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> map = new Dictionary<int, string>();

            //adding key value pairs in Dictionary
            map.Add(1,"Kavin");
            map.Add(2,"Nikil");
            map.Add(3,"Yashwanth");
            map.Add(4,"sadhashivam");
            map.Add(5,"Sujith");
            map.Add(6,"Vigneshwaran");

            //removing the element with specified keys
            map.Remove(6);

            //checking whether the given key exists in Dictionary
            var result = map.ContainsKey(2)? "Yes it Exists" : "No it doesn't exists";
            Console.WriteLine(result);

            //checking whether the given Value exists in Dictionary
            result = map.ContainsValue("Nikil")? "Yes it Exists" : "No it doesn't exists";
            Console.WriteLine(result);

            //counting the number of Key Value Pairs
            Console.WriteLine(map.Count);

            //traversing through Dictionary 
            foreach(KeyValuePair<int,string> pairs in map)
            {
                Console.WriteLine("Key :"+" "+pairs.Key +"    "+"Value :"+" "+pairs.Value);
            }

            //Removing all elements from the Dictionary
            map.Clear();
            Console.WriteLine("All Elements in the Dictionary are removed");
        }
    }
}
