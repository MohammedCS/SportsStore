namespace SportsStore.Controllers;

public class HomeController : Controller
{
    private IStoreRepository _repository;  
    public int PageSize = 4;

    public HomeController(IStoreRepository repository) =>
        _repository = repository;

    public ViewResult Index(int productPage = 2)
        => View(new ProductsListViewModel {
            Products = _repository.Products
                .OrderBy(product => product.ProductID)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize),
            PagingInfo = new() {
                CurrentPage = productPage,
                ItemsPerPage = PageSize,
                TotalItems = _repository.Products.Count()
            }
        });
}