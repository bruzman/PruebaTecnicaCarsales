using PruebaTecnicaCarsales.Models;

namespace PruebaTecnicaCarsales.HttpClients
{
    public interface IRickAndMortyApiClient
    {
        Task<EpisodeResponseDto> GetEpisodesAsync(int page);
    }
}