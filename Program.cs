using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Dynamic;
using System.Globalization;
using System.IO.Pipelines;
using System.Numerics;
using System.Reflection.Metadata;
using Microsoft.VisualBasic;

class Program
{

    // Problem 11
    static void Main()
    {
        Program program = new Program();
        int reservation1 = 3;
        int reservation2 = 4;
        Console.WriteLine("Reservation 1: " + (program.Reserve(reservation1) == true ? "Success" : "Fail"));
        Console.WriteLine("Reservation 2: " + (program.Reserve(reservation2) == true ? "Success" : "Fail"));
    }

    public int stockA = 5;

    public bool Reserve(int reservation)
    {

        if (stockA >= reservation)
        {
            stockA -= reservation;
        }
        else
        {
            return false;
        }

        return true;
    }


    // reverse string practice again
    // static void Main()
    // {
    //     Program program = new Program();
    //     string input = "hello there world";
    //     Console.WriteLine(program.Solution(input));
    // }

    // public string Solution(string input)
    // {
    //     string[] words = input.Split(" ");
    //     Array.Reverse(words);
    //     return string.Join(" ", words);
    // }




    // Problem 4 - Correct Implementation
    // static void Main()
    // {
    //     Program program = new Program();
    //     string input = "((()()))";
    //     bool result = program.Solution(input);
    //     Console.WriteLine(result);
    // }

    // public bool Solution(string input)
    // {
    //     Stack<char> parentheses = new Stack<char>();
    //     char[] chars = input.ToCharArray();

    //     if (chars.Length % 2 != 0)
    //         return false;

    //     foreach (char c in chars)
    //     {
    //         if (c == '(')
    //         {
    //             parentheses.Push('(');
    //         }
    //         if (c == ')')
    //         {
    //             if (parentheses.Count == 0)
    //                 return false;

    //             parentheses.Pop();
    //         }
    //     }

    //     return parentheses.Count == 0;
    // }


    //Problem 10
    // static void Main()
    // {
    //     Program program = new Program();
    //     string[] input = new string[] { "A", "A", "B", "A", "A" };
    //     Console.WriteLine(string.Join(", ", program.Solution(input)));
    // }

    // public List<string> Solution(string[] input)
    // {
    //     Dictionary<string, int> requests = new Dictionary<string, int>();
    //     List<string> authorizations = new List<string>();

    //     foreach (string s in input)
    //     {
    //         if (requests.ContainsKey(s) && requests[s] >= 3)
    //         {
    //             authorizations.Add("deny");
    //             requests[s]++;
    //         }
    //         else if (requests.ContainsKey(s))
    //         {
    //             authorizations.Add("allow");
    //             requests[s]++;
    //         }
    //         else
    //         {
    //             requests[s] = 1;
    //             authorizations.Add("allow");
    //         }
    //     }
    //     return authorizations;
    // }


    // Problem 9
    // static void Main()
    // {
    //     Program program = new Program();
    //     string input = "cat dog cat bird dog cat";
    //     var result = program.Solution(input);
    //     Console.WriteLine("[\"" + string.Join("\", \"", result) + "\"]");
    // }

    // public List<string> Solution(string input)
    // {
    //     Dictionary<string, int> dict = new Dictionary<string, int>();

    //     foreach (string word in input.Split(' '))
    //     {
    //         if (dict.ContainsKey(word))
    //             dict[word]++;
    //         else
    //             dict[word] = 1;
    //     }

    //     return dict
    //     .OrderByDescending(x => x.Value)
    //     .ThenBy(x => x.Key)
    //     .Select(x => x.Key)
    //     .ToList();
    // }


    // Problem 8
    // static void Main()
    // {
    //     Program program = new Program();
    //     Dictionary<string, int> shoppingCart = new Dictionary<string, int> { { "apple", 12 }, { "banana", 2 } };
    //     Console.WriteLine(program.ApplyDiscount(shoppingCart));
    // }

    // public int ApplyDiscount(Dictionary<string, int> shoppingCart)
    // {
    //     int applePrice = 2;
    //     int bananaPrice = 1;

