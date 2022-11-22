using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Lessons.Lesson5
{
    public class PassingCars
    {
        #region Task
        /*
            A non-empty array A consisting of N integers is given. The consecutive elements of array A represent consecutive cars on a road.

            Array A contains only 0s and/or 1s:

            0 represents a car traveling east,
            1 represents a car traveling west.
            The goal is to count passing cars. We say that a pair of cars (P, Q), where 0 ≤ P < Q < N, is passing when P is traveling to the east and Q is traveling to the west.

            For example, consider array A such that:

                A[0] = 0
                A[1] = 1
                A[2] = 0
                A[3] = 1
                A[4] = 1
            We have five pairs of passing cars: (0, 1), (0, 3), (0, 4), (2, 3), (2, 4).

            Write a function:

            class Solution { public int solution(int[] A); }

            that, given a non-empty array A of N integers, returns the number of pairs of passing cars.

            The function should return −1 if the number of pairs of passing cars exceeds 1,000,000,000.

            For example, given:

                A[0] = 0
                A[1] = 1
                A[2] = 0
                A[3] = 1
                A[4] = 1
            the function should return 5, as explained above.

            Write an efficient algorithm for the following assumptions:

            N is an integer within the range [1..100,000];
            each element of array A is an integer that can have one of the following values: 0, 1.
         
         */
        #endregion


        #region MyRegion
        /// 审题：明确问题边界
        /// 0 = east P
        /// 1 = west Q
        /// 
        /// 计算车辆，P 朝 east 走，Q 朝 west走， 当 0 <= P < Q < N ，一对汽车（P,Q）正在经过
        /// 
        /// 0 1 0 1 1
        /// 0 1 2 3 4 
        /// 
        /// (0,1) (0,3) (0,4) (2,3) (2,4)
        /// 
        /// 
        /// 
        /// 思路：
        /// 遍历数组A , 当遇到 item 为 0 时 存储index 为 P , item 为1 时 存储为 Q
        ///  
        /// 当遇到A[i] = 0 时，(i,A.Length) 1 都可以组成一堆 
        ///       A[i+len] =0 时，(i+len,A.Length) 也都可以组成一堆
        ///       A[i+len+len1] =0 
        ///  s
        ///  s
        ///  s
        ///  s
        ///  s
        ///  s
        ///  s





        #endregion
        /// <summary>
        /// 判断数组是否是一个序列
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int solution(int[] A)
        {
            
            return 1;
        }
    }
}
