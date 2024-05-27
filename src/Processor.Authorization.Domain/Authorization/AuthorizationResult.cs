using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processor.Domain.Authorization
{
    public class AuthorizationResult
    {
        public AuthorizationDecision Decision { get; private set; }

        public AuthorizationResult(AuthorizationDecision decision)
        {
            Decision = decision;
        }
    }
}
