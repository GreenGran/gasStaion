using System;
using System.Collections.Generic;

namespace gasStaion_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {   
            List<int> A = new List<int>() { 7, 1, 0, 11, 4};

            List<int> B = new List<int>() { 5, 9, 1, 2, 5};
            int result;
            result = GasStationCalcFunc(A, B);
            Console.WriteLine("result:"+ result);
            result = improvedSimulatio(A, B);
            Console.WriteLine("result:" + result);


        }

        private static int GasStationCalcFunc(List<int> A, List<int> B)
        {
            // brute force time complacity of n^n
            for (int T = 0; T < A.Count; T++)
            {
               int startingIndex = T;
                bool flag = false;
                int currentGas = 0;
                for (int i = T; ; i++)
                {
                    
                    currentGas += A[i];
                    currentGas -= B[i];
                    
                    if (currentGas < 0)
                    {
                       
                        break;
                    }

                    if(i == startingIndex && flag)
                    {
                        
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
        private static int improvedSimulatio(List<int> A, List<int> B)
        {
            // improved version runs much faster at time O(n+n+n)=O(3n) = O(n)
            int diff = 0;
            for (int j = 0; j < A.Count; j++)
            {
                diff += (A[j] - B[j]);
            }
            
            if (diff < 0)// chacks if there is even one possible starting point
            {
                return -1;
            }
            else {
                int starting = 0, currentGas = 0;
                for (int i = 0; i < A.Count; i++)
                {
                    currentGas += A[i] - B[i];
                    if (currentGas < 0)
                    {
                        starting = i + 1;
                        currentGas = 0;
                    }
                }
                return starting;
                }
        }
    }   
    
}
