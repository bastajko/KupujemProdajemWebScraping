using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KupujemProdajemWebScraping.Models
{
    public class Ad
    {
        public string PriceText { get; set; }
        public long AdId { get; set; }
        public string Posted { get; set; }
        public string AdKind { get; set; }
        public string AdClass { get; set; }
        public string AdType { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Currency { get; set; }
        public bool PriceFixed { get; set; }
        public bool Exchange { get; set; }
        public string DescriptionSnippet { get; set; }
        public bool IsRenewed { get; set; }
        public string LastRenew { get; set; }
        public int ViewCount { get; set; }
        public string PhotoPath1 { get; set; }
        public string Photo1Tmb300x300 { get; set; }
        public string AdUrl { get; set; }
        public string DescriptionDecoded { get; set; }
        public string NameDecoded { get; set; }
    }
}
