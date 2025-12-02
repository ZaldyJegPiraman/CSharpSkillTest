using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSkillTest.Models
{
    public class QuickSortStrategy : ISortStrategy
    {
        public string Sort(string input)
        {
            char[] arr = input.ToCharArray();
            QuickSort(arr, 0, arr.Length - 1);
            return new string(arr);
        }

        private void QuickSort(char[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivot = Partition(arr, low, high);
                QuickSort(arr, low, pivot - 1);
                QuickSort(arr, pivot + 1, high);
            }
        }

        private int Partition(char[] arr, int low, int high)
        {
            char pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }

            (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
            return i + 1;
        }
    }
}
