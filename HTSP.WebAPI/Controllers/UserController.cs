using AutoMapper;
using HTSP.Application.Features.Commands.CreateUser;
using HTSP.Application.Features.Commands.DeleteUser;
using HTSP.Application.Features.Queries.UserListQuery;
using HTSP.Application.Features.Queries.UserQuery;
using HTSP.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HTSP.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class UserController : BaseController
    {
        private readonly IMapper _mapper;
        public UserController(IMapper mapper) => _mapper = mapper;
        [HttpGet]
        public async Task<ActionResult<UserListVm>> GetAll()
        {
            var query = new GetUserListQuery
            {
                UserID = ID
            };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }
        [HttpGet("{ID}")]
        public async Task<ActionResult<UserVm>> Get(Guid ID)
        {
            var query = new GetUserQuery
            {
                UserID = ID
            };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }
        [HttpPost]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateUserDto createArticleDto)
        {
            var command = _mapper.Map<CreateUserCommand>(createArticleDto);
            command.UserID = ID;
            var articleID = await Mediator.Send(command);
            return Ok(articleID);
        }
        [HttpDelete("{ID}")]
        public async Task<ActionResult<Guid>> Delete(Guid guid)
        {
            var command = new DeleteUserCommand
            {
                UserID = ID
            };
            await Mediator.Send(command);
            return NoContent();
        }
    }
}