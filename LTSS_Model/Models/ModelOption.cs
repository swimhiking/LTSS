using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace LTSS_Model.Models
{
    public partial class ModelOption
    {
        [Key, Column("ModelId", Order = 0)]
        public int ModelId { get; set; }
        [Key, Column("OptionId", Order = 0)]
        public decimal OptionId { get; set; }

        public virtual Model Model { get; set; }
        public virtual Option Option { get; set; }
    }
}
