using Newtonsoft.Json;

namespace MusicStore.Models
{
    public class CartItem
    {
        public AlbumDTO Album { get; set; }
        public int Quantity { get; set; }

        [JsonIgnore]
        public double SubTotal => Album.Price * Quantity;
    }
}
