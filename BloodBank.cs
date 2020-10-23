using System;

namespace BloodClinic
{
    public class BloodBank
    {
        public void MakeDonation() {
            Console.WriteLine("Making donation");

            // Sandbox
            BloodType typeONeg = new BloodType("O",'-');
            BloodType typeAbPos = new BloodType("AB", '+');

            Donor firstDonor = new Donor("Pablo", "Listingart", new DateTime(1980, 2, 23), typeONeg);

            Donor secondDonor = new Donor("Jesselyn", "Popoff", new DateTime(1990, 1,1), typeAbPos);

            



        }

        public void RequestDonation() {
            Console.WriteLine("Request donation");
        }
    }
}