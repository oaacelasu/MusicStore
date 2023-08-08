using Newtonsoft.Json;

namespace MusicStore.Models
{
    public class AlbumsGridDTO : GridDTO
    {
        [JsonIgnore]
        public const string DefaultFilter = "all";

        public string Artist { get; set; } = DefaultFilter;
        public string Genre { get; set; } = DefaultFilter;
        public string Price { get; set; } = DefaultFilter;
    }
}
