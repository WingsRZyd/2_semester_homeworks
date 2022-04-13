using System;

namespace ShellSort
{
    public class Program
    {
        static void Main()
        {
            var array = new string[] {"hello", "bye", "half", "look", "hell", "helo"};
            var sort = new ShellSort<string>();
            array = sort.Sort(array);
            //array = sort.Swap(array, 5, 2);

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

        }
    }
}
