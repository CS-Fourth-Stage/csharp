using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_Sort
{
    class Program
    {
        static int pa(int[] A, int start, int end) {
            int temp = 0;
            int pivot = A[end];
            int pi = start;
            for (int i = start; i < end; i++)
            {
                if(A[i] <= pivot)
                {
                    temp = A[i];
                    A[i] = A[pi];
                    A[pi] = temp;
                    pi++;
                }
            }
            temp = A[pi];
            A[pi] = A[end];
            A[end] = temp;
            return pi;
        }

        static void QuickSort(int[] A, int start, int end) {
            if (start < end) {
                int pi = pa(A, start, end);
                QuickSort(A, start, pi-1);
                QuickSort(A, pi+1, end);
            }
        }

        static void Main()
        {
            int[] A = new int[5] { 7, 2, 3, 6, 0 };
            QuickSort(A, 0, 4);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(A[i]);
            }

            Console.ReadKey();
        }
    }
}
