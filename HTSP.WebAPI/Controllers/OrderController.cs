using AutoMapper;
using HTSP.Application.Features.Commands.CreateOrder;
using HTSP.Application.Features.Commands.DeleteOrder;
using HTSP.Application.Features.Queries.OrderListQuery;
using HTSP.Application.Features.Queries.OrderQuery;
using HTSP.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace HTSP.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class OrderController : BaseController
    {
        private readonly IMapper _mapper;
        public OrderController(IMapper mapper) => _mapper = mapper;
        [HttpGet]
        public async Task<ActionResult<OrderListVm>> GetAll()
        {
            var query = new GetOrderListQuery
            {
                OrderID = ID
            };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }
        [HttpGet("{ID}")]
        public async Task<ActionResult<OrderVm>> Get(Guid ID)
        {
            var query = new GetOrderQuery
            {
                OrderID = ID
            };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }
        [HttpPost]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateOrderDto createArticleDto)
        {
            var command = _mapper.Map<CreateOrderCommand>(createArticleDto);
            command.OrderId = ID;
            var articleID = await Mediator.Send(command);
            return Ok(articleID);
        }
        [HttpPut]
        [HttpDelete("{ID}")]
        public async Task<ActionResult<Guid>> Delete(Guid guid)
        {
            var command = new DeleteOrderCommand
            {
                OrderID = ID
            };
            await Mediator.Send(command);
            return NoContent();
        }
    }
}
