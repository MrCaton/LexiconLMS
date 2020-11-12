using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconLMS.Models
{
    public class Document
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime dateCreated{ get; set;}
        public int? CourseId { get; set; }

        //Foreign Key
        public int CourseId { get; set; }
        //public int UserId { get; set; }
        public int ModuleId { get; set; }
        public int ActivityId { get; set; }
    }
}
