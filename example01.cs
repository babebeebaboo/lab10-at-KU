using System;
class insertion
{
    static void Main()
    {
        /*
         * This program shows the process of insertion sorting algolithm
         * 
         * Enjoy and Have fun with Coding
         */

        Console.Write("Input: ");
        string input = Console.ReadLine();
        string [] inputArr = input.Split(' ');
        int [] inputs = new int [inputArr.Length];
        for(int i = 0;i<inputArr.Length;i++)
            inputs[i] = int.Parse(inputArr[i]);
        insertionSort(inputs);
        Console.Write("Result: ");
        printArr(inputs);
    }

    static void insertionSort(int [] inputs)
    {
        for(int run = 0;run<inputs.Length; run++)
        {
            //Press something to continue the next step
            Console.ReadKey();
            Console.WriteLine("Round" + Convert.ToString(run+1));
            int now = run;
            for(int sort = run-1;sort>=0;sort--)
            {
                if(inputs[now] < inputs[sort])
                {
                    Console.ReadKey();
                    int temp = inputs[sort];
                    inputs[sort] = inputs[now];
                    inputs[now] = temp;
                    now = sort;
                    printArr(inputs);
                }
            }
            Console.WriteLine();
        }
    }

    static void printArr(int [] inputs)
    {
        for(int i = 0;i<inputs.Length;i++)
        {
            Console.Write(" ");
            Console.Write(inputs[i]);
        }
        Console.WriteLine();
    }
}
