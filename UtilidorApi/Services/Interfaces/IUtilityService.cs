using System.Collections.Generic;
using System.Threading.Tasks;
using UtilidorApi.Models;

namespace UtilidorApi.Services.Interfaces
{
    public interface IUtilityService
    {
        Task<List<CurrentInstance>> GetRunningUtilities();
        Task<List<Utility>> GetAllUtilities();
    }
}
