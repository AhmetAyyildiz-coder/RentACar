using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomBaseController : ControllerBase
{
    private IMediator? _mediatr;
    protected IMediator? Mediator => _mediatr ??= HttpContext.RequestServices.GetService<IMediator>();
}