using PruebaTecnicaCarsales.HttpClients;
using PruebaTecnicaCarsales.Models;
using PruebaTecnicaCarsales.Services;

public class EpisodeService : IEpisodeService
{
    private readonly IRickAndMortyApiClient _apiClient;

    public EpisodeService(IRickAndMortyApiClient apiClient)
    {
        _apiClient = apiClient;
    }

    public async Task<EpisodeResponseDto> GetEpisodesAsync(int page)
    {
        return await _apiClient.GetEpisodesAsync(page);
    }
}