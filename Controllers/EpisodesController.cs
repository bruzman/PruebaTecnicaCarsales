using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaCarsales.Services;

namespace PruebaTecnicaCarsales.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EpisodesController : ControllerBase
    {
        private readonly IEpisodeService _episodeService;

        public EpisodesController(IEpisodeService episodeService)
        {
            _episodeService = episodeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetEpisodes(int page = 1)
        {
            try
            {
                var result = await _episodeService.GetEpisodesAsync(page);
                return Ok(result);
            }
            catch (Exception ex) {

                throw ex.InnerException;
            }
        }
    }
}
