using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace LTSS_Model.Models
{
    public partial class Model
    {
        //public Model()
        //{
        //    ModelOptions = new HashSet<ModelOption>();
        //    ModelTechData = new HashSet<ModelTechDatum>();
        //    TagModelConfigs = new HashSet<TagModelConfig>();
        //    TagModels = new HashSet<TagModel>();
        //}

        [Key]
        public int ModelId { get; set; }
        public string ModelName { get; set; }
        public decimal ModelGroupId { get; set; }
        public decimal ModelTypeId { get; set; }
        public string ModelDesc { get; set; }
        public short? SortOrder { get; set; }
        public short? ObsoleteFlag { get; set; }
        public short? HasOptionFlag { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        //public virtual ModelGroup ModelGroup { get; set; }
        //public virtual ModelType ModelType { get; set; }
        //public virtual ICollection<ModelOption> ModelOptions { get; set; }
        //public virtual ICollection<ModelTechDatum> ModelTechData { get; set; }
        //public virtual ICollection<TagModelConfig> TagModelConfigs { get; set; }
        //public virtual ICollection<TagModel> TagModels { get; set; }
    }
}
