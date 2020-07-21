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
    public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommand, Blog>
    {
        IBlogRepository _blogRepository { get; set;}
        IMapper _mapper { get; set;}
        public CreateBlogCommandHandler(IBlogRepository blogRepository,IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper =mapper;
        }
        public async Task<Blog> Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {
            
            return await _blogRepository.Insert(_mapper.Map<CreateBlogDTO,Blog>(request.createblog));
        }
    }

}