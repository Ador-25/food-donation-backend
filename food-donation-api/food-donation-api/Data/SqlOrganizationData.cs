using food_donation_api.Connection;
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
        ApplicationDbContext _applicationDbContext;
        public SqlOrganizationData(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public Organization AddOrganization(Organization organization)
        {
            _applicationDbContext.Organization.Add(organization);
            _applicationDbContext.SaveChanges();
            return organization;
        }

        public List<Organization> GetNearbyOrganizations(LocationFormat locationFormat)
        {
            return _applicationDbContext.Organization.
                Where(ul => ul.GoogleLocation.DistanceFrom(locationFormat) <= 2).ToList();
        }

        public Organization GetOrganization(string email)
        {
            var find = _applicationDbContext.Organization.Find(email);
            return find;
        }

        public List<Organization> GetOrganizationsByName(string organizationName)
        {
            return _applicationDbContext.Organization
                .Where(org => org.OrganizationName.Contains(organizationName))
                .ToList();
        }
    }
}
