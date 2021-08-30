using System;
using System.Collections.Generic;


namespace Arrays
{
    class Program
    {
        static void Main()
        {
            //1.Create a one-dimensional array of strings. Ask the user to select an index of the array
            //and then display the string at that index on the screen.
            string[] stringArray = { "Hello", "my", "name", "is", "David" };
            Console.WriteLine("Please enter an index for the string array (0-4)");
            int stringIndex = Convert.ToInt32(Console.ReadLine());

            //3. Add in a message that displays when the user selects an index that doesn’t exist.
            if (stringIndex <= 4)
            {
                Console.WriteLine(stringArray[stringIndex]);
            }
            else
            {
                Console.WriteLine("This string index doesn't exist");
            }
           

            //2. Create a one-dimensional array of integers. Ask the user to select an index of the array
            //and then display the integer at that index on the screen.

            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Please enter an index for the integer array (0-8)");
            int integerIndex = Convert.ToInt32(Console.ReadLine());

            //3. Add in a message that displays when the user selects an index that doesn’t exist.
            if (integerIndex <= 8)
            {
                Console.WriteLine(intArray[integerIndex]);
            }
            
            else
            {
                Console.WriteLine("This integer index doesn't exist");
            }


            //4. Create a list of strings. Ask the user to select an index of the list
            //and then display the content at that index on the screen.
            List<string> stringList = new List<string>();
            stringList.Add("Tom");
            stringList.Add("David");
            stringList.Add("Eileen");
            stringList.Add("Cian");
            Console.WriteLine("Please enter an index for the string List");
            int index = Convert.ToInt32(Console.ReadLine());

            //check if index is in the range of the list
            if(index >= 0 && index <= stringList.Count)
            {
                Console.WriteLine(stringList[index]);
            }
            else
            {
                Console.WriteLine("This index doesn't exist");
            }

            Console.Read();
        }
    }
}
