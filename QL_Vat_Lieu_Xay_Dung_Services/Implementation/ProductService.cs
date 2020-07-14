using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using QL_Vat_Lieu_Xay_Dung_Data.Entities;
using QL_Vat_Lieu_Xay_Dung_Data.Enums;
using QL_Vat_Lieu_Xay_Dung_Infrastructure.Interfaces;
using QL_Vat_Lieu_Xay_Dung_Services.Interfaces;
using QL_Vat_Lieu_Xay_Dung_Services.ViewModels.Product;
using QL_Vat_Lieu_Xay_Dung_Utilities.Constants;
using QL_Vat_Lieu_Xay_Dung_Utilities.Dtos;
using QL_Vat_Lieu_Xay_Dung_Utilities.Helpers;

namespace QL_Vat_Lieu_Xay_Dung_Services.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product, int> _productRepository;
        private readonly IRepository<Tag, string> _tagRepository;
        private readonly IRepository<ProductTag, int> _productTagRepository;
        private readonly IRepository<ProductQuantity, int> _productQuantityRepository;
        private readonly IRepository<ProductImage, int> _productImageRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public ProductService(IRepository<Product, int> productRepository, IMapper mapper, IRepository<Tag, string> tagRepository, IUnitOfWork unitOfWork, IRepository<ProductTag, int> productTagRepository, IRepository<ProductQuantity, int> productQuantityRepository, IRepository<ProductImage, int> productImageRepository)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            _tagRepository = tagRepository;
            _unitOfWork = unitOfWork;
            _productTagRepository = productTagRepository;
            _productQuantityRepository = productQuantityRepository;
            _productImageRepository = productImageRepository;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        public List<ProductViewModel> GetAll()
        {
            return _productRepository.FindAll(x => x.ProductCategory).ProjectTo<ProductViewModel>(_mapper.ConfigurationProvider).ToList();
        }

        public ProductViewModel Add(ProductViewModel productViewModel)
        {
            var productTags = new List<ProductTag>();
            if (!string.IsNullOrEmpty(productViewModel.Tags))
            {
               var tags = productViewModel.Tags.Split(',');
                foreach (var t in tags)
                {
                    var tagId = AliasHelper.ConvertToAlias(t);
                    if (!_tagRepository.FindAll(x => x.Id == tagId).Any())
                    {
                        var tag = new Tag
                        {
                            Id = tagId,
                            Name = t
                        };
                        _tagRepository.Add(tag);
                    }

                    var productTag = new ProductTag
                    {
                        TagId = tagId
                    };
                    productTags.Add(productTag);
                }
                var product = _mapper.Map<ProductViewModel, Product>(productViewModel);
                foreach (var productTag in productTags)
                {
                    product.ProductTags.Add(productTag);
                }
                _productRepository.Add(product);
            }
            return productViewModel;
        }

        public void Update(ProductViewModel productViewModel)
        {
          var productTags = new List<ProductTag>();

            if (!string.IsNullOrEmpty(productViewModel.Tags))
            {
                var tags = productViewModel.Tags.Split(',');
                foreach (var t in tags)
                {
                    var tagId = AliasHelper.ConvertToAlias(t);
                    if (!_tagRepository.FindAll(x => x.Id == tagId).Any())
                    {
                        var tag = new Tag {Id = tagId, Name = t};
                        _tagRepository.Add(tag);
                    }
                    _productTagRepository.RemoveMultiple(_productTagRepository.FindAll(x => x.Id == productViewModel.Id).ToList());
                    var productTag = new ProductTag
                    {
                        TagId = tagId
                    };
                    productTags.Add(productTag);
                }
            }

            var product = _mapper.Map<ProductViewModel, Product>(productViewModel);
            foreach (var productTag in productTags)
            {
                product.ProductTags.Add(productTag);
            }
            _productRepository.Update(product);
        }

        public void Delete(int id)
        {
            _productRepository.Remove(id);
        }

        public ProductViewModel GetById(int id)
        {
            return _mapper.Map<Product, ProductViewModel>(_productRepository.FindById(id));
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
        public PagedResult<ProductViewModel> GetAllPaging(int? categoryId, string keyword, int page, int pageSize)
        {
            var query = _productRepository.FindAll(x => x.Status == Status.Active);
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(x => x.Name.Contains(keyword));
            }

            if (categoryId.HasValue)
            {
                query = query.Where(x => x.CategoryId == categoryId.Value);
            }

            var totalRow = query.Count();
            query = query.OrderByDescending(x => x.DateCreated).Skip((page - 1) * pageSize).Take(pageSize);
            var data = _mapper.ProjectTo<ProductViewModel>(query).ToList();
            var paginationSet = new PagedResult<ProductViewModel>()
            {
                ResultList = data,
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize
            };
            return paginationSet;
        }
        public List<ProductViewModel> GetAllSearch(int? categoryId, string keyword)
        {
            var query = _productRepository.FindAll(x => x.Status == Status.Active);
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(x => x.Name.Contains(keyword));
            }

            if (categoryId.HasValue)
            {
                query = query.Where(x => x.CategoryId == categoryId.Value);
            }

            query = query.OrderByDescending(x => x.DateCreated);
            var data = _mapper.ProjectTo<ProductViewModel>(query).ToList();
            return data;
        }

        public void AddQuantity(int productId, List<ProductQuantityViewModel> quantities)
        {
            _productQuantityRepository.RemoveMultiple(_productQuantityRepository.FindAll(x => x.ProductId == productId).ToList());
            foreach (var quantity in quantities)
            {
                _productQuantityRepository.Add(new ProductQuantity()
                {
                    ProductId = productId,
                    SizeId = quantity.SizeId,
                    Quantity = quantity.Quantity
                });
            }
        }

        public List<ProductQuantityViewModel> GetQuantities(int productId)
        {
            return _mapper.ProjectTo<ProductQuantityViewModel>(
                    _productQuantityRepository.FindAll(x => x.ProductId == productId))
                .ToList();
        }

        public void AddImages(int productId, string[] images)
        {
            _productImageRepository.RemoveMultiple(_productImageRepository.FindAll(x => x.ProductId == productId).ToList());
            foreach (var image in images)
            {
                _productImageRepository.Add(new ProductImage()
                {
                    Path = image,
                    ProductId = productId,
                    Caption = string.Empty
                });
            }
        }

        public List<ProductImageViewModel> GetImages(int productId)
        {
            return _mapper.ProjectTo<ProductImageViewModel>(
                _productImageRepository.FindAll(x => x.ProductId == productId)
            ).ToList();
        }
    }
}
