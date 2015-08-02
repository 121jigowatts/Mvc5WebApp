using Mvc5WebApp.Models;
using Mvc5WebApp.RepositoryInterfaces;
using Mvc5WebApp.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc5WebApp.ServiceImplementations
{
    public class PeopleService : IPeopleService
    {
        private readonly IPeopleRepository _repository;
        public PeopleService(IPeopleRepository repository)
        {
            this._repository = repository;
        }

        public IList<Person> Get()
        {
            return _repository.Get();
        }
    }
}
