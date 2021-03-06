﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconLMS.Models
{
    public class Activities
    {
        public int Id { get; set; }

        //public ActivityType ActivityType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        // Foreign key
        public int CourseId { get; set; }
        public int ActivityTypeId { get; set; }
        // Navigation property
        public virtual Document Document { get; set; }                
    }
}
