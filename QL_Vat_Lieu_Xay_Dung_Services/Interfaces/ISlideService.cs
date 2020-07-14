using System;
using System.Collections.Generic;
using System.Text;
using QL_Vat_Lieu_Xay_Dung_Services.ViewModels.Common;
using QL_Vat_Lieu_Xay_Dung_Utilities.Dtos;

namespace QL_Vat_Lieu_Xay_Dung_Services.Interfaces
{
    public interface ISlideService
    {
        List<SlideViewModel> GetSlides(string groupAlias);
        SlideViewModel Add(SlideViewModel slideViewModel);
        void Update(SlideViewModel slideViewModel);
        void Delete(int id);
        SlideViewModel GetById(int id);
        PagedResult<SlideViewModel> GetAllPaging(string keyword, int page, int pageSize);
        void Save();
    }
}
