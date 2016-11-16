/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: stringDetection.cs                
//DATE: 10 Nov 2016                          
/////////////////////////////////////////////
﻿using System;
using System.Collections.Generic;
class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("Input: ");
        Stack<char> stc = new Stack<char>();
        Stack<char> bstc = new Stack<char>();
        int now = 0;
        bool secfuck = false;
        bool firstfuck = false;
        bool bsecfuck = false;
        bool bfirstfuck = false;
        while (true)
        {
            char a = Convert.ToChar(Console.Read());
            if (a == '\n') break;
            if (a == 'R') { now++; continue; }
            if (a == 'L') { now++; continue; }
            if (a == 'M') { now++; continue; }
            if (now == 0)
            {

                if (a != 'a' && a != 'b' && a != 'c' && a != 'd') bfirstfuck = true;
                stc.Push(a);
            }

            if (now == 2)
            {

                if (a != 'a' && a != 'b' && a != 'c' && a != 'd') bsecfuck = true;
                bstc.Push(a);
            }

            if (now == 1)
            {
                if (a != 'R' && a != 'L' && a != 'M')
                {
                    if (stc.Count == 0) firstfuck = true;
                    else if (stc.Peek() != a) { firstfuck = true; }
                    else if (stc.Peek() == a) stc.Pop();
                }
            }

            if (now == 3)
            {
                if (a != 'R' && a != 'L' && a != 'M')
                {
                    if (bstc.Count == 0) secfuck = true;
                    else if (bstc.Peek() != a) { secfuck = true; }
                    else if (bstc.Peek() == a) bstc.Pop();
                }
            }

        }
        if (bfirstfuck) Console.WriteLine("w string is not correct format.");
        else Console.WriteLine("w string is correct format.");
        if (firstfuck) Console.WriteLine("x string is not correct format.");
        else Console.WriteLine("x string is correct format.");
        if (bsecfuck) Console.WriteLine("y string is not correct format.");
        else Console.WriteLine("y string is correct format.");
        if (secfuck) Console.WriteLine("z string is not correct format.");
        else Console.WriteLine("z string is correct format.");
    }
}
