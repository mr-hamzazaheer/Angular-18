namespace WebApi.Middleware
{
    public class Authentication
    {

        private readonly RequestDelegate _next;
        private readonly IWebHostEnvironment _environment;

        public Authentication(RequestDelegate next, IWebHostEnvironment environment)
        {
            _next = next;
            _environment = environment;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
               await _next.Invoke(context);
            }
            catch (Exception ex)
            {
                 
            }
        }
    }
}
