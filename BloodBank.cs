using System;
using System.Collections.Generic;

namespace BloodClinic
{
    public class BloodBank
    {
        public BloodBank() {
            _members = new List<Member>();

            BloodType typeONeg = new BloodType("O",'-');
            BloodType typeAbPos = new BloodType("AB", '+');

            // Test donors
            Donor firstDonor = new Donor("Pablo", "Listingart", new DateTime(1980, 2, 23), typeONeg, "pablo@comit.org");
            Donor secondDonor = new Donor("Jesselyn", "Popoff", new DateTime(1990, 1,1), typeAbPos, "jesselyn@comit.org");

            // Test receiver
            Receiver testReceiver = new Receiver("Homer", "Simpson", new DateTime(1970, 3, 22), typeONeg, "test@comit.org");

            // Basic member
            Member member = new Member("Lisa", "Simpson", new DateTime(2000, 3, 24), typeAbPos, "");

            _members.Add(firstDonor);
            _members.Add(secondDonor);
            _members.Add(testReceiver);
            _members.Add(member);
        }

        private List<Member> _members;


        public void MakeDonation() {
            Console.WriteLine("Making donation");
        }

        public void RequestDonation() {
            Console.WriteLine("Request donation");
        }


        public void SendUpdateToAllMembers() {
            // Send update to all members
            for (int i = 0; i < _members.Count; i++) {
                var nextMember = _members[i];
                nextMember.SendUpdate();
            }
        }
    }
}