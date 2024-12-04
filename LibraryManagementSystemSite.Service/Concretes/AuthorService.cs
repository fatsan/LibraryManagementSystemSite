
using AutoMapper;
using LibraryManagementSystemSite.Repository.Repositories.Abstracts;
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
}
