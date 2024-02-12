using System.Text.Json;

namespace PolskieJeziora.Models
{
    public class Lake
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double MaxDepth { get; set; }
        public double Area { get; set; }
        public string Location  { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Map { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
