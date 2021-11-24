using AutoMapper;
using HTSP.Application.Features.Commands.CreateOrderLine;
using HTSP.Application.Features.Commands.DeleteOrderLine;
using HTSP.Application.Features.Queries.OrderLineListQuery;
using HTSP.Application.Features.Queries.OrderLineQuery;
using HTSP.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace HTSP.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class OrderLineController : BaseController
    {
        private readonly IMapper _mapper;
        public OrderLineController(IMapper mapper) => _mapper = mapper;
        [HttpGet]
        public async Task<ActionResult<OrderLineListVm>> GetAll()
        {
            var query = new GetOrderLineListQuery
            {
                OrderLineID = ID
            };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }
        [HttpGet("{ID}")]
        public async Task<ActionResult<OrderLineVm>> Get(Guid ID)
        {
            var query = new GetOrderLineQuery
            {
                OrderLineID = ID
            };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }
        [HttpPost]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateOrderLineDto createArticleDto)
        {
            var command = _mapper.Map<CreateOrderLineCommand>(createArticleDto);
            command.OrderLineID = ID;
            var articleID = await Mediator.Send(command);
            return Ok(articleID);
        }
        [HttpPut]
        [HttpDelete("{ID}")]
        public async Task<ActionResult<Guid>> Delete(Guid guid)
        {
            var command = new DeleteOrderLineCommand
            {
                OrderLineID = ID
            };
            await Mediator.Send(command);
            return NoContent();
        }
    }
}
