using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QL_Vat_Lieu_Xay_Dung_Services.Interfaces;
using QL_Vat_Lieu_Xay_Dung_Services.ViewModels.User;
using QL_Vat_Lieu_Xay_Dung_Utilities.Dtos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QL_Vat_Lieu_Xay_Dung_WebApi.Controllers
{
    [Authorize]
    public class UserController : APIController
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        // GET: api/<UserController>
        [HttpGet]
        public async Task<IActionResult> GetById(string id)
        {
            var model = await _userService.GetById(id);

            return new OkObjectResult(model);
        }



        [HttpPut("{id}")]
        public async Task<IActionResult> Put(AppUserViewModel userViewModel)
        {

            if (!ModelState.IsValid)
            {
                var allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(allErrors);
            }
            else
            {
                if (User.IsInRole("Customer"))
                {
                    if (userViewModel.Id == null)
                    {
                        await _userService.AddAsync(userViewModel);
                    }
                    else
                    {
                        await _userService.UpdateAsync(userViewModel);
                    }

                }
                return new OkObjectResult(userViewModel);
            }
        }
    }
}
