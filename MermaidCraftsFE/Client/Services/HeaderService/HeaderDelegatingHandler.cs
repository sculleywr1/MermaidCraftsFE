namespace MermaidCraftsFE.Client.Services.HeaderService
{
    public class HeaderDelegatingHandler : DelegatingHandler
    {
        public HeaderDelegatingHandler() : base(new HttpClientHandler())
            { }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Add("Access-Control-Allow-Origin", "*");

            return base.SendAsync(request, cancellationToken);
        }
    }
}
