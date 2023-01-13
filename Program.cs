/**
 * Author: Jesus Noland
 * Creation date: 01-09-2023
 * Purpose: Class 1 C# concepts
 */
using System;

namespace HangTheMan
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Variables needed in Main
            bool gameOver = false;
            bool playerWin;

            string playerInput = "my name is george";
            Console.WriteLine("Welcome to Hang the " + playerInput);

            // This will not be compiled
            Console.WriteLine("Is the sky blue? " + gameOver);

            playerWin = true;
            Console.WriteLine("You alive? " + playerWin);
        }
    }
}