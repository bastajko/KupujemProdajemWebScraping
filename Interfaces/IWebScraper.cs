using KupujemProdajemWebScraping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KupujemProdajemWebScraping.Interfaces
{
    public interface IWebScraper
    {
        Task<List<Ad>> ScrapeAsync(string url);
    }
}
