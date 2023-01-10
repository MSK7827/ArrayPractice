using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    public class EasyPractice
    {
        static void Main(string[] args)
        {
              int[] arr = new int[] {1,0,2,2,0,1 };
            //kadnesAlgortham(arr);


            var arr2 = new int[] { 1, 2, 4, 5, 6, 7, 0,9,15 };

            //Leader(arr2);

            KthSmallestAndMaximumNumber(arr2,4);


           //var result = SortArrays(arr);
           // foreach (var item in result)
           // {
           //     Console.WriteLine(item);
           // }
        }

        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            var result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                var count = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        count++;
                    }
                }
                result[i] = count;
            }

            return result;
        }

        public static int[] ReOrderArray(int[] arr, int[] index)
        {
            var result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                result[index[i]] = arr[i];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = result[i];
                index[i] = i;
            }
            return result;
        }

        public static void MissingNumber(int[] nums, int n)
        {
            int sum = n * (n + 1) / 2;
            for (int i = 0; i < nums.Length; i++)
            {
                sum -= nums[i];
            }
            Console.WriteLine(sum);
        }

        public static void kadnesAlgortham(int[] arr)
        {
            var maxSum = arr[0];
            var CurSum = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                CurSum = Math.Max(arr[i], CurSum + arr[i]);
                maxSum = Math.Max(maxSum, CurSum);
            }

            Console.WriteLine(maxSum);
        }
        //I have to do
        public static int MinimumNumberOfJumps(int[] arr)
        {
            int minJumps = 0;

            if (arr.Length == 0 && arr[0] == 0) return 0;

            for (int i = 0; i < arr.Length; i++)
            {
               

            }


            return minJumps;
        }

        //Wrong .. will check later
        public static int[] SortArrays(int[] arr)
        {
            var result = new int[arr.Length];
            int low = 0;
            int high = arr.Length - 1;
            int mid = 0;
            var temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    temp= arr[low];
                    arr[low] = arr[mid];
                    arr[mid] = temp;
                    low++;
                    mid++;
                }
                if (arr[1] == 1)
                {
                    mid++;
                    
                }
                if (arr[i] == 2)
                {
                    temp = arr[mid];
                    arr[mid] = arr[high];
                    arr[high] = temp;
                    high--;
                }
            }

            return result;
        }

        public static void Leader(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int j;
                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] <= arr[j])
                        break;
                }

                // the loop didn't break
                if (j == arr.Length)
                    Console.Write(arr[i] + " ");
            }
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] <= arr[j])
            //        {
            //            break;
            //        }
            //        if(j == arr.Length)
            //        {
            //            Console.WriteLine(arr[i]+ ",");
            //        }

            //    }
            //}
        }

        //will do later
        public static void KthSmallestAndMaximumNumber(int[] arr, int k)
        {
            var result = 0;
            int smallest = 0;
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        smallest = i;
                    }
                }
            }
            Console.WriteLine(smallest);
        }


    }
}
