using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using myblog.Data.Commands;

using myblog.Model.DTO;
using myblog.Model.Entity;
using myblog.Model.Queries;
using myblog.Utils.Filters;

namespace myblog.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogController : ControllerBase
    {
        public IMediator _mediator { get; private set; }
        public BlogController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [ValidateModelState]
        public async Task<IActionResult> Insert(CreateBlogDTO blogcreate)
        {
            
            Blog blog = await _mediator.Send(new CreateBlogCommand
            {
                createblog = blogcreate
            });
            return CreatedAtAction(nameof(GetById), new { id = blog.Id }, blog);
        }

        [HttpPut("{id}")]
        [ValidateModelState]
        public async Task<IActionResult> Update(int id, UpdateBlogDTO blogupdate)
        {
            try
            {

                Blog blog = await _mediator.Send(new UpdateBlogCommand
                {
                    Id=id,
                    Updateblog = blogupdate
                });
                if(blog == null)
                    return NotFound();
            }
            catch
            {
                return NotFound();
            }
            return NoContent();
        }

        [HttpGet]
        [ValidateModelState]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _mediator.Send(new GetBlogAllQuery()));
        }

        [HttpGet("{id}")]
        [ValidateModelState]
        public async Task<IActionResult> GetById(int id)
        {

            return Ok(await _mediator.Send(new GetBlogById()
            {
                Id = id
            }));
        }

        [HttpDelete("{id}")]
        [ValidateModelState]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Blog blog = await _mediator.Send(new DeleteBlogCommand()
                {
                    Id = id
                });
                
                if(blog==null)
                    return NotFound();
            }
            catch 
            {
                 return NotFound();
            }

            return NoContent();
        }
    }
}
