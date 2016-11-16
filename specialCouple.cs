/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: specialCouple.cs                  
//DATE: 10 Nov 2016                          
/////////////////////////////////////////////
﻿using System;
class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("How many students : ");
        int num = int.Parse(Console.ReadLine());
        string a = Console.ReadLine();
        string[] no = a.Split(' ');
        int ans = 0;
        for (int i = 0; i < num; i++)
        {

            for (int j = i + 1; j < num; j++)
            {
                int same = 0;
                if (no[i][0] == no[j][0]) same++;
                if (no[i][1] == no[j][1]) same++;
                if (no[i][2] == no[j][2]) same++;
                if (no[i][3] == no[j][3]) same++;
                if (same >= 2) ans++;
            }
        }
        Console.Write("{0} special couples", ans);
    }
}
