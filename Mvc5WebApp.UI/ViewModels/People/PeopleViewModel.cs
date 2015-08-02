using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc5WebApp.UI.ViewModels.People
{
    public class PeopleViewModel
    {
        public IList<Models.Person> People { get; set; }
    }
}