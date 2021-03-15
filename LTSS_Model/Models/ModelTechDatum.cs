using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace LTSS_Model.Models
{
    public partial class ModelTechDatum
    {
        [Key, Column("ModelId", Order = 0)]
        public int ModelId { get; set; }
        [Key, Column("TechDataType", Order = 0)]
        public int TechDataType { get; set; }
        public double? MaxValue { get; set; }
        public double? MinValue { get; set; }
        public string Unit { get; set; }

        public virtual Model Model { get; set; }
    }
}
