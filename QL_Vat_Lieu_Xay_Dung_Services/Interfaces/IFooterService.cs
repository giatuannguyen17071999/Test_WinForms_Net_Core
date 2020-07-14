using System;
using System.Collections.Generic;
using System.Text;
using QL_Vat_Lieu_Xay_Dung_Services.ViewModels.Common;
using QL_Vat_Lieu_Xay_Dung_Utilities.Dtos;

namespace QL_Vat_Lieu_Xay_Dung_Services.Interfaces
{
    public interface IFooterService
    {
        FooterViewModel GetFooter();
        FooterViewModel Add(FooterViewModel footerViewModel);
        void Update(FooterViewModel footerViewModel);
        void Delete(string id);
        PagedResult<FooterViewModel> GetAllPaging(string keyword, int page, int pageSize);
        void Save();
    }
}
