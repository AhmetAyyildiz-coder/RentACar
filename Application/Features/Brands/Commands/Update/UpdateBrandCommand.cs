using Application.Services;
using AutoMapper;
using MediatR;

namespace Application.Features.Brands.Commands.Update
{
    public class UpdateBrandCommand : IRequest<UpdatedBrandResponse>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }


    public class UpdateBrandCommandHandler : IRequestHandler<UpdateBrandCommand, UpdatedBrandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBrandRepository _brandRepository;

        public UpdateBrandCommandHandler(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }

        public async Task<UpdatedBrandResponse> Handle(UpdateBrandCommand request, CancellationToken cancellationToken)
        {
            var brand = await _brandRepository.GetAsync(predicate: b => b.Id == request.Id, cancellationToken: cancellationToken);
            brand = _mapper.Map(request, brand);
            await _brandRepository.UpdateAsync(brand);

            return _mapper.Map<UpdatedBrandResponse>(brand);

        }
    }
}
