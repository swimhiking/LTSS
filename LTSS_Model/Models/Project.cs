using System;
using System.Collections.Generic;

#nullable disable

namespace LTSS_Model.Models
{
    public partial class Project
    {
        public Project()
        {
            Tags = new HashSet<Tag>();
        }

        public decimal ProjectId { get; set; }
        public string ProjectName { get; set; }
        public decimal UserId { get; set; }
        public string ProjectDesc { get; set; }

        //public virtual UserInfo User { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
