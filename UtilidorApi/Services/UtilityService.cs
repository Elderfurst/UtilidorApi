using Microsoft.EntityFrameworkCore;
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
        private readonly UtilityContext _utilityContext;

        public UtilityService(UtilityContext utilityContext)
        {
            _utilityContext = utilityContext;
        }

        public Task<List<CurrentInstance>> GetRunningUtilities()
        {
            var currentUtilities = _utilityContext.Utilities.Include(x => x.Instances).Where(x => x.Instances != null && x.Instances.Count(y => y.CompleteTime == null) > 0);

            var currentInstances = new List<CurrentInstance>();

            foreach (var utility in currentUtilities)
            {
                var runningInstance = utility.Instances.First(x => x.CompleteTime == null);

                var num = (double) runningInstance.Numerator.GetValueOrDefault(0);
                var denom = (double) runningInstance.Denominator.GetValueOrDefault(1);

                var evaluation = num / denom * 100;

                var totalInstances = utility.Instances.Count(x => x.StartTime != null && x.CompleteTime != null);
                var totalRuntime = utility.Instances.Where(x => x.StartTime != null && x.CompleteTime != null).Sum(y => (long)(y.CompleteTime - y.StartTime)?.TotalSeconds);

                var returnInstance = new CurrentInstance
                {
                    UtilityId = utility.Id,
                    InstanceId = runningInstance.Id,
                    UtilityName = utility.Name,
                    StartTime = runningInstance.StartTime,
                    AverageTime = totalRuntime / totalInstances,
                    PercentComplete = ((double) runningInstance.Numerator.GetValueOrDefault(0)) / runningInstance.Denominator.GetValueOrDefault(1) * 100
                };

                currentInstances.Add(returnInstance);
            }

            return Task.FromResult(currentInstances);
        }

        public Task<List<Utility>> GetAllUtilities()
        {
            return _utilityContext.Utilities.ToListAsync();
        }

        public Task<List<Instance>> GetInstancesByUtilityId(int utilityId, int count)
        {
            var instances = _utilityContext.Instances.Where(x => x.UtilityId == utilityId);
            if(count == -1 || count == 0)
            {
                return instances.ToListAsync();
            }
            return instances.Take(count).ToListAsync();
        }

        public Task<List<Log>> GetLogsByInstanceId(int instanceId)
        {
            return _utilityContext.Logs.Where(x => x.InstanceId == instanceId).ToListAsync();
        }
    }
}
