using Dogecoin.Api.Service.Endpoint.Dtos.Interfaces;
using Newtonsoft.Json;
using System.Net;

namespace Dogecoin.Api.Service.Endpoint.Dtos
{
    public class ResponseApiBaseDto : ResponseBaseDto
    {
        /// <summary>
        /// valida se o response possui status code de sucesso
        /// (int)StatusCode >= 200 && (int)StatusCode <= 299;
        /// </summary>
        public override bool Result { get { return (int)StatusCode >= 200 && (int)StatusCode <= 299; } }
        [JsonIgnore]
        public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.OK;
    }
    public sealed class ResponseApiBaseDto<TData> : ResponseApiBaseDto, IResponseBaseDto<TData>
    {
        public TData Data { get; set; }
    }
}
