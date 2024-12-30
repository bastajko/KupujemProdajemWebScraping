using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KupujemProdajemWebScraping.Models
{
    public class ApiResponse
    {
        public bool Success { get; set; }
        public List<string> Errors { get; set; }
        public Results Results { get; set; }
        public string Captcha { get; set; }
        public string CaptchaSiteKey { get; set; }
    }
}
