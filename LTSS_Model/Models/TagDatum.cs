using System;
using System.Collections.Generic;

#nullable disable

namespace LTSS_Model.Models
{
    public partial class TagDatum
    {
        public decimal TagId { get; set; }
        public int DataTypeId { get; set; }
        public double? MinValue { get; set; }
        public double? NormalValue { get; set; }
        public double? MaxValue { get; set; }
        public double? DesignValue { get; set; }
        public string Unit { get; set; }

        public virtual TagDataType DataType { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
