using Dogecoin.Api.Service.Endpoint.BusinessRules.Interface;
using Dogecoin.Api.Service.Endpoint.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dogecoin.Api.Service.Endpoint.Controllers
{
    [ApiExplorerSettings(GroupName = @"Address")]
    [ApiController]
    [Route("/api/address/")]
    public class AddressController : MvpBaseController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="serviceProvider"></param>
        public AddressController(IServiceProvider serviceProvider) : base(serviceProvider) { }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("{Address}/balance")]
        [ProducesResponseType(200, Type = typeof(ResponseApiBaseDto<DogecoinAddressBalanceResponseDto>))]
        [ProducesResponseType(400, Type = typeof(ResponseApiBaseDto))]
        public async Task<ActionResult<ResponseApiBaseDto<DogecoinAddressBalanceResponseDto>>> GetBalance(
            [FromRoute]string Address
        ) {
            // Endpoint Obter informações utilizando autenticação jwt
            var response = await GetBusinessRules<IDogecoinBusinessRules>()
                .Handle(new DogecoinAddressBalanceRequestDto {
                    Address = Address
                });
            return EndpointResponse(response);
        }
    }
}
