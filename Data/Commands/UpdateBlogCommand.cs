using MediatR;
using myblog.Model.DTO;
using myblog.Model.Entity;

namespace myblog.Data.Commands
{
    public class UpdateBlogCommand : IRequest<Blog>
    {
        public int Id { get; set; }
        public UpdateBlogDTO Updateblog { get; set; }

    }

}