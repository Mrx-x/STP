using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    public class myFunc
    {
        /*Функция получает два одномерных массива. В массиве int[] ind хранятся
        индексы компонентов массива v.Найдите произведение ненулевых
        компонентов массива v, индексы которых хранятся в массиве ind.*/
        public static int mull(int[] ind, int[] v)
        {
            int result = 1;
            for(int i = 0; i < v.Length; ++i)
            {
                if (v[ind[i]] != 0)
                {
                    result *= v[ind[i]];
                }
                else
                {
                    continue;
                }
            }
            return result;
        }

        /*Функция получает одномерный массив целых переменных. Вычисляет и
        возвращает минимальный по значению элемент этого массива и номер его
        индекса.*/
        public static int minElement(int[] a, out int index)
        {
            int min = a[0];
            index = 0;
            for (int i = 0; i < a.Length; ++i)
            {
                if (min > a[i])
                {
                    min = a[i];
                    index = i;
                }
            }

            return min;
        }

        /*Функция получает одномерный массив вещественных переменных. В
        полученном массиве функция переставляет значения компонентов
        массива в обратном порядке.
        */
        public static void reverseElement(ref float[] a)
        {
            for(int i = 0, j = a.Length-1; i < j; i++, j--)
            {
                float temp = a[i];
                a[i] = a[j];
                a[j] = temp;
            }
        }
    }
}
