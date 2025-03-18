using BookStore.EntityFrameworkCore;
using Xunit;

namespace BookStore.Authors
{
    [Collection(BookStoreTestConsts.CollectionDefinitionName)]
    public class EfCoreAuthorAppService_Tests : AuthorAppService_Tests<BookStoreEntityFrameworkCoreTestModule>
    {
    }
}
