/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: wordSearch03.cs                   
//DATE: 15 Nov 2016                          
/////////////////////////////////////////////
﻿
using System;
class test
{
    public static void Main(string[] args)
    {
        Console.Write("Input Sentence: ");
        string input = Console.ReadLine();
        Console.Write("Input Word: ");
        string word = Console.ReadLine();
        word = word.ToUpper();
        string tmp;
        string ans = "";
        bool found = false;
        bool same = false;
        for (int i = 0; i < input.Length - word.Length; i++)
        {
            if (findword(input, word, i))
            {
                found = true;
                i += word.Length - 1;
            }
        }
        for (int i = 0; i < input.Length - word.Length + 1; i++)
        {
            if (findword(input, word, i, out tmp, found))
            {
                i += word.Length - 1;
                same = true;
                ans += tmp;
            }
            else
                ans += input[i];
        }
        if (same)
            Console.WriteLine("Found\n{0}", ans);
        else
            Console.WriteLine("Not found");
    }

    static bool findword(string input, string word, int p)
    {
        string res = "";
        for (int i = 0; i < word.Length; i++)
            res += input[i + p];
        if (res.ToUpper() == word) return true;
        return false;
    }
    static bool findword(string txt, string key, int p, out string res, bool found)
    {
        bool Second = false;
        res = "[";
        for (int i = 0; i < key.Length; i++)
        {
            if (txt[i + p].ToString().ToUpper() != key[i].ToString())
            {
                if (Second || found) return false;
                Second = true;
                res += "?";
            }
            else
                res += txt[i + p];
        }
        res += "]";
        return true;
    }
}
