using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconLMS.Models
{
    public class ActivityType
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        // Navigation property
        public virtual ICollection<Activities> Activities { get; set; }
    }
}
