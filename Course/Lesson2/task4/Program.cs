﻿namespace task4;

using System;

class Program
{
    static void Main()
    {
        int num = 0;
        Console.WriteLine("Нажмите клавишу Enter несколько раз:");
        for (int i = 0; i<= 1000; i++ )
        {
            if (Console.ReadLine() == "")
            {
                num += 1;
            }
            else
            {
                Console.WriteLine("Я не разрешал писать что-то кроме enter...... Ты нажал enter "+ num + "раз.");
            }
           
        }
    }   
}