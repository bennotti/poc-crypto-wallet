using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Dogecoin.Api.Service.Endpoint.Dtos.Interfaces;
using Newtonsoft.Json;

namespace Dogecoin.Api.Service.Endpoint.Dtos
{
    [ExcludeFromCodeCoverage]
    public class ResponseBaseDto : IResponseBaseDto
    {
        public virtual bool Result { get; set; }

        public string Message { get; set; }

        private readonly string _resultId;

        public string ResultId { get { return _resultId; } }

        private Exception _exception;
        public Dictionary<string, string[]> ModelState { get; set; }

        [JsonIgnore]
        public Exception Exception
        {
            get
            {
                return _exception;
            }
            set
            {
                if (value != null)
                {
                    Result = false;
                    _exception = value;
                }
            }
        }
        private bool _isFromCache;
        public bool IsFromCache => _isFromCache;

        public ResponseBaseDto()
        {
            _isFromCache = false;
            Result = true;
            Message = "";
            _resultId = Guid.NewGuid().ToString();
        }

        public void SetFromCache()
        {
            _isFromCache = true;
        }
    }

    [ExcludeFromCodeCoverage]
    public class ResponseBaseDto<TData> : ResponseBaseDto, IResponseBaseDto<TData>
    {
        public TData Data { get; set; }
    }
}
