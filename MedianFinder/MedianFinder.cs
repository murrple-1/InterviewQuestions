using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roadrunner.Interview.MedianFinder
{
    public class MedianFinder
    {
        public static int FindMedian(int[] data)
        {
            return Select(data, data.Length / 2);
        }

        public static int Select(int[] data, int k)
        {
            return Select(data, 0, data.Length - 1, k);
        }

        private static int Select(int[] data, int left, int right, int k)
        {
            while (true)
            {

                if (right <= left + 1)
                {

                    if (right == left + 1 && data[right] < data[left])
                    {
                        Swap(data, left, right);
                    }

                    return data[k];

                }
                else
                {

                    int middle = (int) ((uint) (left + right) >> 1);
                    Swap(data, middle, left + 1);

                    if (data[left] > data[right])
                    {
                        Swap(data, left, right);
                    }

                    if (data[left + 1] > data[right])
                    {
                        Swap(data, left + 1, right);
                    }

                    if (data[left] > data[left + 1])
                    {
                        Swap(data, left, left + 1);
                    }

                    int i = left + 1;
                    int j = right;
                    int pivot = data[left + 1];

                    while (true)
                    {
                        do
                        {
                            i++;
                        }
                        while (data[i] < pivot);
                        do
                        {
                            j--;
                        }
                        while (data[j] > pivot);

                        if (j < i)
                        {
                            break;
                        }

                        Swap(data, i, j);
                    }

                    data[left + 1] = data[j];
                    data[j] = pivot;

                    if (j >= k)
                    {
                        right = j - 1;
                    }

                    if (j <= k)
                    {
                        left = i;
                    }
                }
            }
        }

        private static void Swap(int[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
    }
}
