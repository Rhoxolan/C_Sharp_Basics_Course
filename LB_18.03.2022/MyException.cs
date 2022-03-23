using System;

namespace MyException
{
    public class MyExceptionToString: ApplicationException
    {
        public MyExceptionToString(string message) : base(message) { }
    }
}
