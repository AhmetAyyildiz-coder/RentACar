namespace Application.Features.Brands.Queries.GetById;

public class GetByIdBrandResponse 
{
    // brand nesnesini get by id ile sorguladıklarında ne döneceğiz ? 
    public Guid Id { get; set; }
    public string Name { get; set; }
}