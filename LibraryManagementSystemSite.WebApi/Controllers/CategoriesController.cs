using LibraryManagementSystemSite.Model.Dtos.Books.Requests;
using LibraryManagementSystemSite.Model.Dtos.Categories.Requests;
using LibraryManagementSystemSite.Service.Abstracts;
using LibraryManagementSystemSite.Service.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystemSite.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController(ICategoryService _categoryService) : ControllerBase
{
    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        var result = _categoryService.GetAll();
        return Ok(result);
    }
    [HttpPost("add")]
    public IActionResult Add([FromBody] CreateCategoryRequest dto)
    {
        var result = _categoryService.Add(dto);
        return Ok(result);
    }
    [HttpGet("getbyid/{id}")]
    public IActionResult GetById([FromRoute] Guid id)
    {
        var result = _categoryService.GetById(id);
        return Ok(result);
    }
    [HttpDelete("delete")]
    public IActionResult Delete([FromBody] Guid Id)
    {
        var result = _categoryService.Delete(Id);
        return Ok(result);
    }
    [HttpPut("put")]
    public IActionResult Update([FromBody] UpdateCategoryRequest dto)
    {
        var result = _categoryService.Update(dto);
        return Ok(result);
    }
}
