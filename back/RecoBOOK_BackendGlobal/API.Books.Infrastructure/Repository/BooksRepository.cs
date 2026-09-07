using API.Books.Domain.DTO;
using API.Books.Domain.Interfaces.Persistence;
using API.Books.Infrastructure.DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace API.Books.Infrastructure.Repository
{
    public class BooksRepository : IBooksRepository
    {

        private readonly ILogger<BooksRepository> _logger;
        private readonly IDbContextFactory<BooksSQLModel> _dbContextFactory;


        public BooksRepository(ILogger<BooksRepository> logger, IDbContextFactory<BooksSQLModel> dbContextFactory)
        {
            _logger = logger;
            _dbContextFactory = dbContextFactory;
        }


        public async Task<List<GenresDto>> GetGenresAsync()
        {
            using var context = await _dbContextFactory.CreateDbContextAsync();
            try
            {
                var genres = await context.GetGenresAsync();
                return genres;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving genres.");
                throw;
            }
        }


    }
}
