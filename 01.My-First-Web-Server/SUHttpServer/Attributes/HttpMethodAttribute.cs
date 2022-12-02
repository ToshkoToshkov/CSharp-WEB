using SUHttpServer.HTTP;
using System;

namespace SUHttpServer.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public abstract class HttpMethodAttribute : Attribute
    {
        public Method HttpMethod { get; }

        protected HttpMethodAttribute(Method httpMethod)
            => HttpMethod = httpMethod;
    }
}
