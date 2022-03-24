using food_donation_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace food_donation_api.Data
{
    public class SqlUserDonatesOrganizationData : IUserDonatesOrganizationData
    {
        public UserDonatesOrganization AcceptDonation(Guid donationId)
        {
            throw new NotImplementedException();
        }

        public UserDonatesOrganization CancelDonation(Guid donationId)
        {
            throw new NotImplementedException();
        }

        public UserDonatesOrganization CompleteDonation(Guid donationId)
        {
            throw new NotImplementedException();
        }

        public UserDonatesOrganization DeleteDonation(Guid donationId)
        {
            throw new NotImplementedException();
        }

        public List<UserDonatesOrganization> GetAllDonations(string OrganizationEmail)
        {
            throw new NotImplementedException();
        }

        public UserDonatesOrganization NewDonation(UserDonatesOrganization userDonatesOrganization)
        {
            throw new NotImplementedException();
        }

        public int NumberOfDonationsByUser(string UserEmail)
        {
            throw new NotImplementedException();
        }

        public int NumberOfDonationsToAnOrganization(string Organization)
        {
            throw new NotImplementedException();
        }

        public UserDonatesOrganization RejectDonation(Guid donationId)
        {
            throw new NotImplementedException();
        }
    }
}
