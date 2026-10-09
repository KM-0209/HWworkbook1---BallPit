using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// <summary>
// This program calculates the number of balls that can fit in a pit based on user input for the dimensions of the pit and the balls.
// </summary>

class Program
    {
        // Method to calculate the volume of the pit
        static double pitVolume(double pitRadius, double pitHeight)
        {
            return 3.14 * (pitRadius * pitRadius) * pitHeight;
        }

        // Method to calculate the volume of the ball
        static double ballVolume(double ballRadius)
        {
            return (4.0 / 3.0) * 3.14 * (ballRadius * ballRadius * ballRadius);
        }
        
        // Method to calculate and display the number of balls that can fit in the pit
        static void Main(string[] args)
        {
            double pitRadius;
            double pitHeight;
            double ballRadius;
            
            // Get user input for the radius and height of the pit, and the radius of the ball
            Console.Write("What is the radius of the pit in meters? ");
            while (!double.TryParse(Console.ReadLine(), out pitRadius) || pitRadius <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number for the radius of the pit.");
                Console.Write("What is the radius of the pit in meters? ");
            }
            Console.Write("What is the height of the pit in meters? ");
            while (!double.TryParse(Console.ReadLine(), out pitHeight) || pitHeight <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number for the height of the pit.");
                Console.Write("What is the height of the pit in meters? ");
            }
            

            Console.Write("What is the radius of the ball in meters? ");
            while (!double.TryParse(Console.ReadLine(), out ballRadius) || ballRadius <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number for the radius of the ball.");
                Console.Write("What is the radius of the ball in meters? ");
            }
            
            // Calculate the number of balls that can fit in the pit
            double numberOfBalls = (pitVolume(pitRadius, pitHeight) / ballVolume(ballRadius)) * 0.75;
            int roundedNumberOfBalls = (int)Math.Floor(numberOfBalls);
            Console.WriteLine("The number of balls that can fit in the pit is: {0}", roundedNumberOfBalls);
        }
    }
