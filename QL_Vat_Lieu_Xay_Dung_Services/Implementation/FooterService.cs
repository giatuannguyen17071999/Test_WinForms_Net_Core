using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using QL_Vat_Lieu_Xay_Dung_Data.Entities;
using QL_Vat_Lieu_Xay_Dung_Infrastructure.Interfaces;
using QL_Vat_Lieu_Xay_Dung_Services.Interfaces;
using QL_Vat_Lieu_Xay_Dung_Services.ViewModels.Common;
using QL_Vat_Lieu_Xay_Dung_Utilities.Constants;
using QL_Vat_Lieu_Xay_Dung_Utilities.Dtos;

namespace QL_Vat_Lieu_Xay_Dung_Services.Implementation
{
    public class FooterService : IFooterService
    {
        private readonly IRepository<Footer, string> _footerRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public FooterService(IRepository<Footer, string> footerRepository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _footerRepository = footerRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public FooterViewModel GetFooter()
        {
            return _mapper.Map<Footer, FooterViewModel>(_footerRepository.FindSingle(x => x.Id == CommonConstants.DefaultFooterId));
        }

        public FooterViewModel Add(FooterViewModel footerViewModel)
        {
            _footerRepository.Add(_mapper.Map<FooterViewModel, Footer>(footerViewModel));
            return footerViewModel;
        }

        public void Update(FooterViewModel footerViewModel)
        {
            _footerRepository.Update(_mapper.Map<FooterViewModel, Footer>(footerViewModel));
        }

        public void Delete(string id)
        {
            _footerRepository.Remove(id);
        }

        public PagedResult<FooterViewModel> GetAllPaging(string keyword, int page, int pageSize)
        {
            var query = _footerRepository.FindAll();
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(x => x.Content.Contains(keyword));
            }
            var totalRow = query.Count();
            query = query.Skip(page - 1 * pageSize).Take(pageSize);
            var data = _mapper.ProjectTo<FooterViewModel>(query).ToList();
            var paginationSet = new PagedResult<FooterViewModel>()
            {
                ResultList = data,
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize
            };
            return paginationSet;
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}
