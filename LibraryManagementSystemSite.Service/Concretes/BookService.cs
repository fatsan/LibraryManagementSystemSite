
using AutoMapper;
using Core.Entities;
using LibraryManagementSystemSite.Model.Dtos.Books.Requests;
using LibraryManagementSystemSite.Model.Dtos.Books.Responses;
using LibraryManagementSystemSite.Model.Entities;
using LibraryManagementSystemSite.Repository.Repositories.Abstracts;
using LibraryManagementSystemSite.Service.Abstracts;

namespace LibraryManagementSystemSite.Service.Concretes;

public sealed class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;
    private readonly IMapper _mapper;

    public BookService(IBookRepository bookRepository, IMapper mapper)
    {
        _bookRepository = bookRepository;
        _mapper = mapper;
    }

    public ReturnModel<BookResponseDto> Add(CreateBookRequest dto)
    {
        Book createdBook = _mapper.Map<Book>(dto);
        createdBook.Id = Guid.NewGuid();

        Book book = _bookRepository.Add(createdBook);
        BookResponseDto responseDto = _mapper.Map<BookResponseDto>(book);
        return new ReturnModel<BookResponseDto>
        {
            Data = responseDto,
            Message = $"The Book {responseDto.Title} has been added.",
            Status = 200,
            Success = true
        };
    }

    public ReturnModel<BookResponseDto> Delete(Guid id)
    {

        var book = _bookRepository.GetById(id);
        var deletedBook = _bookRepository.Delete(book);
        var response = _mapper.Map< BookResponseDto>(book);

        return new ReturnModel<BookResponseDto>
        {
            Data = response,
            Message = $"The Book {response.Title} has been deleted.",
            Status = 200,
            Success = true
        };
    }

    public ReturnModel<List<BookResponseDto>> GetAll()
    {
        var list = _bookRepository.GetAll();
        var responseList = _mapper.Map<List<BookResponseDto>>(list);

        return new ReturnModel<List<BookResponseDto>>
        {
            Data = responseList,
            Message = string.Empty,
            Status = 200,
            Success = true
        };

    }

    public ReturnModel<BookResponseDto> GetById(Guid id)
    {
        var book = _bookRepository.GetById(id);
        var response = _mapper.Map<BookResponseDto>(book);

        return new ReturnModel<BookResponseDto>
        {
            Data = response,
            Message= "The Book that you looking for...",
            Status=200,
            Success= true
        };
    }

    public ReturnModel<BookResponseDto> Update(UpdateBookRequest dto)
    {
        var book = _bookRepository.GetById(dto.Id);

        Book update = new Book
        {
            Id = book.Id,
            ISBN = dto.ISBN,
            Title = dto.ISBN,
            Description = dto.Description,
            PageSize = dto.PageSize,
            CreatedDate = book.CreatedDate,
            UpdatedDate = DateTime.Now,
            PublishDate = dto.PublishDate,

        };

        var updatedBook = _bookRepository.Update(update);

        var response = _mapper.Map<BookResponseDto>(updatedBook);

        return new ReturnModel<BookResponseDto>
        {
            Data = response,
            Message = "Updated",
            Status = 200,
            Success = true
        };

    }
}
