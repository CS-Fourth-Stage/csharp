using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    // Selection Sort
    class Volume
    {
        public double width;
        public double height;
        public double length;

        public Volume(double w, double h, double l)
        {
            width = w;
            height = h;
            length = l;
        }

        public double calculate()
        {
            return (width * height * length);
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            //Volume ob = new Volume(2.0, 2.0, 2.0);
            //Console.WriteLine("Volume={0}", ob.calculate());

            //int[] arr = {7, 11, 1, 4, 20};
            int[] arr = { 17, 23, 6, 11, 32, 5, 1, 4, 0 };
            int small_num=arr[0];
            int index=0;
            int temp;
            bool flag = false;

            Console.Write("UnSorted Array: ");

            for (int i = 0; i < arr.Length-1; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.Write("\n\n");

            for (int i = 0; i < arr.Length-1; i++)
            {
                flag = false;
                small_num = arr[i];
                for (int j = i+1; j < arr.Length; j++)
                {
                    
                    if(small_num > arr[j])
                    {
                        small_num = arr[j];
                        index = j;
                        flag = true;
                    }
                }

                if (flag == true)
                {
                    temp=arr[i];
                    arr[i] = small_num;
                    arr[index] = temp;
                }
            }

            Console.WriteLine("Sorted Array Using Selection Technech: ");

            for(int i=0;i<arr.Length;i++)
            { 
                Console.Write(arr[i]+" "); 
            }

            Console.ReadKey();
        }
    }
}
