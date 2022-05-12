using demo.gulf.repositories.entities;

namespace demo.gulf.business.core
{
    public interface IMasterLogic
    {
        MstCompany GetMstCompanyById(int id);
    }
}