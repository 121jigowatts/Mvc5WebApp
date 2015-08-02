using Mvc5WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc5WebApp.RepositoryInterfaces
{
    public interface IPeopleRepository
    {
        IList<Person> Get();
    }
}
