using LibraryManagementSystemSite.Model.Dtos.Books.Requests;
using LibraryManagementSystemSite.Service.Abstracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystemSite.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BooksController(IBookService _bookService) : ControllerBase
{
    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        var result = _bookService.GetAll();
        return Ok(result);
    }
    [HttpPost("add")]
    public IActionResult Add([FromBody] CreateBookRequest dto)
    {
        var result = _bookService.Add(dto);
        return Ok(result);
    }
    [HttpGet("getbyid/{id}")]
    public IActionResult GetById([FromRoute] Guid id)
    {
        var result = _bookService.GetById(id);
        return Ok(result);
    }
    [HttpDelete("delete")]
    public IActionResult Delete([FromBody]Guid Id)
    {
        var result = _bookService.Delete(Id);
        return Ok(result);
    }
    [HttpPut("put")]
    public IActionResult Update([FromBody]UpdateBookRequest dto)
    {
        var result = _bookService.Update(dto);
        return Ok(result);
    }
}
