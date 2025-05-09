using PruebaTecnicaCarsales.Models;

namespace PruebaTecnicaCarsales.HttpClients
{
    public class RickAndMortyApiClient : IRickAndMortyApiClient
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "https://rickandmortyapi.com/api";

        public RickAndMortyApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<EpisodeResponseDto> GetEpisodesAsync(int page)
        {
            var response = await _httpClient.GetFromJsonAsync<EpisodeResponseDto>($"{BaseUrl}/episode?page={page}");
            return response ?? new EpisodeResponseDto();
        }
    }
}
