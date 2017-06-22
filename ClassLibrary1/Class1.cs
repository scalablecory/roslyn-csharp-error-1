using System;
using System.Linq;

namespace ClassLibrary1
{
    public class Class1
    {
        void Test1()
        {
            int x = 0, y = 1;
            var t = (x, y);

            var (foo, bar) = t;
        }
    }
}
