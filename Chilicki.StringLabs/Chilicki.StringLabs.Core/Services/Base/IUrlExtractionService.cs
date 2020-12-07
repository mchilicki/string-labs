using System.Collections.Generic;

namespace Chilicki.StringLabs.Core.Services.Base
{
    public interface IUrlExtractionService
    {
        IEnumerable<string> ExtractUrls(string input);
    }
}