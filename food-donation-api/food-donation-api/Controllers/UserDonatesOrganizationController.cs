using food_donation_api.Connection;
using food_donation_api.Data;
using food_donation_api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace food_donation_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDonatesOrganizationController : ControllerBase
    {
        private IUserDonatesOrganizationData _iData;
        public UserDonatesOrganizationController(IUserDonatesOrganizationData iData)
        {
            _iData = iData;
        }
        // GET: api/<UserDonatesOrganizationController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UserDonatesOrganizationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserDonatesOrganizationController>
        [HttpPost("new-req")]
        [Authorize("User")] //"Admin"
        public IActionResult NewRequest([FromBody] UserDonatesOrganization  userDonatesOrganization)
        {
            var find = User.Identity.Name;
            userDonatesOrganization.User.Email=find;
            return Ok(
            _iData.NewDonation(userDonatesOrganization)!=null? 
            new Response { Status="Ok", Message= "Request Success"}
            : new Response { Status = "Error", Message = "Request Error" });

        }


        [HttpPut("accept-req/{id}")]
        [Authorize("Admin")] //"Admin"
        public IActionResult AcceptRequest(Guid id)
        {
            
            return Ok(_iData.AcceptDonation(id) != null ?
            new Response { Status = "Ok", Message = "Request Success" }
            : new Response { Status = "Error", Message = "Request Error" });

        }

        // PUT api/<UserDonatesOrganizationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserDonatesOrganizationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
