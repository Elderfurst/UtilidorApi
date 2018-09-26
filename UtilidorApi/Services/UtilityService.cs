using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UtilidorApi.Data;
using UtilidorApi.Models;
using UtilidorApi.Services.Interfaces;

namespace UtilidorApi.Services
{
    public class UtilityService : IUtilityService
    {
        private readonly UtilidorContext _utilityContext;

        public Task<List<Utility>> GetRunningUtilities()
        {
            return null;
        }
    }
}
