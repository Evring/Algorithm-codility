using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Lessons.Lesson4
{
    public  class PermCheck
    {
        #region Task
        /*
         A non-empty array A consisting of N integers is given.

        A permutation is a sequence containing each element from 1 to N once, and only once.

        For example, array A such that:

            A[0] = 4
            A[1] = 1
            A[2] = 3
            A[3] = 2
        is a permutation, but array A such that:

            A[0] = 4
            A[1] = 1
            A[2] = 3
        is not a permutation, because value 2 is missing.

        The goal is to check whether array A is a permutation.

        Write a function:

        class Solution { public int solution(int[] A); }

        that, given an array A, returns 1 if array A is a permutation and 0 if it is not.

        For example, given array A such that:

            A[0] = 4
            A[1] = 1
            A[2] = 3
            A[3] = 2
        the function should return 1.

        Given array A such that:

            A[0] = 4
            A[1] = 1
            A[2] = 3
        the function should return 0.

        Write an efficient algorithm for the following assumptions:

        N is an integer within the range [1..100,000];
        each element of array A is an integer within the range [1..1,000,000,000].
         
         */
        #endregion


        #region MyRegion
        /// 审题：明确问题边界
        /// 题目的主要是想让判断A数组是否 是一个序列，并且每个元素只出现一次。
        /// 
        /// 思路：
        /// 判断是否有序连续,如果连续的话那么索引对应的值一定是存在的。
        /// 所以可以通过 A[i] - 1 来判断 数组的索引是否存在。
        /// 
        /// 但是当 A 中的元素 出现 超出索引范围的值将会出现异常
        ///

        #endregion
        /// <summary>
        /// 判断数组是否是一个序列
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int solution(int[] A)
        {
            var arr = new int[A.Length];
            foreach (var item in A)
            {
                if (item > A.Length)
                    return 0; // out of range
                if (arr[item - 1] == 0)
                {
                    arr[item - 1] = 1;
                }
                else
                {
                    return 0; // duplicated
                }
            }
            return 1;
        }

        /// <summary>
        /// 判断 4，5，8,6，7 是否为连续的数组
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        //public int solution(int[] A)
        //{
        //    // 使用 dic 存储


        //}MaxCounters
    }
}
