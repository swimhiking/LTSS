using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace LTSS_Model.Models
{
    public partial class TagModelConfig
    {
        [Key, Column("TagId", Order = 0)]
        public decimal TagId { get; set; }
        [Key, Column("ModelId", Order = 0)]
        public decimal ModelId { get; set; }
        [Key, Column("OptionClassId", Order = 0)]
        public decimal OptionClassId { get; set; }
        public decimal OptionId { get; set; }
        public short? SortOrder { get; set; }
        public string OptionCode { get; set; }

        public virtual Model Model { get; set; }
        public virtual Option Option { get; set; }
        public virtual OptionClass OptionClass { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
