using System;
using System.Collections.Generic;

#nullable disable

namespace LTSS_Model.Models
{
    public partial class Tag
    {
        public Tag()
        {
            TagData = new HashSet<TagDatum>();
            TagModelConfigs = new HashSet<TagModelConfig>();
            TagModels = new HashSet<TagModel>();
        }

        public decimal TagId { get; set; }
        public string TagName { get; set; }
        public decimal UserId { get; set; }
        public decimal ProjectId { get; set; }
        public string TagDesc { get; set; }
        public string TagNote { get; set; }

        public virtual Project Project { get; set; }
        //public virtual UserInfo User { get; set; }
        public virtual ICollection<TagDatum> TagData { get; set; }
        public virtual ICollection<TagModelConfig> TagModelConfigs { get; set; }
        public virtual ICollection<TagModel> TagModels { get; set; }
    }
}
