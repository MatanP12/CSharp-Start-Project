using System;

namespace B20_Ex01_5
{
    public class Program
    {
        //-----------------------------------------------------------------------------------------------------------------------//
        public static void Main()
        {
            programInitiation();
        }

        //-----------------------------------------------------------------------------------------------------------------------//
        private static void programInitiation()
        {
            bool isLegalInput = false;
            Console.WriteLine("Please enter a string");
            string userInputString = Console.ReadLine();
            isLegalInput = checkUserInputString(userInputString);
            while (isLegalInput == false)
            {
                Console.WriteLine("Invalid input, please enter another:");
                userInputString = Console.ReadLine();
                isLegalInput = checkUserInputString(userInputString);
            }

            printMaximumDigitInTheNumber(userInputString);
            printMinimumDigitInTheNumber(userInputString);
            countDigitsDividedByThreeNoRemain(userInputString);
            countDigitsGreaterThanTheFirstDigit(userInputString);
        }

        //-----------------------------------------------------------------------------------------------------------------------//
        private static bool checkUserInputString(string i_UserInputString)
        {
            bool isLegalInput = i_UserInputString.Length == 9;

            if (isLegalInput)
            {
                if (!int.TryParse(i_UserInputString, out int stringNumberRepresentation))
                {
                    isLegalInput = false;
                }
                else
                {
                    isLegalInput = stringNumberRepresentation != 0;
                }
            }

            return isLegalInput;
        }

        //-----------------------------------------------------------------------------------------------------------------------//
        private static void printMaximumDigitInTheNumber(string i_Number)
        {
            double maximumDigit = char.GetNumericValue(i_Number[0]);
            double currentDigitNumberRepresentation;
            foreach (char digitToCheck in i_Number)
            {
                currentDigitNumberRepresentation = char.GetNumericValue(digitToCheck);
                if (currentDigitNumberRepresentation >= maximumDigit)
                {
                    maximumDigit = currentDigitNumberRepresentation;
                }
            }

            Console.WriteLine("The maximum digit in the string is: {0}", maximumDigit);
        }

        //-----------------------------------------------------------------------------------------------------------------------//
        private static void printMinimumDigitInTheNumber(string i_Number)
        {
            double minimumDigit = char.GetNumericValue(i_Number[0]);
            double currentDigitNumberRepresentation;
            foreach (char digitToCheck in i_Number)
            {
                currentDigitNumberRepresentation = char.GetNumericValue(digitToCheck);
                if (currentDigitNumberRepresentation <= minimumDigit)
                {
                    minimumDigit = currentDigitNumberRepresentation;
                }
            }

            Console.WriteLine("The minimum digit in the string is: {0}", minimumDigit);
        }

        //-----------------------------------------------------------------------------------------------------------------------//
        private static void countDigitsDividedByThreeNoRemain(string i_Number)
        {
            int numOfDigitsDividedByThreeWithoutRemain = 0;
            double currentDigitNumberRepresentation;
            foreach (char digitToCheck in i_Number)
            {
                currentDigitNumberRepresentation = char.GetNumericValue(digitToCheck);
                if (currentDigitNumberRepresentation % 3 == 0)
                {
                    numOfDigitsDividedByThreeWithoutRemain++;
                }
            }

            Console.WriteLine("The number of digits divided by 3 without a remain is: {0}", numOfDigitsDividedByThreeWithoutRemain);
        }

        //-----------------------------------------------------------------------------------------------------------------------//
        private static void countDigitsGreaterThanTheFirstDigit(string i_Number)
        {
            int numberOfDigitsGreaterThanTheFirstDigit = 0;
            double firstDigit = char.GetNumericValue(i_Number[i_Number.Length - 1]);
            double currentDigitNumberRepresentation;
            foreach (char digitToCheck in i_Number)
            {
                currentDigitNumberRepresentation = char.GetNumericValue(digitToCheck);
                if (currentDigitNumberRepresentation > firstDigit)
                {
                    numberOfDigitsGreaterThanTheFirstDigit++;
                }
            }

            Console.WriteLine("There are {0} digits greater than the first digit", numberOfDigitsGreaterThanTheFirstDigit);
        }

        //-----------------------------------------------------------------------------------------------------------------------//
    }
}
