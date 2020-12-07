using Chilicki.StringLabs.Core.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chilicki.StringLabs.Core.Services
{
    class UrlExtractionService : IUrlExtractionService
    {
        private const string whitespaceSplitCharacter = "\t\n ";
        private const string http = "http://";
        private const string https = "https://";
        private const string www = "www.";        

        public IEnumerable<string> ExtractUrls(string input)
        {
            var urls = input
                .Split(whitespaceSplitCharacter.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Where(s => s.StartsWith(https) || s.StartsWith(www) || s.StartsWith(http));
            return urls;
        }
    }
}
