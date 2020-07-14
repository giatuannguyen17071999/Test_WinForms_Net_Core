using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QL_Vat_Lieu_Xay_Dung_Services.Interfaces;
using QL_Vat_Lieu_Xay_Dung_Services.ViewModels.Common;
using QL_Vat_Lieu_Xay_Dung_WebApp.Authorization;

namespace QL_Vat_Lieu_Xay_Dung_WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class SlideController : Controller
    {
        private readonly IAuthorizationService _authorizationService;
        private readonly ISlideService _slideService;
        public SlideController(ISlideService slideService, IAuthorizationService authorizationService)
        {
            _slideService = slideService;
            _authorizationService = authorizationService;
        }
        public async Task<IActionResult> Index()
        {
            var result = await _authorizationService.AuthorizeAsync(User, "SLIDE", Operation.Read);
            if (!result.Succeeded)
            {
                return new RedirectResult("/Admin/Login/Index");
            }

            return View();
        }
        #region Get Data API


        [HttpPost]
        public IActionResult SaveEntity(SlideViewModel slideViewModel)
        {
            if (!ModelState.IsValid)
            {
                var allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(allErrors);
            }
            else
            {
                if (slideViewModel.Id == 0)
                {
                    _slideService.Add(slideViewModel);
                }
                else
                {
                    _slideService.Update(slideViewModel);
                }
                _slideService.Save();
                return new OkObjectResult(slideViewModel);

            }
        }


        [HttpGet]
        public IActionResult GetAllPaging(string keyword, int page, int pageSize)
        {
            var model = _slideService.GetAllPaging(keyword, page, pageSize);
            return new OkObjectResult(model);
        }


        [HttpGet]
        public IActionResult GetById(int id)
        {
            var model = _slideService.GetById(id);
            return new OkObjectResult(model);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return new BadRequestResult();
            }
            else
            {
                _slideService.Delete(id);
                _slideService.Save();
                return new OkObjectResult(id);
            }
        }


        #endregion
    }
}
