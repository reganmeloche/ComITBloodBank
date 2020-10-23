using System;

namespace BloodClinic
{
    public class Receiver : Member
    {
        public Receiver(string firstName, string lastName, DateTime dateOfBirth, BloodType memberBloodType)
             {
            LastReceivedDate = DateTime.MinValue;
        }

        public DateTime LastReceivedDate { get; set; }
    }
}