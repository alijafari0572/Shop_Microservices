using Products.domain.Products;
using Products.domain;
using Products.Infra.Products;
using Products.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Infra
{
    public class WriteUnitOfWork : IWriteUnitOfWork
    {
        private readonly ProductDbContext _context;

        public WriteUnitOfWork(ProductDbContext context)
        {
            _context = context;
        }

        private ProductWriteRepository _productWriteRepository;

        public IProductWriteRepository ProductWriteRepository
        {
            get
            {
                return _productWriteRepository ??= new ProductWriteRepository(_context);
            }
        }
    }
}