

using AutoMapper;
using Core.Entities;
using LibraryManagementSystemSite.Model.Dtos.Authors.Requests;
using LibraryManagementSystemSite.Model.Dtos.Authors.Responses;
using LibraryManagementSystemSite.Model.Dtos.Categories.Requests;
using LibraryManagementSystemSite.Model.Dtos.Categories.Responses;
using LibraryManagementSystemSite.Model.Entities;
using LibraryManagementSystemSite.Repository.Repositories.Abstracts;
using LibraryManagementSystemSite.Repository.Repositories.Concretes;
using LibraryManagementSystemSite.Service.Abstracts;

namespace LibraryManagementSystemSite.Service.Concretes;

public sealed class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public ReturnModel<CategoryResponseDto> Add(CreateCategoryRequest dto)
    {
        Category createdCategory = _mapper.Map<Category>(dto);
        createdCategory.Id = Guid.NewGuid();

        Category category = _categoryRepository.Add(createdCategory);
        CategoryResponseDto responseDto = _mapper.Map<CategoryResponseDto>(category);
        return new ReturnModel<CategoryResponseDto>
        {
            Data = responseDto,
            Message = $"The Category has been added.",
            Status = 200,
            Success = true
        };
    }

    public ReturnModel<CategoryResponseDto> Delete(Guid id)
    {

        var category = _categoryRepository.GetById(id);
        var deletedCategory = _categoryRepository.Delete(category);
        var response = _mapper.Map<CategoryResponseDto>(category);

        return new ReturnModel<CategoryResponseDto>
        {
            Data = response,
            Message = $"The Category has been deleted.",
            Status = 200,
            Success = true
        };
    }

    public ReturnModel<List<CategoryResponseDto>> GetAll()
    {
        var list = _categoryRepository.GetAll();
        var responseList = _mapper.Map<List<CategoryResponseDto>>(list);

        return new ReturnModel<List<CategoryResponseDto>>
        {
            Data = responseList,
            Message = string.Empty,
            Status = 200,
            Success = true
        };

    }

    public ReturnModel<CategoryResponseDto> GetById(Guid id)
    {
        var category = _categoryRepository.GetById(id);
        var response = _mapper.Map<CategoryResponseDto>(category);

        return new ReturnModel<CategoryResponseDto>
        {
            Data = response,
            Message = "The Category that you looking for...",
            Status = 200,
            Success = true
        };
    }

    public ReturnModel<CategoryResponseDto> Update(UpdateCategoryRequest dto)
    {
        var category = _categoryRepository.GetById(dto.Id);

        Category update = new Category
        {
            Id = category.Id,
            Name = dto.Name,
            UpdatedDate = DateTime.Now,
            CreatedDate = category.CreatedDate,
        };

        var updatedCategory = _categoryRepository.Update(update);

        var response = _mapper.Map<CategoryResponseDto>(updatedCategory);

        return new ReturnModel<CategoryResponseDto>
        {
            Data = response,
            Message = "Updated",
            Status = 200,
            Success = true
        };

    }
}