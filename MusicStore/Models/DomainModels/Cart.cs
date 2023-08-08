﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace MusicStore.Models
{
    public class Cart : ICart
    {
        private const string CartKey = "mycart";
        private const string CountKey = "mycount";

        private List<CartItem> items { get; set; }
        private List<CartItemDTO> storedItems { get; set; }

        private ISession session { get; set; }
        private IRequestCookieCollection requestCookies { get; set; }
        private IResponseCookies responseCookies { get; set; }

        public Cart(IHttpContextAccessor ctx)
        {
            session = ctx.HttpContext.Session;
            requestCookies = ctx.HttpContext.Request.Cookies;
            responseCookies = ctx.HttpContext.Response.Cookies;
            items = new List<CartItem>();
        }

        public void Load(IRepository<Album> data)
        {
            items = session.GetObject<List<CartItem>>(CartKey);
            if (items == null)
            {
                items = new List<CartItem>();
                storedItems = requestCookies.GetObject<List<CartItemDTO>>(CartKey);
            }
            if (storedItems?.Count > items?.Count)
            {
                foreach (CartItemDTO storedItem in storedItems)
                {
                    var album = data.Get(new QueryOptions<Album>
                    {
                        Includes = "AlbumArtists.Artist, Genre",
                        Where = b => b.AlbumId == storedItem.AlbumId
                    });
                    if (album != null)
                    {
                        var dto = new AlbumDTO();
                        dto.Load(album);

                        CartItem item = new CartItem
                        {
                            Album = dto,
                            Quantity = storedItem.Quantity
                        };
                        items.Add(item);
                    }
                }
                Save();
            }
        }

        public double SubTotal => items.Sum(c => c.SubTotal);
        public int? Count => session.GetInt32(CountKey) ?? requestCookies.GetInt32(CountKey);
        public IEnumerable<CartItem> List => items;

        public CartItem GetById(int id) =>
            items.FirstOrDefault(ci => ci.Album.AlbumId == id);

        public void Add(CartItem item)
        {
            var exists = GetById(item.Album.AlbumId);
            if (exists == null)   
                items.Add(item);
            else                  
                exists.Quantity += item.Quantity;
        }

        public void Edit(CartItem item)
        {
            var exists = GetById(item.Album.AlbumId);
            if (exists != null)
            {
                exists.Quantity = item.Quantity;
            }
        }

        public void Remove(CartItem item) => items.Remove(item);
        public void Clear() => items.Clear();

        public void Save()
        {
            if (items.Count == 0)
            {
                session.Remove(CartKey);
                session.Remove(CountKey);
                responseCookies.Delete(CartKey);
                responseCookies.Delete(CountKey);
            }
            else
            {
                session.SetObject<List<CartItem>>(CartKey, items);
                session.SetInt32(CountKey, items.Count);
                responseCookies.SetObject<List<CartItemDTO>>(CartKey, items.ToDTO());
                responseCookies.SetInt32(CountKey, items.Count);
            }
        }
    }
}
