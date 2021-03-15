using LTSS_Model.Models;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace LTSS_Model.ViewModels
{
    public class ModelVM
    {        
        public ModelVM()
        {
            Model = new Model();
        }

        public Model Model { get; set; }
        public IEnumerable<SelectListItem> ModelOptionSelectList { get; set; }
        

    }
}
