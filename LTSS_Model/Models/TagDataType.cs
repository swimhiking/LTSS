using System;
using System.Collections.Generic;

#nullable disable

namespace LTSS_Model.Models
{
    public partial class TagDataType
    {
        public TagDataType()
        {
            TagData = new HashSet<TagDatum>();
        }

        public int DataTypeId { get; set; }
        public string DataTypeName { get; set; }
        public string DataTypeDesc { get; set; }

        public virtual ICollection<TagDatum> TagData { get; set; }
    }
}
