using Core.Application.Request;
using Core.Application.Responses;
using MediatR;

namespace Application.Features.Brands.Queries.GetList;

public class GetListBrandQuery : IRequest<GetListResponse<GetListBrandItemDto>>
{
    public PageRequest  PageRequest { get; set; }
}