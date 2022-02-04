﻿using System;
using System.Collections.Generic;
class Program
{
    public static void Main(string[] args)
    {
        var totalDeCasosDeTeste = int.Parse(Console.ReadLine());
        // Implemente a solução aqui
        List<string> lista = new List<string>();

        for (int i = 0; i < totalDeCasosDeTeste; i++)
        {
            if (i > 100) return;
            string[] linha = Console.ReadLine().Split(" ");

            for (int item = 0; item < linha.Length; item++)
            {
                if (item > 1000) return;
                if (!lista.Contains(linha[item]))
                {
                    lista.Add(linha[item]);
                }
            }

            lista.Sort();
            Console.WriteLine(string.Join(" ", lista));
            lista.Clear();
        }
    }
}