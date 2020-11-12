using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconLMS.Models
{
    public class Module
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        //Foreign Key
        public int CourseId { get; set; }
        //Navigation property
        public virtual ICollection<Activities> Activities { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
    }
}