    //     int appleQuantity = shoppingCart.ContainsKey("apple") ? shoppingCart["apple"] : 0;
    //     int bananaQuantity = shoppingCart.ContainsKey("banana") ? shoppingCart["banana"] : 0;

    //     int freeApples = appleQuantity / 4;
    //     int paidApples = appleQuantity - freeApples;

    //     int appleCost = paidApples * applePrice;
    //     int bananaCost = bananaQuantity * bananaPrice;

    //     return appleCost + bananaCost;
    // }

    // Problem 7
    // static void Main()
    // {
    //     Program program = new Program();
    //     List<(int start, int end)> values = new List<(int start, int end)> { (1, 3), (2, 4), (6, 8), (3, 5) };
    //     program.Solution(values);
    // }

    // public void Solution(List<(int start, int end)> values)
    // {
    //     values = values.OrderBy(v => v.start).ToList(); // sort

    //     List<(int start, int end)> ranges = new List<(int start, int end)>();

    //     (int start, int end) current = values[0];

    //     for (int i = 1; i < values.Count; i++)
    //     {
    //         if (values[i].start <= current.end)
    //         {
    //             current.end = Math.Max(current.end, values[i].end);
    //         }
    //         else
    //         {
    //             ranges.Add(current);
    //             current = values[i];
    //         }
    //     }

    //     ranges.Add(current);
    //     Console.WriteLine(string.Join(",", ranges));
    // }


    // Problem 6
    // static void Main()
    // {
    //     Program program = new Program();
    //     string[] input = new string[] { "cat", "tree", "dog", "house", "exit", "sport" };
    //     program.Solution(input);
    // }

    // public void Solution(string[] input)
    // {
    //     Dictionary<int, List<string>> keyValuePairs = new Dictionary<int, List<string>>();
    //     for (int i = 0; i < input.Length; i++)
    //     {
    //         int wordLength = input[i].Length;

    //         if (!keyValuePairs.ContainsKey(wordLength))
    //         {
    //             List<string> strings = [input[i]];
    //             keyValuePairs.Add(wordLength, strings);
    //         }
    //         else
    //         {
    //             List<string> strings = keyValuePairs[wordLength];
    //             strings.Add(input[i]);
    //             //Console.WriteLine(string.Join(',', strings));
    //             keyValuePairs[wordLength] = strings;
    //         }
    //     }

    //     foreach (var (key, value) in keyValuePairs)
    //     {
    //         Console.WriteLine($"{key}: {string.Join(", ", value)}");
    //     }
    // }



    // Problem 5
    // static void Main()
    // {
    //     Program program = new Program();
    //     int[] input = new int[] { 1, 2, 3, 2, 4, 1 };
    //     HashSet<int> result = program.Solution(input);
    //     Console.WriteLine(string.Join(',', result));
    // }

    // public HashSet<int> Solution(int[] input)
    // {
    //     Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
    //     HashSet<int> duplicates = new HashSet<int>();

    //     for (int i = 0; i < input.Length; i++)
    //     {
    //         if (!keyValuePairs.ContainsKey(input[i]))
    //         {
    //             keyValuePairs.Add(input[i], 1);
    //         }
    //         else
    //         {
    //             keyValuePairs[input[i]]++;
    //         }
    //     }

    //     // Optional for sorted by order of appearance of duplication
    //     for (int i = 0; i < input.Length; i++)
    //     {
    //         if (keyValuePairs[input[i]] > 1)
    //         {
    //             duplicates.Add(input[i]);
    //         }
    //     }

    //     return duplicates;
    // }




    // Problem 4
    // static void Main()
    // {
    //     Program program = new Program();
    //     string input = "((()))";
    //     bool result = program.Solution(input);
    //     Console.WriteLine(result);
    // }

    // public bool Solution(string input)
    // {
    //     bool balanced = false;
    //     Dictionary<char, int> parentheses = new Dictionary<char, int>();
    //     int count;
    //     int leftSide;
    //     int rightSide;
    //     //int totalCount = input.Length;

