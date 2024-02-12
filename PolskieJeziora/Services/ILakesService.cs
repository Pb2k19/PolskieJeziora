using PolskieJeziora.Models;

namespace PolskieJeziora.Services;

public interface ILakesService
{
    IEnumerable<Lake> GetLakes();
}