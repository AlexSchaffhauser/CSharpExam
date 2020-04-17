using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExam1
{
    public static class IntExt
    {
        public static bool IsMultiple3(this int i)
        {
            if(i % 3 > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
