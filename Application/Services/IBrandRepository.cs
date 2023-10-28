using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services;

public interface IBrandRepository : IAsyncRepository<Brand, Guid>, IRepository<Brand, Guid>
{
}