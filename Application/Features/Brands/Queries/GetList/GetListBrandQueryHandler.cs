using Application.Services;
using AutoMapper;
using Core.Application.Responses;
using MediatR;

namespace Application.Features.Brands.Queries.GetList;

public class GetListBrandQueryHandler : IRequestHandler<GetListBrandQuery,GetListResponse<GetListBrandItemDto>>
{
    private readonly IBrandRepository _brandRepository;
    private readonly IMapper _mapper;

    public GetListBrandQueryHandler(IBrandRepository brandRepository, IMapper mapper)
    {
        _brandRepository = brandRepository;
        _mapper = mapper;
    }

    public async Task<GetListResponse<GetListBrandItemDto>> Handle(GetListBrandQuery request, CancellationToken cancellationToken)
    {
        // handler içerisinde request nesnesi üstteki IRequest'ten türetilen nesneye eşdeğerdir.
        var data =await _brandRepository.GetListAsync(
            index: request.PageRequest.PageIndex
            ,size:request.PageRequest.PageSize
            ,cancellationToken:cancellationToken
        );

        GetListResponse<GetListBrandItemDto> response = _mapper.Map<GetListResponse<GetListBrandItemDto>>(data);
        return response;
    }
}