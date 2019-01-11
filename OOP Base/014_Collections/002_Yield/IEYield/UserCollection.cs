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
            for (int i = 0; i < 5; i++)
            {
                yield return "Hello world! "+i;
            }
            
            
        }
    }
}
