﻿
using Core.Entities;
using LibraryManagementSystemSite.Model.Dtos.Categories.Requests;
using LibraryManagementSystemSite.Model.Dtos.Categories.Responses;

namespace LibraryManagementSystemSite.Service.Abstracts;

public interface ICategoryService
{
    ReturnModel<CategoryResponseDto> Add(CreateCategoryRequest dto);
    ReturnModel<List<CategoryResponseDto>> GetAll();
    ReturnModel<List<CategoryResponseDto>> GetById(int id);
    ReturnModel<CategoryResponseDto> Update(UpdateCategoryRequest dto);
    ReturnModel<CategoryResponseDto> Delete(int id);
}