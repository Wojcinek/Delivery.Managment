using System.Net.Http;

namespace Delivery.Managment.MVC.Services.Base
{
    public partial interface IClient
    {
        public HttpClient HttpClient { get; }
    }
}
