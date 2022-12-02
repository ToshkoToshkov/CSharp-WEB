using SUHttpServer.HTTP;

namespace SUHttpServer.Attributes
{
    public class HttpPostAttribute : HttpMethodAttribute
    {
        public HttpPostAttribute() : base(Method.Post)
        {
        }
    }
}
