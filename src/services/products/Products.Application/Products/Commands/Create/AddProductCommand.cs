using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products.domain.Products;

namespace Products.Application.Products.Commands.Create
{
    public class AddProductCommand : ProductReqDto, IRequest<ProductResDto>
    {
    }
}