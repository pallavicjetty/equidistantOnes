using System;
using System.Collections.Generic;

namespace equidistantOnes
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumber;
            Console.WriteLine("Enter the number to verify the eqidistant one's\n");
            inputNumber = Console.ReadLine();//input
            Console.WriteLine("entered number is {0}",inputNumber);
            Program p = new Program();

            //if it return true it is equidistant
            if (p.setNumber(inputNumber))
            {
                Console.WriteLine("It is equidistant");
            }
            //if it return false it is not equidistant
            else
                Console.WriteLine("It is not equidistant");
            Console.ReadKey();
        }
        public bool setNumber(string input)
        {
            //if input is empty then it throws exception
            if (string.IsNullOrEmpty(input))
            {
                throw new Exception("input cannot be empty");
            }

            int lengthOfTheString = input.Length;
            List<int> position = new List<int>();//to store the position of the one's
 
            for (int index= 0; index < lengthOfTheString; index++)
            {

                if (input[index] == '1' || input[index] == '0')//to check the string contains only zeroes and ones
                {
                    if(input[index] =='1')
                    {
                        Console.WriteLine("One present at {0}", index);
                        position.Add(Convert.ToInt32(index)); 
                    }
                }
                else
                    throw new Exception("should contain only ones and zeros");//if input string contains element other than zero and one it throws exception
            }
            int positionOfOnesLength = position.Count;//to determine the length 
            for (int j = 1; j < positionOfOnesLength; j++)
            {
                Console.WriteLine("you entered {0}", position[j]);
                if ((position[j] - position[j - 1]) != (position[1] - position[0]))
                    return false;
            }
            return true;
        }
    }

}
