using System;

namespace BloodClinic
{
    public class Donation
    {
        public Guid Id { get; set; }
        public Donor Donor { get; set; }
        public DateTime DonationDate { get; set; }
    }
}