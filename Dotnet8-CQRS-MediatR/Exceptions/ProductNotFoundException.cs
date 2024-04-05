namespace Dotnet8_CQRS_MediatR.Exceptions
{
    public class ProductNotFoundException : Exception
    {
        public ProductNotFoundException() : base("Product not found!")
        {
            
        }
    }
}
