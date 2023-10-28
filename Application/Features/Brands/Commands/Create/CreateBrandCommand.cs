using MediatR;

namespace Application.Features.Brands.Commands.Create;

// api'dan bu nesne gelecek. Bu bir request nesnesidir diyoruz.
// marka eklemek için gerekli olan request nesnesinin kendisidir aslında.
public class CreateBrandCommand : IRequest<CreatedBrandResponse>
{
    public required string Name { get; set; }
}