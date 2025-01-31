using MediatR;
using Products.domain.Products;

namespace Products.Application.Products.Commands.Update
{
    public class UpdateProductCommand : ProductReqDto, IRequest<bool>
    {
    }
}