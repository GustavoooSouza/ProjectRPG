﻿using System;
using ProjetoRPG.Entities;

namespace ProjetoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");

            Console.WriteLine(knight.Attack());
            Console.WriteLine(wizard.MagicAttack());
        }
    }
}
