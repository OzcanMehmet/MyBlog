using System.Collections.Generic;
using MediatR;
using myblog.Model.DTO;
using myblog.Model.Entity;

namespace myblog.Model.Queries
{
    public class GetBlogAllQuery : IRequest<IEnumerable<Blog>>
    {

    }

}