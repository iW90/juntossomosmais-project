﻿using jsmclients.Application.Models.Requests;
using jsmclients.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace jsmclients.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        //desacomplamento de código
        private readonly IUseCaseAsync<ElegibleListRequest, IActionResult> _elegibleListAsync;

        public ClientController(
            IUseCaseAsync<ElegibleListRequest, IActionResult> elegibleListAsync)
        {
            _elegibleListAsync = elegibleListAsync;
        }

        //Requisições HTTP
        //Get Elegibles List
        [HttpGet("ElegibleList")]
        public async Task<IActionResult> Get([FromQuery] ElegibleListRequest request)
        {
            return await _elegibleListAsync.ExecuteAsync(request);
        }
    }
}