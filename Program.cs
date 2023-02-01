/**
 * Author: Jesus Noland
 * Creation date: 01-09-2023
 * Purpose: Class 1 C# concepts
 */
using System;
using WackyStudios;

namespace CSharpHelloWorld415
{
    public class Program
    {
        static void Main(string[] args)
        {
            int GetTotalScore(int generalScore, int bonusScore)
            {
                return generalScore + bonusScore;
            }

            bool IsEqual(char[] charArray, string stringArray)
            {
                for (int index = 0; index < charArray.Length; index++)
                {
                    if (stringArray[index] == charArray[index])
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }

                return true;
            }

            Console.WriteLine("Hello World!");

            // char[] helloCharArray = { 'h', 'e', 'l', 'o', 'o' };
            string helloString = "helo";
            // char[] helloCharArray = helloString.ToCharArray();
            char[] helloCharArray = new char[helloString.Length];
            for (int index = 0; index < helloCharArray.Length; index++)
            {
                helloCharArray[index] = helloString[index];
            }

            string? playerInput = Console.ReadLine();

            if (playerInput != null && playerInput != "")
            {
                char playerCharChoice = playerInput[0];
                Console.WriteLine(playerCharChoice);
            }

            Console.WriteLine(helloString[1]);

            if (IsEqual(helloCharArray, helloString))
            {
                Console.WriteLine("It is the cheese.");
            }
            else
            {
                Console.WriteLine("No equals");
            }

            Person person1 = new Person();
            int someAge = 33;
            person1.SetAge(someAge);
            Console.WriteLine(person1.SayAge());

            // Variables needed in Main
            string gameOver = "true";
            bool playerWin;
            int playerScore = 99;
            int bonus = 50;
            bonus -= playerScore;
            bonus++;
            bonus--;

            for (int i = 150; i > playerScore; i--)
            {
                Console.WriteLine("Score: " + i);
            }
            int totalScore = GetTotalScore(playerScore, bonus);

            float playerSpeed = 1.56456456f;

            // String array of player choices
            string[] playerChoices = new string[10];
            playerChoices[0] = "hello";
            int playerChoiceIndex = 0;

            string[] guessStrings = new string[5]
            {
                "hamburger",
                "fries",
                "shake",
                "pepsi",
                "cake"
            };
            Console.WriteLine(guessStrings[0]);

            guessStrings[1] = "donut";
            Console.WriteLine(guessStrings[1]);

            // Console.WriteLine("Your total score is " + totalScore);

            // Console.WriteLine("Welcome to Hang the " + playerInput);

            // This will not be compiled
            // Console.WriteLine("Is the sky blue? " + gameOver);

            // playerWin = true;
            Console.WriteLine("You alive? ");

            bool friend = true;
            int friendScore = 99;
            if (!friend)
            {
                Console.WriteLine("Boo!");
                friendScore = 0;
            }
            Console.WriteLine(friendScore);
            while (true)
            {
                // do stuff here
                // Console.WriteLine("You alive? " + playerWin);
                playerInput = Console.ReadLine();
                if (playerInput == "quit")
                {
                    break;
                }
                else
                {
                    if (playerInput != null)
                    {
                        // 0        1 2 3 4
                        // [onion][][][][]
                        playerChoices[playerChoiceIndex] = playerInput;
                    }
                    continue;
                }
            }
            Console.WriteLine("Thank you, come again!");
            Console.WriteLine(playerChoices[playerChoiceIndex]);
        }
    }
}
