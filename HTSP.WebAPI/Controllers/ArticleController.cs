using AutoMapper;
using HTSP.Application.Features.Commands.CreateArticle;
using HTSP.Application.Features.Commands.DeleteArticle;
using HTSP.Application.Features.Commands.UpdateArticle;
using HTSP.Application.Features.Queries.ArticleListQuery;
using HTSP.Application.Features.Queries.ArticleQuery;
using HTSP.Domain.Entities;
using HTSP.Interaction.Database_Interaction;
using HTSP.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace HTSP.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ArticleController : BaseController
    {
        private readonly IMapper _mapper;
        public ArticleController(IMapper mapper) => _mapper = mapper;
        [HttpGet]
        public async Task<ActionResult<ArticleListVm>> GetAll()
        {
            var query = new GetArticleListQuery
            {
                ArticleID = ID
            };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }
        [HttpGet ("{ID}")]
        public async Task<ActionResult<ArticleVm>> Get(Guid ID)
        {
            var query = new GetArticleQuery
            {
                ArticleID = ID                
            };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }
        [HttpPost]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateArticleDto createArticleDto)
        {
            var command = _mapper.Map<CreateArticleCommand>(createArticleDto);
            command.ArticleID = ID;
            var articleID = await Mediator.Send(command);
            return Ok(articleID);
        }
        [HttpPut]
        public async Task<ActionResult<Guid>> Update([FromBody] UpdateArticleDto updateArticleDto)
        {
            var command = _mapper.Map<UpdateArticleCommand>(updateArticleDto);
            command.ArticleID = ID;
            await Mediator.Send(command);
            return NoContent();
        }
        [HttpDelete("{ID}")]
        public async Task<ActionResult<Guid>> Delete(Guid guid)
        {
            var command = new DeleteArticleCommand
            {
                ArticleID = ID
            };
            await Mediator.Send(command);
            return NoContent();
        }
    }
}
