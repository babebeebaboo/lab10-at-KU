using System;
class max
{
    static void Main()
    {
        Console.Write("Input an array: ");
        string rawInput = Console.ReadLine();
        string [] inputArr = rawInput.Split();
        int [] inputs = new int [inputArr.Length];
        for(int i = 0;i < inputArr.Length;i++)
        {
            inputs[i] = int.Parse(inputArr[i]);
        }
        int [] freq = new int [inputs.Length];
        mkFreq(freq,inputs);
        //printArr(freq);
        printResult(inputs, freq);
    }
    
    static void printResult(int [] inputs, int [] freq)
    {
        Console.Write("Result: ");
        int max = findMax(freq);
        for(int i = 0;i<freq.Length;i++)
        {
            if(freq[i] == max)
            {
                Console.Write("{");
                for(int j=i;j<max+i;j++)
                {
                    Console.Write(inputs[j]);
                    if(j != max+i-1)
                        Console.Write(",");
                }
                Console.Write("} ");
            }
        }
        Console.WriteLine();
    }
    static int findMax(int [] freq)
    {
        int max = 0;
        for(int i = 0;i<freq.Length;i++)
        {
            max = Math.Max(freq[i],max);
        }
        return max;
    }

    static void mkFreq(int [] freq, int [] inputs)
    {
        for(int now = 0;now<inputs.Length;now++)
        {
            int countFreq = 1;
            for(int next = now+1;next < inputs.Length;next++)
            {
                if(inputs[now]+countFreq==inputs[next])
                {
                    countFreq++;
                    if(next == inputs.Length-1)
                    {
                        freq[now] = countFreq;
                        now+=countFreq;
                        continue;
                    }
                }
                else
                {
                    freq[now] = countFreq;
                    now += countFreq;
                    continue;
                }
            }
        }
    }

    static void printArr(int [] arr){
        for(int i = 0 ;i<arr.Length;i++)
        {
            Console.Write(arr[i]);
        }
    }
}
