using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace ShellSort
{
    public class ShellSort<T> where T : IComparable<T>
    {
        public T[] Sort(T[] array)
        {
            int length = array.Length;
            int step = length / 2;
            int j;
            
            while (step > 0)
            {
                for (int i = 0; i < (array.Length - step); i++)
                {
                    j = i;
                    while ((j >= 0) && (array[j].CompareTo(array[j + step]) > 0))
                    {
                        Swap(array, j, j + step);
                        j = j - step;
                    }
                }
                step = step / 2;
            }

            return array;
        }

        public T[] Swap(T[] array, int j, int i)
        {
            T temp = array[j];
            array[j] = array[i];
            array[i] = temp;
            return array;
        }

        public T[] ReverseArray(T[] array)
        {
            var result = new T[array.Length];
            int i = array.Length - 1;
            int j = 0;

            while (i >= 0)
            {
                result[j] = array[i];
                i--;
                j++;
            }

            return result;
        }

        public T[] ReverseSort(T[] array)
        {
            var sort = new ShellSort<T>();
            array = sort.Sort(array);
            array = sort.ReverseArray(array);
            return array;
        }
    }
}