    //     foreach (char c in input)
    //     {
    //         if (!parentheses.ContainsKey(c))
    //         {
    //             parentheses.Add(c, 1);
    //         }
    //         else
    //         {
    //             count = parentheses[c] + 1;
    //             parentheses[c] = count;
    //         }
    //     }

    //     leftSide = parentheses['('];
    //     rightSide = parentheses[')'];

    //     if (leftSide == rightSide)
    //     {
    //         balanced = true;
    //     }
    //     else
    //     {
    //         balanced = false;
    //     }

    //     return balanced;
    // }



    // Problem 3
    // static void Main()
    // {
    //     string input = "the quick brown fox jumps over the lazy dog";
    //     string result = Program.Solution(input);
    //     Console.WriteLine(result);
    // }

    // static string Solution(string input)
    // {
    //     string[] words = input.Split(' ');
    //     Array.Reverse(words);
    //     string reverse = string.Join(' ', words);
    //     return reverse;
    // }



    // Problem 2
    // static void Main()
    // {
    //     string input = "swiss";
    //     char result = Program.Solution(input);
    //     Console.WriteLine(result);
    // }

    // static char Solution(string input)
    // {
    //     Dictionary<char, int> characters = new Dictionary<char, int>();
    //     int count = 0;
    //     char result = input[0];

    //     foreach (char c in input)
    //     {
    //         if (!characters.ContainsKey(c))
    //         {
    //             count = 1;
    //             characters.Add(c, count);
    //         }
    //         else
    //         {
    //             count = characters[c] + 1;
    //             characters[c] = count;
    //         }
    //     }

    //     foreach (char c in input)
    //     {
    //         if (characters[c] == 1)
    //         {
    //             result = c;
    //             break;
    //         }
    //     }

    //     return result;
    // }



    // Problem 1
    // static void Main()
    // {
    //     string input = "banana";
    //     Program program = new Program();
    //     Dictionary<char, int> result = program.Solution(input);
    //     Console.WriteLine(string.Join(",", result));
    // }

    // public Dictionary<char, int> Solution(string input)
    // {
    //     var characterCounts = new Dictionary<char, int>();

    //     foreach (char c in input)
    //     {
    //         if (!characterCounts.ContainsKey(c))
    //         {
    //             characterCounts.Add(c, 1);
    //         }
    //         else
    //         {
    //             int count = characterCounts[c];
    //             count++;
    //             characterCounts[c] = count;
    //         }
    //     }

    //     return characterCounts;
    // }




    // // Generate numbers between A and 1_000_000_000 divisable by 10
    // public int Solution(int A)
    // {
    //     int start = (A + 9) / 10;
    //     int end = 1_000_000_000 / 10;

    //     Random rand = new Random();
    //     int num = rand.Next(start, end + 1) * 10;

    //     return num;
    // }

    // =====================================
    // Dice Problem
    // static void Main()
    // {
    //     int[] A = { 3, 2, 4 };
    //     int F = 2;
    //     int M = 3;
    //     Program program = new Program();
    //     int[] result = program.Solution(A, F, M);
    //     Console.WriteLine(string.Join(", ", result));
    // }

    // public int[] Solution(int[] A, int F, int M)
    // {
    //     int N = A.Length;
    //     int knownSum = 0;
    //     int missingSum;
    //     int targetSum = (N + F) * M;

    //     for (int i = 0; i < N; i++)
    //     {
    //         knownSum += A[i];
    //     }

    //     missingSum = targetSum - knownSum;

    //     if (missingSum < F || missingSum > (6 * F))
    //     {
    //         return new int[] { 0 };
    //     }

    //     int[] result = new int[F];

    //     for (int i = 0; i < F; i++)
    //     {
    //         result[i] = 1;
    //     }

    //     missingSum -= F;

    //     for (int i = 0; i < F; i++)
    //     {
    //         int add = Math.Min(5, missingSum);
    //         result[i] += add;
    //         missingSum -= add;
    //     }

    //     return result;
    // }
    // ====================================

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