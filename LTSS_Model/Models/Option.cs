using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace LTSS_Model.Models
{
    public partial class Option
    {
        //public Option()
        //{
        //    ModelOptions = new HashSet<ModelOption>();
        //    OptionTechData = new HashSet<OptionTechDatum>();
        //    TagModelConfigs = new HashSet<TagModelConfig>();
        //}

        [Key]
        public decimal OptionId { get; set; }
        public string OptionCode { get; set; }
        public string OptionDesc { get; set; }
        public decimal OptionClassId { get; set; }
        public short? SortOrder { get; set; }
        public short? ObsoleteFlag { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string SuggestionMsg { get; set; }
        public DateTime? MsgStartDate { get; set; }
        public DateTime? MsgEndDate { get; set; }

        //    public virtual OptionClass OptionClass { get; set; }
        //    public virtual ICollection<ModelOption> ModelOptions { get; set; }
        //    public virtual ICollection<OptionTechDatum> OptionTechData { get; set; }
        //    public virtual ICollection<TagModelConfig> TagModelConfigs { get; set; }
    }
}
