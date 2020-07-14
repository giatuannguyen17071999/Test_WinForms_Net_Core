using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QL_Vat_Lieu_Xay_Dung_Services.Interfaces;


namespace QL_Vat_Lieu_Xay_Dung_WebApi.Controllers
{
    public class SlideController : APIController
    {
        private readonly ISlideService _slideService;
        public SlideController(ISlideService slideService)
        {
            _slideService = slideService;
        }
        [HttpGet("{id}")]
        public IActionResult GetSlides(string groupAlias)
        {
            return new OkObjectResult(_slideService.GetSlides(groupAlias));
        }
    }
}
