using System.Collections.Generic;

namespace MusicStore.Models
{
    public class CartViewModel 
    {
        public IEnumerable<CartItem> List { get; set; }
        public double SubTotal { get; set; }
        public RouteDictionary AlbumGridRoute { get; set; }
    }
}
