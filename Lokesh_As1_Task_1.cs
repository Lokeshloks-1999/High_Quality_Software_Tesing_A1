using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Task_1
    {
        static void Main(string[] args)
        {
            
            int TorontoTOCalgary = 1350*2;
            int TorontoTOVancouver = 1500*2;
            int TorontoToMontreal = 575*2;

            

            // Total number of trips to Calgary
            Console.Write("Enter the total number of trips did Carlo took from Toronto to Calgary: ");
            // Reading input as string and converting into integer
            int TotalCalgaryTrip = int.Parse(Console.ReadLine());
            if (TotalCalgaryTrip < 1)
            {
                Console.WriteLine("Please enter a valid number");
                return;
            }
            // Formula for calculating trip cost from Toronto to Calgary
            double TotalSpentForCalgary = (TorontoTOCalgary * TotalCalgaryTrip);
            //Printing the total expense for Caralo from Toronto to Calgary
            Console.WriteLine("The total expense for Caralo from Toronto to Calgary is:" + "$" + TotalSpentForCalgary);


            // Total number of trips to Vancouver
            Console.Write("Enter the total number of trips did Carlo took from Toronto to Vancouver:");
            // Reading input as string and converting into integer
            int TotalVancouverTrip = int.Parse(Console.ReadLine());
            if  (TotalVancouverTrip < 1)
                {
                Console.WriteLine("Please enter a valid number");
                return;

            }
            // Formula for calculating trip cost from Toronto to  Vancouver
            double TotalSpentForVancover = (TorontoTOVancouver * TotalVancouverTrip);
            //Printing the total expense for Caralo from Toronto to Vancouver
            Console.WriteLine("The total expense for Caralo from Toronto to Vancouver is:" + "$" + TotalSpentForVancover);


            // Total number of trips to Vancouver
            Console.Write("Enter the total number of trips did Carlo took from Toronto to Montreal:");
            // Reading input as string and converting into integer
            int TotalMontrealTrip = int.Parse(Console.ReadLine());
            if (TotalMontrealTrip < 1)
            {
                Console.WriteLine("Please enter a valid number");
                return;
            }
            // Formula for calculating trip cost from Toronto to Montreal
            double TotalSpentForMontreal = (TorontoToMontreal * TotalMontrealTrip);
            //Printing the total expense for Caralo from Toronto to Montreal
            Console.WriteLine("The total expense for Caralo from Toronto to Montreal is:" + "$" + TotalSpentForMontreal);


            Console.WriteLine("\n ------ Summary for Caralo's trip-------");



            //Formula for Calculating the overall trip cost
            double TotalTripCost = (TotalSpentForCalgary + TotalSpentForVancover + TotalSpentForMontreal);
            // Printing the overall trip cost
            Console.WriteLine("\n Money spent by Caralo for the overall trip is:" + "$" + TotalTripCost);


            //Total number of trips by Carlo
            int total_trips = (TotalCalgaryTrip + TotalVancouverTrip + TotalMontrealTrip );
            Console.WriteLine("Total number of trips by Caralo is:" + total_trips + "trips" );


            //Explicit Casting - Conversion of double to float - Example to understand the concept

            //double doubleValue = value;
            //float floatValue = (float)doubleValue; // Explicit conversion
            //Console.WriteLine(floatValue);

            // Average overall trip cost 
            double AverageCost = (TotalTripCost / total_trips);
            float AverageTripCost = (float)AverageCost;
            Console.WriteLine("Average cost of a trip is:" + "$" + AverageTripCost);


        }
    }
}
