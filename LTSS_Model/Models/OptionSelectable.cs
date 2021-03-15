using System;
using System.Collections.Generic;

#nullable disable

namespace LTSS_Model.Models
{
    public partial class OptionSelectable
    {
        public decimal SelectableOptionId { get; set; }
        public short SelectableFlag { get; set; }
        public decimal OptionId1 { get; set; }
        public decimal OptionId2 { get; set; }
        public decimal OptionId3 { get; set; }
        public decimal OptionId4 { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual Option SelectableOption { get; set; }
    }
}
