using food_donation_api.Helper;
using food_donation_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace food_donation_api.Data
{
    public interface IOrganizationData
    {
        // Get all nearby organizations for a location
        List<Organization> GetNearbyOrganizations(LocationFormat locationFormat);
        // Get Organization Info by email
        Organization GetOrganization(string email);
        // Get list of Organizations for a name
        List<Organization> GetOrganizationsByName(string organizationName);

        Organization AddOrganization(Organization organization);
    }
}
