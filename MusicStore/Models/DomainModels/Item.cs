using Newtonsoft.Json;

namespace MusicStore.Models;

public class Item
{
    [JsonProperty("id")]
    public string Id { get; set; }
}