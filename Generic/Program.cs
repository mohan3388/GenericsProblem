using System;
using Generic;

class Program
{
    public static void Main(string[] args)
    {
        
        GenericProblem problem = new GenericProblem();
        int[] intarr = { 10, 14, 15, 20, 26, 50 };
        float[] floatarr = { 10.4f, 15.8f, 18.17f, 40.02f };
        string[] stringarr = { "abc", "bdfr", "refwe", "treyss" };
        problem.MaxInt<int>(intarr);
        problem.MaxInt<float>(floatarr);
        problem.MaxInt<string>(stringarr);

    }
}
