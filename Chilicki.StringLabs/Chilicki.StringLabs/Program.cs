using Chilicki.StringLabs.Core;
using System;

namespace Chilicki.StringLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            string teamsMeetingUrl = args[0];
            new ProgramService().Run(teamsMeetingUrl);
        }
    }
}
