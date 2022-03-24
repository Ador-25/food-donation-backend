using food_donation_api.Helper;
using food_donation_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace food_donation_api.Data
{
    public class SqlOrganizationData : IOrganizationData
    {
        public List<Organization> GetNearbyOrganizations(LocationFormat locationFormat)
        {
            throw new NotImplementedException();
        }

        public Organization GetOrganization(string email)
        {
            throw new NotImplementedException();
        }

        public List<Organization> GetOrganizationsByName(string organizationName)
        {
            throw new NotImplementedException();
        }
    }
}
