﻿/*CarpetCalculator.cs
 * Author: Levi Timothy
 * Date: 8/30/2023
 */

using System;
using static System.Console;

namespace CarpetCalculator
{
    public class CarpetCalculatorApp
    {
        public static void Main()
        {
            const int SQ_FT_PER_SQ_YARD = 9;
            const int INCHES_PER_FOOT = 12;
            const string BEST_CARPET = "Berber";
            const string ECONOMY_CARPET = "Pile";

            int roomLengthFeet = 12, roomLengthInches = 2,
                roomWidthFeet = 14, roomWidthInches = 7;
            double roomLength, roomWidth, carpetPrice,
                numberOfSquareFeet, numberOfSquareYards,
                totalCost;
            roomLength = roomLengthFeet + (double)roomLengthInches / INCHES_PER_FOOT;
            
            roomWidth = roomWidthFeet + (double)roomWidthInches / INCHES_PER_FOOT;
            
            numberOfSquareFeet = roomLength * roomWidth;
            numberOfSquareYards = numberOfSquareFeet / SQ_FT_PER_SQ_YARD;

            //Pass in the price for Berber
            carpetPrice = 27.95;

            totalCost = numberOfSquareYards * carpetPrice;

            WriteLine($"The cost of {BEST_CARPET} is {totalCost,0:C}");
            WriteLine();

            //Pass in the print for Pile
            carpetPrice = 15.95;

            totalCost = numberOfSquareYards * carpetPrice;

            WriteLine($"The cost of {ECONOMY_CARPET} is {totalCost,0:C}");
            WriteLine();
            ReadKey();
        }
    }
}