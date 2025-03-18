using AutoMapper;
using BookStore.Authors;
using BookStore.Books;

namespace BookStore;

public class BookStoreApplicationAutoMapperProfile : Profile
{
    public BookStoreApplicationAutoMapperProfile()
    {
        #region books
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        #endregion

        #region authors
        CreateMap<Author, AuthorDto>();
        CreateMap<Author, AuthorLookupDto>();
        #endregion

    }
}
