using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_2__InClassExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int> { 1, 2, 3, 2, 4, 5, 3, 6, 7, 8, 9, 1 };

            List<int> uniqueValues = GetUniqueElements(data);

            foreach (int uniqueValue in uniqueValues)
            {
                Console.WriteLine($"{uniqueValue} is a unique number in data");
            }
            Console.ReadLine();
        }

        /// <summary>
        /// This method uses List collection to get all unique values within the input parameter
        /// A unique value is a number that does not repeat, or appear more than once in collection
        /// </summary>
        public static List<int> GetUniqueElements(List<int> numbers)
        {
            //TODO: add code here to return a List<int> of all integers that are unique in numbers
            //1st method
             return numbers.Distinct().ToList();
            //2st method
            IList<int> temp  = new List<int>();
            foreach (int i in numbers) 
            {
                if (!temp.Contains(i))
                    temp.Add(i);
            }
            return temp;


        }
            
    }
}
