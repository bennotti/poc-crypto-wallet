using System;
using System.Collections.Generic;

namespace Dogecoin.Api.Service.Endpoint.Dtos.Interfaces
{
    public interface IResponseBaseDto
    {
        bool Result { get; }
        string Message { get; }
        string ResultId { get; }
        Exception Exception { get; }
        Dictionary<string, string[]> ModelState { get; }
        bool IsFromCache { get; }
        void SetFromCache();
    }
    public interface IResponseBaseDto<out TData>
    {
        TData Data { get; }
    }
}
