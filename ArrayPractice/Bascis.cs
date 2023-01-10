using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    public class Bascis
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 6 ,6,6,6,6};
            int value = 7;
            int pos = 5;
            // InsertAtEnd(arr, value);
            // InsertAtPosition(arr, value, pos);
            DuplicateInArray(arr);
        }

        public static void InsertAtEnd(int[] arr, int value)
        {
            //by appending the value
            var result = arr.Append(value);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            //2nd method

            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = value;
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        public static void InsertAtPosition(int[] arr, int value, int pos)
        {
            var newArray = new int[arr.Length + 1];
            for (int i = 0; i < arr.Length + 1; i++)
            {
                if (i < pos - 1)
                    newArray[i] = arr[i];
                else if (i == pos - 1)
                    newArray[i] = value;
                else
                    newArray[i] = arr[i - 1];
            }

            foreach (var item in newArray)
            {
                Console.WriteLine(item);
            }
        }

        public static void DuplicateInArray(int[] arr)
        {

            for(int i =0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length-1; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine("DUPLICATE NUMBER" +arr[i]);  
                    }
                }
            }
        }

















        public static void KtimesRotation(int[] arr, int k)
        {
            var newArray = new int[arr.Length];
            var result = k % arr.Length;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i < result)
                {
                    Console.WriteLine(arr[arr.Length + i - result] + " ");
                }
                else
                {
                    Console.WriteLine(arr[i - result]);
                }
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

        }

        public static void ReArrangeArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        var temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        break;
                    }

                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != i)
                {
                    arr[i] = -1;
                }
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        public static void MoveZerosToEnd(int[] arr)
        {
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0) { continue; }
                arr[index] = arr[i];
                index++;
            }
            for (int i = index; i < arr.Length; i++)
            {
                arr[i] = 0;
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

        }

        public static void SegreGateOddEven(int[] arr)
        {
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    arr[index] = arr[i];
                    index++;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    arr[index] = arr[i];
                    index++;
                }
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        public static int KthSmallestAndLargestElement(int[] arr, int k)
        {
            Array.Sort(arr);
            return arr[k - 1];
        }

        public static void MultipleLargest(int[] arr)
        {
            var frist = 0; var second = 0; var third = 0;

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                if (arr[i] > frist)
                {
                    third = second;
                    second = frist;
                    frist = arr[i];
                }
                else if (arr[i] > second && arr[i] != frist)
                {
                    third = second;
                    second = arr[i];
                }
                else if (arr[i] > third && arr[i] != second)
                {
                    third = arr[i];
                }
            }

            Console.WriteLine("fritst value " + frist + "second value " + second + "third value " + third);

        }

        public static void SecondLargestNumber(int[] arr)
        {
            //var result = arr.OrderByDescending(x=>x).Skip(1).SingleOrDefault();
            //Console.WriteLine(result);

            int largest = int.MinValue;
            int second = int.MinValue;
            if (arr.Length < 2) { Console.WriteLine("invalid input"); return; }

            for (int i = 0; i < arr.Length; i++)
            {
                largest = Math.Max(largest, arr[i]);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != largest)
                {
                    second = Math.Max(second, arr[i]);
                }
            }

            if (second == int.MinValue)
                Console.Write("There is no second " +
                              "largest element\n");
            else
                Console.Write("The second largest " +
                              "element is {0}\n", second);
        }

        public static void DistnictNumbeRFromArray(int[] arr)
        {
            var set = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!set.Contains(arr[i]))
                {
                    set.Add(arr[i]);
                }
            }

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }

        public static void ElementOnce(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] != arr[i + 1])
                {
                    Console.WriteLine(arr[i]);
                }

            }
        }

        public static void RearrangePostiveAndNegative(int[] arr)
        {
            var counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {

            }
        }

        public int NumIdenticalPairs(int[] nums)
        {
            var goodpairs = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j] && i < j)
                    {
                        goodpairs++;
                    }
                }
            }
            return goodpairs;
        }

        public static void Paging(List<int> list)
        {
            var pagenumber = 10;
            var pageSize = 10;
            var result = list.OrderBy(x => x).Skip(pagenumber - 1 * pageSize).Take(pageSize).ToList();
            // 9*10 = 90 40
            foreach (var item in result)
            {
                Console.Write(item + " , ");
            }
        }

        public static void convertArray(int[] arr, int row, int column)
        {
            var result = new int[row, column];
            if (row * column == arr.Length)
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        result[i, j] = arr[i * column + j];
                    }
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }




    }


}
