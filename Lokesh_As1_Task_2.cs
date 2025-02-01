using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_task2
{
    internal class Task_2
    {
        static void Main(string[] args)
        {
            //Initializing ticket price for Purple, Green and Blue
            int PurpleTicketPrice = 50;
            int GreenTicketPrice = 80;
            int BlueTicketPrice = 100;

            //Initializing ticket variable     
            int PurpleTicket,GreenTicket,BlueTicket;

            Console.WriteLine("Joe's Raptors Game");
            
                // Getting input for purple ticket
                Console.Write("Enter Purple ticket:");
                PurpleTicket = int.Parse(Console.ReadLine());
                // Making to show error message, if user gives ticket lesser than 1
                if (PurpleTicket < 1)
                {
                    Console.WriteLine("Enter a valid number");
                    return;
                }

                // Printing amount spent for purple ticket           
                Console.WriteLine("Amount spent for Purple ticket: $" + PurpleTicketPrice * PurpleTicket);
            

            // Getting input from user for Green ticket
            Console.Write("Enter Green ticket:");
            GreenTicket = int.Parse(Console.ReadLine());
            // Making to show error message, if user gives ticket lesser than 1
            if (GreenTicket < 1)
            {
                Console.WriteLine("Enter a valid number");
                return;
            }
            // Printing amount spent for Green ticket
            Console.WriteLine("Amount spent for Green ticket: $" + GreenTicketPrice * GreenTicket);

            // Getting input from user for Blue ticket
            Console.Write("Enter Blue ticket:");
            BlueTicket = int.Parse(Console.ReadLine());

            //Making to show error message, if user gives ticket lesser than 1
            if (BlueTicket < 1)
            {
                Console.WriteLine("Enter a valid number");
                return;
            }   
            // Printing amount spent for Blue ticket
            Console.WriteLine("Amount spent for Blue ticket: $" + BlueTicketPrice * BlueTicket);

            // Total tickets
            int totalGames = PurpleTicket + GreenTicket + BlueTicket;
            // Total amount spent on all tickets
            int totalAmount = (PurpleTicketPrice * PurpleTicket) + (GreenTicketPrice * GreenTicket) + (BlueTicketPrice * BlueTicket);
            // Average cost 
            int average_cost =  totalAmount/totalGames;
            double average_cost_ticket = (double)average_cost;

            Console.WriteLine("\n -------Joe's Game Summary--------"); 

            // Printing Total games attended by Joe, Total amount spent, and Average amount spent
            Console.WriteLine("\nTotal Games: " + totalGames);
            Console.WriteLine("Total amount spent by Joe is: $" + totalAmount);
            Console.WriteLine("Average amount spent by Joe is: $" + average_cost);

            
        }
    }
}   
