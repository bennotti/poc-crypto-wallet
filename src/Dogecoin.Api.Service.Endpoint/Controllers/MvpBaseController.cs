using Dogecoin.Api.Service.Endpoint.BusinessRules.Interface;
using Dogecoin.Api.Service.Endpoint.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;

namespace Dogecoin.Api.Service.Endpoint.Controllers
{
    [ExcludeFromCodeCoverage]
    public class MvpBaseController : ControllerBase
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IServiceProvider _serviceProvider;
        protected MvpBaseController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _httpContextAccessor = GetService<IHttpContextAccessor>();
        }

        protected T GetService<T>()
        {
            return (T)GetService(typeof(T));
        }
        protected object GetService(Type type)
        {
            return _serviceProvider?.GetService(type);
        }

        protected T GetBusinessRules<T>() where T : IApiBusinessRules
        {
            return GetService<T>();
        }

        protected ActionResult<T> EndpointResponse<T>([ActionResultObjectValue] T returnAPI)
            where T : ResponseApiBaseDto
        {
            var result = GetResult(returnAPI);
            var httpStatusCode = GetStatus(returnAPI);

            if (result.HasValue)
            {
                var statusCodeInt = httpStatusCode.HasValue ? (int)httpStatusCode.Value : 400;
                var resultStatusCode = result.Value ? 200 : statusCodeInt;
                var actionResult = new ObjectResult(returnAPI)
                {
                    StatusCode = resultStatusCode
                };

                return actionResult;
            }

            throw new ArgumentException("Não foi informado Response");
        }

        private bool IsResponseApiBaseDto(Type type)
        {
            return type.Name.StartsWith("ResponseApiBaseDto") ||
                type.Name.Contains("ResponseApiBaseDto") ||
                type.Name.StartsWith("PagingResponseApiBaseDto") ||
                type.Name.Contains("PagingResponseApiBaseDto");
        }

        private bool? GetResult(object obj)
        {
            var type = obj.GetType();
            if (IsResponseApiBaseDto(type))
            {
                return (bool)type.GetProperty("Result").GetValue(obj);
            }
            else
            {
                return null;
            }
        }

        private HttpStatusCode? GetStatus(object obj)
        {
            var type = obj.GetType();

            if (IsResponseApiBaseDto(type))
            {
                return (HttpStatusCode)type.GetProperty("StatusCode").GetValue(obj);
            }
            else
            {
                return null;
            }
        }
    }
}
