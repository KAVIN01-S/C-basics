using System.Collections;

namespace Collection
{
    //Exampl class for Dictionary
    class AttayList_Example
    {
        public static void main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            //Add method to add elements in arrayList
            arrayList.Add(1);
            arrayList.Add("Bill");
            arrayList.Add(" ");
            arrayList.Add(true);
            arrayList.Add(4.5);
            arrayList.Add(null);

            //foreach loop to traverse over the arrayList
            foreach(var value in arrayList)
            {
                Console.WriteLine(value);
            }

            /*arrayList is not Generic so accepts other elements which resides in other collection types*/
            ArrayList array_list1 = new ArrayList();
            var array_list2 = new ArrayList(){ 1, "Bill", " ", true, 4.5, null};

            int[] arr = { 100, 200, 300, 400 };

            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World!");

            array_list1.Add(array_list2); //adding arraylist in arraylist 
            array_list1.AddRange(arr); //adding array in arraylist
            array_list1.AddRange(myQ); //adding Queue in arraylist

            //Traversing in array_list1
            foreach(var array_value in array_list1)
            {
                Console.WriteLine(array_value);
            }

            ArrayList arlist1 = new ArrayList(){100, 200, 600,45,89,90};
            ArrayList arlist2 = new ArrayList(){300, 400, 500};
            arlist1.ToArray();
            //InsertRange method to add an another arraylist from the specified index
            arlist1.InsertRange(2, arlist2);
            foreach(var item in arlist1)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            //Console.WriteLine(arlist1[14]);
            Console.WriteLine(arlist1.Capacity);
            
            //Removing Elements
            arlist1.Remove(null); //Removes first occurance of null
            arlist1.RemoveAt(4); //Removes element at index 4
            arlist1.RemoveRange(0, 2);

            //Sorting ArrayList
            arlist1.Sort();

            //Reversing the arrayList
            arlist1.Reverse();
        }
    }
}
