using Chilicki.StringLabs.Core.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chilicki.StringLabs.Core.Services
{
    class QuotationMarkReplacer : IQuotationMarkReplacer
    {
        private const string quotationMark = "\"";
        private const string whitespace = " ";

        public string ReplaceQuotationMarks(string input)
        {
            var result = input.Replace(quotationMark, whitespace);
            return result;
        }
    }
}
