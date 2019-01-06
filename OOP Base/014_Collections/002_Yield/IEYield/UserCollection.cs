using System.Collections;
using System.Collections.Generic;
using System;
using System.Threading;

namespace Yield
{
    class UserCollection
    {
        public static IEnumerable Power()
        {
            yield return "Hello world!";
        }
    }
}
