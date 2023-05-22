using Ardalis.Specification.EntityFrameworkCore;
using Prueba.Application.Common.Interfaces;
using Prueba.Persistence.Contexts;


namespace Prueba.Persistence.Repository
{
    public  class CustomRepositoryAsync<T> : RepositoryBase<T>,IRepositoryAsync<T> where T : class
    {
        private readonly ApplicationDbContext dbContext;

        public CustomRepositoryAsync(ApplicationDbContext dbContext): base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
