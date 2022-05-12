using demo.gulf.repositories.entities;

namespace demo.gulf.business.core
{
    public class MasterLogic : IMasterLogic
    {
        private  AZUREDBEBIDDINGDEVContext _context { get; }
        public MasterLogic(AZUREDBEBIDDINGDEVContext context)
        {
            _context = context;
        }



        public MstCompany GetMstCompanyById(int id)
        {
            var c = _context.MstCompanies.FirstOrDefault();
            return  c;
        }
    }
}