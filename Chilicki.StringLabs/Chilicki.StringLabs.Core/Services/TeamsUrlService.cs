using Chilicki.StringLabs.Core.Exceptions;
using Chilicki.StringLabs.Core.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chilicki.StringLabs.Core.Services
{
    public class TeamsUrlService : ITeamsUrlService
    {
        private readonly IUrlExtractionService urlExtractionService;
        private readonly IQuotationMarkReplacer quotationMarkReplacer;

        public TeamsUrlService(
            IUrlExtractionService urlExtractionService,
            IQuotationMarkReplacer quotationMarkReplacer)
        {
            this.urlExtractionService = urlExtractionService;
            this.quotationMarkReplacer = quotationMarkReplacer;
        }

        public string ExtractUrl(string teamsMeetingInvitation)
        {
            Validate(teamsMeetingInvitation);
            string teamsMeetingInvitationWithoutQuotes = this.quotationMarkReplacer
                .ReplaceQuotationMarks(teamsMeetingInvitation);
            IEnumerable<string> urls = this.urlExtractionService.ExtractUrls(teamsMeetingInvitationWithoutQuotes);
            string targetUrl = urls.First();
            return targetUrl;
        }

        private void Validate(string teamsMeetingInvitation)
        {
            if (string.IsNullOrWhiteSpace(teamsMeetingInvitation))
                throw new InvalidInputException();            
        }
    }
}
