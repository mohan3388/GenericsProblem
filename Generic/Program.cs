using System;
using Generic;

class Program
{
    public static void Main(string[] args)
    {
        GeneicProblem problem = new GeneicProblem();
        int[] arr1 = { 5, 2, 10, 20 };
        float[] arr2 = { 10.5f, 14.4f, 19.5f };
        string[] arr3 = { "abc", "abcd", "abcde", "abcef" };
        problem.MaxInt<int>(arr1);
        problem.MaxInt<float>(arr2);
        problem.MaxInt<string>(arr3);

    }
}
