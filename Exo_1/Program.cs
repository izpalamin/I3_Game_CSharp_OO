﻿using Exo_Monoply.Enums;
using Exo_Monopoly.Models;
using System.Security.Cryptography;

namespace Exo_Monopoly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Joueur, veuillez indiquer votre nom :");
            string userName = Console.ReadLine();

            Console.WriteLine("Veuillez choisir un pion :");
            string[] pionNames = Enum.GetNames<Pions>();
            //Pions[] pions = Enum.GetValues<Pions>();

            foreach (string pionName in pionNames)
            {
                Console.WriteLine($"\t- {pionName}");
            }
            Console.WriteLine("Quel pion choisissez-vous?");
            string userInput = Console.ReadLine();
            Pions choice = Enum.Parse<Pions>(userInput);

            Joueur j1 = new Joueur()
            {
                nom = userName,
                pions = choice
            };

            Console.WriteLine($"Le joueur {j1.nom} avec le pion {j1.pions} se trouve à la case {j1.position}.");
            bool isDouble = j1.Avancer();
            if (isDouble)
            {
                Console.WriteLine("Super! Un double!");
            }
            Console.WriteLine($"Le joueur {j1.nom} avec le pion {j1.pions} se trouve à la case {j1.position}.");


        }
    }
}
