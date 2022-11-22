using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Lessons.Lesson4
{
    public class MaxCounters
    {
        #region Task
        /*
       You are given N counters, initially set to 0, and you have two possible operations on them:

increase(X) − counter X is increased by 1,
max counter − all counters are set to the maximum value of any counter.
A non-empty array A of M integers is given. This array represents consecutive operations:

if A[K] = X, such that 1 ≤ X ≤ N, then operation K is increase(X),
if A[K] = N + 1 then operation K is max counter.
For example, given integer N = 5 and array A such that:

    A[0] = 3
    A[1] = 4
    A[2] = 4
    A[3] = 6
    A[4] = 1
    A[5] = 4
    A[6] = 4
the values of the counters after each consecutive operation will be:

    (0, 0, 1, 0, 0)
    (0, 0, 1, 1, 0)
    (0, 0, 1, 2, 0)
    (2, 2, 2, 2, 2)
    (3, 2, 2, 2, 2)
    (3, 2, 2, 3, 2)
    (3, 2, 2, 4, 2)
The goal is to calculate the value of every counter after all operations.

Write a function:

class Solution { public int[] solution(int N, int[] A); }

that, given an integer N and a non-empty array A consisting of M integers, returns a sequence of integers representing the values of the counters.

Result array should be returned as an array of integers.

For example, given:

    A[0] = 3
    A[1] = 4
    A[2] = 4
    A[3] = 6
    A[4] = 1
    A[5] = 4
    A[6] = 4
the function should return [3, 2, 2, 4, 2], as explained above.

Write an efficient algorithm for the following assumptions:

N and M are integers within the range [1..100,000];
each element of array A is an integer within the range [1..N + 1].
         
         */
        #endregion


        #region MyRegion
        /// 审题：明确问题边界
        /// 主要是对N个计数器进行操作，当A[i]的值小于N时，那么就对第N个计数器+1，当A[i]的值大于 N+1的时候，则所有的计数器都变为当前的最大值。
        /// 
        /// 思路：
        /// 对数组A进行循环，
        /// 
        /// 
        /// 
        ///

        #endregion
        /// <summary>
        /// 判断数组是否是一个序列 timeout ,
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int[] solution(int N, int[] A)
        {
            int[] arr = new int[N];

            int max = 0; // 1,[1]
            foreach (var item in A)
            {
                if (item <= N)   // such that item ≤ N, then operation increase item
                {
                    arr[item - 1] = arr[item - 1] + 1;
                    max = max > arr[item - 1] ? max : arr[item - 1];
                }
                else            // if item = N + 1 then operation K is max counter.
                {
                    for (int i = 0; i < N; i++)
                        arr[i] = max;
                }
            }

            return arr;
        }

        /// <summary>
        /// 要求时间复杂度是O(N+M)，空间复杂度是O(N)
        /// 所以我们要对上面的算法进行改良，
        /// 当我们遍历的时候，其实max 可以留在下次其它计数器更新的时候再进行更新，它更新为max+1即可。
        /// 最后再统一遍历一边没有更新过的值,把它们更新为max.
        /// </summary>
        /// <param name="N"></param>
        /// <param name="A"></param>
        /// <returns></returns>
        public int[] solution2(int N, int[] A)
        {
            int max = 0, updateVal = 0;
            int[] arr = new int[N];
            foreach (var item in A)
            {
                if (item <= N)
                {
                    if (arr[item - 1] < updateVal)
                        arr[item - 1] = updateVal + 1;
                    else
                        arr[item - 1]++;
                    max = max > arr[item - 1] ? max : arr[item - 1];
                }
                else
                    updateVal = max;
            }
            for (var i = 0; i < N; i++)
            {
                if (arr[i] < updateVal)
                    arr[i] = updateVal;
            }
            return arr;
        }
    }
}
