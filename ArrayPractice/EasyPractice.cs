using System;
using System.Collections.Generic;
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
              int[] arr = new int[] { 1,2,2,3,3,5 };
              int[] index = new int[] { 3, 0, 4, 1, 2 };
            var n = 4;
           var rresult = FrstReapeatingChar(arr);
            Console.WriteLine(rresult);
           // MissingNumber(arr, n);
            //var res = ReOrderArray(arr, index);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            //var result = SmallerNumbersThanCurrent(arr);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
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
            var result = 0;
          
            int sum = n * (n + 1) / 2;
            for (int i = 0; i < nums.Length; i++)
            {
                sum -= nums[i];
            }
            int missingNumber = sum - result;
            Console.WriteLine(sum);
        }

        public static int FrstReapeatingChar(int[] arr)
        {
            var index = 0;
            for(int i =0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        index = Array.IndexOf(arr, arr[j]);
                       
                    }
                    break;
                }
               
            }
            return index;
        }
    }
}
