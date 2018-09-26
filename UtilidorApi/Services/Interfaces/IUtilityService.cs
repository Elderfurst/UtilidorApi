using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UtilidorApi.Models;

namespace UtilidorApi.Services.Interfaces
{
    public interface IUtilityService
    {
        Task<List<Utility>> GetRunningUtilities();
    }
}
