using LTSS_DataAccess.Data;
using LTSS_DataAccess.Repository.IRepository;
using LTSS_Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LTSS_DataAccess.Repository
{
    public class OptionRepository : Repository<Option>,IOptionRepository
    {
        private readonly ApplicationDbContext _db;

        public OptionRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Option obj)
        {
            var objFromDb = base.FirstOrDefault(u => u.OptionId == obj.OptionId);
            if (objFromDb != null)
            {
                objFromDb.OptionCode = obj.OptionCode;
                objFromDb.OptionDesc = obj.OptionDesc;
                objFromDb.OptionClassId = obj.OptionClassId;
                objFromDb.SortOrder = obj.SortOrder;
                objFromDb.ObsoleteFlag = obj.ObsoleteFlag;
                objFromDb.StartDate = obj.StartDate;
                objFromDb.EndDate = obj.EndDate;
                objFromDb.SuggestionMsg = obj.SuggestionMsg;
                objFromDb.MsgStartDate = obj.MsgStartDate;
                objFromDb.MsgEndDate = obj.MsgEndDate;
            }
        }
    }
}
