﻿//Problem 3. Check for a Play Card

//Classical play cards use the following signs to designate the card face: 
//`2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints “yes” if it is a 
//valid card sign or “no” otherwise.

using System;

namespace PlayingCards
{
    class PlayingCards
    {
        static void Main()
        {
            Console.Write("Write a card to check if valid: ");
            string card = Console.ReadLine();

            Console.WriteLine();

            switch (card)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "A":
                case "K":
                case "Q":
                case "J": Console.WriteLine("The card is VALID.");
                    break;
                default: Console.WriteLine("The card is INVALID.");
                    break;
            }

            //using arryas

            /* string[] cardArray = new string[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "K", "Q", "J" };
            int position = Array.IndexOf(cardArray, card);

            Console.WriteLine();

            if (position > -1)
            {
                Console.WriteLine("The card is VALID.");
            }
            else
            {
                Console.WriteLine("The card is INVALID.");
            }
             */
        }
    }
}
