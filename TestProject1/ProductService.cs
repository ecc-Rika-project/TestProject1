
internal class ProductService
{
    private IProductRepository @object;

    public ProductService(IProductRepository @object)
    {
        this.@object = @object;
    }

    internal bool UpdatePrice(int v1, int v2)
    {
        throw new NotImplementedException();
    }
}