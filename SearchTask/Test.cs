using System;
using System.Collections.Generic;
using System.Text;

namespace SearchTaskVer1
{
    class Test
    {
        public void TestPrivatProtected_InternalProtected()
        {
            Shape s = new Shape("Generic Shape");
            s.Area = 100; // allowed internal protected (same project)

            //s.ShapeName = "Square";  Not allowed: private protected not accessible here
        }
    }
}
