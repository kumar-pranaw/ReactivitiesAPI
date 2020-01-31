using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.ProductList;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet]   
        public async Task<ActionResult<List<Product>>> Details()
        {
            return await _mediator.Send(new List.Query());
        }
    }
}