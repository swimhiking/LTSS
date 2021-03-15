using LTSS_Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LTSS_DataAccess.Repository.IRepository
{
    public interface IOptionRepository: IRepository<Option>
    {
        void Update(Option obj);
    }
}
