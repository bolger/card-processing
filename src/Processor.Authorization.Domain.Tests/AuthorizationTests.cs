using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Processor.Domain;
using Processor.Domain.Authorization;
using Xunit;

namespace Processor.Domain.Tests
{
    public class AuthorizationTests
    {
        [Fact]
        public void ProcessAuthorization_IssuedPan_AuthApproved()
        {
            // Arrange/Act
            var auth = new AuthorizationTestBuilder()
                .WithIssuedPan()
                .ProcessAuthorization(); 

            // Assert
            Assert.Equal(
                expected: AuthorizationDecision.Approved, 
                actual: auth.Result.Decision);
        }

        [Fact]
        public void ProcessAuthorization_NonIssuedPan_AuthDeclined()
        {
            // Arrange/Act
            var auth = new AuthorizationTestBuilder()
                .WithNonIssuedPan()
                .ProcessAuthorization();

            // Assert
            Assert.Equal(
                expected: AuthorizationDecision.Declined, 
                actual: auth.Result.Decision);
        }
    }
}
