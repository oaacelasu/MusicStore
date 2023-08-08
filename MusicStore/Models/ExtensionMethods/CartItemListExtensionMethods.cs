using System.Linq;
using System.Collections.Generic;

namespace MusicStore.Models
{
    public static class CartItemListExtensions
    {
        public static List<CartItemDTO> ToDTO(this List<CartItem> list) =>
            list.Select(ci => new CartItemDTO {
                AlbumId = ci.Album.AlbumId,
                Quantity = ci.Quantity
            }).ToList();
    }
}
