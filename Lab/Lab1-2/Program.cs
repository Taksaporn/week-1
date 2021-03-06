﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {
        static void Main(string[] args)
        {
            BubbleSortFunction  iput = new BubbleSortFunction(); // if not call class is not call function plss remember
            
            int[] a = iput.input();
            iput.process(a);
            iput.output(a);
          
        } 
        
        // input
        public int []input()
        {
            string v;
            Console.Write("Enter number for sort: ");
            v = Console.ReadLine();
            int[] input;
            input = v.Split(' ').Select(y => Convert.ToInt32(y)).ToArray();
            return input;

            //int[] x = { 4, 5, 2, 8, 9, 1, 2, 4, 3, 1 };
            //return x;
        }

        public void process(int[] input) {
            
            bool flag = true;
            while (flag)
                {
                    flag = false;
                    for (int i = 0; i != input.Length - 1; i++)
                    {
                        if (input[i] > input[i + 1])
                        {
                            int temp = input[i];
                            input[i] = input[i + 1];
                            input[i + 1] = temp;
                            flag = true;
                        }
                    }
                }
        }

        public void output(int[] input)
        {
           
            for (int i = 0; i != input.Length; i++)
                {
                    Console.Write(input[i]);
                    Console.Write(" ");
                }
                Console.ReadKey();
                
        }
    }
}
