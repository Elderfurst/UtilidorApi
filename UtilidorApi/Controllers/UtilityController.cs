using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UtilidorApi.Models;
using UtilidorApi.Services.Interfaces;

namespace UtilidorApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilityController : ControllerBase
    {
        private readonly IUtilityService _utilityService;

        public UtilityController(IUtilityService utilityService)
        {
            _utilityService = utilityService;
        }
        [HttpGet]
        public async Task<List<Utility>> GetRunningUtilities()
        {
            return await _utilityService.GetRunningUtilities();
        }
    }
}