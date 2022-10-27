using System;

namespace Lib_5
{
    public class LibClass
    {
        /// <summary>
        /// Находит сумму целых чисел в диапозоне от -7 до 3
        /// </summary>
        /// <param name="genNums">Сгенерированные числа</param>
        /// <param name="count">Кол-во сгенерированных чисел</param>
        /// <param name="K">Предел суммы</param>
        /// <returns>Сумму целых чисел</returns>
        public static int SumOfNums(out string genNums, out int count, int K)
        {
            Random rnd = new Random();
            int sum = 0;
            genNums = "";
            int randNum;
            count = 0;
            for (int i = 1; sum < K; i++)
            {
                randNum = rnd.Next(-7, 3);
                genNums = $"{randNum} ; {genNums}";
                if (randNum < 0) { randNum = rnd.Next(-7, 3); }
                else
                {
                    sum += randNum;
                    count = i;
                }
            }
            return sum;
        }

        /// <summary>
        /// Считает произведение чисел < 3
        /// </summary>
        /// <param name="arr">Одномерный массив</param>
        /// <returns>Произведение чисел < 3</returns>
        public static int PowOfNum(int[] arr)
        {
            int pow = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < 3)
                {
                    pow *= arr[i];
                }
            }
            return pow;
        }
        /// <summary>
        /// Среднее
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double AvgOfNumArr(int[,] arr)
        {
            double avg = 0;
            for (int i = 1; i < arr.GetLength(1); i += 2)
            {
                avg = 0;
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    avg += arr[i, j];
                    avg /= arr.GetLength(0);
                }
            }
            return avg;
        }
    }
}
