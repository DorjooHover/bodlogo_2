using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bodlogo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = MultiAndSum();
            for(int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }

        public static int[] MultiAndSum()
        {
            int[] n = { 0, 1 };
            int odd = 0, even = 1;
            int[,] arr = { { 11, 12, 13, 14, 15 }, { 31, 32, 33, 34, 35 } };
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    if(arr[i ,j] % 2 == 0)
                    {
                        odd += arr[i, j];
                    }else
                    {
                        even *= arr[i, j];
                    }
                }
            }
            n[0] = odd;
            n[1] = even;

            return n;
        }
    }
}
