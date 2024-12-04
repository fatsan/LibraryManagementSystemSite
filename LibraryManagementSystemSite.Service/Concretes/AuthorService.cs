
using AutoMapper;
using Core.Entities;
using LibraryManagementSystemSite.Model.Dtos.Authors.Requests;
using LibraryManagementSystemSite.Model.Dtos.Authors.Responses;
using LibraryManagementSystemSite.Model.Dtos.Books.Requests;
using LibraryManagementSystemSite.Model.Dtos.Books.Responses;
using LibraryManagementSystemSite.Model.Entities;
using LibraryManagementSystemSite.Repository.Repositories.Abstracts;
using LibraryManagementSystemSite.Repository.Repositories.Concretes;
using LibraryManagementSystemSite.Service.Abstracts;

namespace LibraryManagementSystemSite.Service.Concretes;

public sealed class AuthorService : IAuthorService
{
    private readonly IAuthorRepository _authorRepository;
    private readonly IMapper _mapper;

    public AuthorService(IAuthorRepository authorRepository, IMapper mapper)
    {
        _authorRepository = authorRepository;
        _mapper = mapper;
    }

    public ReturnModel<AuthorResponseDto> Add(CreateAuthorRequest dto)
    {
        Author createdAuthor = _mapper.Map<Author>(dto);
        createdAuthor.Id = Guid.NewGuid();

        Author author = _authorRepository.Add(createdAuthor);
        AuthorResponseDto responseDto = _mapper.Map<AuthorResponseDto>(author);
        return new ReturnModel<AuthorResponseDto>
        {
            Data = responseDto,
            Message = $"The Author has been added.",
            Status = 200,
            Success = true
        };
    }

    public ReturnModel<AuthorResponseDto> Delete(Guid id)
    {

        var author = _authorRepository.GetById(id);
        var deletedAuthor = _authorRepository.Delete(author);
        var response = _mapper.Map<AuthorResponseDto>(author);

        return new ReturnModel<AuthorResponseDto>
        {
            Data = response,
            Message = $"The Author has been deleted.",
            Status = 200,
            Success = true
        };
    }

    public ReturnModel<List<AuthorResponseDto>> GetAll()
    {
        var list = _authorRepository.GetAll();
        var responseList = _mapper.Map<List<AuthorResponseDto>>(list);

        return new ReturnModel<List<AuthorResponseDto>>
        {
            Data = responseList,
            Message = string.Empty,
            Status = 200,
            Success = true
        };

    }

    public ReturnModel<AuthorResponseDto> GetById(Guid id)
    {
        var author = _authorRepository.GetById(id);
        var response = _mapper.Map<AuthorResponseDto>(author);

        return new ReturnModel<AuthorResponseDto>
        {
            Data = response,
            Message = "The Author that you looking for...",
            Status = 200,
            Success = true
        };
    }

    public ReturnModel<AuthorResponseDto> Update(UpdateAuthorRequest dto)
    {
        var author = _authorRepository.GetById(dto.Id);

        Author update = new Author
        {
            Id = author.Id,
            FullName = dto.FullName,
            UpdatedDate = DateTime.Now,
            CreatedDate = author.CreatedDate,
        };

        var updatedAuthor = _authorRepository.Update(update);

        var response = _mapper.Map<AuthorResponseDto>(updatedAuthor);

        return new ReturnModel<AuthorResponseDto>
        {
            Data = response,
            Message = "Updated",
            Status = 200,
            Success = true
        };

    }
}
