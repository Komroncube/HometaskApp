// See https://aka.ms/new-console-template for more information
using Hometask;
using Hometask._18_09_2023;
using Hometask._19_09_2023;
using Hometask.Collections;

//Console.WriteLine("Hello, World!");
/*var solution = new SolutionFor_12_09_2023();
solution.Problem1();
solution.Problem2();
solution.Problem3();
solution.Problem4();
solution.Problem1_New();
Console.WriteLine(solution.MaximumNumber("132",new int[] { 9, 8, 5, 0, 3, 6, 4, 2, 6, 8}));*/

/*int[][] jaggedArray = new int[2][];
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

}*/

/*RegexHometask regex = new RegexHometask();
regex.GetEmail();
regex.Replace("AA@%^&CC");
regex.Replace("w3source.com");*/

//19-09-2023
/*FileSearcher fileSearcher = new FileSearcher();
fileSearcher.GetPathOfFile();*/

//data yozib olish uchun
/*using(FileStream file = new FileStream(@"fizika\baza.txt", FileMode.Open))
{
    using(StreamWriter writer = new StreamWriter(file))
    {
        for(int i = 0; i<100; i++)
        {
            writer.WriteLine(i);
        }
    }
}    */
/*
TestForStudents testForStudents = new TestForStudents();
testForStudents.CreateTestForStudent();*/
ConsoleCMD console =  new ConsoleCMD();
console.RunTerminal();