using PolskieJeziora.Models;
using System.Text.Json;

namespace PolskieJeziora.Services
{
    public class LakesFromJsonService : ILakesService
    {
        private readonly JsonSerializerOptions jsonOptions = new() { PropertyNameCaseInsensitive = true };

        public IWebHostEnvironment WebHostEnvironment { get; }

        protected string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "jezioraPolskie.json"); }
        }

        public LakesFromJsonService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IEnumerable<Lake> GetLakes()
        {
            using var jsonFileReader = File.OpenText(JsonFileName);
            return JsonSerializer.Deserialize<Lake[]>(jsonFileReader.ReadToEnd(), jsonOptions);
        }
    }
}
