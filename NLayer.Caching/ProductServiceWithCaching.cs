using System.Linq.Expressions;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using NLayer.Core;
using NLayer.Core.DTOs;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;

namespace NLayer.Caching;

public class ProductServiceWithCaching:IProductService
{
    private const string CacheProductKey = "productsCache";
    private readonly IMapper _mapper;
    private readonly IMemoryCache _memoryCache;
    private readonly IProductRepository _productRepository;
    private readonly IUnitOfWork _unitOfWork;

    public  ProductServiceWithCaching(IMapper mapper,IMemoryCache memoryCache,IProductRepository productRepository,IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _memoryCache = memoryCache;
        _productRepository = productRepository;
        _unitOfWork = unitOfWork;
        if (!_memoryCache.TryGetValue(CacheProductKey, out _))
        {
            _memoryCache.Set(CacheProductKey, _productRepository.GetAll().ToListAsync());
        }
    }
    
    public Task<Product> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Product>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public IQueryable<Product> Where(Expression<Func<Product, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public Task<bool> AnyAsync(Expression<Func<Product, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public Task<Product> AddAsync(Product entity)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Product>> AddRangeAsync(IEnumerable<Product> entities)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Product entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveAsync(Product entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRangeAsync(IEnumerable<Product> entities)
    {
        throw new NotImplementedException();
    }

    public Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductsWithCategory()
    {
        throw new NotImplementedException();
    }
}