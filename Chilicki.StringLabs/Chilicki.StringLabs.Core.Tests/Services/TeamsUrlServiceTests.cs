using Chilicki.StringLabs.Core.DependencyInjection;
using Chilicki.StringLabs.Core.Exceptions;
using Chilicki.StringLabs.Core.Services.Base;
using Chilicki.StringLabs.Core.Tests.DependencyInjection;
using Chilicki.StringLabs.Core.Tests.TestCases;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace Chilicki.StringLabs.Core.Tests.Services
{
    public class TeamsUrlServiceTests
    {
        private readonly ITeamsUrlService teamsUrlService;

        public TeamsUrlServiceTests()
        {
            IServiceProvider serviceProvider = TestsDependencyInjection.RunDependencyInjection();
            this.teamsUrlService = serviceProvider.GetRequiredService<ITeamsUrlService>();
        }

        [Theory]
        [InlineData(TeamsUrlServiceTestCases.CorrectTestCase1, TeamsUrlServiceTestCases.CorrectResult1)]
        [InlineData(TeamsUrlServiceTestCases.CorrectTestCase2, TeamsUrlServiceTestCases.CorrectResult2)]
        public void ExtractUrl_CorrectInput_CorrectOutput(string teamsMeetingInvitation, string expected)
        {
            string url = this.teamsUrlService.ExtractUrl(teamsMeetingInvitation);

            Assert.Equal(expected, url);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ExtractUrl_InvalidInput_ThrowsInvalidInputException(string teamsMeetingInvitation)
        {
            Assert.Throws<InvalidInputException>(
                () => this.teamsUrlService.ExtractUrl(teamsMeetingInvitation));
        }
    }
}
