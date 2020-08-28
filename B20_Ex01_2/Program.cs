using System;
using System.Text;

namespace B20_Ex01_2
{
    public class Program 
    {
        //-----------------------------------------------------------------------------------------------------------------------//
        public static void Main()
        {
            InitProgram();
        }

        //-----------------------------------------------------------------------------------------------------------------------//
        public static void InitProgram()
        {
            PrintSandClock(5);
        }

        //-----------------------------------------------------------------------------------------------------------------------//
        public static void PrintSandClock(int i_RowLength)
        {
            StringBuilder sandClockBuilder = new StringBuilder();

            // Uneven numbers are sent to function as is
            if (i_RowLength % 2 == 1) 
            {
                RecursivePrintSandClock(ref sandClockBuilder, i_RowLength, i_RowLength);
            }
            else
            {
                // Fixed even numbers by adding one before sending to function
                RecursivePrintSandClock(ref sandClockBuilder, i_RowLength + 1, i_RowLength + 1);
            }

            Console.Write(sandClockBuilder.ToString());
        }

        //-----------------------------------------------------------------------------------------------------------------------//
        public static void RecursivePrintSandClock(ref StringBuilder io_StringBuilder, int i_CurrentRowLength, int i_MaximumRowLength)
        {
            bool v_IsRowSmallerThanOne = false;
            int amountOfSpaces = (i_MaximumRowLength - i_CurrentRowLength) / 2;
            io_StringBuilder.Append(' ', amountOfSpaces);
            io_StringBuilder.Append('*', i_CurrentRowLength);
            io_StringBuilder.AppendLine();

            if (i_CurrentRowLength <= 1)
            {
                v_IsRowSmallerThanOne = true;
            }

            if (!v_IsRowSmallerThanOne)
            {
                RecursivePrintSandClock(ref io_StringBuilder, i_CurrentRowLength - 2, i_MaximumRowLength);

                io_StringBuilder.Append(' ', amountOfSpaces);
                io_StringBuilder.Append('*', i_CurrentRowLength);
                io_StringBuilder.AppendLine();
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------//
    }
}