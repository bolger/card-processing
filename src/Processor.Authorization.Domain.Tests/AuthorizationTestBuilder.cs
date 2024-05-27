using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processor.Domain.Tests
{
    internal class AuthorizationTestBuilder
    {
        private string _pan=  "12341123412341234";

        internal AuthorizationTestBuilder WithIssuedPan()
        {
            // TODO: Mock card provider to return a result that indicates the issued pan exists
            return this;
        }

        internal AuthorizationTestBuilder WithNonIssuedPan()
        {
            // TODO: Mock card provider to return a result that indicates the issued pan does not exist
            return this;
        }

        internal Authorization.Authorization ProcessAuthorization()
        {
            return Authorization.Authorization.ProcessAuthorization(
                _pan
            );
        }
    }
}
