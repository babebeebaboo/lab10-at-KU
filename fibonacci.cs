/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: fibonacci.cs                      
//DATE: 10 Nov 2016                          
/////////////////////////////////////////////
﻿using System;
class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("n: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("a{1} = {0}", fibo(a), a);
    }
    public static int fibo(int a)
    {
        if (a == 0 || a == 1) return a;
        else return fibo(a - 1) + fibo(a - 2);
    }
}
/*

1. recursive เป็นการเรียกฟังก์ชั่นแบบเรียกวน ไม่เหมือนการ loop ที่ไม่มีการเรียกตัวเอง

2. Overflow เปลืองแรม เมม เวลา



*/
