using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace UtilidorApi.Models
{
    [NotMapped]
    public class CurrentInstance
    {
        public int UtilityId { get; set; }
        public int InstanceId { get; set; }
        public string UtilityName { get; set; }
        public DateTime StartTime { get; set; }
        public long ElapsedTime { get; set; }
        public long AverageTime { get; set; }
        public int PercentComplete { get; set; }
    }
}
