using System;

namespace BloodClinic
{
    public class Donor : Member
    {
        public Donor(string firstName, string lastName, DateTime dateOfBirth, BloodType memberBloodType) 
            : base(firstName, lastName, dateOfBirth, memberBloodType) {
            LastDonatedDate = DateTime.MinValue;
            NumTimesDonated = 0;
        }

        public DateTime LastDonatedDate { get; set; }
        public int NumTimesDonated {get;set;}
    }
}