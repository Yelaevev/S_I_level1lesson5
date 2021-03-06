﻿using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static string PatternUnlock(int N, int[] hits)
        {
            if (N != hits.Length)
            {
                Console.WriteLine("initial conditions is false");
                return "0";
            }

            foreach (int i in hits)
            {
                if ((i < 1) || (i > 9))
                {
                    Console.WriteLine("initial conditions is false");
                    return "0";
                }
            }


            double sum = hits.Length - 1;
            int[,] mass = new int[3, 3];
            mass[0, 0] = 6; mass[0, 1] = 1; mass[0, 2] = 9;
            mass[1, 0] = 5; mass[1, 1] = 2; mass[1, 2] = 8;
            mass[2, 0] = 4; mass[2, 1] = 3; mass[2, 2] = 7;
            for (int i = 0; i < hits.Length - 1; i++)
            {
                for (int n = 0; n < 3; n++)
                {
                    for (int m = 0; m < 3; m++)
                    {
                        if ((n >= 1) && (m <= 1) && (hits[i] == mass[n, m]) && (hits[i + 1] == mass[n - 1, m + 1]))
                        {
                            sum = sum - 1 + Math.Sqrt(2);
                        }


                        if ((n <= 1) && (m <= 1) && (hits[i] == mass[n, m]) && (hits[i + 1] == mass[n + 1, m + 1]))
                        {
                            sum = sum - 1 + Math.Sqrt(2);
                        }

                        if ((n <= 1) && (m >= 1) && (hits[i] == mass[n, m]) && (hits[i + 1] == mass[n + 1, m - 1]))
                        {
                            sum = sum - 1 + Math.Sqrt(2);
                        }

                        if ((n >= 1) && (m >= 1) && (hits[i] == mass[n, m]) && (hits[i + 1] == mass[n - 1, m - 1]))
                        {
                            sum = sum - 1 + Math.Sqrt(2);
                        }
                    }

                }

            }
            //Console.WriteLine(sum + "=znachenie sum");
            //double c = 5.0087987098797;
            double c = sum;
            double b = Math.Round(c, 5);  //okruglyem do 5 znaka posle zapytoy
                                          // Console.WriteLine(b + "=znachenie");
            b = b * 100000;// izbavlyamsy ot zapytoi
                           // Console.WriteLine(b + "=znachenie new");
            string str;
            str = b.ToString(); //perevodim v string
                                // Console.WriteLine(str + "=znachenie str");
            char zero = '0';
            foreach (char i in str)
            {
                if (i == zero)
                {
                    int indexOfChar = str.IndexOf(zero); // nahodim index nulya
                    str = str.Remove(indexOfChar, 1);    // ydalyaem v stroke  elementy c nyshnogo indexa na kolichestvo elemrnto (1)
                }
            }

            return str;
        }

        //static void Main(string[] args)
        //{

        //    int[] test = { 1, 2, 3, 4, 5, 6, 2, 7, 8, 9 };
        //    string str;
        //    str = PatternUnlock(test.Length, test);

        //    Console.WriteLine(str + "=znachenie str new");


        //}
    }
}
