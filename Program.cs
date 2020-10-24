using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVIWeek5PracticalAssessment
{
    class Program
    {
        static void Main(string[] args)
        {

            string pinNumber = "1234";
            bool isValidPin = false;

            Console.WriteLine("You will only have 3 tries to guess the correct pin number.");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("What is your pin: ");
                string userPin = Console.ReadLine();

                if (userPin == pinNumber)
                {
                    isValidPin = true;
                    break;
                }

            }


            if (isValidPin)
            {
                Console.WriteLine("You have access to the application");
            }
            else
            {
                Console.WriteLine("You have exceeded the allowed number of attempts.");
            }





            Console.WriteLine("Press ENTER to exit");
            Console.ReadLine();


        }




    }
}