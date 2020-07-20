using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace myblog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogController : ControllerBase
    {
        public IMediator _mediator { get; private set; }
        public BlogController(IMediator mediator)
        {
            _mediator = mediator;
        }


/*         [HttpPost]
        public async Task<IActionResult> Insert()
        {
           
            return  Ok(_mediator.Send());
        }
 */
    }
}
