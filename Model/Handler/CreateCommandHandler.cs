using System.Threading;
using System.Threading.Tasks;
using MediatR;
using myblog.Data.Abstract;
using myblog.Model.Commands;
using myblog.Model.DTO;
using myblog.Model.Entity;

namespace myblog.Model.Handler
{
    public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommand, Blog>
    {
        IBlogRepository _blogRepository { get; set;}
        public CreateBlogCommandHandler(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public async Task<Blog> Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {
            await _blogRepository.Insert(new Blog());
            return new Blog();
        }
    }

}