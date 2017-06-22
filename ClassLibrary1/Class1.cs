using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public void Foo()
        {
            int x = 0;
            float y = 1.0f;

            var t = (x, y);

            (int foo, float bar) = t;
        }
    }
}
