using Core.Persistence.Repositories;

namespace Domain.Entities;

public class Brand : Entity<Guid>
{
    public Brand(Guid id, string name)
    {
        Id = id;
        Name = name;
    }

    public Brand()
    {
        Id = default;
    }
    public  string? Name { get; set; }
}