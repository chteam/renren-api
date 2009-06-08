using System;
using System.Net;

namespace XiaoNei
{
    public class ResponseException : Exception
    {
        public ResponseException(string message)
            : base(message)
        {

        }
    }
}