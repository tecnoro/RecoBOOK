using Microsoft.AspNetCore.Mvc;

namespace RecoBOOK.API.Books.Controllers
{
    [ApiController]
    [Route("api/v1/books")]
    public class BooksController : ControllerBase
    {
        /* Plantilla para hacer endpoint
        [HttpGet("favorites")]
        public async Task<IActionResult> GetFavorites()
        {
            try
            {
                return Ok();
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);

                return StatusCode(500, "An error ocurred while retrieving favorites");
            }
        }
        */




        private readonly ILogger<BooksController> _logger;
        private readonly IConfiguration _config;
        private readonly IHostEnvironment _env;


        public BooksController(ILogger<BooksController> logger, IConfiguration config, IHostEnvironment env)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _config = config ?? throw new ArgumentNullException(nameof(config));
            _env = env ?? throw new ArgumentNullException(nameof(env));
        }


        [HttpGet("genres")]
        public async Task<IActionResult> GetGenres()
        {
            try
            {
                var genres = new List<string>
                {
                    "Fiction",
                    "Non-Fiction",
                    "Science Fiction",
                    "Fantasy",
                    "Mystery",
                    "Romance",
                    "Thriller",
                    "Horror",
                    "Biography",
                    "Self-Help"
                };
                return Ok(genres);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return StatusCode(500, "An error occurred while retrieving genres.");
            }
        }

        #region Favorite's methods
        [HttpGet("favorites")]
        public async Task<IActionResult> GetFavorites()
        {
            try
            {
                return Ok();
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);

                return StatusCode(500, "An error ocurred while retrieving favorites");
            }
        }

        [HttpPut("favorites")]
        public async Task<IActionResult> AddFavorites()
        {
            try
            {
                return Ok();
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);

                return StatusCode(500, "An error ocurred while updating favorites");
            }
        }

        [HttpPost("favorites")]
        public async Task<IActionResult> CreateFavorites()
        {
            try
            {
                return Ok();
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);

                return StatusCode(500, "An error ocurred while creating favorites");
            }
        }

        [HttpDelete("favorites/all")]
        public async Task<IActionResult> DeleteFavorites()
        {
            try
            {
                return Ok();
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                return StatusCode(500, "An error ocurred while deleting favorites");
            }
        }

        [HttpDelete("favorites/selected")]
        public async Task<IActionResult> DeleteSelectedFavorites()
        {
            try
            {
                return Ok();
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                return StatusCode(500, "An error ocurred while deleting some favorites");
            }
        }

        #endregion

    }
}
