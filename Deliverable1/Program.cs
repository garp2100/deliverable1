using System;

class MainClass
{
    public static void Main(string[] args)
    {
        string restartValue;

        while(true)
        {
            Console.WriteLine("How many people are we making PB and J sandwiches for?");
            int numberOfPeople = int.Parse(Console.ReadLine());
            decimal totalSlicesNeeded = numberOfPeople * 2;
            decimal totalPbTblSpnsNeeded = numberOfPeople * 2;
            decimal totalJellyTeaSpnsNeeded = numberOfPeople * 4;

            decimal totalLoavesNeededed = totalSlicesNeeded / 28;
            decimal totalPbJarsNeeded = totalPbTblSpnsNeeded / 32;
            decimal TotalJellyJarsNeeded = totalJellyTeaSpnsNeeded / 48;

            Console.WriteLine(
                "for " + numberOfPeople + " people" + Environment.NewLine +
                "you need: " + Environment.NewLine +
                totalSlicesNeeded + " slices of bread" + Environment.NewLine +
                totalPbTblSpnsNeeded + " tablespoons of peanut butter" + Environment.NewLine +
                totalJellyTeaSpnsNeeded + " teaspoons of jelly" + Environment.NewLine +
                "which is..." + Environment.NewLine +
                Math.Ceiling(totalLoavesNeededed) + " loaves of bread" + Environment.NewLine +
                Math.Ceiling(totalPbJarsNeeded) + " jars of peanut butter" + Environment.NewLine +
                Math.Ceiling(TotalJellyJarsNeeded) + " jars jelly" + Environment.NewLine              
                );
            while (true)
            {
                Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");
                restartValue = Console.ReadLine().ToLower();
                if (restartValue == "y")
                    break;
                if (restartValue == "yes")
                    break;
                else
                    Console.WriteLine("Goodbye!");
                    Environment.Exit(0);
            }
        }      
    }
}