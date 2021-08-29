using System.Net;

namespace DepotKiwiApiCore.Exceptions {
    public class BadRequestException : DepotKiwiException {
        public BadRequestException(HttpStatusCode statusCode, string message) : base(message) {
            StatusCode = statusCode;
        }

        public HttpStatusCode StatusCode { get; }
    }
}