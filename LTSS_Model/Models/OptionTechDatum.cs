using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace LTSS_Model.Models
{
    public partial class OptionTechDatum
    {
        [Key, Column("OptionId1", Order = 0)]
        public decimal OptionId1 { get; set; }
        [Key, Column("OptionId2", Order = 1)]
        public decimal OptionId2 { get; set; }
        [Key, Column("OptionId3", Order = 2)]
        public decimal OptionId3 { get; set; }
        [Key, Column("TechDataType", Order = 3)]
        public int TechDataType { get; set; }
        public double? MaxValue { get; set; }
        public double? MinValue { get; set; }
        public string Unit { get; set; }

        public virtual Option OptionId1Navigation { get; set; }
    }
}
