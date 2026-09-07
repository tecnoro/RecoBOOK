using API.Books.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Books.Domain.Interfaces.Persistence
{
    public interface IBooksRepository
    {
        Task<List<GenresDto>> GetGenresAsync();
    }
}
