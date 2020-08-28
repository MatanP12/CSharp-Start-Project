using System;

namespace B20_Ex01_4
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
            Console.WriteLine("Please enter a string:");
            string userInputString = Console.ReadLine();
            isLegalInput = checkUserInputString(userInputString);
            while (isLegalInput == false)
            {
                Console.WriteLine("Invalid input, please enter another:");
                userInputString = Console.ReadLine();
                isLegalInput = checkUserInputString(userInputString);
            }

            checkIfTheStringIsPalindrome(userInputString);
            if (int.TryParse(userInputString, out int stringNumberRepresentation))
            {
                checkIfNumberDividedByFiveWithoutARemain(stringNumberRepresentation);
            }
            else
            {
                countNumOfUppercases(userInputString);
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------//
        // Check for a valid input
        private static bool checkUserInputString(string i_UserInputString)
        {
            bool isTheUserInputLegal = true;
            bool isNumberChar = false;
            bool isLetterChar = false;
            if (i_UserInputString.Length != 8)
            {
                isTheUserInputLegal = false;
            }

            foreach (char currentStringChar in i_UserInputString)
            {
                if (char.IsDigit(currentStringChar))
                {
                    isNumberChar = true;
                }
                else if (char.IsLetter(currentStringChar))
                {
                    isLetterChar = true;
                }
                else
                {
                    isTheUserInputLegal = false;
                    break;
                }

                if (isNumberChar == true && isLetterChar == true)
                {
                    isTheUserInputLegal = false;
                    break;
                }
            }

            return isTheUserInputLegal;
        }

        //-----------------------------------------------------------------------------------------------------------------------//
        // Check if the string is palindrome
        private static void checkIfTheStringIsPalindrome(string i_StringToCheck)
        {
            int startIndex = 0;
            int endIndex = i_StringToCheck.Length - 1;
            if (checkPalindromeForStringRecursive(i_StringToCheck, startIndex, endIndex))
            {
                Console.WriteLine("The string is Palindrome");
            }
            else
            {
                Console.WriteLine("The string is not Palindrome");
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------//
        // Check Palindrome recursive method
        private static bool checkPalindromeForStringRecursive(string i_StringToCheck, int i_LeftIndexOfCharToCheck, int i_RightIndexOfCharToCheck)
        {
            bool isPalindrome = true;
            if (i_LeftIndexOfCharToCheck > i_RightIndexOfCharToCheck)
            {
                isPalindrome = true;
            }
            else
            {
                if (i_StringToCheck[i_LeftIndexOfCharToCheck] != i_StringToCheck[i_RightIndexOfCharToCheck])
                {
                    isPalindrome = false;
                }
                else
                {
                    isPalindrome = checkPalindromeForStringRecursive(i_StringToCheck, i_LeftIndexOfCharToCheck + 1, i_RightIndexOfCharToCheck - 1);
                }
            }

            return isPalindrome;
        }

        //-----------------------------------------------------------------------------------------------------------------------//
        private static void countNumOfUppercases(string i_StringToCheck)
        {
            int numOfUppercases = 0;
            foreach (char currentStringChar in i_StringToCheck)
            {
                if (char.IsUpper(currentStringChar))
                {
                    numOfUppercases++;
                }
            }

            if (numOfUppercases == 0)
            {
                Console.WriteLine("There are no upper-cases in the string");
            }
            else
            {
                Console.WriteLine("The number of upper-cases in the string is: {0}", numOfUppercases);
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------//
        private static void checkIfNumberDividedByFiveWithoutARemain(int i_Number)
        {
            if (i_Number % 5 == 0)
            {
                Console.WriteLine("The number is divided by 5 without a remain");
            }
            else
            {
                Console.WriteLine("The number is not divided by 5 without a remain");
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------//
    }
}