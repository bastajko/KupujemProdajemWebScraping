using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KupujemProdajemWebScraping.Models
{
    public class Results
    {
        public bool HasReachedMax { get; set; }
        public int Total { get; set; }
        public int Pages { get; set; }
        public int Page { get; set; }
        public long FilterId { get; set; }
        public string FilterName { get; set; }
        public string PostedMax { get; set; }
        public string Url { get; set; }
        public List<Ad> Ads { get; set; }
        public List<Leader> Leaders { get; set; }
        public List<object> Sales { get; set; }
        public bool IsSearchExisting { get; set; }
        public bool IsSearchSaveAllowed { get; set; }
        public bool ShowSearchIsbnInfo { get; set; }
    }
}