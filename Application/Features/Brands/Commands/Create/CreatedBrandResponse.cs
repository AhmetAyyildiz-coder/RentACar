namespace Application.Features.Brands.Commands.Create;

// brand nesnesi oluştuktan sonra döneceğimiz response nesnesidir aslında.
public class CreatedBrandResponse
{
    public CreatedBrandResponse()
    {
        Id = default;
    }

    public CreatedBrandResponse(Guid id , string name)
    {
        Id = id;
        Name = name;
    }
    public Guid Id { get; set; }
    public string Name { get; set; }
}