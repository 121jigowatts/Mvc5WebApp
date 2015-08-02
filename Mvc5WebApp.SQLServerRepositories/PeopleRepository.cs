using Mvc5WebApp.Contracts;
using Mvc5WebApp.Models;
using Mvc5WebApp.RepositoryInterfaces;
using Mvc5WebApp.SQLServerRepositories.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc5WebApp.SQLServerRepositories
{
    public class PeopleRepository : IPeopleRepository
    {
        private readonly IObjectMapper _mapper;
        public PeopleRepository(IObjectMapper mapper) 
        {
            this._mapper = mapper;
        }

        public IList<Models.Person> Get()
        {
            using (var context = new EFContext()) 
            {
                var query = from x in context.People
                            select x;

                var list = query.ToList<SQLServerRepositories.Database.Person>();

                var people = _mapper.Map<List<Models.Person>>(list);

                return people;
                
            }
            
        }
    }
}
