using System;

namespace BloodClinic
{
    public class Donor : Member
    {
        public Donor(string firstName, string lastName, DateTime dateOfBirth, BloodType memberBloodType, string email) 
            : base(firstName, lastName, dateOfBirth, memberBloodType, email) {
            LastDonatedDate = DateTime.MinValue;
            NumTimesDonated = 0;
        }

        public DateTime LastDonatedDate { get; set; }
        public int NumTimesDonated {get;set;}

        public override void SendUpdate() {
            Console.WriteLine("\nHello donor!");
            Console.WriteLine($"Name: {FullName}");
            Console.WriteLine($"Num times donated: {NumTimesDonated}");
            Console.WriteLine($"Last Donation Date: {LastDonatedDate}\n");
            
        }
    }
}