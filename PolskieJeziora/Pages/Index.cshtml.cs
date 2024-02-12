using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PolskieJeziora.Models;
using PolskieJeziora.Services;

namespace PolskieJeziora.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, ILakesService lakesService)
        {
            _logger = logger;
        }
    }
}