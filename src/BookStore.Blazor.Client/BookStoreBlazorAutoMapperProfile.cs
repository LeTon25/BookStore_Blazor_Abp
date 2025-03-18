using AutoMapper;
using BookStore.Authors;
using BookStore.Books;

namespace BookStore.Blazor.Client;

public class BookStoreBlazorAutoMapperProfile : Profile
{
    public BookStoreBlazorAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Blazor project.
        CreateMap<BookDto, CreateUpdateBookDto>();

        CreateMap<AuthorDto, UpdateAuthorDto>();

    }
}