using System;
using System.Collections.Generic;

namespace UtilidorApi.Models
{
    public class Instance
    {
        public int Id { get; set; }
        public int UtilityId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime CompleteTime { get; set; }
        public int? Numerator { get; set; }
        public int? Denominator { get; set; }

        public virtual List<Log> Logs { get; set; }
        public virtual Utility Utility { get; set; }
    }
}
