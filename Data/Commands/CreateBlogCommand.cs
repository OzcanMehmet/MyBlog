using MediatR;
using myblog.Model.DTO;
using myblog.Model.Entity;

namespace myblog.Data.Commands
{
    public class CreateBlogCommand : IRequest<Blog>
    {
       public CreateBlogDTO createblog { get; set; }

    }

}