using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExam1
{
    class ExamGeneric<E> where E:class
    {
        public E myClass;

        public ExamGeneric(E myClass)
        {
            this.myClass = myClass;
        }
    }
}
