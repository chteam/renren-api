using System;
using System.Net;

namespace RenRen
{
    public class ResponseException : Exception
    {
        public ResponseException(string message)
            : base(message)
        {

        }
    }
}