using MediatR;
using Persistence;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;
using System.Threading;

namespace Application.ProductList
{
    public class List
    {
        public class Query : IRequest<List<Product>> { }

        public class Handler : IRequestHandler<Query, List<Product>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<List<Product>> Handle(Query request, CancellationToken cancellationToken)
            {
                var products = await _context.Products.ToListAsync();
                return products;
            }
        }
    }
}
