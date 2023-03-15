using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SaveUrShowUsingCFA.Controllers;
using SaveUrShowUsingCFA.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaveUrShowUsingCFA.Repository.RegistrationRepository
{
    public class RegistrationRepository : IRegistrationRepository
    {
        private readonly SaveUrShowUsingCFADbContext _context;
        private readonly ILogger<RegistrationsController> _logger;

        public RegistrationRepository(SaveUrShowUsingCFADbContext context, ILogger<RegistrationsController> logger)
        {
            _context = context;
            _logger = logger;
        }
        public async Task<ActionResult<IEnumerable<Registration>>> GetRegistration()
        {
            //_logger.LogInformation["Getting all the users successfully."];
            return await _context.Registration.ToListAsync();
            //throw new NotImplementedException();
        }

        public async Task<ActionResult<Registration>> GetRegistration(string email, string password)
        {
            var registration = await _context.Registration.FirstOrDefaultAsync(record => record.email == email && record.password == password); 
            return registration;
        }
    }
}
