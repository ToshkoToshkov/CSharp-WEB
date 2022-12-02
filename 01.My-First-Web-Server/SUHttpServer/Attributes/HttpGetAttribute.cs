using SUHttpServer.HTTP;

namespace SUHttpServer.Attributes
{
    public class HttpGetAttribute : HttpMethodAttribute
    {
        public HttpGetAttribute() : base(Method.Get)
        {
        }
    }
}
