using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace LTSS_Model.Models
{
    public partial class ModelType
    {
        public ModelType()
        {
            ModelGroups = new HashSet<ModelGroup>();
            Models = new HashSet<Model>();
        }

        [Key]
        public int ModelTypeId { get; set; }
        public string ModelTypeName { get; set; }
        public string ModelTypeDesc { get; set; }
        public short? SortOrder { get; set; }

        public virtual ICollection<ModelGroup> ModelGroups { get; set; }
        public virtual ICollection<Model> Models { get; set; }
    }
}
