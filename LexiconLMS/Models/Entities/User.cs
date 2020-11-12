using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconLMS.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int phone { get; set; }


        //Navigation property
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
    }
}
