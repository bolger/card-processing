using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processor.Domain.Authorization
{
    public class Authorization
    {
        public AuthorizationResult Result { get; private set; }

        public static Authorization ProcessAuthorization(string pan)
        {
            var authorisation = new Authorization();

            return authorisation;
        }
    }
}
