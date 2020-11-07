using System;
using System.Collections.Generic;

using BloodClinic.Models;

namespace BloodClinic.Storage
{
    public class DonorStorageDB : IStoreDonors
    {

        public DonorStorageDB() {

        }

        public void Create(Donor donorToCreate) {
            // Code...


            return;
        }

        public Donor GetById(Guid donorId) {
            // Code...
            return null;
        }

        public List<Donor> GetAll() {
            return new List<Donor>();
        }
    }
}