﻿using System;


namespace capgemini_programs
{
    class Specialchar
    {

        static void Main()
        {
            //string str;
            int alphabet, digit, specialchar, i;
            alphabet = digit = specialchar = i = 0;



            Console.Write("Enter the string : ");
            string str = Console.ReadLine();
            int l = str.Length;



            while (i < l)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    alphabet++;
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    digit++;
                }
                else
                {
                    specialchar++;
                }



                i++;
            }



            Console.Write("Number of Alphabets in the string is : {0}\n", alphabet);
            Console.Write("Number of Digits in the string is : {0}\n", digit);
            Console.Write("Number of Special characters in the string is : {0}\n\n", specialchar);



            Console.ReadLine();



        }




    }
}
