using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Demo.Controllers
{
    /// <summary>
    /// this is where i give you all the information about my peeps
    /// </summary>
    public class peopleController : ApiController
    {
        List<person> people = new List<person>();

        public peopleController()
        {
            people.Add(new person { FirstName = "Laura", LastName = " Ouf", Id = 1 });
            people.Add(new person { FirstName = "Sue", LastName = " Storm", Id = 2 });
            people.Add(new person { FirstName = "Bilbo", LastName = " Corey", Id = 3 });
        }
        /// <summary>
        /// Gets a list of the first names of all users
        /// </summary>
        /// <param name="userId">The unique identifier for this person.</param>
        /// <param name="age">we want to know how old they are.</param>
        /// <returns>A list of first names....</returns>
        [Route("api/people/GetFirstNames/{userId:int}/{age:int}")]
        [HttpGet]
        public List<string> GetFirstNames(int userId, int age)
        {
            List<string> output = new List<string>();
            foreach (var p in people)
            {
                output.Add(p.FirstName);
            }
            return output;
        }

        // GET: api/people
        public List<person> Get()
        {
            return people;
        }

        // GET: api/people/5
        public person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/people
        public void Post(person val)
        {
            people.Add(val);
        
        }

        // DELETE: api/people/5
        public void Delete(int id)
        {
        }
    }
}
