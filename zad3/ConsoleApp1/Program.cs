using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GenericList
{
    class Program
    {

        public static void Main()
        {

            IGenericList<string> stringList = new GenericList<string>();
            stringList.Add(" Hello ");
            stringList.Add(" World ");
            stringList.Add("!");
            foreach (string value in stringList)
            {
                Console.WriteLine(value);
            }

            Console.ReadLine();

        }

        public static void ListExample(GenericList<int> list)
        {
            list.Add(1); // [1]
            list.Add(2); // [1 ,2]
            list.Add(3); // [1 ,2 ,3]
            list.Add(4); // [1 ,2 ,3 ,4]
            list.Add(5); // [1 ,2 ,3 ,4 ,5]
            list.RemoveAt(0); // [2 ,3 ,4 ,5]
            list.Remove(5);
            Console.WriteLine(list.Count); // 3
            Console.WriteLine(list.Remove(100)); // false
            Console.WriteLine(list.RemoveAt(5)); // false
            list.Clear(); // []
            Console.WriteLine(list.Count); // 
        }
    }
}