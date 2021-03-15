using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace LTSS_Model.Models
{
    public partial class OptionClass
    {
        public OptionClass()
        {
            Options = new HashSet<Option>();
            TagModelConfigs = new HashSet<TagModelConfig>();
        }

        [Key]
        public decimal OptionClassId { get; set; }
        public string OptionClassName { get; set; }
        public decimal ModelGroupId { get; set; }
        public string OptionClassDesc { get; set; }
        public short? SortOrder { get; set; }
        public short? RequiredFlag { get; set; }
        public string ShortName { get; set; }

        public virtual ModelGroup ModelGroup { get; set; }
        public virtual ICollection<Option> Options { get; set; }
        public virtual ICollection<TagModelConfig> TagModelConfigs { get; set; }
    }
}
