using LibraryManagementSystemSite.Model.Dtos.Authors.Requests;
using LibraryManagementSystemSite.Model.Dtos.Books.Requests;
using LibraryManagementSystemSite.Service.Abstracts;
using LibraryManagementSystemSite.Service.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystemSite.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthorsController(IAuthorService _authorService) : ControllerBase
{
    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        var result = _authorService.GetAll();
        return Ok(result);
    }
    [HttpPost("add")]
    public IActionResult Add([FromBody] CreateAuthorRequest dto)
    {
        var result = _authorService.Add(dto);
        return Ok(result);
    }
    [HttpGet("getbyid/{id}")]
    public IActionResult GetById([FromRoute] Guid id)
    {
        var result = _authorService.GetById(id);
        return Ok(result);
    }
    [HttpDelete("delete")]
    public IActionResult Delete([FromBody] Guid Id)
    {
        var result = _authorService.Delete(Id);
        return Ok(result);
    }
    [HttpPut("put")]
    public IActionResult Update([FromBody] UpdateAuthorRequest dto)
    {
        var result = _authorService.Update(dto);
        return Ok(result);
    }
}
