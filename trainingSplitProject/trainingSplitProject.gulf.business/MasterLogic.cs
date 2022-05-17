using System;
using System.Collections.Generic;

using System.Collections.Generic;
using System.Linq;
using trainingSplitProject.gulf.business.core;
using trainingSplitProject.gulf.repositories.entities;

namespace trainingSplitProject.gulf.business
{
    public class MasterLogic : IMasterLogic
    {
        private readonly AZUREDBEBIDDINGDEVContext _context;

        public MasterLogic(AZUREDBEBIDDINGDEVContext context)
        {
            _context = context;
        }

        public List<MstCompany> GetCompanyByDatabase()
        {
            var entity = _context.MstCompanies.ToList();

            return entity;
        }

    }
}
