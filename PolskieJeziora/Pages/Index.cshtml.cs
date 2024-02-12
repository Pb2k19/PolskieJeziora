using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PolskieJeziora.Models;
using PolskieJeziora.Services;

namespace PolskieJeziora.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public LakesFromJsonService LakesService;
        public IEnumerable<Lake> Lakes { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, LakesFromJsonService lakesService)
        {
            _logger = logger;
            LakesService = lakesService;
        }

        public void OnGet()
        {
            Lakes = LakesService.GetLakes();
        }
    }
}