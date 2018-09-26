using System.Collections.Generic;

namespace UtilidorApi.Models
{
    public class Utility
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Instance> Instances { get; set; }
    }
}
