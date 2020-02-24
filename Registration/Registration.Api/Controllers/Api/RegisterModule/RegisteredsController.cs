using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Registration.Domain.RegisterModule;
using Registration.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace Registration.Api.Controllers.RegisterModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class RegisteredsController : BaseDomainController<Registered,Registered>

    {

        public RegisteredsController(IRegisteredDomain domain):base(domain) {}

    }
}
