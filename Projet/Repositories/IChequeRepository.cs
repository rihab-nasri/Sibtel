using Projet.Entities;

namespace Projet.Repositories
{
    public interface IChequeRepository
    {
        Cheque Add(Cheque cheque);
        void delete(Cheque cheque);
        List<Cheque> GetAll();
        Cheque getById(int id);
    }
}