﻿// See https://aka.ms/new-console-template for more information
using Hometask;
using Hometask.Collections;

//Console.WriteLine("Hello, World!");
/*var solution = new SolutionFor_12_09_2023();
solution.Problem1();
solution.Problem2();
solution.Problem3();
solution.Problem4();
solution.Problem1_New();
Console.WriteLine(solution.MaximumNumber("132",new int[] { 9, 8, 5, 0, 3, 6, 4, 2, 6, 8}));*/

int[][] jaggedArray = new int[2][];
jaggedArray[0] = new int[] { 31 };
jaggedArray[1] = new int[] { 28, 29 };
jaggedArray.YangiExtensionMethod(1, 7);
jaggedArray = jaggedArray.YangiExtensionMethod(8);


int len = jaggedArray.Length;
for(int i = 0; i < len; i++)
{
    foreach (int j in jaggedArray[i])
    {
        Console.Write(j + " ");
    }
    Console.WriteLine();

}