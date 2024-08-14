using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm
{
    public class BinarSearch
    {
        static int BinarySearch(int value, int[] array, int left, int right)
        {

            var middle = (left + right) / 2;

            var midElement = array[middle];

            if (midElement == value)
            {
                return middle;
            }
            else if (left < right)
            {
                if (value < midElement)
                {
                    return BinarySearch(value, array, left, middle - 1);
                }
                else
                {
                    return BinarySearch(value, array, middle + 1, right);
                }
            }
            else
            {
                return -1;
            }
        }
        //searchedValue - искомое значение, arr[] - массив, first - первый индекс массива (обычнно 0. ), last - последний индекс массива (array.length - 1)  
        static int TaskBinarySearch(int searchedValue, int[] arr, int first, int last) 
        {
            while(first <= last)
            {
                //индекс среднего элемента
                var middle = (first + last) / 2;

                if (searchedValue == arr[middle])
                {
                    return middle;
                }
                else if (searchedValue < arr[middle])
                {
                    //сужаем рабочую зону массива с правой стороны
                    last = middle - 1;
                }
                else
                {
                    //сужаем рабочую зону массива с левой стороны
                    first = middle + 1;
                }
            }
            //ничего не нашли
            return -1;
        }
    }
}
