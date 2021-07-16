using System;
using System.Collections.Generic;
using System.Linq;

namespace Skocimis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            //Three integers A, B and C (0 < A < B < C < 100), the intial position of the kangaroos
            string input = Console.ReadLine();

            string[] positions = input.Split(" ");

            int positionLeft = int.Parse(positions[0]);
            int positionMiddle = int.Parse(positions[1]);
            int positionRight = int.Parse(positions[2]);

            int leftGap;
            int rightGap;
            int numberOfJumps = 0;
            int newMiddle;
            do
            {

                leftGap = positionMiddle - positionLeft;
                rightGap = positionRight - positionMiddle;

                if(leftGap == 1 && rightGap == 1)
                {
                    continue;
                }


                if (rightGap > leftGap)
                {
                    newMiddle = positionMiddle + 1;
                    positionLeft = positionMiddle;  
                }
                else
                {
                    newMiddle = positionMiddle - 1;
                    positionRight = positionMiddle;
                }

                positionMiddle = newMiddle;
                numberOfJumps++;

            } while (leftGap > 1 || rightGap > 1);

            Console.WriteLine(numberOfJumps);
        }
    }
}
