using System.Collections.Generic;

namespace MusicStore.Models
{
    public class DropDownViewModel
    {
        public Dictionary<string, string> Items { get; set; }
        public string SelectedValue { get; set; }
        public string DefaultValue { get; set; }
    }
}
