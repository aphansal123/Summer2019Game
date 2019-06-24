using System;

namespace DataTypes {
    class Program {
        public static void Main(string[] args) {
            int totalSecondsPlayed = 100;
            const int secondsPerMniute = 60;
            
            // calculate minutes and seconds played
            int minutesPlayed = totalSecondsPlayed / secondsPerMniute;
            int secondsPlayed = totalSecondsPlayed;
            
            // print results
            Console.WriteLine("Minutes Played: " + minutesPlayed);
            Console.WriteLine("Seconds Played: " + secondsPlayed);
            
            // calculate and print the cosine of 45 degrees
            // float cosine = (float) Math.Cos(45); //0.8f;
            
            // convert from degrees to radians
            float cosine = (float) Math.Cos(45 * Math.PI / 180); //0.8f;
            
            Console.WriteLine("Cosine of 45 degrees: " + cosine);

            Console.WriteLine();

            Console.WriteLine("Pick up the shiny thing? (1 for yes, 2 for no):\n");
            int answer = int.Parse(Console.ReadLine());
            /*if (answer == 1) {
                Console.WriteLine("You have the shinny thing!");
            } else if (answer == 2) {
                Console.WriteLine("You have the dull thing.");
            } else {
                Console.WriteLine("invalid input");
            }*/
            switch (answer) {
                case 1:
                    Console.WriteLine("You have the shiny thing");
                    break;
                case 2:
                    Console.WriteLine("You do not have the shiny thing");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
            // Console.WriteLine("Answer : " + answer);
        }
    }
}