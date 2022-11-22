using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Lessons.Lesson4
{
    public class MissingInteger
    {
        #region Task
        /*
            This is a demo task.

            Write a function:

            class Solution { public int solution(int[] A); }

            that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.

            For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.

            Given A = [1, 2, 3], the function should return 4.

            Given A = [−1, −3], the function should return 1.

            Write an efficient algorithm for the following assumptions:

            N is an integer within the range [1..100,000];
            each element of array A is an integer within the range [−1,000,000..1,000,000].
         */
        #endregion


        #region 分析

        /// 审题：明确问题边界
        /// 返回A中没有出现的最小的正整数
        /// 
        /// 1.就是说最小的正整数一定是>0的
        /// 2.当A是连续的，应该返回A.Length + 1
        /// 3.这里还有个坑就是当A = [3，4，5，6] 时,会让人误解应该返回2，但题目中说的是A中没有出现的正整数，所以只要1没有出现，答案就一定是1.
        /// 
        /// 思路：
        /// 
        /// 我们要找一个最小的正整数，通过审题得出
        /// 
        /// 我们的核心就是遍历A,把A中元素的值作为数组B的索引，并标记为1, 也就是说B的索引所对应的值为1的时候表示它在A中存在，不为1的话就是A中缺失的值。
        /// 
        /// 数组B 可以是bool[] arr , 也可以是 int[] arr  主要是用来标记A的值是否存在。
        /// 
        /// 那么存入数组中的元素的条件应该是什么呢？
        /// 1.因为要获取最小的正整数，所以，值一定要大于 0，即 A[i] > 0  
        /// 2.那么当A中元素的值大于A.length 时，说明一定不是从1开始的 ，那么结果一定为1. 所以不用管他,我们只存储小于A.Length的值。 即 A[i] <= A.Length
        ///   为什么是小于等于？因为我们把A[i]当作 B 数组的索引，而索引是从0开始存储的，要把A中的值都放入B中，应该<=A.length 或者< A.Length + 1 
        /// 综合得出 ==> 0 < A[i] <= A.Length
        /// 
        /// 然后就是遍历 B 没有标记的就是缺失的，
        /// 当遍历完如果都标记过了，证明是连续的，需要返回A.Length + 1.
        /// 
        /// 

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int solution(int[] A)
        {
            int[] arr = new int[A.Length];
            foreach (int i in A)
            {
                if (i > 0 && i <= A.Length)
                {
                    arr[i - 1] = i;
                }
            }

            for (int i = 0; i < A.Length; i++)
            {
                if (arr[i] == 0)
                    return i + 1;
            }
            return A.Length + 1;
        }

        public int solution2(int[] A)
        {
            int[] arr = new int[A.Length + 1];
            foreach (int i in A)
            {
                if (i > 0)
                {
                    arr[i - 1] = i;
                }
            }

            for (int i = 0; i < A.Length + 1; i++)
            {
                if (arr[i] == 0)
                    return i + 1;
            }
            return 1;
        }


    }
}
