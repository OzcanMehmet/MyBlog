using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using myblog.Data.Abstract;
using myblog.Data.Commands;
using myblog.Model.DTO;
using myblog.Model.Entity;

namespace myblog.Data.Handler.Command
{
    public class DeleteBlogCommandHandler : IRequestHandler<DeleteBlogCommand, Blog>
    {
        IBlogRepository _blogRepository { get; set;}
        IMapper _mapper { get; set;}
        public DeleteBlogCommandHandler(IBlogRepository blogRepository,IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper =mapper;
        }

        public async Task<Blog> Handle(DeleteBlogCommand request, CancellationToken cancellationToken)
        {
            Blog blog= await _blogRepository.FindById(request.Id);
            if(blog==null)
                return blog;
            return await _blogRepository.Delete(blog);
        }
    }

}