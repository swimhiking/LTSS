using System;
using System.Collections.Generic;

#nullable disable

namespace LTSS_Model.Models
{
    public partial class UnitType
    {
        //public UnitType()
        //{
        //    Units = new HashSet<Unit>();
        //}

        public int UnitTypeId { get; set; }
        public string UnitTypeName { get; set; }
        public string UnitTypeDesc { get; set; }

        //public virtual ICollection<Unit> Units { get; set; }
    }
}
