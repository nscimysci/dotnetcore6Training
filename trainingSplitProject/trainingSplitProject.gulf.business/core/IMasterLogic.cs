using System;
using System.Collections.Generic;
using trainingSplitProject.gulf.repositories.entities;


namespace trainingSplitProject.gulf.business.core
{
    public interface IMasterLogic
    {
         List<MstCompany> GetCompanyByDatabase();

    }
}
