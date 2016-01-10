using DAL.Contracts.Repositories;
using DAL.Entities;

namespace DAL.Repositories
{
    public class WordRepository : RepositoryBase<Word>, IWordRepository
    {
        public WordRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
