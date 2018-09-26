using System;
using UtilidorApi.Enums;

namespace UtilidorApi.Models
{
    public class Log
    {
        public int Id { get; set; }
        public int InstanceId { get; set; }
        public DateTime Timestamp { get; set; }
        public LogLevel Level { get; set; }
        public string Message { get; set; }

        public Instance Instance { get; set; }
    }
}
