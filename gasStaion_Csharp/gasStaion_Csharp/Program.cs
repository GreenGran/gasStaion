using System;
using System.Collections.Generic;

namespace gasStaion_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {   
            List<int> A = new List<int>() { 7, 1, 0, 11,4 };

            List<int> B = new List<int>() { 5, 9, 1, 2, 5 };
            int currentGas = 0;

            int result = GasStationCalcFunc(A, B);
            Console.WriteLine("result:"+ result);
            result = GasStationCalcFunc2(A, B);
            Console.WriteLine("result:" + result);


        }

        private static int GasStationCalcFunc(List<int> A, List<int> B)
        {
            for (int T = 0; T < A.Count; T++)
            {
               int startingIndex = T;
                bool flag = false;
                int currentGas = 0;
                for (int i = T; ; i++)
                {
                    Console.WriteLine("T:" + T);
                    Console.WriteLine("i:"+i);
                    currentGas += A[i];
                    currentGas -= B[i];
                    Console.WriteLine("currentGas:" + currentGas);
                    if (currentGas < 0)
                    {
                        Console.WriteLine("breaking out");
                        break;
                    }

                    if(i == startingIndex && flag)
                    {
                        Console.WriteLine("circal complet");
                        return T;
                    }
                    flag = true;
                    if(i==A.Count - 1)
                    {
                        i =-1;
                    }
                }
            }
            return -1;
        }
        private static int GasStationCalcFunc2(List<int> A, List<int> B)
        {
            for (int T = 0; T < A.Count; T++)
            {
                int startingIndex = T;
                bool flag = false;
                int currentGas = 0;
                for (int i = T; ; )
                {
                    Console.WriteLine("T:" + T);
                    Console.WriteLine("i:" + i);
                    currentGas += A[i];
                    currentGas -= B[i];
                    Console.WriteLine("currentGas:" + currentGas);
                    if (currentGas < 0)
                    {
                        Console.WriteLine("breaking out");
                        break;
                    }
                    i++;
                    if (i == startingIndex)
                    {
                        Console.WriteLine("circal complet");
                        return T;
                    }
                   
                    
                    if (i == A.Count - 1)
                    {
                        i = 0;
                    }
                }
            }
            return -1;
        }
    }   
    
}
