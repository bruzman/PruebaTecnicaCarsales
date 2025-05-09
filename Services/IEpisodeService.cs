using PruebaTecnicaCarsales.Models;

namespace PruebaTecnicaCarsales.Services
{
    public interface IEpisodeService
    {
        Task<EpisodeResponseDto> GetEpisodesAsync(int page);
    }
}
