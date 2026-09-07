using API.Books.Domain.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Books.Infrastructure.DataModel
{
    public class BooksSQLModel : DbContext
    {

        public BooksSQLModel(DbContextOptions<BooksSQLModel> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your entity mappings here
            base.OnModelCreating(modelBuilder);
        }




        public async Task<List<GenresDto>> GetGenresAsync()
        {
            
           FormattableString query = $@"SELECT * FROM Genres";
            return await this.Database.SqlQuery<GenresDto>(query).ToListAsync();
        }


    }
}
