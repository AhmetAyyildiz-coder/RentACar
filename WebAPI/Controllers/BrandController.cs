using Application.Features.Brands.Commands.Create;
using Application.Features.Brands.Commands.Delete;
using Application.Features.Brands.Commands.Update;
using Application.Features.Brands.Queries.GetById;
using Application.Features.Brands.Queries.GetList;
using Core.Application.Request;
using Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class BrandController : CustomBaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateBrandCommand commnad)
    {
        var response = await Mediator!.Send(commnad);
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest request)
    {
        GetListBrandQuery query = new()
        {
            PageRequest = request
        };
        GetListResponse<GetListBrandItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetById([FromQuery] Guid id)
    {
        GetByIdBrandQuery query = new() { Id = id };
        var response = await Mediator.Send(query);
        return Ok(response);

    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateBrandCommand command)
    {
        var response = await Mediator.Send(command);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromQuery] DeleteBrandCommand command)
    {
        var response = await Mediator.Send(command);
        return Ok(response);
    }
    

}