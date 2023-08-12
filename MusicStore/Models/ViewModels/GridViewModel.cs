using System.Collections.Generic;

namespace MusicStore.Models
{
    public class GridViewModel<T>
    {
        public IEnumerable<T> Items { get; set; }
        public RouteDictionary CurrentRoute { get; set; }
        public int TotalPages { get; set; }
        public int TotalRecords { get; set; }
    }
}
