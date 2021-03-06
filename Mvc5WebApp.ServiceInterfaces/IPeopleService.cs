﻿using Mvc5WebApp.Models;
using Mvc5WebApp.UI.ViewModels.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc5WebApp.ServiceInterfaces
{
    public interface IPeopleService
    {
        PeopleViewModel Get();

        PersonViewModel GetById(int id);
    }
}
