using System;

namespace Dogecoin.Api.Service.Endpoint.Swagger
{
    [AttributeUsage(AttributeTargets.Property)]
    public class SwaggerExcludeAttribute : Attribute
    {
    }
}
