using MediatR;
using myblog.Model.DTO;
using myblog.Model.Entity;

namespace myblog.Data.Commands
{
    public class DeleteBlogCommand : IRequest<Blog>
    {
       public int Id { get; set; }

    }

}