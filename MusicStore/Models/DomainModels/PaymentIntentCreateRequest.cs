using Newtonsoft.Json;

namespace MusicStore.Models;

public class PaymentIntentCreateRequest
{
    [JsonProperty("items")]
    public Item[] Items { get; set; }
}