using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace LTSS_Model.Models
{
    public partial class ModelGroup
    {
        public ModelGroup()
        {
            Models = new HashSet<Model>();
            OptionClasses = new HashSet<OptionClass>();
        }
        [Key]
        public decimal ModelGroupId { get; set; }
        public string ModelGroupName { get; set; }
        public decimal ModelTypeId { get; set; }
        public string ModelGroupDesc { get; set; }
        public short? SortOrder { get; set; }

        public virtual ModelType ModelType { get; set; }
        public virtual ICollection<Model> Models { get; set; }
        public virtual ICollection<OptionClass> OptionClasses { get; set; }
    }
}
