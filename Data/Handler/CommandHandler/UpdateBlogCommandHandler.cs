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
    public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand, Blog>
    {
        IBlogRepository _blogRepository { get; set;}
        IMapper _mapper { get; set;}
        public UpdateBlogCommandHandler(IBlogRepository blogRepository,IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper =mapper;
        }

        public async Task<Blog> Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            
            Blog blog=_mapper.Map<UpdateBlogDTO,Blog>(request.Updateblog);
            blog.Id = request.Id;
            return await _blogRepository.Update(blog);
        }
    }

}