﻿using Microsoft.AspNetCore.Mvc;
using SaveUrShowUsingCFA.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaveUrShowUsingCFA.Repository.RegistrationRepository
{
    public interface IRegistrationRepository
    {
        Task<ActionResult<IEnumerable<Registration>>> GetRegistration();
        Task<ActionResult<Registration>> GetRegistration(string email, string password);
    }
}