using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chilicki.StringLabs.Core.Services.Base
{
    public interface ITeamsUrlService
    {
        string ExtractUrl(string teamsMeetingUrl);
    }
}
