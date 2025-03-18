using BookStore.EntityFrameworkCore;
using Xunit;

namespace BookStore.Books
{

    [Collection(BookStoreTestConsts.CollectionDefinitionName)]
    public class EfCoreBookAppService_Tests : BookAppService_Tests<BookStoreEntityFrameworkCoreTestModule>
    {

    }
}
