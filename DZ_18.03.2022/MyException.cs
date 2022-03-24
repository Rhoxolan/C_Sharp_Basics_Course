namespace MyException
{
    using System;

    public class MyExceptionToString : ApplicationException
    {
        public MyExceptionToString(string message) : base(message) { }
    }
}
