using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortingscript
{
    class Program
    {
        static bool Complete;

        static void Main(string[] args)
        {
            Sortnumbers();
        }

        static void Sortnumbers()
        {
            //numbers 2 sort
            int Num1;
            int Num2;
            int Num3;
            int Num4;
            //number generator
            Random rnd;
            //largest value and value being checked
            int Upperval = 5;
            int Current = 2;
            int Currentval = 0;

            rnd = new Random();

            //this gives each number a randomized value.
            Num1 = rnd.Next(0, 100);
            Num2 = rnd.Next(0, 100);
            Num3 = rnd.Next(0, 100);
            Num4 = rnd.Next(0, 100);

            Console.WriteLine("numbers: " + Num1 + "," + Num2 + "," + Num3 + "," + Num4);

            //thing loops until all numbers have been sorted
            while (Upperval > 1)
            {
                //whatever part of the order we're on becomes the current value.
                switch (Current)
                {
                    case 2:
                        Currentval = Num2;
                        break;

                    case 3:
                        Currentval = Num3;
                        break;

                    case 4:
                        int Currentval4 = Num4;
                        break;
                }
                //while we haven't gone past the highest found value it loops this
                while (Current < Upperval)
                {
                    //the current makes the current value equal to the position we're on, saves it as a separate integer, and then swaps them if needed.
                    switch (Current)
                    {
                        case 2:
                            Currentval = Num2;
                            int Currentsav = Num2;
                            if (Currentval < Num1)
                            {
                                Num2 = Num1;
                                Num1 = Currentsav;
                                Console.WriteLine("new order: " + Num1 + " , " + Num2 + " , " + Num3 + " , " + Num4);
                                ++Current;
                            }
                            //if not swapped puts out order and moves forward
                            else
                            {
                                Console.WriteLine("new order: " + Num1 + " , " + Num2 + " , " + Num3 + " , " + Num4);
                                ++Current;
                            }
                            break;

                        case 3:
                            Currentval = Num3;
                            Currentsav = Num3;
                            if (Currentval < Num2)
                            {
                                Num3 = Num2;
                                Num2 = Currentsav;
                                Console.WriteLine("new order: " + Num1 + " , " + Num2 + " , " + Num3 + " , " + Num4);
                                Current = 4;
                            }

                            else
                            {
                                Console.WriteLine("new order: " + Num1 + " , " + Num2 + " , " + Num3 + " , " + Num4);
                                Current = 4;
                            }
                            break;

                        case 4:
                            Currentval = Num4;
                            Currentsav = Num4;
                            if (Currentval < Num3)
                            {
                                Num4 = Num3;
                                Num3 = Currentsav;
                                Console.WriteLine("new order: " + Num1 + " , " + Num2 + " , " + Num3 + " , " + Num4);
                                Current = 5;
                            }

                            else
                            {
                                Console.WriteLine("new order: " + Num1 + " , " + Num2 + " , " + Num3 + " , " + Num4);
                                Current = 5;
                            }
                            break;
                    }
                }
                //when the loop gets to the end it resets and removes 1 from the highest value found (since we have our first highest value)
                Current = 2;
                Upperval = Upperval - 1;
            }
            //when its done, it puts out a console.writeline and lets you do another number set.
            Console.WriteLine("done!");
            Complete = true;
            if (Complete == true)
            {
                Console.WriteLine("press any key to sort another number set...");
                Console.ReadKey();
                Sortnumbers();
                Complete = false;
            }
        }
    }
 }

