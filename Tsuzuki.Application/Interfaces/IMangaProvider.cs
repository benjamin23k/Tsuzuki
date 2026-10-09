using System;
using System.Collections.Generic;
using System.Text;
using Tsuzuki.Application.Dtos;

namespace Tsuzuki.Application.Interfaces
{
    public  interface IMangaProvider
    {
        Task<List<MangaDto>> SearchAsync(string query, int limit, int offset, CancellationToken cancellationToken = default);
      


        Task<MangaDto> GetByIdAsync(Guid id, CancellationToken cancellation = default);




        Task<List<MangaDto>> GetLastestAsync();


        Task<List<MangaDto>> GetPopularAsync();




     
    }
}
