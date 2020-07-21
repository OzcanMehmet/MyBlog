using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using myblog.Data.Abstract;
using myblog.Data.Commands;
using myblog.Model.DTO;
using myblog.Model.Entity;
using myblog.Model.Queries;

namespace myblog.Data.Handler.Command
{
    public class GetBlogAllHandler : IRequestHandler<GetBlogAllQuery, IEnumerable<Blog>>
    {
        IBlogRepository _blogRepository { get; set;}
        IMapper _mapper { get; set;}
        public GetBlogAllHandler(IBlogRepository blogRepository,IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper =mapper;
        }
        public async Task<IEnumerable<Blog>> Handle(GetBlogAllQuery request, CancellationToken cancellationToken)
        {
            return await _blogRepository.GetAll();
        }
    }

}