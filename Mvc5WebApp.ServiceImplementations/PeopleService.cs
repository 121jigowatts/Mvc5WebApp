using Mvc5WebApp.Contracts;
using Mvc5WebApp.Models;
using Mvc5WebApp.RepositoryInterfaces;
using Mvc5WebApp.ServiceInterfaces;
using Mvc5WebApp.UI.ViewModels.People;
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
        private readonly IObjectMapper _mapper;
        public PeopleService(IPeopleRepository repository,IObjectMapper mapper)
        {
            this._repository = repository;
            this._mapper = mapper;
        }

        public PeopleViewModel Get()
        {
            var model = new PeopleViewModel();
            model.People = _repository.Get();
            return model;
        }


        public PersonViewModel GetById(int id)
        {
            var person = _repository.GetById(id);
            var model = _mapper.Map<PersonViewModel>(person);
            return model;
        }
    }
}
