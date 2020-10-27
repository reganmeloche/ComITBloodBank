using System;

namespace BloodClinic
{
    class Program
    {
        static void Main(string[] args)
        {
            var theBloodBank = new BloodBank();

            Console.WriteLine("Welcome to the ComIT Blood bank!");

            while (true) {
                Console.WriteLine("d - make donation; r - request donation; u - send update; q - quit");

                string userInput = Console.ReadLine();

                if (userInput == "d") {
                    theBloodBank.MakeDonation();
                }

                if (userInput == "r") {
                    theBloodBank.RequestDonation();
                }

                if (userInput == "u") {
                    theBloodBank.SendUpdateToAllMembers();
                }

                if (userInput == "q") {
                    break;
                }
            }

            Console.WriteLine("See you later!");


        }
    }
}
