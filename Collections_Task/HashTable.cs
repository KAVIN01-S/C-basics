using System.Collections;
namespace Collection
{
    //Example class for Dictionary
    class HashTable_Example
    {
        public static void main(string[] args)
        {
            //Object created for Hashtable
            Hashtable hash = new Hashtable();

            //adding elements to the hashtable
            hash.Add(1,"Kavin");
            hash.Add(2,"Nikil");
            hash.Add("Syed",3);
            hash.Add("Charan",4);

            //Displaying key value pairs stored in hashtable
            foreach(DictionaryEntry value in hash)
            {
                Console.WriteLine(value.Key +" "+ value.Value);
            }

            Console.WriteLine("After alteration");

            //If nikil is in hashtable changing the Value
            if(hash.ContainsValue("Nikil"))
            {
                hash[2]= "Nikil kutty";
            }

            //removing elements
            hash.Remove("Nikil");
            
            // Traversing through hashtable using GetEnumerator
            IDictionaryEnumerator denum = hash.GetEnumerator();
            DictionaryEntry dentry;

            Console.WriteLine();
            Console.WriteLine("    Iterating through Hashtable using GetEnuerator");
            Console.WriteLine("    ----------------------------------------------------");
            while (denum.MoveNext())
            {
                dentry = (DictionaryEntry) denum.Current;
                Console.WriteLine("Key :{0}  Value :{1}", dentry.Key, dentry.Value);
            }
            Console.WriteLine();

            Console.WriteLine("Using ICollection to store the keys alone");
            Console.WriteLine("-------------------------------------------");
            // Get a collection of the keys.
            ICollection c = hash.Keys;
  
            // Displaying the contents
            foreach(var str in c)
                Console.WriteLine(str + ": "+ hash[str]);
        }
    }
}