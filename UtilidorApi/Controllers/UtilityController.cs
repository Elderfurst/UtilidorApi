using System.Collections.Generic;
using System.Threading.Tasks;
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
        [Route("running")]
        public async Task<List<CurrentInstance>> GetRunningUtilities()
        {
            return await _utilityService.GetRunningUtilities();
        }

        [HttpGet]
        public async Task<List<Utility>> GetAllUtilities()
        {
            return await _utilityService.GetAllUtilities();
        }

        [HttpGet]
        [Route("{utilityId}/instances")]
        public async Task<List<Instance>> GetInstancesByUtilityId(int utilityId, int count)
        {
            return await _utilityService.GetInstancesByUtilityId(utilityId, count);
        }

        [HttpGet]
        [Route("logs/{instanceId}")]
        public async Task<List<Log>> GetLogsByInstanceId(int instanceId)
        {
            return await _utilityService.GetLogsByInstanceId(instanceId);
        }
    }
}