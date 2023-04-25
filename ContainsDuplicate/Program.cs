﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainsDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Duplicates duplicates = new Duplicates();

            // Case 1
            int[] numbers1 = { 1, 2, 3, 1 };
            Console.WriteLine(duplicates.CheckForDuplicates(numbers1));

            // Case2 
            int[] numbers2 = { 1, 2, 3, 4 };
            Console.WriteLine(duplicates.CheckForDuplicatesUsingLINQ(numbers2));


            //Case3
            int[] numbers3 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            Console.WriteLine(duplicates.CheckForDuplicatesUsingLINQ(numbers3));

        }
    }
}
