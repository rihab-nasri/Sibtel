using Projet.Entities;

namespace Projet.Repositories
{
    public class ChequeRepository : IChequeRepository
    {
        private readonly AppDbContext _appDbContext;

        public ChequeRepository(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public List<Cheque> GetAll()
        {
            return _appDbContext.Cheques.ToList();
        }

        public Cheque Add(Cheque cheque)
        {
            _appDbContext.Cheques.Add(cheque);
            return cheque;
        }

        public void delete(Cheque cheque)
        {
            _appDbContext.Cheques.Remove(cheque);
        }

        public Cheque getById(int id)
        { 
            throw new NotImplementedException(); 
        }
    }

}

