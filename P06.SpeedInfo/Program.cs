﻿using System;

namespace P06.SpeedInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Да се напише програма, която чете скорост(реално число), въведена от потребителя и отпечатва информация за скоростта. 
         double speed = double.Parse(Console.ReadLine());
            //•При скорост до 10(включително) отпечатайте "slow"
            if (speed <= 10)
                Console.WriteLine("slow");
            //•При скорост над 10 и до 50(включително) отпечатайте "average"
            else if (speed <= 50) 
                Console.WriteLine("average");
             //•При скорост над 50 и до 150(включително) отпечатайте "fast"
            else if (speed <= 150)
                Console.WriteLine("fast");
            //•При скорост над 150 и до 1000(включително) отпечатайте "ultra fast"
            else if (speed <= 1000)
                Console.WriteLine("ultra fast");
            //•При по-висока скорост отпечатайте "extremely fast"
            else
                Console.WriteLine("extremely fast");

        }
    }
}
