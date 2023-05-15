using Microsoft.AspNetCore.Mvc;
using OrchardCore;
using OrchardCore.ContentManagement;

namespace OrchardApiTest.Controllers
{
    [Route("/api/[controller]")]
    [Route("resources/api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        
        //private readonly DBContext _ctx;
        private readonly IOrchardHelper Orchard;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public HomeController(IOrchardHelper orchard, IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor)
        {
            Orchard = orchard;
            _webHostEnvironment = webHostEnvironment;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<List<ContentItem>> GetAllCustomArticles()
        {
            List<ContentItem> articles = (List<ContentItem>)await Orchard.GetRecentContentItemsByContentTypeAsync("CustomArticleType", 9);

            return articles;
        }

        [HttpGet]
        [Route("[action]")]
        public string[] GetAllCustomStyles()
        {
            string contentRootPath = _webHostEnvironment.ContentRootPath;

            var path = Path.Combine(contentRootPath, "App_Data", "Sites", "Default", "Media", "CustomStyles");

            string[] stylesheets = System.IO.Directory.GetFiles(path, "*.css").Select(f => Path.GetFileName(f)).ToArray();

            string? baseUrl = _httpContextAccessor.HttpContext?.Request.Host.Value + _httpContextAccessor.HttpContext?.Request.PathBase.Value + "/media/CustomStyles/";

            for (int i = 0; i < stylesheets.Length; i++)
            {
                stylesheets[i] = Path.Combine("https://", baseUrl, stylesheets[i]);
            }

            return stylesheets;
        }

    }
}
