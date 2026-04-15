using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Globalization;
using System.IO.Pipelines;
using System.Numerics;
using System.Reflection.Metadata;

class Program
{
    static void Main()
    {
        int[] A = { 3, 2, 4 };
        int F = 2;
        int M = 3;
        Program program = new Program();
        int[] result = program.Solution(A, F, M);
        Console.WriteLine(string.Join(", ", result));
    }

    public int[] Solution(int[] A, int F, int M)
    {
        int N = A.Length;
        int knownSum = 0;
        int missingSum;
        int targetSum = (N + F) * M;

        for (int i = 0; i < N; i++)
        {
            knownSum += A[i];
        }

        missingSum = targetSum - knownSum;

        if (missingSum < F || missingSum > (6 * F))
        {
            return new int[] { 0 };
        }

        int[] result = new int[F];

        for (int i = 0; i < F; i++)
        {
            result[i] = 1;
        }

        missingSum -= F;

        for (int i = 0; i < F; i++)
        {
            int add = Math.Min(5, missingSum);
            result[i] += add;
            missingSum -= add;
        }

        return result;
    }

    // public int Solution(int[] A, int X)
    // {
    //     HashSet<int> seen = new HashSet<int>();
    //     for (int i = 0; i < A.Length; i++)
    //     {
    //         //seen.Add(A[i]);

    //         if (A[i] <= X)
    //         {
    //             seen.Add(A[i]);
    //         }

    //         if (seen.Count == X)
    //         {
    //             return i;
    //         }
    //     }
    //     return -1;
    // }

    // public int Solution(int[] A)
    // {
    //     int total = 0;
    //     int currentDiff = 0;
    //     int leftSum = 0;
    //     int rightSum = 0;
    //     int minDiff = 0;

    //     // start at the end of the array
    //     for (int i = 0; i < A.Length; i++)
    //     {
    //         total += A[i];
    //     }

    //     minDiff = total;
    //     for (int i = 0; i < A.Length - 1; i++)
    //     {
    //         leftSum += A[i];
    //         rightSum = total - leftSum;
    //         currentDiff = Math.Abs(rightSum - leftSum);

    //         if (currentDiff < minDiff)
    //         {
    //             minDiff = currentDiff;
    //         }
    //     }

    //     return minDiff;
    // }

    // public int[] Solution(int[] A, int N)
    // {
    //     // create counters
    //     int[] counters = new int[N];
    //     int currentMax = 0;
    //     int baseValue = 0;

    //     for (int i = 0; i < A.Length; i++)
    //     {

    //         if (A[i] >= 1 && A[i] <= N)
    //         {
    //             int index = A[i] - 1;

    //             if (counters[index] < baseValue)
    //             {
    //                 counters[index] = baseValue;
    //             }

    //             counters[index]++;

    //             if (counters[index] > currentMax)
    //             {
    //                 currentMax = counters[index];
    //             }
    //         }
    //         else if (A[i] == N + 1)
    //         {
    //             baseValue = currentMax;
    //         }
    //     }
    //     for (int i = 0; i < N; i++)
    //     {
    //         if (counters[i] < baseValue)
    //         {
    //             counters[i] = baseValue;
    //         }
    //     }
    //     return counters;
    // }
}