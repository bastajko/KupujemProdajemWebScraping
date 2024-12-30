using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KupujemProdajemWebScraping.Models
{
    public class Leader
    {
        public int LeaderId { get; set; }
        public int CategoryId { get; set; }
        public int GroupId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string CalloutText { get; set; }
        public bool IsKpUrl { get; set; }
        public string ThumbnailUrl { get; set; }
        public int ClickCount { get; set; }
        public int ViewCount { get; set; }
    }
}