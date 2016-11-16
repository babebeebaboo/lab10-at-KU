/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: huangjui.cs                       
//DATE: 15 Nov 2016                          
/////////////////////////////////////////////
﻿
using System;
class count
{
    static void Main()
    {
        double min = 100000, mon;
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());
        int[,] place = new int[row, col];
        for (int i = 0; i < row; i++)
        {
            string aa = Console.ReadLine();
            string[] ll = aa.Split(' ');
            for (int j = 0; j < col; j++) place[i, j] = Convert.ToInt32(ll[j]);
        }
        for (int i = 0; i < row - 1; i++)
            for (int j = 0; j < col - 1; j++)
            {
                mon = place[i, j] * 1.0 + place[i, j + 1] * 1.1 + place[i + 1, j] * 1.21 + place[i + 1, j + 1] * 1.1;
                if (min > mon) min = mon;
                mon = place[i, j] * 1.21 + place[i, j + 1] * 1.1 + place[i + 1, j] * 1.0 + place[i + 1, j + 1] * 1.1;
                if (min > mon) min = mon;
            }
        Console.WriteLine(min);
    }
}
