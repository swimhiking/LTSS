using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace LTSS_Model.Models
{
    public partial class TagModel
    {
        [Key, Column("TagId", Order = 0)]
        public decimal TagId { get; set; }
        [Key, Column("ModelId", Order = 0)]
        public decimal ModelId { get; set; }
        public short? HasOptionFlag { get; set; }
        public string ModelString { get; set; }
        public short? SortOrder { get; set; }

        public virtual Model Model { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
