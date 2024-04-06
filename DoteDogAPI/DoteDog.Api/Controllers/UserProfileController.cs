using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoteDog.DataAccess.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DoteDog.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserProfileController : ControllerBase
    {

        private readonly IUserProfileData _userProfile;

        public UserProfileController(IUserProfileData userProfile)
        {
            _userProfile = userProfile;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _userProfile.GetUsers());
        }
    }
}