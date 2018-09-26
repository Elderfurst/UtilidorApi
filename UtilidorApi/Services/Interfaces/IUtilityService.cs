using System.Collections.Generic;
using System.Threading.Tasks;
using UtilidorApi.Models;

namespace UtilidorApi.Services.Interfaces
{
    public interface IUtilityService
    {
        Task<List<CurrentInstance>> GetRunningUtilities();
        Task<List<Utility>> GetAllUtilities();
        Task<List<Instance>> GetInstancesByUtilityId(int utilityId, int count);
        Task<List<Log>> GetLogsByInstanceId(int instanceId);
    }
}
