using PolskieJeziora.Models;
using System.Text.Json;

namespace PolskieJeziora.Services
{
    public class LakesFromJsonService : ILakesService
    {
        private readonly JsonSerializerOptions jsonOptions = new() { PropertyNameCaseInsensitive = true };
        private readonly string jsonFileName;
        private Lake[] lakes = [];

        public IWebHostEnvironment WebHostEnvironment { get; }

        public LakesFromJsonService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
            jsonFileName = Path.Combine(WebHostEnvironment.WebRootPath, "data", "jezioraPolskie.json");
        }

        public async ValueTask<IEnumerable<Lake>> GetLakesAsync()
        {
            if (lakes.Length == 0)
                await ReloadLakesAsync();
            
            return lakes;
        }

        public async ValueTask<Lake> GetLakeByIdAsync(int id)
        {
            if (lakes.Length == 0)
                await ReloadLakesAsync();

            return lakes.First(x => x.Id == id);
        }

        private async Task ReloadLakesAsync()
        {
            using FileStream jsonFileReader = File.OpenRead(jsonFileName);
            lakes = (await JsonSerializer.DeserializeAsync<Lake[]>(jsonFileReader, jsonOptions)) ?? [];
        }
    }
}
