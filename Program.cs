﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cd;
            double d;
            double r;

            Console.Write("Qual é a cotação do dolar: ");
            cd = double.Parse(Console.ReadLine());

            Console.Write("Qual é o valor em dolares: ");
            d = double.Parse(Console.ReadLine());

            r = d * cd;

            Console.WriteLine("O valor em reais é: {0:f}R$", r);

        }
    }
}
