using PolskieJeziora.Models;

namespace PolskieJeziora.Services;

public interface ILakesService
{
    ValueTask<Lake> GetLakeByIdAsync(int id);
    ValueTask<IEnumerable<Lake>> GetLakesAsync();
}